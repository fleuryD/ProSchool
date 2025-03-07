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
    public partial class F_Responsables_Eleve : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Eleve selectedEleve;



        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Responsables_Eleve(Eleve Elv)
        {
            InitializeComponent();
            this.selectedEleve = Elv;
        }

        private void F_Responsables_Eleve_Load(object sender, EventArgs e)
        {
            LB_ResponsablesCount.Text = selectedEleve.Responsables.Count().ToString();
            LB_EleveNom.Text = selectedEleve.Nom;
            LB_ElevePrenom.Text = selectedEleve.Prenom;

            PAN_Responsables.Controls.Clear();
            foreach (Responsable Resp in selectedEleve.Responsables)
            {
                UserControl_Responsable UC_Resp = new UserControl_Responsable(Resp);
                UC_Resp.Dock = DockStyle.Top;
                PAN_Responsables.Controls.Add(UC_Resp);
            }


        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
