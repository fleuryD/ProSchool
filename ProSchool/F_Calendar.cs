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
    public partial class F_Calendar : Form
    {



        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private DateTime AnneeSco_Debut = Convert.ToDateTime("2019/09/05");
        private DateTime AnneeSco_Fin = Convert.ToDateTime("2020/07/04");
        
        private Boolean InitOk;
        UserControl_Calendar_Day Selected_UC_CalDay;

        DateTime SelectedDate;

        private Color Color1 = Global.Color_Menu_Agenda;
        private Color Color2 = Global.Color_Menu_Agenda2;

        /*
        private DateTime CalendarFirstDay = Convert.ToDateTime("2019/08/19");
        //  private DateTime CalendarLastDay = Convert.ToDateTime("2020/07/02");
        private DateTime CalendarLastDay = Convert.ToDateTime("2020/07/15");
        */


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Calendar()
        {
            InitializeComponent();

            FLP_Calendar.BackColor = Color2;
            // FLP_Calendar.BackColor = Color.White;
            PAN_CalendarHeader.BackColor = Color2;
            PAN_Evenements.BackColor = Color2;
            PAN_HeaderSelectedDay.BackColor = Color2;
        }

        private void F_Calendar_Load(object sender, EventArgs e)
        {
            InitOk = false;

            PAN_SelectedDay.Visible = false;
            SelectedDate = DateTime.Today;


            CreerItem_COMBO_Mois();
            // CreateCalendar_V3();
            COMBO_Mois.SelectedValue = Global.GetFirstDayOfMonth(DateTime.Today);
            Load_Calendar(DateTime.Today);

            InitOk = true;



         //   MessageBox.Show(SelectedDate.ToString());


        }

        private void FLP_Calendar_Resize(object sender, EventArgs e)
        {
            int CalDay_width = (FLP_Calendar.Width / 7) - 12;

            foreach(Control Ctrl in FLP_Calendar.Controls)
            {
                Ctrl.Width = CalDay_width;
            }
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  COMBO_MOIS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void CreerItem_COMBO_Mois()
        {

            COMBO_Mois.Items.Clear();

            Dictionary<DateTime, string> DicoComboSem = new Dictionary<DateTime, string>();



            DateTime TempDay = Global.GetFirstDayOfMonth(AnneeSco_Debut);
            while (TempDay <= AnneeSco_Fin)
            {


                DateTime TempDay2 = TempDay;


                String ComboText = TempDay2.ToString("MMMM yyyy");
                if (DateTime.Today.Month == TempDay.Month)
                {

                    ComboText += " (Mois en cours)";
                }

                DicoComboSem.Add(TempDay2, ComboText);
                TempDay = TempDay.AddMonths(1);

            }

            COMBO_Mois.DataSource = new BindingSource(DicoComboSem, null);
            COMBO_Mois.DisplayMember = "Value";
            COMBO_Mois.ValueMember = "Key";

            // COMBO_Mois.SelectedValue = SelectedMonday;




        }

        private void COMBO_Mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {
                String str_FirstDayOfSelectedMonth = ((KeyValuePair<DateTime, string>)COMBO_Mois.SelectedItem).Key.ToString();

                DateTime FirstDayOfSelectedMonth = DateTime.Parse(str_FirstDayOfSelectedMonth);
                // MessageBox.Show(str_FirstDayOfSelectedMonth);


                Load_Calendar(FirstDayOfSelectedMonth);


            }
        }


        private void BT_NextMonth_Click(object sender, EventArgs e)
        {
            //  int selItem = COMBO_Mois.SelectedIndex;
            //   COMBO_Mois.SelectedIndex += 1;

            if (COMBO_Mois.SelectedIndex < COMBO_Mois.Items.Count - 1)
            {
                COMBO_Mois.SelectedIndex = COMBO_Mois.SelectedIndex + 1;
            }

        }

        private void BT_PreviousMonth_Click(object sender, EventArgs e)
        {
            if (COMBO_Mois.SelectedIndex > 0)
            {
                COMBO_Mois.SelectedIndex = COMBO_Mois.SelectedIndex - 1;
            }
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void Load_Calendar(DateTime DT)
        {
            DateTime firstDayOfSelectedMonth = Global.GetFirstDayOfMonth(DT);
            DateTime CalendarFirstDay = Global.GetMondayFromDateTime(firstDayOfSelectedMonth);

            PAN_SelectedDay.Visible = false;

            List<Evenement> Evenements = Evenement.GetListEvenementsFromBdd();

            int CalDay_width = (FLP_Calendar.Width / 7) - 12;
            FLP_Calendar.Controls.Clear();

            DateTime TempDay = CalendarFirstDay;
           // DateTime CalendarLastDay =
            DateTime lastDayOfMonth = firstDayOfSelectedMonth.AddMonths(1).AddDays(-1);
            DateTime CalendarLastDay = Global.GetNextSundayFromDateTime(lastDayOfMonth);


            while (TempDay <= CalendarLastDay)
            {
                List<Evenement> DaysEvenements = new List<Evenement>();

                foreach (Evenement Evnt in Evenements)
                {
                    if (Evnt.DateDebut == TempDay.ToString("yyyy-MM-dd"))
                    {
                        DaysEvenements.Add(Evnt);
                    }
                    else if (!String.IsNullOrEmpty(Evnt.DateFin))
                    {

                        if (
                            DateTime.Compare(DateTime.Parse(Evnt.DateDebut), TempDay) < 0
                            &&
                            DateTime.Compare(DateTime.Parse(Evnt.DateFin), TempDay) >= 0
                            )
                        {
                            DaysEvenements.Add(Evnt);
                        }

                    }
                }



                UserControl_Calendar_Day UC_CalDay = new UserControl_Calendar_Day(TempDay, DaysEvenements);

                //    UC_CalDay.Dock = DockStyle.Right;

                UC_CalDay.Width = CalDay_width;
                DateTime TempDayCopy = TempDay;
                UC_CalDay.PAN_Allx.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, UC_CalDay, DaysEvenements);
                foreach (Control c in UC_CalDay.PAN_Allx.Controls)
                {
                    c.Click += (sender2, e2) => UC_CalDay_Click(sender2, e2, UC_CalDay, DaysEvenements);
                }
                FLP_Calendar.Controls.Add(UC_CalDay);

                if(TempDay == SelectedDate)
                {
                    SelecteDate_NEW(UC_CalDay, DaysEvenements);
                }



                TempDay = TempDay.AddDays(1);
            }

        }

        private void UC_CalDay_Click(object sender, EventArgs e, UserControl_Calendar_Day UC_CalDay, List<Evenement> Evnts)
        {


            SelectedDate = UC_CalDay.Dt;


            SelecteDate_NEW(UC_CalDay, Evnts);
        }



        private void SelecteDate_NEW(UserControl_Calendar_Day UC_CalDay, List<Evenement> Evnts)
        {

            PAN_SelectedDay.Visible = true;


            if (Selected_UC_CalDay != null)
            {
                Selected_UC_CalDay.BackColor = Color.Gray;
            }



            LB_Date.Text = SelectedDate.ToString("ddd dd MMM yyyy");


            LB_DateHuman.Text = Global.HumanDateDiffFromToday(SelectedDate);
        


            UC_CalDay.BackColor = Color.Blue;
            Selected_UC_CalDay = UC_CalDay;



            PAN_Evenements.Controls.Clear();
            int maxWidth = PAN_Evenements.Width - 20;
            foreach (Evenement Evnt in Evnts)
            {
                UserControl_Evenement UC_Event = new UserControl_Evenement(Evnt);
                PAN_Evenements.Controls.Add(UC_Event);
                UC_Event.Dock = DockStyle.Top;
                UC_Event.SetAutoSize(maxWidth);
                UC_Event.BT_Edit.Click += (sender2, e2) => BT_EvenementEdit_Click(sender2, e2, Evnt);
            }


        }



        private void CreateCalendar_V3()
        {

            List<Evenement> Evenements = Evenement.GetListEvenementsFromBdd();

            int CalDay_width = (FLP_Calendar.Width / 7) - 12;
            FLP_Calendar.Controls.Clear();

            DateTime TempDay = Global.GetMondayOfCurrentWeek();
            for (int i = 0; i < 60; i++)
            {
                List<Evenement> DaysEvenements = new List<Evenement>();
                foreach (Evenement Evnt in Evenements)
                {
                    if (Evnt.DateDebut == TempDay.ToString("yyyy-MM-dd"))
                    {
                        DaysEvenements.Add(Evnt);
                    }
                    else if (!String.IsNullOrEmpty(Evnt.DateFin))
                    {

                        if (
                            DateTime.Compare(DateTime.Parse(Evnt.DateDebut), TempDay) < 0
                            &&
                            DateTime.Compare(DateTime.Parse(Evnt.DateFin), TempDay) >= 0
                            )
                        {
                            DaysEvenements.Add(Evnt);
                        }

                    }
                }



                UserControl_Calendar_Day UC_CalDay = new UserControl_Calendar_Day(TempDay, DaysEvenements);

                //    UC_CalDay.Dock = DockStyle.Right;

                UC_CalDay.Width = CalDay_width;
                FLP_Calendar.Controls.Add(UC_CalDay);





                TempDay = TempDay.AddDays(1);
            }


        }


        private void CreateCalendar_V2()
        {

            List<Evenement> Evenements = Evenement.GetListEvenementsFromBdd();

            int CalDay_width = (FLP_Calendar.Width / 7) - 12;
            FLP_Calendar.Controls.Clear();

            DateTime TempDay = Global.GetMondayOfCurrentWeek();
            for (int i = 0; i < 60; i++)
            {
                List<Evenement> DaysEvenements = new List<Evenement>();
                foreach (Evenement Evnt in Evenements)
                {
                    if (Evnt.DateDebut == TempDay.ToString("yyyy-MM-dd"))
                    {
                        DaysEvenements.Add(Evnt);
                    }
                    else if ( !String.IsNullOrEmpty(Evnt.DateFin))
                    {
                        
                        if (
                            DateTime.Compare(DateTime.Parse(Evnt.DateDebut), TempDay) < 0 
                            && 
                            DateTime.Compare(DateTime.Parse(Evnt.DateFin), TempDay) >= 0
                            )
                        {
                            DaysEvenements.Add(Evnt);
                        }
                        
                    }
                }



                UserControl_Calendar_Day UC_CalDay = new UserControl_Calendar_Day(TempDay, DaysEvenements);

            //    UC_CalDay.Dock = DockStyle.Right;

                UC_CalDay.Width = CalDay_width;
                FLP_Calendar.Controls.Add(UC_CalDay);





                TempDay = TempDay.AddDays(1);
            }


        }




        private void BT_AddEvenement_Click(object sender, EventArgs e)
        {
            F_Calendar_EvenementtAdd frm = new F_Calendar_EvenementtAdd(SelectedDate);
            frm.ShowDialog();
            Load_Calendar(SelectedDate);
        }


        private void BT_EvenementEdit_Click(object sender, EventArgs e, Evenement Evnt)
        {
            F_Calendar_EvenementtAdd Frm = new F_Calendar_EvenementtAdd(Evnt);
            Frm.ShowDialog();
            Load_Calendar(SelectedDate);

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
