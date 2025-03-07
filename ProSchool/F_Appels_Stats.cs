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
    public partial class F_Appels_Stats : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        Boolean INIT_OK = false;

        private List<Classe> Classes;

        private List<Jour> JoursPeriode;    // ce sont des demi-journées !!!!
        private List<Appel> AppelsAll;


        private DateTime Periode_MinDay = DateTime.Parse("2019-09-01");   //minDate
        private DateTime Periode_FirstDay = DateTime.Parse("2019-09-01");   //minDate
        private DateTime Periode_LastDay = DateTime.Today;

        Boolean ShowRetard;
        Boolean CompterAppelsNonFaits;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Appels_Stats()
        {
            InitializeComponent();
        }

        private void F_Appels_Stats_Load(object sender, EventArgs e)
        {
            INIT_OK = false;

            DTPICKER_DateDebut.Value = Periode_FirstDay;
            DTPICKER_DateDebut.MinDate = Periode_MinDay;
            DTPICKER_DateDebut.MaxDate = DateTime.Today; 

            DTPICKER_DateFin.Value = DateTime.Today;
            DTPICKER_DateFin.MinDate = Periode_MinDay;
            DTPICKER_DateFin.MaxDate = DateTime.Today;

            Classes = Classe.Bdd_GetClasses_OrderByName();
            foreach (Classe Cl in Classes)
            {
                Cl.Eleves = Eleve .GetListElevesFromBddByClasseIdentifiant(Cl.Identifiant);
                Cl.SetPersonnels();
            }
            LoadStat();
            INIT_OK = true;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void LoadStat()
        {

            /*** FILTRES **/
            Periode_FirstDay = DTPICKER_DateDebut.Value;
            Periode_LastDay = DTPICKER_DateFin.Value;

            ShowRetard = RADIO_Retards_Show.Checked;
            CompterAppelsNonFaits = RADIO_CompterAppelsNonFaits.Checked;
       


            /*** FILTRES **/

            int NbreJour = (int)(Periode_LastDay - Periode_FirstDay).TotalDays +1;

            LB_Periode.Text = "(" + NbreJour + " jours)";





            SQLiteConnection MaConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            MaConnexion.Open();

            JoursPeriode = Get_DemiJours_From_Periodes(MaConnexion);

           AppelsAll = Appel.GetAppelsPeriode(MaConnexion, Periode_FirstDay.ToString("yyy-MM-dd"), Periode_LastDay.ToString("yyy-MM-dd"));
          //  MessageBox.Show(AppelsAll.Count().ToString());

            LB_NbreDemiJour.Text = JoursPeriode.Count().ToString();


            Setup_DGV_Stat();
            Populate_DGV_Stat();

            MaConnexion.Close();
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private List<Jour> Get_DemiJours_From_Periodes(SQLiteConnection MaConnexion)
        {
            List<Jour> JoursPeriodeTemp = new List<Jour>();

            DateTime TempDay = Periode_FirstDay;
            while (TempDay <= Periode_LastDay)
            {
                DateTime TempDay2 = TempDay;
                Boolean Vac = Global.IsVacances(MaConnexion, TempDay2.ToString("yyyy-MM-dd"));
                Boolean Fer = Global.IsFerie(MaConnexion, TempDay2.ToString("yyyy-MM-dd"));
                Jour JM = new Jour(TempDay2, "Matin", Vac, Fer);
                if (!JM.IsWeekend && !JM.IsFerie && !JM.IsVacances)
                {
                    JoursPeriodeTemp.Add(JM);
                    JoursPeriodeTemp.Add(new Jour(TempDay2, "Aprem", Vac, Fer));
                }
                TempDay = TempDay.AddDays(1);
            }

            return JoursPeriodeTemp;
        }

        private String StrPourcentage(int nbre, int total, int nbre_unite, int nbre_decimal)
        {
            String Str = "";

            if(total == 0)
            {
                return "Err: division par 0";
            }

            float pourcent = (float)nbre * (float)100 / (float)total;

            Str = pourcent.ToString() + "   %";

            if (nbre_unite >= 2 && pourcent < 10)
            {
                Str = "0" + Str;
            }
            if (nbre_unite >= 3 && pourcent < 100)
            {
                Str = "0" + Str;
            }

            return Str;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void DGV_AddCol(DataGridView _DGV, String _Name, String _HeaderText = "")
        {
            _DGV.ColumnCount = _DGV.ColumnCount + 1;


            if (_HeaderText == "")
            {
                _HeaderText = _Name;
            }

            DGV_Stat.Columns[_DGV.ColumnCount - 1].Name = _Name;
            DGV_Stat.Columns[_DGV.ColumnCount - 1].HeaderText = _HeaderText;
        }
        private void Setup_DGV_Stat()
        {

            DGV_Stat.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Stat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Stat.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Stat.Font, FontStyle.Bold);
            DGV_Stat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Stat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //     DGV_Stat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DGV_Stat.ColumnHeadersHeight = 40;
            DGV_Stat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Stat.RowHeadersVisible = false;
            //   DGV_Stat.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DGV_Stat.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Stat.GridColor = Color.Black;
            DGV_Stat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Stat.MultiSelect = true;
            DGV_Stat.AllowUserToAddRows = false;
            DGV_Stat.AllowUserToOrderColumns = false;
            DGV_Stat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 240, 255);
            DGV_Stat.DefaultCellStyle.SelectionForeColor = Color.Black;


            DGV_Stat.ColumnCount = 0;
            /*
            DGV_Stat.Columns[0].Name = "id";
            DGV_Stat.Columns[1].Name = "identifiant";
            DGV_Stat.Columns[2].Name = "nom";
            DGV_Stat.Columns[3].Name = "cycles";
            DGV_Stat.Columns[4].Name = "nbreEleves";
            DGV_Stat.Columns[5].Name = "profs";
      

            //DGV_Stat.Columns["xxxxxxxx"].Width = 350;

            DGV_Stat.Columns["id"].Visible = false;
            DGV_Stat.Columns["identifiant"].Visible = false;
                  */
    


            DGV_AddCol(DGV_Stat, "classe_id", "");
            DGV_AddCol(DGV_Stat, "classe_nom", "Classe");
            DGV_AddCol(DGV_Stat, "profs", "Prof(s)");
            DGV_AddCol(DGV_Stat, "nbre_eleves", "Elèves");
            DGV_AddCol(DGV_Stat, "nbre_demijournee_out", "demi-journees Out (élève hors etab.)");

            DGV_AddCol(DGV_Stat, "nbre_appels_theo", "Appels_theorique\r\n\r\n( Nbre_élèves  x  Nbre_DemiJours - Nbre_demijournees_out )");
            DGV_AddCol(DGV_Stat, "nbre_appels_fait", "Appels faits");
            DGV_AddCol(DGV_Stat, "pourcentage_appels_fait", "Pourcentage Appels faits");

            DGV_AddCol(DGV_Stat, "nbre_present", "Present");
            DGV_AddCol(DGV_Stat, "nbre_retard", "Retard");
            DGV_AddCol(DGV_Stat, "nbre_absent", "Absent");
            DGV_AddCol(DGV_Stat, "nbre_appel_non_fait", "Appel non-faits");

            DGV_AddCol(DGV_Stat, "pourcentage_present", "Pourcentage Present");
            DGV_AddCol(DGV_Stat, "pourcentage_retard", "Pourcentage Retard");
            DGV_AddCol(DGV_Stat, "pourcentage_absent", "Pourcentage Absent");
            DGV_AddCol(DGV_Stat, "pourcentage_appel_non_fait", "Pourcentage Appel non-faits");


            DGV_Stat.Columns["nbre_present"].DefaultCellStyle.BackColor = Color.LightGreen;
            DGV_Stat.Columns["pourcentage_present"].DefaultCellStyle.BackColor = Color.LightGreen;


            DGV_Stat.Columns["nbre_absent"].DefaultCellStyle.BackColor = Color.LightPink;
            DGV_Stat.Columns["pourcentage_absent"].DefaultCellStyle.BackColor = Color.LightPink;


            DGV_Stat.Columns["nbre_retard"].DefaultCellStyle.BackColor = Color.Orange;
            DGV_Stat.Columns["pourcentage_retard"].DefaultCellStyle.BackColor = Color.Orange;


            DGV_Stat.Columns["nbre_appel_non_fait"].DefaultCellStyle.BackColor = Color.LightGray;
            DGV_Stat.Columns["pourcentage_appel_non_fait"].DefaultCellStyle.BackColor = Color.LightGray;



            if (CompterAppelsNonFaits)
            {
                DGV_Stat.Columns["nbre_appel_non_fait"].Visible = true;
                DGV_Stat.Columns["pourcentage_appel_non_fait"].Visible = true;
            }
            else
            {
                DGV_Stat.Columns["nbre_appel_non_fait"].Visible = false;
                DGV_Stat.Columns["pourcentage_appel_non_fait"].Visible = false;
            }


            if (ShowRetard)
            {

                DGV_Stat.Columns["nbre_present"].HeaderText = "Present";

                DGV_Stat.Columns["nbre_retard"].Visible = true;
                DGV_Stat.Columns["pourcentage_retard"].Visible = true;
            }
            else
            {
                DGV_Stat.Columns["nbre_present"].HeaderText = "Present\r\net Retard";
                DGV_Stat.Columns["nbre_retard"].Visible = false;
                DGV_Stat.Columns["pourcentage_retard"].Visible = false;
            }





            DGV_Stat.Columns["nbre_eleves"].Visible = CB_ShowColonnesCalculs.Checked;
            DGV_Stat.Columns["nbre_demijournee_out"].Visible = CB_ShowColonnesCalculs.Checked;
            DGV_Stat.Columns["nbre_appels_theo"].Visible = CB_ShowColonnesCalculs.Checked;
            DGV_Stat.Columns["nbre_appels_fait"].Visible = CB_ShowColonnesCalculs.Checked;



            DGV_Stat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           DGV_Stat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
                


        private void Populate_DGV_Stat()
        {

            DGV_Stat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Stat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Stat.Rows.Clear();

            foreach (Classe Cl in Classes)
            {


                String str_profs = "";
                foreach (Personnel Pers in Cl.Personnels.Where(X => X.Genre == "Prof"))
                {
                    if (str_profs != "")
                    {
                        str_profs += ", ";
                    }
                    str_profs += Pers.Nom;  // Pers.Prenom + " " +                   
                }

                int nbre_eleves = Cl.Eleves.Count();
                int nbre_appels_Out =  0;
                int nbre_appels_theo;
                int nbre_appels_fait = 0;
                int nbre_appel_non_fait;
                int nbre_present = 0;
                int nbre_absent = 0;
                int nbre_retard = 0;


                foreach (Eleve Elv in Cl.Eleves)
                {
                    Elv.Appels = AppelsAll.Where(X => X.EleveId == Elv.Id).ToList();


                    nbre_appels_fait += Elv.Appels.Count();


                    if (ShowRetard)
                    {
                        nbre_present += Elv.Appels.Where(X => X.Etat == "Present").Count();
                        nbre_retard += Elv.Appels.Where(X => X.Etat == "Retard").Count();
                    }
                    else
                    {
                        nbre_present += Elv.Appels.Where(X => X.Etat == "Present" || X.Etat == "Retard").Count();
                    }


                    nbre_absent += Elv.Appels.Where(X => X.Etat == "Absent").Count();


                    if (!String.IsNullOrEmpty(Elv.DateEntree))
                    {
                        //   nbre_demijournee -= 1;
                        // DateTime _dateEntree = DateTime.Parse(Elv.DateEntree);
                        nbre_appels_Out += JoursPeriode.Where(X => X.DateDT < DateTime.Parse(Elv.DateEntree)).Count();

                    }


                }
                 nbre_appels_theo = nbre_eleves * JoursPeriode.Count() - nbre_appels_Out;

                nbre_appel_non_fait = nbre_appels_theo - nbre_appels_fait;


                int Total = nbre_appels_theo;
                if (!CompterAppelsNonFaits)
                {
                    Total = nbre_appels_theo - nbre_appel_non_fait;
                }



                    var index = DGV_Stat.Rows.Add();

                DGV_Stat.Rows[index].Cells["classe_id"].Value = Cl.Id;
                DGV_Stat.Rows[index].Cells["classe_nom"].Value = Cl.Nom;
                DGV_Stat.Rows[index].Cells["profs"].Value = str_profs;

                DGV_Stat.Rows[index].Cells["nbre_eleves"].Value = nbre_eleves.ToString();
                DGV_Stat.Rows[index].Cells["nbre_demijournee_out"].Value = nbre_appels_Out.ToString();


                DGV_Stat.Rows[index].Cells["nbre_appels_theo"].Value = nbre_appels_theo.ToString();
                DGV_Stat.Rows[index].Cells["nbre_appels_fait"].Value = nbre_appels_fait.ToString();
                DGV_Stat.Rows[index].Cells["pourcentage_appels_fait"].Value = StrPourcentage(nbre_appels_fait, Total, 3, 2);

                DGV_Stat.Rows[index].Cells["nbre_present"].Value = nbre_present.ToString();
                DGV_Stat.Rows[index].Cells["pourcentage_present"].Value = StrPourcentage(nbre_present, Total, 2, 2);

                DGV_Stat.Rows[index].Cells["nbre_absent"].Value = nbre_absent.ToString();
                DGV_Stat.Rows[index].Cells["pourcentage_absent"].Value = StrPourcentage(nbre_absent, Total, 1, 2);

                DGV_Stat.Rows[index].Cells["nbre_appel_non_fait"].Value = nbre_appel_non_fait.ToString();
                DGV_Stat.Rows[index].Cells["pourcentage_appel_non_fait"].Value = StrPourcentage(nbre_appel_non_fait, Total, 3, 2);


                if (ShowRetard)
                {

                    DGV_Stat.Rows[index].Cells["nbre_retard"].Value = nbre_retard.ToString();
                    DGV_Stat.Rows[index].Cells["pourcentage_retard"].Value = StrPourcentage(nbre_retard, Total, 2, 2);
                }







            }
            DGV_Stat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Stat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FILTRES    ■■■■■■■■■■■■■■■■■■■■■■■■

    

        private void RADIO_Retards_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (INIT_OK)
            {
                LoadStat();
            }
        }

        private void DTPICKER_Date_ValueChanged(object sender, EventArgs e)
        {
            if (INIT_OK)
            {
                LoadStat();
            }
            
        }

        private void RADIO_CompterAppelsNonFaits_CheckedChanged(object sender, EventArgs e)
        {
            if (INIT_OK)
            {
                LoadStat();
            }
        }

        private void CB_ShowColonnesCalculs_CheckedChanged(object sender, EventArgs e)
        {
            if (INIT_OK)
            {


                DGV_Stat.Columns["nbre_eleves"].Visible = CB_ShowColonnesCalculs.Checked;
                DGV_Stat.Columns["nbre_demijournee_out"].Visible = CB_ShowColonnesCalculs.Checked;
                DGV_Stat.Columns["nbre_appels_theo"].Visible = CB_ShowColonnesCalculs.Checked;
                DGV_Stat.Columns["nbre_appels_fait"].Visible = CB_ShowColonnesCalculs.Checked;
            }
        }
    }



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

}
