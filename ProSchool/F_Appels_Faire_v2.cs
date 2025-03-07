using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Appels_Faire_v2 : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
        
        private Boolean InitOk;
        
        private DateTime SelectedMonday;
        private Classe SelectedClasse;
        private List<Eleve> SelectedClasseEleves;
        private List<Jour> JoursPeriode;
        private Jour SelectedJour;
        private List<Appel> AppelsTemp;

        private DateTime Today;
        
        private DateTime APZ_FirstDayOfYear = Convert.ToDateTime("2019/09/02");
        private DateTime APZ_LastDayOfYear = Convert.ToDateTime("2020/07/15");

        List<Evenement> EventVacancesFeries;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Appels_Faire_v2()
        {
            InitializeComponent();
        }

        private void F_Appels_Faire_v2_Load(object sender, EventArgs e)
        {
            Today = DateTime.Today;
            LB_DateToday.Text = Today.ToLongDateString();   //today.ToLongDateString() + " >>>> " + today.ToString("dddd dd MMMM") + " >>>> " + today.ToString("yyyy-MM-dd");
            //LB_DateToday.Text = Today.ToString("yyyy-MM-dd");
            LB_DateToday.ForeColor = Global.Color_Menu_Absences;
            LB_Label_Classe.ForeColor = Global.Color_Menu_Absences;
            LB_Label_Semaine.ForeColor = Global.Color_Menu_Absences;
            COMBO_Semaines.ForeColor = Global.Color_Menu_Absences;
            BT_AppelTermine.ForeColor = Global.Color_Menu_Absences;

            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            EventVacancesFeries = Evenement.GetListEvenementsVacancesFeriesFromBdd();

            SelectedMonday = Global.GetMondayOfCurrentWeek();
            SelectedClasse = null;

            CreerItem_COMBO_Semaines();
            CreerItem_COMBO_Classes();  // et defini SelectedClasse

        //    SelectedClasseEleves = Global.GetListElevesFromBddByClasseIdentifiant(SelectedClasse.Identifiant);
            SelectedClasseEleves = Eleve.GetListElevesFromBddByClasseIdentifiant_SortByNiveau(SelectedClasse.Identifiant);
          

            ChargerAppel();
            InitOk = true;
        }
        
        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXXXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void ChargerAppel()
        {

            SQLiteConnection MaConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            MaConnexion.Open();
            
            PAN_Help_Appel1.Visible = true;
            PAN_Help_Appel2.Visible = false;
           // PAN_Help_Justifier.Visible = true;

            SelectedJour = null;

            JoursPeriode = new List<Jour>();

            DateTime TempDay = SelectedMonday;
            while (TempDay <= SelectedMonday.AddDays(6))
            {
                DateTime TempDay2 = TempDay;
                Boolean Vac = Global.IsVacances(MaConnexion, TempDay2.ToString("yyyy-MM-dd"));
                Boolean Fer = Global.IsFerie(MaConnexion, TempDay2.ToString("yyyy-MM-dd"));
                Jour JM = new Jour(TempDay2, "Matin", Vac, Fer);
                JoursPeriode.Add(JM);
                if (!JM.IsWeekend && !JM.IsFerie && !JM.IsVacances)
                {
                    JoursPeriode.Add(new Jour(TempDay2, "Aprem", Vac, Fer));
                }
                TempDay = TempDay.AddDays(1);
            }
                       

            Setup_DGV_Appel();

            foreach (Eleve Elv in SelectedClasseEleves)
            {
                Elv.SetAppelsFromPeriode(MaConnexion, SelectedMonday.ToString("yyyy-MM-dd"), SelectedMonday.AddDays(7).ToString("yyyy-MM-dd"));
            }

            MaConnexion.Close();

            Populate_DGV_Appel(SelectedClasseEleves);
        }
               
        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Appel    ■■■■■■■■■■■■■■■■■■■■■■■■
        
        private void Setup_DGV_Appel()
        {

            DGV_Appel.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Appel.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Appel.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Appel.Font, FontStyle.Bold);
            DGV_Appel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Appel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //     DGV_Appel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DGV_Appel.ColumnHeadersHeight = 40;
            DGV_Appel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Appel.RowHeadersVisible = false;
            //   DGV_Appel.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DGV_Appel.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Appel.GridColor = Color.Black;
            DGV_Appel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Appel.MultiSelect = false;
            DGV_Appel.AllowUserToAddRows = false;
            DGV_Appel.AllowUserToOrderColumns = false;
            DGV_Appel.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 240, 255);
            DGV_Appel.DefaultCellStyle.SelectionForeColor = Color.Black;

            
            DGV_Appel.ColumnCount = 4;
            

            DGV_Appel.Columns[0].Name = "id";
            DGV_Appel.Columns[1].Name = "nom";
            DGV_Appel.Columns[1].HeaderText = "Nom";
            DGV_Appel.Columns[2].Name = "prenom";
            DGV_Appel.Columns[2].HeaderText = "Prénom";
            DGV_Appel.Columns[3].Name = "niveau";
            DGV_Appel.Columns[3].HeaderText = "Niveau";



            foreach (Jour Jr in JoursPeriode)
            {
                int ColCount = DGV_Appel.ColumnCount + 1;
                DGV_Appel.ColumnCount = ColCount;

                Jr.DgvColumn = DGV_Appel.Columns[ColCount - 1];

                DGV_Appel.Columns[ColCount-1].HeaderText = Jr.DateDT.ToString("ddd dd MMM") + "\r\n\r\n" + Jr.DemiJour;

                if (Jr.DemiJour == "Matin")
                {
                    DGV_Appel.Columns[ColCount - 1].Name = Jr.DateDT.ToString("yyyy-MM-dd") + "_AM";
                }
                else
                {
                    DGV_Appel.Columns[ColCount - 1].Name = Jr.DateDT.ToString("yyyy-MM-dd") + "_PM";
                }


                if (Jr.IsFerie)
                {
                    DGV_Appel.Columns[ColCount - 1].HeaderText = Jr.DateDT.ToString("ddd dd MMM") + "\r\nFérié";
                    DGV_Appel.Columns[ColCount - 1].DefaultCellStyle.BackColor = Color.Pink;
                }
                else if (Jr.IsVacances)
                {
                    DGV_Appel.Columns[ColCount - 1].HeaderText = Jr.DateDT.ToString("ddd dd MMM") + "\r\nVacances";
                    DGV_Appel.Columns[ColCount - 1].DefaultCellStyle.BackColor = Color.Magenta;
                }
                else if (Jr.IsWeekend)
                {
                    DGV_Appel.Columns[ColCount - 1].HeaderText = Jr.DateDT.ToString("ddd dd MMM");
                    DGV_Appel.Columns[ColCount - 1].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }


            foreach (DataGridViewColumn column in DGV_Appel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 100;
            }
           
            DGV_Appel.Columns["id"].Visible = false;

        }

        private void Populate_DGV_Appel(List<Eleve> Eleves)
        {

            DGV_Appel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Appel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Appel.Rows.Clear();

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            foreach (Eleve Elv in Eleves)
            {

                var index = DGV_Appel.Rows.Add();
                DGV_Appel.Rows[index].Cells["id"].Value = Elv.Id;
                DGV_Appel.Rows[index].Cells["nom"].Value = Elv.Nom;
                DGV_Appel.Rows[index].Cells["prenom"].Value = Elv.Prenom;
                DGV_Appel.Rows[index].Cells["niveau"].Value = Elv.Niveau;

                foreach (Jour Jr in JoursPeriode)
                {
                    RemplirCellAppel(index, Jr.DgvColumn.Index, Elv, Jr);
                }

                // Elv.Dgv_row = DGV_Appel.Rows[index];
            }
            maConnexion.Close();

            DGV_Appel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Appel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void RemplirCellAppel(int RowIndex, int ColIndex, Eleve Elv, Jour Jr)
        {
            DataGridViewCell Cell = DGV_Appel.Rows[RowIndex].Cells[ColIndex];
            
            Appel Apl = Elv.Appels.FirstOrDefault(X => X.Jour == Jr.DateStr && X.DemiJournee == Jr.DemiJour);
            if (Apl != null)
            {
                Cell.Value = Apl.Etat;
                if (Apl.Etat.Equals("Absent"))
                {
                    if (Apl.Justifiee != "")
                    {
                        Cell.Value += " (" + Apl.Justifiee + ")";
                        Cell.Style.BackColor = Color.FromArgb(255, 200, 200);
                        Cell.Style.SelectionBackColor = Color.FromArgb(255, 200, 200);
                    }
                    else
                    {
                        Cell.Value += " (NJ)";
                        Cell.Style.ForeColor = Color.White;
                        Cell.Style.BackColor = Color.Red;
                        Cell.Style.SelectionBackColor = Color.Red;
                    }

                }
                else if (Apl.Etat.Equals("Retard"))
                {
                    Cell.Style.BackColor = Color.Orange;
                    Cell.Style.SelectionBackColor = Color.Orange;
                    if (Apl.Justifiee != "")
                    {
                        Cell.Value += " (" + Apl.Justifiee + ")";
                    }
                    else
                    {
                        Cell.Value += " (NJ)";
                    }
                }
            }
            else
            {
                Cell.Value = "";    // POUR QUE LA VALEUR NE SOIT PAS NULL
            }


            if(! string.IsNullOrEmpty(Elv.DateEntree))
            {
                if(DateTime.Parse(Elv.DateEntree) > Jr.DateDT)
                {
                    Cell.Style.BackColor = Color.Gray;
                    Cell.Style.SelectionBackColor = Color.Gray;
                }
            }

        }
        
        private void DGV_Appel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int ColIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;
            
            if (ColIndex < 3)   // 1: nom  et 2:Prenom
            {
                return;
            }


            DataGridViewColumn Selected_col = DGV_Appel.Columns[e.ColumnIndex];
            Jour JourCliked = JoursPeriode.First(X => X.DgvColumn == Selected_col);


            if (JourCliked.IsVacances)
            {
                MessageBox.Show("Vous ne pouvez pas faire l'appel un pendant les vacances");
                return;
            }
            else if (JourCliked.IsFerie)
            {
                MessageBox.Show("Vous ne pouvez pas faire l'appel un jour férié");
                return;
            }
            else if (JourCliked.IsWeekend)
            {
                MessageBox.Show("Vous ne pouvez pas faire l'appel un " + JourCliked.DateDT.ToString("dddd"));
                return;
            }



            // ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■    Header Double-Click

            if (RowIndex == -1) //header
            {
                if (SelectedJour != null)
                {
                    return;
                }             
                          
                if (JourCliked.DateDT > DateTime.Today)
                {
                    MessageBox.Show("Vous ne pouvez pas faire l'appel pour un jour du futur, posterieur à la date actuelle d'aujourd'hui.");
                    return;
                }

                SelectedJour = JourCliked;
                SelectionnerColonne_SelectedJour();
                return;
            }


            // ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■    


            DataGridViewRow Row = DGV_Appel.Rows[RowIndex];
            DataGridViewCell Cell = Row.Cells[ColIndex];
            String StrEleve = Row.Cells[1].Value.ToString() + " " + Row.Cells[2].Value.ToString();
            int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());


            // ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■    Cell Double-Click : APPEL ELEVE

            if (SelectedJour == null)
            {
                DoubleClick_Cellule_Unique(Row, Cell, JourCliked, eleveId, StrEleve);
            }



            // ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■    Cell Double-Click : APPEL CLASSE

            if (SelectedJour != null && ColIndex == SelectedJour.DgvColumn.Index)
            {
              

                Appel Apl = AppelsTemp.Where(x => x.EleveId == eleveId).FirstOrDefault();


                F_Appel_Noter Frm = new F_Appel_Noter(StrEleve, Apl);
                var result = Frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Cell.Value = Apl.Etat;
                    if (Apl.Justifiee != "")
                    {
                        Cell.Value += " : " + Apl.Justifiee;
                    }


                    if (Apl.Etat == "Absent")
                    {
                        Cell.Style.BackColor = Color.Red;
                        Cell.Style.SelectionBackColor = Color.Red;
                        if (Apl.Justifiee != "")
                        {
                            Cell.Style.BackColor = Color.Pink;
                        }
                    }
                    else if (Apl.Etat == "Retard")
                    {
                        Cell.Style.BackColor = Color.Orange;
                        Cell.Style.SelectionBackColor = Color.Orange;
                    }
                    else
                    {
                        Cell.Style.BackColor = Color.Yellow;
                        Cell.Style.SelectionBackColor = Color.Yellow;
                    }


                }


            }
        



        }
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  FAIRE APPEL    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void SelectionnerColonne_SelectedJour()
        {


            PAN_Help_Appel1.Visible = false;
            PAN_Help_Appel2.Visible = true;
            PAN_Help_Justifier.Visible = false;



            int SelectedColIndex = SelectedJour.DgvColumn.Index;


            foreach (DataGridViewRow Row in DGV_Appel.Rows)
            {
                if (Row.Cells[SelectedColIndex].Value.ToString() == "" || Row.Cells[SelectedColIndex].Value.ToString() == "Present")
                {
                    Row.Cells[SelectedColIndex].Style.BackColor = Color.Yellow;
                    Row.Cells[SelectedColIndex].Value = "Present";
                }
            }



            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            AppelsTemp = new List<Appel>();
            foreach (Eleve Elv in SelectedClasseEleves)
            {
                Appel Apl = new Appel();

                using (SQLiteCommand fmd = maConnexion.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + Elv.Id + "' AND jour = '" + SelectedJour.DateStr + "' AND demi_journee = '" + SelectedJour.DemiJour + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader rdr = fmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Apl = new Appel(rdr);
                    }
                }

                if (Apl.Id == 0)
                {
                    Apl.EleveId = Elv.Id;
                    Apl.Jour = SelectedJour.DateStr;
                    Apl.DemiJournee = SelectedJour.DemiJour;
                    Apl.Etat = "Present";
                    Apl.Justifiee = "";
                    Apl.Infos = "";
                }

                AppelsTemp.Add(Apl);
            }
            maConnexion.Close();

            BT_AnnulerAppel.Visible = true;
            BT_AppelTermine.Visible = true;

        }
        
        private void DoubleClick_Cellule_Unique(DataGridViewRow Row, DataGridViewCell Cell, Jour Jr, int eleveId, string StrEleve)
        {



            Row.Cells[1].Style.SelectionBackColor = Color.Yellow;
            Row.Cells[1].Style.BackColor = Color.Yellow;
            Row.Cells[2].Style.SelectionBackColor = Color.Yellow;
            Row.Cells[2].Style.BackColor = Color.Yellow;
            Cell.Style.SelectionBackColor = Color.Yellow;
            Cell.Style.BackColor = Color.Yellow;


            Appel Apl = Appel.GetAppel(eleveId, Jr.DateStr, Jr.DemiJour);

            if (Apl == null)
            {
                Apl = new Appel();
                Apl.EleveId = eleveId;
                Apl.Jour = Jr.DateStr;
                Apl.DemiJournee = Jr.DemiJour;
                Apl.Etat = "Present";
                Apl.Justifiee = "";
                Apl.Infos = "";

            }

            F_Appel_Noter Frm = new F_Appel_Noter(StrEleve, Apl);
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {

                if(Apl.Etat == "Present" && DateTime.Parse(Apl.Jour)> Today)    // on supprime les appel "Present" du futur 
                {
                    if (Apl.Id != 0)    // si Apl.Id == 0 :: l'appel n'est pas encore dans la BDD, donc pas la peine de le suppr
                    {
                        Apl.DeleteInBdd();
                    }
                        
                }
                else if (Apl.Id == 0)
                {
                    Apl.InsertInBdd();
                }
                else
                {
                    Apl.UpdateInBdd();
                }

                ChargerAppel();

            }

        }
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  COMBO_Semaines    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void CreerItem_COMBO_Semaines()
        {
            COMBO_Semaines.Items.Clear();

            Dictionary<DateTime, string> DicoComboSem = new Dictionary<DateTime, string>();

            DateTime TempDay = APZ_FirstDayOfYear;
            while (TempDay <= APZ_LastDayOfYear)
            {
                DateTime TempDay2 = TempDay;
                String ComboText = TempDay2.ToString("dd MMM");
                if (SelectedMonday == TempDay)
                {
                    ComboText += " (Semaine en cours)";
                }
                DicoComboSem.Add(TempDay2, ComboText);
                TempDay = TempDay.AddDays(7);
            }

            COMBO_Semaines.DataSource = new BindingSource(DicoComboSem, null);
            COMBO_Semaines.DisplayMember = "Value";
            COMBO_Semaines.ValueMember = "Key";
            COMBO_Semaines.SelectedValue = SelectedMonday;

        }

        private void COMBO_Semaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {
                SelectedMonday = ((KeyValuePair<DateTime, string>)COMBO_Semaines.SelectedItem).Key;
                ChargerAppel();

            }
        }

        private void BT_PreviousWeek_Click(object sender, EventArgs e)
        {
            if (COMBO_Semaines.SelectedIndex > 0)
            {
                COMBO_Semaines.SelectedIndex = COMBO_Semaines.SelectedIndex - 1;
            }
        }

        private void BT_NextWeek_Click(object sender, EventArgs e)
        {
            if (COMBO_Semaines.SelectedIndex < COMBO_Semaines.Items.Count - 1)
            {
                COMBO_Semaines.SelectedIndex = COMBO_Semaines.SelectedIndex + 1;
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  COMBO_Classes    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void CreerItem_COMBO_Classes()
        {

            /*
          
         
            foreach (Classe Cl in Classes)
            {
                Button BT = new Button();
                BT.Text = Cl.Nom;
                BT.FlatStyle = FlatStyle.Flat;
                BT.BackColor = Color.White;


               

                BT.Click += (sender2, e2) => BT_Classe_Click(sender2, e2, Cl);
                FLP_BoutonsClasses.Controls.Add(BT);

            }
            */
            /////////


            List<Classe> ClassesTemp = Classe.Bdd_GetClasses_OrderByName();

            COMBO_Classes.Items.Clear();

            Dictionary<Classe, string> DicoComboClasse = new Dictionary<Classe, string>();

            SelectedClasse = null;


            foreach (Classe Cl in ClassesTemp)
            {
                String ComboText = Cl.Nom;
                foreach (Classe UserClasse in Global.User.Personnel.Classes)
                {
                    if (UserClasse.Id == Cl.Id)
                    {
                        ComboText += " (Ma classe)";
                        SelectedClasse = Cl;
                    }
                }
                DicoComboClasse.Add(Cl, ComboText);

            }

            if (SelectedClasse == null)
            {
                SelectedClasse = ClassesTemp.Where(X => X.Id != 0).First();
            }


            COMBO_Classes.DataSource = new BindingSource(DicoComboClasse, null);
            COMBO_Classes.DisplayMember = "Value";
            COMBO_Classes.ValueMember = "Key";
            COMBO_Classes.SelectedValue = SelectedClasse;

        }

        private void COMBO_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {
                SelectedClasse = ((KeyValuePair<Classe, string>)COMBO_Classes.SelectedItem).Key;
                //    SelectedClasseEleves = Global.GetListElevesFromBddByClasseIdentifiant(SelectedClasse.Identifiant);
                SelectedClasseEleves = Eleve.GetListElevesFromBddByClasseIdentifiant_SortByNiveau(SelectedClasse.Identifiant);
               // SelectedClasseEleves = Global.GetListElevesFromBdd();
                ChargerAppel();
            }
        }
             

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void BT_AnnulerAppel_Click(object sender, EventArgs e)
        {
            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            SelectedJour = null;
        //    FLP_BoutonsClasses.Enabled = true;
            ChargerAppel();
        }

        private void BT_AppelTermine_Click(object sender, EventArgs e)
        {
            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            if (SelectedJour != null)
            {


                String StrResult = "Appel Terminé";
                StrResult += "\r\n\r\n" + SelectedJour + " - " + SelectedJour.DemiJour + "\r\n\r\n";



                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();

                foreach (Eleve Elv in SelectedClasseEleves)
                {
                    SQLiteCommand command = new SQLiteCommand(maConnexion);
                    command.CommandText = "DELETE FROM appels WHERE eleve_id = '" + Elv.Id + "' AND jour = '" + SelectedJour.DateStr + "' AND demi_journee = '" + SelectedJour.DemiJour + "'";
                    command.ExecuteNonQuery();
                }

                foreach (Appel Ap in AppelsTemp)
                {
                    Ap.InsertInBdd(maConnexion);
                }
                maConnexion.Close();

                SelectedJour = null;

           //     FLP_BoutonsClasses.Enabled = true;
                ChargerAppel();
            }
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
