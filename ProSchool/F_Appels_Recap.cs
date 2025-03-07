using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Appels_Recap : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private List<Classe> Classes;
        private String SelectedJour;



        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Appels_Recap()
        {
            InitializeComponent();
        }

        private void F_Appels_Recap_Load(object sender, EventArgs e)
        {

            Classes = Classe.Bdd_GetClasses_OrderByName();

            SelectedJour = DateTime.Now.ToString("yyyy-MM-dd");
            DTPicker.Value = DateTime.Now;

            LB_ErrSelctedDate.Visible = false;
           // SelectedJour = "2019-08-30";

            //CreateUC_AppelRecap();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void CreateUC_AppelRecap()
        {
            FLP_Classes.Controls.Clear();
            foreach (Classe Cl in Classes)
            {
                UserControl_AppelClasseRecap UC_ACR = new UserControl_AppelClasseRecap(Cl, SelectedJour);

                FLP_Classes.Controls.Add(UC_ACR);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            SelectedJour = DTPicker.Value.ToString("yyyy-MM-dd");
            CreateUC_AppelRecap();

        }

        private void BT_Today_Click(object sender, EventArgs e)
        {
            DTPicker.Value = DateTime.Now;
        }

        private void BT_PreviousDay_Click(object sender, EventArgs e)
        {
            DateTime CurrentSelectedDay = DTPicker.Value.Date;
            DTPicker.Value = CurrentSelectedDay.AddDays(-1);
        }

        private void BT_NextDay_Click(object sender, EventArgs e)
        {
            DateTime CurrentSelectedDay = DTPicker.Value.Date;
            DTPicker.Value = CurrentSelectedDay.AddDays(1);
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
