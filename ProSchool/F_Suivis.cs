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
    public partial class F_Suivis : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Suivi> Suivis;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Suivis()
        {
            InitializeComponent();
        }
        private void F_Suivis_Load(object sender, EventArgs e)
        {
            Suivis = Suivi.Bdd_GetSuivis_OrderByX();

            foreach (Suivi Suiv in Suivis)
            {
                UserControl_Suivi UC_Suiv = new UserControl_Suivi(Suiv);
                UC_Suiv.Dock = DockStyle.Top;
                PAN_Suivis.Controls.Add(UC_Suiv);
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■




    }
}
