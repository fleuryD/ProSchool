using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Appels_Faire : Form
    {               
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Eleve> ElevesClasses;
        private int SelectedColIndex = -1;

        private String SelectedJour = "";
        private String SelectedDemiJour = "";
        private String SelectedColName = "";





        //////////// copié OK ///////////


        private List<Appel> AppelsTemp;
        private Boolean InitOk;
        private DateTime Today;
        private DateTime CalendarFirstDay = Convert.ToDateTime("2019/09/02");
        private DateTime CalendarLastDay = Convert.ToDateTime("2020/07/15");
        private DateTime SelectedMonday;
        private Classe SelectedClasse;


        ////////////////////////////////////////////////

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Appels_Faire()
        {
            InitializeComponent();
        }

        private void F_Appels_Faire_Load(object sender, EventArgs e)
        {
            InitOk = false;
            PAN_Help_SelectClasse.Visible = true;
            PAN_Help_Appel1.Visible = false;
            PAN_Help_Appel2.Visible = false;
            PAN_Help_Justifier.Visible = false;
            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;
            DGV_Appel.Visible = false;


            Today = DateTime.Today;
            LB_DateToday.Text = Today.ToLongDateString();   //today.ToLongDateString() + " >>>> " + today.ToString("dddd dd MMMM") + " >>>> " + today.ToString("yyyy-MM-dd");
            
            SelectedMonday = Global.GetMondayOfCurrentWeek();
            SelectedClasse = null;

            CreerBoutonsClasses();
            CreerItem_COMBO_Semaines();

            InitOk = true;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  NEW    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void ChargerAppel()
        {
            PAN_Help_SelectClasse.Visible = false;
            PAN_Help_Appel1.Visible = true;
            PAN_Help_Appel2.Visible = false;
            PAN_Help_Justifier.Visible = true;
            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;
            DGV_Appel.Visible = true;



            Setup_DGV_Appel();
            ElevesClasses = Eleve.GetListElevesFromBddByClasseIdentifiant(SelectedClasse.Identifiant);
            Populate_DGV_Appel(ElevesClasses);
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  BT Click + Create    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void BT_AppelTermine_Click(object sender, EventArgs e)
        {

            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            if (SelectedColIndex > 0)
            {
        

                String StrResult = "Appel Terminé";
                StrResult += "\r\n\r\n" + SelectedJour + " - " + SelectedDemiJour + "\r\n\r\n";

       

                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();

                foreach(Eleve Elv in ElevesClasses) { 
                    SQLiteCommand command = new SQLiteCommand(maConnexion);
                    command.CommandText = "DELETE FROM appels WHERE eleve_id = '" + Elv.Id + "' AND jour = '" + SelectedJour + "' AND demi_journee = '" + SelectedDemiJour + "'";
                    command.ExecuteNonQuery();
                }

                foreach (Appel Ap in AppelsTemp)
                {
                    Ap.InsertInBdd(maConnexion);
                }
                maConnexion.Close();

                SelectedColIndex = -1;

                FLP_BoutonsClasses.Enabled = true;
                ChargerAppel();
            }
        }

        private void BT_AppelTermine_Click_________________OLD(object sender, EventArgs e)
        {

            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            if (SelectedColIndex > 0)
            {
                List<Appel> Appels = new List<Appel>();


                String StrResult = "Appel Terminé";
                StrResult += "\r\n\r\n" + SelectedJour + " - " + SelectedDemiJour + "\r\n\r\n";

                foreach (DataGridViewRow Row in DGV_Appel.Rows)
                {
                    String StrEleve = Row.Cells[1].Value.ToString();
                    int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());
                    String StrLigne = Row.Cells[SelectedColIndex].Value.ToString();
                    if (!StrLigne.Equals("Present"))
                        StrResult += "\r\n" + StrEleve + " : " + StrLigne;

                    Appels.Add(new Appel(0, eleveId, SelectedJour, SelectedDemiJour, StrLigne, "", ""));

                }

                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();

                foreach (Appel Ap in Appels)
                {
                    Ap.InsertInBdd(maConnexion);
                }
                maConnexion.Close();

                //MessageBox.Show(StrResult);
                SelectedColIndex = -1;

                FLP_BoutonsClasses.Enabled = true;
                ChargerAppel();
            }
        }

        private void BT_AnnulerAppel_Click(object sender, EventArgs e)
        {
            BT_AnnulerAppel.Visible = false;
            BT_AppelTermine.Visible = false;

            SelectedColIndex = -1;
            FLP_BoutonsClasses.Enabled = true;
            ChargerAppel();
            /*
            foreach (DataGridViewRow Row in DGV_Appel.Rows)
            {
                Row.Cells[SelectedColIndex].Style.BackColor = Color.White;
                Row.Cells[SelectedColIndex].Value = "";
            }


            SelectedColIndex = -1;
            */
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);

            int daysOffset = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;

            DateTime firstMonday = jan1.AddDays(daysOffset);

            int firstWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(jan1, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

            if (firstWeek <= 1)
            {
                weekOfYear -= 1;
            }

            return firstMonday.AddDays(weekOfYear * 7);
        }
              


        private void xxxxxxxx(SQLiteConnection maConnexion, int RowIndex, int ColIndex, int EleveId)
        {
            DataGridViewCell Cell = DGV_Appel.Rows[RowIndex].Cells[ColIndex];

            String Etat = GetAppelFromEleveIdAndJour_DemiJour(maConnexion, EleveId, DGV_Appel.Columns[ColIndex].Name);
            Cell.Value = Etat;

            if (Etat.Equals("Absent"))
            {
                
                Cell.Style.BackColor = Color.Red;
                Cell.Style.SelectionBackColor = Color.Red;
            }
            else if (Etat.Equals("Retard"))
            {
                Cell.Style.BackColor = Color.Orange;
                Cell.Style.SelectionBackColor = Color.Orange;
            }
        }


        private String GetAppelFromEleveIdAndJour_DemiJour(SQLiteConnection maConnexion, int EleveId, string Jour_DemiJour)
        {
            String Jour = "Jour ?";
            String DemiJour = "DemiJour ?";
            String StringReturnAppel = "";

            if (Jour_DemiJour.EndsWith("_AM"))
            {
                Jour = Jour_DemiJour.Replace("_AM", "");
                DemiJour = "Matin";
            }
            else if (Jour_DemiJour.EndsWith("_PM"))
            {
                Jour = Jour_DemiJour.Replace("_PM", "");
                DemiJour = "Aprem";
            }



            using (SQLiteCommand fmd = maConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + EleveId + "' AND jour = '" + Jour + "' AND demi_journee = '" + DemiJour + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader rdr = fmd.ExecuteReader();
                while (rdr.Read())
                {
                    StringReturnAppel = rdr["etat"].ToString();
                }
            }



            return StringReturnAppel;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Appel    ■■■■■■■■■■■■■■■■■■■■■■■■
        
        private void Setup_DGV_Appel()
        {
            DGV_Appel.ColumnCount = 14;

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

            DGV_Appel.Columns[0].Name = "id";
            DGV_Appel.Columns[1].Name = "nom";
            DGV_Appel.Columns[1].HeaderText = "Nom";
            DGV_Appel.Columns[2].Name = "prenom";
            DGV_Appel.Columns[2].HeaderText = "Prénom";


            DateTime Monday = SelectedMonday;
            DateTime day = Monday;
            DGV_Appel.Columns[3].Name = day.ToString("yyyy-MM-dd")+"_AM";
            DGV_Appel.Columns[3].HeaderText = day.ToString("ddd dd MMM") + "\r\nMatin";
            DGV_Appel.Columns[4].Name = day.ToString("yyyy-MM-dd") + "_PM";
            DGV_Appel.Columns[4].HeaderText = day.ToString("ddd dd MMM") + "\r\nAprem";


            day = day.AddDays(1);
            DGV_Appel.Columns[5].Name = day.ToString("yyyy-MM-dd") + "_AM";
            DGV_Appel.Columns[5].HeaderText = day.ToString("ddd dd MMM") + "\r\nMatin";
            DGV_Appel.Columns[6].Name = day.ToString("yyyy-MM-dd") + "_PM";
            DGV_Appel.Columns[6].HeaderText = day.ToString("ddd dd MMM") + "\r\nAprem";
      

            day = day.AddDays(1);
            DGV_Appel.Columns[7].Name = "Mercredi";
            DGV_Appel.Columns[7].HeaderText = "Mer.";
     

            day = day.AddDays(1);
            DGV_Appel.Columns[8].Name = day.ToString("yyyy-MM-dd") + "_AM";
            DGV_Appel.Columns[8].HeaderText = day.ToString("ddd dd MMM") + "\r\nMatin";
            DGV_Appel.Columns[9].Name = day.ToString("yyyy-MM-dd") + "_PM";
            DGV_Appel.Columns[9].HeaderText = day.ToString("ddd dd MMM") + "\r\nAprem";

            day = day.AddDays(1);
            DGV_Appel.Columns[10].Name = day.ToString("yyyy-MM-dd") + "_AM";
            DGV_Appel.Columns[10].HeaderText = day.ToString("ddd dd MMM") + "\r\nMatin";
            DGV_Appel.Columns[11].Name = day.ToString("yyyy-MM-dd") + "_PM";
            DGV_Appel.Columns[11].HeaderText = day.ToString("ddd dd MMM") + "\r\nAprem";
            
            DGV_Appel.Columns[12].Name = "Samedi";
            DGV_Appel.Columns[12].HeaderText = "Sam.";
            DGV_Appel.Columns[13].Name = "Dimanche";
            DGV_Appel.Columns[13].HeaderText = "Dim.";


            foreach (DataGridViewColumn column in DGV_Appel.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 100;
            }

            DGV_Appel.Columns["Mercredi"].Width = 50;
            DGV_Appel.Columns["Samedi"].Width = 50;
            DGV_Appel.Columns["Dimanche"].Width = 50;

            DGV_Appel.Columns["Mercredi"].DefaultCellStyle.BackColor = Color.LightGray;
            DGV_Appel.Columns["Samedi"].DefaultCellStyle.BackColor = Color.LightGray;
            DGV_Appel.Columns["Dimanche"].DefaultCellStyle.BackColor = Color.LightGray;

            DGV_Appel.Columns["id"].Visible = false;

        }
                       
        private void Populate_DGV_Appel(List<Eleve> Eleves)
        {

            DGV_Appel.Rows.Clear();
            DGV_Appel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Appel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            ///////////////////////////   DGV_Appel.Rows.Clear();
            ///

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            foreach (Eleve Elv in Eleves)
            {

                var index = DGV_Appel.Rows.Add();
                DGV_Appel.Rows[index].Cells["id"].Value = Elv.Id;
                DGV_Appel.Rows[index].Cells["nom"].Value = Elv.Nom;
                DGV_Appel.Rows[index].Cells["prenom"].Value = Elv.Prenom;


                xxxxxxxx(maConnexion, index, 3, Elv.Id);
                xxxxxxxx(maConnexion, index, 4, Elv.Id);
                xxxxxxxx(maConnexion, index, 5, Elv.Id);
                xxxxxxxx(maConnexion, index, 6, Elv.Id);
                xxxxxxxx(maConnexion, index, 8, Elv.Id);
                xxxxxxxx(maConnexion, index, 9, Elv.Id);
                xxxxxxxx(maConnexion, index, 10, Elv.Id);
                xxxxxxxx(maConnexion, index, 11, Elv.Id);


                // Obj.Dgv_row = DGV_Appel.Rows[index];
                // DGV_Appel.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            maConnexion.Close();

            //  DGV_Appel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Appel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void DGV_Appel_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SelectedColIndex != -1)
            {
                return;
            }




            int ColIndex = e.ColumnIndex;
            String ColName = DGV_Appel.Columns[ColIndex].Name;

            if (ColName.EndsWith("_AM"))
            {
                SelectedJour = ColName.Replace("_AM", "");
                SelectedDemiJour = "Matin";
            }
            else if (ColName.EndsWith("_PM"))
            {
                SelectedJour = ColName.Replace("_PM", "");
                SelectedDemiJour = "Aprem";
            }
            else
            {
                return;
            }

            PAN_Help_Appel1.Visible = false;
            PAN_Help_Appel2.Visible = true;
            PAN_Help_Justifier.Visible = false;
            BT_AnnulerAppel.Visible = true;
            BT_AppelTermine.Visible = true;


            FLP_BoutonsClasses.Enabled = false;

            SelectedColIndex = ColIndex;
            SelectedColName = ColName;


            foreach (DataGridViewRow Row in DGV_Appel.Rows)
            {
                if(Row.Cells[SelectedColIndex].Value.ToString() == "" || Row.Cells[SelectedColIndex].Value.ToString() == "Present")
                {
                    Row.Cells[SelectedColIndex].Style.BackColor = Color.Yellow;
                    Row.Cells[SelectedColIndex].Value = "Present";
                }
            }


            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            AppelsTemp = new List<Appel>();
            foreach (Eleve Elv in ElevesClasses)
            {
                Appel Apl = new Appel();

                using (SQLiteCommand fmd = maConnexion.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + Elv.Id + "' AND jour = '" + SelectedJour + "' AND demi_journee = '" + SelectedDemiJour + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader rdr = fmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Apl = new Appel (rdr);
                    }
                }
                
                if (Apl.Id == 0)
                {
                    Apl.EleveId = Elv.Id;
                    Apl.Jour = SelectedJour;
                    Apl.DemiJournee = SelectedDemiJour;
                    Apl.Etat = "Present";
                    Apl.Justifiee = "";
                    Apl.Infos = "";
                }

                AppelsTemp.Add(Apl);
             }
            maConnexion.Close();

        }

        private void DGV_Appel_CellDoubleClick__________OLD(object sender, DataGridViewCellEventArgs e)
        {
            int ColIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;

            if (RowIndex == -1)
            {
                return;
            }
            else if (ColIndex == SelectedColIndex)
            {
                //    DGV_Appel.Columns[ColIndex].Cells[ColIndex].Value = "Present";
                DataGridViewCell Cell = DGV_Appel.Rows[RowIndex].Cells[ColIndex];

                if (Cell.Value.Equals("Present"))
                {
                    Cell.Value = "Absent";
                    Cell.Style.BackColor = Color.Red;
                    Cell.Style.SelectionBackColor = Color.Red;
                }
                else if (Cell.Value.Equals("Absent"))
                {
                    Cell.Value = "Retard";
                    Cell.Style.BackColor = Color.Orange;
                    Cell.Style.SelectionBackColor = Color.Orange;
                }
                else
                {
                    Cell.Value = "Present";
                    Cell.Style.BackColor = Color.Yellow;
                    Cell.Style.SelectionBackColor = Color.Yellow;
                }

            }

        }
        
        private void DGV_Appel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ColIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;

            if (RowIndex == -1)
            {
                return;
            }
            else if (ColIndex == SelectedColIndex)
            {
                DataGridViewRow Row = DGV_Appel.Rows[RowIndex];

                //Eleve Elv = 
                String StrEleve = Row.Cells[1].Value.ToString() + " " + Row.Cells[2].Value.ToString();
                int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());

                //    MessageBox.Show(AppelsTemp.Count.ToString());
                Appel Apl = AppelsTemp.Where(x => x.EleveId == eleveId).FirstOrDefault();

                //     MessageBox.Show(eleveId + " " + StrEleve);
                //  MessageBox.Show(Apl.EleveId.ToString());


                F_Appel_Noter Frm = new F_Appel_Noter(StrEleve, Apl);
                var result = Frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataGridViewCell Cell = Row.Cells[ColIndex];
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


            else if (SelectedColIndex == -1 && (ColIndex == 1 || ColIndex == 2))
            {
             //   MessageBox.Show("eleve");

                DataGridViewRow Row = DGV_Appel.Rows[RowIndex];
                int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());
                Eleve SelectedEleve = Eleve.GetEleveByIdFromBdd(eleveId);
                SelectedEleve.Appels = Appel.GetAppelFromEleveId(SelectedEleve.Id);
                F_Eleves_Absences_Dgv Frm = new F_Eleves_Absences_Dgv(SelectedEleve);
                Frm.ShowDialog();

                /*

                //Eleve Elv = 
                String StrEleve = Row.Cells[1].Value.ToString() + " " + Row.Cells[2].Value.ToString();
                int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());

                //    MessageBox.Show(AppelsTemp.Count.ToString());
                Appel Apl = AppelsTemp.Where(x => x.EleveId == eleveId).FirstOrDefault();

                //     MessageBox.Show(eleveId + " " + StrEleve);
                //  MessageBox.Show(Apl.EleveId.ToString());


                F_Appel_Noter Frm = new F_Appel_Noter(StrEleve, Apl);
                var result = Frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataGridViewCell Cell = Row.Cells[ColIndex];
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
                
    */

            }

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  combo SEMAINES    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void CreerItem_COMBO_Semaines()
        {

            COMBO_Semaines.Items.Clear();

            Dictionary<DateTime, string> DicoComboSem = new Dictionary<DateTime, string>();



            DateTime TempDay = CalendarFirstDay;
            while (TempDay <= CalendarLastDay)
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
                String strMonday = ((KeyValuePair<DateTime, string>)COMBO_Semaines.SelectedItem).Key.ToString();

                SelectedMonday = DateTime.Parse(strMonday);
                //     MessageBox.Show(strMonday);



                if (SelectedClasse != null)
                {
                    ChargerAppel();
                }



            }
        }

        private void BT_NextWeek_Click(object sender, EventArgs e)
        {
            if (COMBO_Semaines.SelectedIndex < COMBO_Semaines.Items.Count - 1)
            {
                COMBO_Semaines.SelectedIndex = COMBO_Semaines.SelectedIndex + 1;
            }
        }

        private void BT_PreviousWeek_Click(object sender, EventArgs e)
        {
            if (COMBO_Semaines.SelectedIndex > 0)
            {
                COMBO_Semaines.SelectedIndex = COMBO_Semaines.SelectedIndex - 1;
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  Boutons Classes    ■■■■■■■■■■■■■■■■■■■■■■■■
               
        private void CreerBoutonsClasses()
        {



            List<Classe> Classes = Classe.Bdd_GetClasses_OrderByName();
            FLP_BoutonsClasses.Controls.Clear();
            foreach (Classe Cl in Classes)
            {
                Button BT = new Button();
                BT.Text = Cl.Nom;
                BT.FlatStyle = FlatStyle.Flat;
                BT.BackColor = Color.White;


                foreach (Classe UserClasse in Global.User.Personnel.Classes)
                {
                    if (UserClasse.Id == Cl.Id)
                    {
                        BT.ForeColor = Color.Blue;
                    }
                }

                BT.Click += (sender2, e2) => BT_Classe_Click(sender2, e2, Cl);
                FLP_BoutonsClasses.Controls.Add(BT);

            }

        }
        private void BT_Classe_Click(object sender, EventArgs e, Classe cl)
        {
            foreach (Control CtrlBt in FLP_BoutonsClasses.Controls)
            {
                CtrlBt.BackColor = Color.White;
            }

            Button BT = (Button)sender;
            BT.BackColor = Color.Yellow;
            SelectedClasse = cl;
            ChargerAppel();
        }

       


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
