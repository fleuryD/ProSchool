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
    public partial class UserControl_Evenement : UserControl
    {
        private Evenement evnt;

        Color Color1 = Global.Color_Menu_Agenda;
        Color Color2 = Global.Color_Menu_Agenda2;

        public Button BT_Edit;


        public UserControl_Evenement(Evenement evnt)
        {
            InitializeComponent();
            BT_Edit = this.BT_EvenementEdit;


            this.evnt = evnt;


            DateTime DtDebut = DateTime.Parse(evnt.DateDebut);


            this.RichTXT_Date.Text = "";

            if (!String.IsNullOrEmpty(evnt.DateFin))
            {
                Global.RichTXT_AppendText(this.RichTXT_Date, Color.Black, "du ", 8f);
            }



            Global.RichTXT_AppendText(this.RichTXT_Date, Color1, DtDebut.ToString("ddd dd MMM"), 11f);
            

            if (!String.IsNullOrEmpty(evnt.DateFin))
            {
                DateTime DtFin = DateTime.Parse(evnt.DateFin);
                Global.RichTXT_AppendText(this.RichTXT_Date, Color.Black , " au ", 8f);
                Global.RichTXT_AppendText(this.RichTXT_Date, Color1, DtFin.ToString("ddd dd MMM"), 11f);
            }

            Global.RichTXT_AppendText(this.RichTXT_Date, Color.Green, "    (" + Global.HumanDateDiffFromToday(DtDebut) + ")", 9f);

          //  this.RichTXT_Date.BackColor = Color2;
            this.RichTXT_Date.BackColor = Color.White;
            this.LB_Genre.Text = evnt.Genre;
            this.LB_Nom.Text = evnt.Nom;
            this.LB_Infos.Text = evnt.Infos;


           

        }


        public void SetAutoSize(int _width)
        {



            RichTXT_Date.Size = new Size(_width, 20);
            //RichTXT_Date.AutoSize = true;

            LB_Infos.MaximumSize = new Size(_width, 0);
            LB_Infos.AutoSize = true;
        }

        
    }
}
