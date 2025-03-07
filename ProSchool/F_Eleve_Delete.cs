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
    public partial class F_Eleve_Delete : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Eleve SelectedEleve;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Eleve_Delete(Eleve _selectedEleve)
        {
            InitializeComponent();
            this.SelectedEleve = _selectedEleve;
        }

        private void F_Eleve_Delete_Load(object sender, EventArgs e)
        {
            LB_Eleve_Nom.Text = SelectedEleve.Nom + " " + SelectedEleve.Prenom;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  BT    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EleveDelete_Click(object sender, EventArgs e)
        {



            SelectedEleve.DeleteInBdd();

            this.Close();

        }

        private void BT_EleveSansClasse_Click(object sender, EventArgs e)
        {
            SelectedEleve.ClasseId = 0;
            SelectedEleve.UpdateInBdd();
            this.Close();

        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
