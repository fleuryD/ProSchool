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
    public partial class F_Eleve_Add : Form
    {

        private List<Classe> Classes;


        public F_Eleve_Add()
        {
            InitializeComponent();
        }

        private void F_Eleve_Add_Load(object sender, EventArgs e)
        {


            Classes = Classe.Bdd_GetClasses_OrderByName();


          


            foreach (Classe Cl in Classes)
            {
                Combo_Classe.Items.Add(Cl.Nom);
            }
            Combo_Classe.SelectedIndex = 0;
        }

        private Boolean CheckForError()
        {
            TXT_Nom.BackColor = Color.White;
            TXT_Prenom.BackColor = Color.White;


            Boolean Erreur = false;

            if (TXT_Nom.Text == "")
            {
                TXT_Nom.BackColor = Color.Yellow;
                Erreur = true;
            }
            if (TXT_Prenom.Text == "")
            {
                TXT_Prenom.BackColor = Color.Yellow;
                Erreur = true;
            }

            return Erreur;
        }

        private void BT_PersonnelAdd_Click(object sender, EventArgs e)
        {


            

            if (CheckForError())
            {
                return;
            }


            Eleve Elv = new Eleve();

            Elv.Nom = TXT_Nom.Text;
            Elv.Prenom = TXT_Prenom.Text;

            if (RADIO_SexeFemme.Checked)
            {
                Elv.Sexe = "F";
            }
            else if (RADIO_SexeHomme.Checked)
            {
                Elv.Sexe = "M";
            }


            String ClasseNom = Combo_Classe.SelectedItem.ToString();
            foreach (Classe Cl in Classes)
            {
                if(Cl.Nom == ClasseNom)
                {
                    Elv.ClasseId = Cl.Identifiant;
                }
            }

            Elv.ImportGenre = "Ajout manuel";
            Elv.DateEntree = DatePicker_DateEntree.Value.ToString("yyyy-MM-dd");

            Elv.InsertInBdd();
            MessageBox.Show("TODO - Rafraichir la page");
            this.Close();

        }

    }
}
