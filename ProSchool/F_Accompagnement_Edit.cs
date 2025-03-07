using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Accompagnement_Edit : Form
    {



        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Accompagnement SelectedAccompagnement;



        //    private String ModeCreateUpdate;



        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■" + RC2;
        public F_Accompagnement_Edit(Accompagnement _selectedAccompagnement = null)
        {
            InitializeComponent();

            NUM_Id.Enabled = false;
            LB_Erreurs.Visible = false;

            if (_selectedAccompagnement == null)
            {
               // ModeCreateUpdate = "CREATE";
                SelectedAccompagnement = new Accompagnement();

                LB_Titre.Text = "Ajouter un accompagnement";
                this.Text = "Ajouter un accompagnement";

                NUM_Position.Value = 99;
                NUM_Id.Visible = false;

                BT_Update.Visible = false;
                BT_Create.Visible = true;
                BT_Supprimer.Visible = false;


                LB_NbreEleves.Visible = false;
            }
            else
            {
              //  ModeCreateUpdate = "UPDATE";
                SelectedAccompagnement = _selectedAccompagnement;
                SetFormulaireFromSelectedAccompagnement();

                LB_Titre.Text = "Modifier un accompagnement";
                this.Text = "Modifier un accompagnement";

                BT_Update.Visible = true;
                BT_Create.Visible = false;
                BT_Supprimer.Visible = true;


                LB_NbreEleves.Text = "Il y a " + SelectedAccompagnement.EleveCount + " élève(s) inscrit(s) à cet accompagnement";
                LB_NbreEleves.Visible = true;
            }


            this.DialogResult = DialogResult.OK;
        }

        private void F_Accompagnement_Edit_Load(object sender, EventArgs e)
        {

        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FORM - OBJET    ■■■■■■■■■■■■■■■■■■■■■■■■
        

        private void SetFormulaireFromSelectedAccompagnement()
        {
            NUM_Id.Value = SelectedAccompagnement.Id;
            TXT_Nom.Text = SelectedAccompagnement.Nom;
            TXT_NomSimple.Text = SelectedAccompagnement.NomSimple;
            NUM_Position.Value = SelectedAccompagnement.Position;

        }

        private void SetSelectedAccompagnementFromFormulaire()
        {
             SelectedAccompagnement.Id = (int)NUM_Id.Value;
             SelectedAccompagnement.Nom = TXT_Nom.Text;
             SelectedAccompagnement.NomSimple = TXT_NomSimple.Text;
             SelectedAccompagnement.Position = (int)NUM_Position.Value;
        }

        private Boolean ErreursFormulaire()
        {
            Boolean Err = false;
            LB_Erreurs.Text = "";
            LB_Erreurs.Visible = false;


            if (TXT_Nom.Text == "")
            {
                LB_Erreurs.Text += "Le Nom ne peut pas être vide !\r\n";
                Err = true;
            }

            if (TXT_NomSimple.Text == "")
            {
                LB_Erreurs.Text += "Le Nom Simple ne peut pas être vide !\r\n";
                Err = true;
            }

            if (Err)
            {
                LB_Erreurs.Visible = true;
            }

            return Err;    // false = pas d'erreur
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  BT - CREATE - UPDATE - CANCEIL - DELETE    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void BT_Update_Click(object sender, EventArgs e)
        {
            if (ErreursFormulaire())
            {
                return;
            }
            SetSelectedAccompagnementFromFormulaire();
            

            if (SelectedAccompagnement.EleveCount > 0)
            {
                String message = "Modifier l'accompagnement : \"" + SelectedAccompagnement.Nom + "\" ?";

                message += "\r\n\r\nATTENTION :\r\nIl y a " + SelectedAccompagnement.EleveCount + " élève(s) inscrit(s) à cet accompagnement.";

                message += "\r\n\r\n\r\nSi vous modifiez cet accompagnement, ça affectera les élèves qui y sont inscrits!";
                DialogResult dr = MessageBox.Show(message, "Modifier Accompagnement ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                   
                }
                else{
                    return;
                }


            }
            



            SelectedAccompagnement.Bdd_Update();
           // MessageBox.Show("WIP : Bdd_Update");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            if (ErreursFormulaire())
            {
                return;
            }
            SetSelectedAccompagnementFromFormulaire();
            SelectedAccompagnement.Bdd_Insert();
           // MessageBox.Show("WIP : Bdd_Insert");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            String message = "Supprimer l'accompagnement : \"" + SelectedAccompagnement.Nom +"\" ?";
            if (SelectedAccompagnement.EleveCount > 0)
            {
                message += "\r\n\r\nATTENTION :\r\nIl y a " + SelectedAccompagnement.EleveCount + " élève(s) inscrit(s) à cet accompagnement.";
                message += "\r\n\r\n\r\nSi vous supprimez cet accompagnement, et bein les élèves ils y seront plus inscrits! C'est logique koi !";
            }

            DialogResult dr = MessageBox.Show(message, "Supprimer Accompagnement ?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();

                SelectedAccompagnement.Bdd_Delete(maConnexion); //Supprime aussi les "accompagnements_eleves"

                maConnexion.Close();


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■






    }
}
