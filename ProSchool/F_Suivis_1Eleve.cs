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
    public partial class F_Suivis_1Eleve : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Eleve SelectedEleve;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Suivis_1Eleve(Eleve _selectedEleve)
        {

            InitializeComponent();
            this.SelectedEleve = _selectedEleve;
            this.Text = "Suivi de " + SelectedEleve.Nom + " " + SelectedEleve.Prenom;
            LB_Titre.Text = "Suivi de " + SelectedEleve.Nom + " " + SelectedEleve.Prenom;
        }

        private void F_Suivis_1Eleve_Load(object sender, EventArgs e)
        {

            PAN_Suivis.Controls.Clear();
            foreach (Suivi Suiv in SelectedEleve.Suivis)
            {
                UserControl_Suivi UC_Suiv = new UserControl_Suivi(Suiv);
                UC_Suiv.Dock = DockStyle.Top;
                PAN_Suivis.Controls.Add(UC_Suiv);
            }
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■




        private void BT_SuiviAdd_Click(object sender, EventArgs e)
        {
            using (var form = new F_Suivi_Add(SelectedEleve))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedEleve = Eleve.GetEleveByIdFromBdd(SelectedEleve.Id);   // pour rafraichir l'eleve
                    MessageBox.Show("RAFRAICHIR LA PAGE !");
                    //   RemplirFicheEleve(SelectedEleve);
                }
            }
        }
        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■






    }
}
