using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class UserControl_Calendar_Day_Absences : UserControl
    {
  

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Appel m_appel;
        private DateTime m_date;
        private String m_demijour;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public UserControl_Calendar_Day_Absences()
        {
            InitializeComponent();
        }


        public UserControl_Calendar_Day_Absences(DateTime _tempDay, Appel _App, String _Demijour)
        {
            InitializeComponent();

            this.m_appel = _App;
            this.m_date = _tempDay;
            this.m_demijour = _Demijour;

            if (m_demijour == "Matin")
            {
                LB_MatinAprem.Text = "Matin";
                this.Margin = new Padding(0, 0, 0, 0);
                this.Padding = new Padding(4, 4, 0, 4);
            }
            else if (m_demijour == "Aprem")
            {
                LB_JourChiffre.Visible = false;
                LB_JourLettre.Visible = false;
                LB_JourMois.Visible = false;

                LB_MatinAprem.Text = "Aprem";
                this.Margin = new Padding(0, 0, 0, 0);
                this.Padding = new Padding(0, 4, 4, 4);

            }
            else
            {
                LB_MatinAprem.Text = _App.DemiJournee;
                this.Margin = new Padding(0, 0, 0, 0);
                this.Padding = new Padding(4, 4, 4, 4);
            }


            if ((m_date == DateTime.Today))
            {
                this.BackColor = Color.Blue;
            }
            else if ((m_date.DayOfWeek == DayOfWeek.Saturday) || (m_date.DayOfWeek == DayOfWeek.Sunday))
            {
                this.PAN_All.BackColor = Color.FromArgb(255, 230, 230);
            }
            else
            {
                this.PAN_All.BackColor = Color.White;
            }


            LB_JourLettre.Text = m_date.ToString("ddd");
            LB_JourChiffre.Text = m_date.ToString("dd");
            LB_JourMois.Text = m_date.ToString("MMM");



            if (m_appel == null)
            {
                LB_Presence.Text = "???";
            }
            else {


                LB_Presence.Text = m_appel.Etat;

                if (m_appel.Etat == "Present")
                {
                    this.PAN_All.BackColor = Color.FromArgb(100, 255, 100);
                }
                else
                {
                    if (m_appel.Etat == "Absent")
                    {
                   
                        if (m_appel.Justifiee == "")
                        {
                            this.PAN_All.BackColor = Color.FromArgb(255, 100, 100);
                        }
                        else
                        {
                            this.PAN_All.BackColor = Color.FromArgb(255, 200, 200);
                        }
                    }
                    else if (m_appel.Etat == "Retard")
                    {
                        this.PAN_All.BackColor = Color.FromArgb(255, 192, 128);
                    }


                    if (m_appel.Justifiee == "")
                    {
                        LB_Presence.Text += " (NJ)";
                    }
                    else
                    {
                        LB_Presence.Text += " (" + m_appel.Justifiee  + ")";
                    }

                }
                
               

            }
           


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (m_date < DateTime.Today)
            {

                Pen blackpen = new Pen(Color.Black, 2);

                Graphics g = PAN_All.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                //    g.DrawLine(blackpen, 0, 0, this.Width, this.Height);
                g.DrawLine(blackpen, PAN_All.Width, 0, 0, PAN_All.Height);

                g.Dispose();
            }

        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Panel PAN_Allx { get => PAN_All; }
        public Appel Appel { get => m_appel; set => m_appel = value; }
        public DateTime Date { get => m_date; set => m_date = value; }
        public string Demijour { get => m_demijour; set => m_demijour = value; }





        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
