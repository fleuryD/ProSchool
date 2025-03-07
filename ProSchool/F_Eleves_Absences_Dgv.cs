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
    public partial class F_Eleves_Absences_Dgv : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private Eleve SelectedEleve;
        private List<Appel> SelectedAppels;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Eleves_Absences_Dgv(Eleve _selectedEleve)
        {
            InitializeComponent();
            this.SelectedEleve = _selectedEleve;
            SelectedAppels = new List<Appel>();
        }



        private void F_Eleves_Absences_Dgv_Load(object sender, EventArgs e)
        {


            this.FLP_Calendar.Resize += new System.EventHandler(this.FLP_Calendar_Resize);

            LB_Eleve.Text = SelectedEleve.Nom + " " + SelectedEleve.Prenom;
            BT_ResponsablesShow.Text = SelectedEleve.Responsables.Count() + " responsable(s)";

            LB_Resume.Text = "";
            LB_Resume.Text += SelectedEleve.Appels.Where(p => p.Etat == "Absent").Count() + " demi-journée(s) d'absence";
            LB_Resume.Text += "\r\n" + SelectedEleve.Appels.Where(p => p.Etat == "Retard").Count() + " retard(s)";





            foreach (Appel App in SelectedEleve.Appels.Where(p => p.Etat != "Present"))
            {

                //Today.ToLongDateString();   //today.ToLongDateString() + " >>>> " + today.ToString("dddd dd MMMM") + " >>>> " + today.ToString("yyyy-MM-dd");
                DateTime Jour = Convert.ToDateTime(App.Jour);

                RichTXT_AppendText(Jour.ToString("dddd dd MMMM") + " (" + App.DemiJournee + ")", Color.Black);
                RichTXT_AppendText(" - ", Color.Black);

                if (App.Etat == "Absent")
                {
                    RichTXT_AppendText(App.Etat, Color.Red);
                }
                else
                {
                    RichTXT_AppendText(App.Etat, Color.Blue);
                }

                RichTXT_AppendText(" - ", Color.Black);

                if (App.Justifiee != "")
                {
                    RichTXT_AppendText("Justifié(e) : ", Color.Green);
                    RichTXT_AppendText(App.Justifiee, Color.Green);
                }
                else
                {
                    RichTXT_AppendText("Non justifié(e)", Color.Red);
                }

                if (App.Infos != "")
                {
                    RichTXT_AppendText(" (" + App.Infos + ")", Color.DarkGreen);
                }

                RichTXT_AppendText("\r\n", Color.Black);

            }


            DateTime DT = DateTime.Parse("02-09-2019");
            Load_Calendar(DT);

        }

        private void FLP_Calendar_Resize(object sender, EventArgs e)
        {
            int CalDay_width = (FLP_Calendar.Width / 8) - 5;

            foreach (Control Ctrl in FLP_Calendar.Controls)
            {
                Ctrl.Width = CalDay_width;
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void Load_Calendar(DateTime DT)
        {
            DateTime firstDayOfSelectedMonth = Global.GetFirstDayOfMonth(DT);
            DateTime CalendarFirstDay = Global.GetMondayFromDateTime(firstDayOfSelectedMonth);


        //    List<Evenement> Evenements = new List<Evenement>();
          //  List<Evenement> Evenements = GetListEvenementsFromBdd();

            int CalDay_width = (FLP_Calendar.Width / 8) - 5;
            FLP_Calendar.Controls.Clear();

            DateTime TempDay = CalendarFirstDay;
            // DateTime CalendarLastDay =
            DateTime lastDayOfMonth = firstDayOfSelectedMonth.AddMonths(1).AddDays(-1);
            DateTime CalendarLastDay = Global.GetNextSundayFromDateTime(lastDayOfMonth);


            while (TempDay <= CalendarLastDay)
            {

                if ((TempDay.DayOfWeek != DayOfWeek.Saturday) && (TempDay.DayOfWeek != DayOfWeek.Sunday) && (TempDay.DayOfWeek != DayOfWeek.Wednesday))
                {
                    Appel AppAm = SelectedEleve.Appels.Where(p => p.Jour == TempDay.ToString("yyyy-MM-dd") && p.DemiJournee== "Matin").FirstOrDefault();
                    Appel AppPm = SelectedEleve.Appels.Where(p => p.Jour == TempDay.ToString("yyyy-MM-dd") && p.DemiJournee== "Aprem").FirstOrDefault();


                    UserControl_Calendar_Day_Absences UC_CalDay_Am = new UserControl_Calendar_Day_Absences(TempDay, AppAm, "Matin");
                    UserControl_Calendar_Day_Absences UC_CalDay_Pm = new UserControl_Calendar_Day_Absences(TempDay, AppPm, "Aprem");

                    DateTime TempDayCopy = TempDay;

                    foreach (Control c in UC_CalDay_Am.PAN_Allx.Controls)
                    {
                        c.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, TempDayCopy, UC_CalDay_Am, AppAm, "Matin");
                    }
                    foreach (Control c in UC_CalDay_Pm.PAN_Allx.Controls)
                    {
                        c.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, TempDayCopy, UC_CalDay_Pm, AppPm, "Aprem");
                    }


                    UC_CalDay_Am.PAN_Allx.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, TempDayCopy, UC_CalDay_Am, AppAm, "Matin");
                    UC_CalDay_Pm.PAN_Allx.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, TempDayCopy, UC_CalDay_Pm, AppPm, "Aprem");

                    UC_CalDay_Am.Cursor = Cursors.Hand;
                    UC_CalDay_Pm.Cursor = Cursors.Hand;

                    UC_CalDay_Am.Width = CalDay_width;
                    UC_CalDay_Pm.Width = CalDay_width;
                    //    UC_CalDay.Dock = DockStyle.Right;
                    FLP_Calendar.Controls.Add(UC_CalDay_Am);
                    FLP_Calendar.Controls.Add(UC_CalDay_Pm);

                    /*
                    foreach (Appel App in SelectedEleve.Appels.Where(p => p.Etat != "Present"))
                   {

                   }
                    */
                }





                TempDay = TempDay.AddDays(1);
            }

        }

        private void UC_CalDay_Click(object sender2, EventArgs e2, DateTime tempDayCopy, UserControl_Calendar_Day_Absences uC_CalDay, Appel Apl, string demiJour)
        {

            /*
            //  Appel Apl = AppelsTemp.Where(x => x.EleveId == SelectedEleve.Id).FirstOrDefault();
            if (uC_CalDay_Am.Apppp == null)
            {
                MessageBox.Show("NULL");
            }
            else
            {
                Appel Apl = uC_CalDay_Am.Apppp;


                F_Appel_Noter Frm = new F_Appel_Noter(SelectedEleve.Nom + " " + SelectedEleve.Prenom, Apl);
                var result = Frm.ShowDialog();               
            }
        
              */


            if (uC_CalDay.BackColor == Color.Red)
            {
                uC_CalDay.BackColor = Color.White;

                Appel ClickedAppel;
                if (Apl != null)
                {
                    ClickedAppel = Apl;
                }
                else
                {
                    ClickedAppel = SelectedAppels.Where(X => X.Jour == uC_CalDay.Date.ToString("yyyy-MM-dd") && X.DemiJournee == demiJour).First();

                }
                SelectedAppels.Remove(ClickedAppel);
            }
            else
            {

                Appel ClickedAppel;
                if (Apl != null)
                {
                    ClickedAppel = Apl;
                }
                else
                {
                    ClickedAppel = new Appel();
                    ClickedAppel.Id = 0;
                    ClickedAppel.Jour = uC_CalDay.Date.ToString("yyyy-MM-dd");
                    ClickedAppel.DemiJournee = demiJour;

                }

                uC_CalDay.BackColor = Color.Red;
                SelectedAppels.Add(ClickedAppel);
            }

            LB_SelectedAppelCount.Text = SelectedAppels.Count().ToString();

            LB_SelectedAppelCount.Text += "\r\n";
            foreach (Appel App in SelectedAppels)
            {
                LB_SelectedAppelCount.Text += "#"+App.Id + " - " +App.Jour + ": " + App.DemiJournee+"\r\n";
            }

        }

        private void Calendar_Resize(object sender, EventArgs e)
        {

            /*
            int CalDay_width = (FLP_Calendar.Width / 7) - 12;

            foreach (Control Ctrl in FLP_Calendar.Controls)
            {
                Ctrl.Width = CalDay_width;
            }

    */
        }

        private void BT_ResponsablesShow_Click(object sender, EventArgs e)
        {

            F_Responsables_Eleve Frm = new F_Responsables_Eleve(SelectedEleve);
            Frm.ShowDialog();
        }

        public void RichTXT_AppendText(string text, Color color)
        {
            RichTXT_Absences.SelectionStart = RichTXT_Absences.TextLength;
            RichTXT_Absences.SelectionLength = 0;

            RichTXT_Absences.SelectionColor = color;
            RichTXT_Absences.AppendText(text);
            RichTXT_Absences.SelectionColor = RichTXT_Absences.ForeColor;

        }

        private void BT_Valider_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();

                foreach (Appel Apl in SelectedAppels)
                {


                    if (RADIO_EtatAbsent.Checked)
                        Apl.Etat = "Absent";
                    else if (RADIO_EtatRetard.Checked)
                        Apl.Etat = "Retard";
                    else if (RADIO_EtatPresent.Checked)
                        Apl.Etat = "Present";
                    /*
                    else if (RADIO_Etat_AppelNonFait.Checked)
                        Apl.Etat = "XXXXXXXXXXXXXXXXXXXXXXX";
                        */

                    Apl.Infos = TXT_Infos.Text;



                    if (RADIO_JustifMaladie.Checked)
                        Apl.Justifiee = "Maladie";
                    else if (RADIO_JustifFamille.Checked)
                        Apl.Justifiee = "Famille";
                    else if (RADIO_JustifAutre.Checked)
                        Apl.Justifiee = "Autre";
                    else
                        Apl.Justifiee = "";


                    if (Apl.Etat == "Present")
                        Apl.Justifiee = "";


                    if (Apl.Id == 0)
                    {
                        Apl.InsertInBdd(connect);
                        MessageBox.Show("CREER" + Apl.Jour + " - " + Apl.DemiJournee + " : " + Apl.Etat);
                    }
                    else
                    {
                        Apl.UpdateInBdd(connect);
                        //   MessageBox.Show("Modifier" + Apl.Jour + " - " +Apl.DemiJournee + " : " + Apl.Etat);
                    }

                }


                connect.Close();
            }


        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
