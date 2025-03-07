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
    public partial class F_Calendar_Evenements : Form
    {






        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■





        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Calendar_Evenements()
        {
            InitializeComponent();

            LB_Titre.ForeColor = Global.Color_Menu_Agenda;
            FLP_Evenements.BackColor = Global.Color_Menu_Agenda2;
        }

        private void F_Calendar_Evenements_Load(object sender, EventArgs e)
        {





            REFRESH_ALL();

        }

        private void REFRESH_ALL()
        {

            List<Evenement> EvenementsFuture = Evenement.Bdd_GetEvenements_Futurs();

            FLP_Evenements.Controls.Clear();

            foreach (Evenement Evnt in EvenementsFuture)
            {
                UserControl_Evenement UC_Event = new UserControl_Evenement(Evnt);
                FLP_Evenements.Controls.Add(UC_Event);
                UC_Event.BT_Edit.Click += (sender2, e2) => BT_EvenementEdit_Click(sender2, e2, Evnt);
            }



        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void BT_EvenementEdit_Click(object sender, EventArgs e, Evenement Evnt)
        {
            F_Calendar_EvenementtAdd Frm = new F_Calendar_EvenementtAdd(Evnt);
            Frm.ShowDialog();
            REFRESH_ALL();
        }
        private void BT_AddEvenement_Click(object sender, EventArgs e)
        {
            DateTime SelectedDate = DateTime.Today.AddDays(1);
            F_Calendar_EvenementtAdd frm = new F_Calendar_EvenementtAdd(SelectedDate);
            frm.ShowDialog();
            REFRESH_ALL();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
