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

    public partial class UserControl_Calendar_Day : UserControl
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public DateTime Dt{ get; set; }
        private List<Evenement> Evenements;


        Color Color1 = Global.Color_Menu_Agenda;
        Color Color2 = Global.Color_Menu_Agenda2;

        Color Color_WeekEnd = Color.FromArgb(255, 230, 230);
        Color Color_Vacances = Color.FromArgb(255, 100, 100);
        Color Color_Today = Color.Yellow;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■




        public UserControl_Calendar_Day(DateTime tempDay, List<Evenement> daysEvenements)
        {
            InitializeComponent();


            // this.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            this.BackColor = Color1;
            this.Dt = tempDay;
            this.Evenements = daysEvenements;





            if ((Dt == DateTime.Today))
            {
                this.RICHTXT_Date.BackColor = Color_Today;
            }
            else if (Dt < DateTime.Today)
            {
                this.RICHTXT_Date.BackColor = Color.Gray;
                // this.PAN_All.BackColor = Color2;
            }
            else
            {
                this.RICHTXT_Date.BackColor = Color.White;
            }

                       

            if ((Dt.DayOfWeek == DayOfWeek.Saturday) || (Dt.DayOfWeek == DayOfWeek.Sunday) || (Dt.DayOfWeek == DayOfWeek.Wednesday))
            {
                this.LB_Evenements.BackColor = Color_WeekEnd;
            }
            else
            {
                this.LB_Evenements.BackColor = Color.White;
            }

            RICHTXT_Date.Text = "";
            Global.RichTXT_AppendText(this.RICHTXT_Date, Color.Black, " " +Dt.ToString("ddd") + " " , 10f);
            Global.RichTXT_AppendText(this.RICHTXT_Date, Color.Black, Dt.ToString("dd") + "  " , 13f);
            Global.RichTXT_AppendText(this.RICHTXT_Date, Color.Black, Dt.ToString("MMM"), 10f);


            LB_Evenements.Text = "";
            foreach (Evenement Evnt in this.Evenements)
            {
                if (Evnt.Genre == "Vacances")
                {
                    this.LB_Evenements.BackColor = Color_Vacances;
                }
                LB_Evenements.Text += "➔ " + Evnt.Genre + " - " + Evnt.Nom + " - " + Evnt.Infos + "\r\n";    //  •
            }

        }



        /*
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (Dt < DateTime.Today)
            {

                Pen blackpen = new Pen(Color.Black, 2);

                Graphics g = PAN_All.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //    g.DrawLine(blackpen, 0, 0, this.Width, this.Height);
                g.DrawLine(blackpen, PAN_All.Width, 0, 0, PAN_All.Height);

                g.Dispose();
            }

        }

       */ 


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Panel PAN_Allx { get => PAN_All;  }

    


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
