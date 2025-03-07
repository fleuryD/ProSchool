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
    public partial class F_Suivi_Add : Form
    {
       

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private Eleve Elv;


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Suivi_Add(Eleve selectedEleve)
        {
            InitializeComponent();
            this.Elv = selectedEleve;
        }

        private void F_Suivi_Add_Load(object sender, EventArgs e)
        {
            LB_Eleve.Text = Elv.Nom + " " + Elv.Prenom;
            BT_EntretienUpdate.Visible = false;
            BT_EntretienDelete.Visible = false;
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void BT_SuiviAdd_Click(object sender, EventArgs e)
        {
            Suivi Suiv = new Suivi();
            Suiv.DateHeure = dateTimePicker_Date.Value.ToString();
            Suiv.Genre = COMBO_Genre.Text;
            Suiv.Contenu = TXT_Contenu.Text;
            Suiv.Decision = TXT_Decision.Text;
            Suiv.EleveId = Elv.Id;


            Suiv.PersonnelId = 0;
            Suiv.GenreId = 0;

            if (CB_WithEleve.Checked && CB_WithFamille.Checked)
            {
                Suiv.EleveOuFamille = "Eleve et Famille";
            }
            else if (CB_WithEleve.Checked)
            {
                Suiv.EleveOuFamille = "Eleve";
            }
            else if (CB_WithFamille.Checked)
            {
                Suiv.EleveOuFamille = "Famille";
            }
            else
            {
                Suiv.EleveOuFamille = "";
            }

            Suiv.Bdd_Insert();

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void BT_EntretienCanceil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EntretienUpdate_Click(object sender, EventArgs e)
        {

        }

        private void COMBO_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
