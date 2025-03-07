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
    public partial class F_Personnels_Add : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Personnel SelectedPersonnel;
        private String Mode_AddEdit;
        private Boolean InitOk;
        public int Retrun_CreatedPersonnelId;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Personnels_Add()
        {
            InitializeComponent();
            this.Text = "Ajouter un personnel";
            InitOk = false;
            TXT_Genre.Visible = false;
            Mode_AddEdit = "Add";
            BT_PersonnelEdit.Visible = false;
        }

        public F_Personnels_Add(Personnel _selectedPersonnel)
        {

            InitializeComponent();
            InitOk = false;
            TXT_Genre.Visible = false;
            Mode_AddEdit = "Edit";
            this.SelectedPersonnel = _selectedPersonnel;
            this.Text = "Modifier un personnel: " + SelectedPersonnel.Prenom + " " + SelectedPersonnel.Nom;
            BT_PersonnelAdd.Visible = false;


            /********/
            TXT_Nom.Text = SelectedPersonnel.Nom;
            TXT_Prenom.Text = SelectedPersonnel.Prenom;
            TXT_Pseudo.Text = SelectedPersonnel.Pseudo;
         ///   TXT_Genre.Text = SelectedPersonnel.Genre;
            TXT_Password.Text = SelectedPersonnel.Password;
            TXT_TelephonePortable.Text = SelectedPersonnel.TelephonePortable;
            TXT_TelephoneDomicile.Text = SelectedPersonnel.TelephoneDomicile;
            TXT_Mail.Text = SelectedPersonnel.Mail;
            TXT_Mail2.Text = SelectedPersonnel.Mail2;
            TXT_Adresse.Text = SelectedPersonnel.Adresse;

            if (SelectedPersonnel.Sexe == "F")
            {
                RADIO_SexeFemme.Checked = true;
            }
            else if (SelectedPersonnel.Sexe == "M")
            {
                RADIO_SexeHomme.Checked = true;
            }



            TXT_Genre.Text = SelectedPersonnel.Genre;
            if (SelectedPersonnel.Genre == "Prof")
            {
                RADIO_GenreProf.Checked = true;
            }
            else if (SelectedPersonnel.Genre == "AVS")
            {
                RADIO_GenreAvs.Checked = true;
            }
            else if (SelectedPersonnel.Genre == "RASED")
            {
                RADIO_GenreRased.Checked = true;
            }
            else if (SelectedPersonnel.Genre == "Rep+")
            {
                RADIO_GenreRepPlus.Checked = true;
            }
            else 
            {
                RADIO_GenreAutre.Checked = true;
                TXT_Genre.Visible = true;
            }



            /********/

        }

        private void F_Personnels_Add_Load(object sender, EventArgs e)
        {
            InitOk = true;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void BT_PersonnelAdd_Click(object sender, EventArgs e)
        {

            if (CheckForError())
            {
                return;
            }

            Personnel NewPersonnel = new Personnel();
            
            NewPersonnel.Nom = TXT_Nom.Text;
            NewPersonnel.Prenom = TXT_Prenom.Text;
            NewPersonnel.Pseudo = TXT_Pseudo.Text;
            NewPersonnel.Genre = TXT_Genre.Text;
            NewPersonnel.Password = TXT_Password.Text;
            NewPersonnel.TelephonePortable = TXT_TelephonePortable.Text;
            NewPersonnel.TelephoneDomicile = TXT_TelephoneDomicile.Text;
            NewPersonnel.Mail = TXT_Mail.Text;
            NewPersonnel.Mail2 = TXT_Mail2.Text;
            NewPersonnel.Adresse = TXT_Adresse.Text;

            NewPersonnel.Sexe = "";
            if (RADIO_SexeFemme.Checked)
            {
                NewPersonnel.Sexe = "F";
            }
            else if (RADIO_SexeHomme.Checked)
            {
                NewPersonnel.Sexe = "H";
            }
                       

     

            NewPersonnel.InsertInBdd();


            Retrun_CreatedPersonnelId = NewPersonnel.Id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BT_PersonnelAdd_Click___OLDDDDD(object sender, EventArgs e)
        {



            //    int temp_id = NUM_Id.Value;
            String temp_nom = TXT_Nom.Text;
            String temp_prenom = TXT_Prenom.Text;
            String temp_pseudo = TXT_Pseudo.Text;
            String temp_genre = TXT_Genre.Text;
            String temp_password = TXT_Password.Text;

            String temp_sexe = "";
            if (RADIO_SexeFemme.Checked)
            {
                temp_sexe = "F";
            }
            else if (RADIO_SexeHomme.Checked)
            {
                temp_sexe = "H";
            }

            String temp_telephonePortable = TXT_TelephonePortable.Text;
            String temp_telephoneDomicile = TXT_TelephoneDomicile.Text;
            String temp_Mail = TXT_Mail.Text;
            String temp_Mail2 = TXT_Mail2.Text;
            String temp_adresse = TXT_Adresse.Text;



            TXT_Nom.BackColor = Color.White;
            TXT_Prenom.BackColor = Color.White;
            GROUPOX_Genre.BackColor = Color.Gray;

            Boolean Erreur = false;
            if (temp_nom == "")
            {
                TXT_Nom.BackColor = Color.Yellow;
                Erreur = true;
            }
            if (temp_prenom == "")
            {
                TXT_Prenom.BackColor = Color.Yellow;
                Erreur = true;
            }
            if (temp_genre == "")
            {
                GROUPOX_Genre.BackColor = Color.Yellow;
                Erreur = true;
            }

            if (Erreur)
            {
                return;
            }


            Personnel NewPersonnel = new Personnel(temp_nom, temp_prenom, temp_pseudo, temp_genre, temp_password, temp_sexe, temp_telephonePortable, temp_telephoneDomicile, temp_Mail, temp_Mail2, temp_adresse);

            NewPersonnel.InsertInBdd();





            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void BT_PersonnelEdit_Click(object sender, EventArgs e)
        {

            if (CheckForError())
            {
                return;
            }
         

            SelectedPersonnel.Nom = TXT_Nom.Text;
            SelectedPersonnel.Prenom = TXT_Prenom.Text;
            SelectedPersonnel.Pseudo = TXT_Pseudo.Text;
            SelectedPersonnel.Genre = TXT_Genre.Text;
            SelectedPersonnel.Password = TXT_Password.Text;
            SelectedPersonnel.TelephonePortable = TXT_TelephonePortable.Text;
            SelectedPersonnel.TelephoneDomicile = TXT_TelephoneDomicile.Text;
            SelectedPersonnel.Mail = TXT_Mail.Text;
            SelectedPersonnel.Mail2 = TXT_Mail2.Text;
            SelectedPersonnel.Adresse = TXT_Adresse.Text;

            SelectedPersonnel.Sexe = "";
            if (RADIO_SexeFemme.Checked)
            {
                SelectedPersonnel.Sexe = "F";
            }
            else if (RADIO_SexeHomme.Checked)
            {
                SelectedPersonnel.Sexe = "H";
            }




            SelectedPersonnel.UpdateInBdd();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }


        private Boolean CheckForError()
        {
            TXT_Nom.BackColor = Color.White;
            TXT_Prenom.BackColor = Color.White;
            GROUPOX_Genre.BackColor = Color.LightGray;


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
            if (TXT_Genre.Text == "")
            {
                GROUPOX_Genre.BackColor = Color.Yellow;
                Erreur = true;
            }

            return Erreur;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  RADIO_GENRE    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void RADIO_GenreProf_CheckedChanged(object sender, EventArgs e)
        {
            TXT_Genre.Text = "Prof";
            TXT_Genre.Visible = false;

        }

        private void RADIO_GenreAvs_CheckedChanged(object sender, EventArgs e)
        {
            TXT_Genre.Text = "AVS";
            TXT_Genre.Visible = false;
        }

        private void RADIO_GenreRased_CheckedChanged(object sender, EventArgs e)
        {
            TXT_Genre.Text = "RASED";
            TXT_Genre.Visible = false;
        }

        private void RADIO_GenreAutre_CheckedChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {
                TXT_Genre.Text = "";
            }
            
            TXT_Genre.Visible = true;
        }

        private void RADIO_GenreRepPlus_CheckedChanged(object sender, EventArgs e)
        {
            TXT_Genre.Text = "Rep+";
            TXT_Genre.Visible = false;
        }






        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
