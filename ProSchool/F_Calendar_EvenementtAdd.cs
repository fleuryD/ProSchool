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
    public partial class F_Calendar_EvenementtAdd : Form
    {
                          
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private DateTime selectedDate;
        private Evenement SelectedEvenement;
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        
        public F_Calendar_EvenementtAdd(DateTime _selectedDate)
        {
            ///// CREATE //////

            InitializeComponent();


            this.selectedDate = _selectedDate;
            SelectedEvenement = new Evenement();

            CB_DateFin.Checked = false;
            DatePicker_Debut.Value = this.selectedDate;
            DatePicker_Fin.Value = this.selectedDate.AddDays(1);


            BT_Create.Visible = true;
            BT_Update.Visible = false;
            BT_Supprimer.Visible = false;
            LB_Titre.Text = "Ajouter un évènement";

            LB_Erreurs.Visible = false;


        }

        

        public F_Calendar_EvenementtAdd(Evenement _Evnt)
        {
            ///// UPDATE //////
           
            InitializeComponent();
           // this.selectedDate = _selectedDate;
            SelectedEvenement = _Evnt;

            SetFormulaireFromSelectedEvenement();


            BT_Create.Visible = false;
            BT_Update.Visible = true;
            BT_Supprimer.Visible = true;
            LB_Titre.Text = "Modifier un évènement";


            LB_Erreurs.Visible = false;

        }

   

        private void F_Calendar_EvenementtAdd_Load(object sender, EventArgs e)
        {

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FORM - OBJET       ■■■■■■■■■■■■■■■■■■■■■■■■

        private void SetFormulaireFromSelectedEvenement()
        {

            // NUM_Id.Value = SelectedEvenement.Id;
            DatePicker_Debut.Value = DateTime.Parse(SelectedEvenement.DateDebut);

            if (String.IsNullOrEmpty(SelectedEvenement.DateFin))
            {
                DatePicker_Fin.Visible = false;
                CB_DateFin.Checked = false;
            }
            else
            {
                DatePicker_Fin.Value = DateTime.Parse(SelectedEvenement.DateFin);
                DatePicker_Fin.Visible = true;
                CB_DateFin.Checked = true;

            }
            COMBO_Genre.Text = SelectedEvenement.Genre;
            TXT_Infos.Text = SelectedEvenement.Infos;
            TXT_Nom.Text = SelectedEvenement.Nom;
            
        }


        private void SetSelectedEvenementFromFormulaire()
        {

            SelectedEvenement.DateDebut = DatePicker_Debut.Value.ToString("yyyy-MM-dd");

            if (CB_DateFin.Checked)
            {
                SelectedEvenement.DateFin = DatePicker_Fin.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                SelectedEvenement.DateFin = null;
            }
            SelectedEvenement.Genre = COMBO_Genre.Text;
            SelectedEvenement.Infos = TXT_Infos.Text;
            SelectedEvenement.Nom = TXT_Nom.Text;
        }

    
        private Boolean ErreursFormulaire()
        {
            Boolean Err = false;
            LB_Erreurs.Text = "";
            LB_Erreurs.Visible = false;





            /*
            if (TXT_Id.Text == "")
            {
                LB_Erreurs.Text += "Le Id ne peut pas être vide !\r\n";
                Err = true;
            }
            if (TXT_DateDebut.Text == "")
            {
                LB_Erreurs.Text += "Le DateDebut ne peut pas être vide !\r\n";
                Err = true;
            }
            if (TXT_DateFin.Text == "")
            {
                LB_Erreurs.Text += "Le DateFin ne peut pas être vide !\r\n";
                Err = true;
            }
            if (TXT_Genre.Text == "")
            {
                LB_Erreurs.Text += "Le Genre ne peut pas être vide !\r\n";
                Err = true;
            }
            if (TXT_Infos.Text == "")
            {
                LB_Erreurs.Text += "Le Infos ne peut pas être vide !\r\n";
                Err = true;
            }
            if (TXT_Nom.Text == "")
            {
                LB_Erreurs.Text += "Le Nom ne peut pas être vide !\r\n";
                Err = true;
            }
            if (Err)
            {
                LB_Erreurs.Visible = true;
            }
            */
            return Err;    // false = pas d'erreur
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  BT - CREATE - UPDATE - CANCEIL - DELETE    ■■■■■■■■■■■■■■■■■■■■■■■■
        
    
        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Supprimer l'évenement ?", "Supprimer l'évenement  ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //   MessageBox.Show("WIP : Bdd_Delete");
                // SelectedEvenement.Bdd_Delete(maConnexion);
                SelectedEvenement.DeleteInBdd();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            if (ErreursFormulaire())
            {
                return;
            }
            SetSelectedEvenementFromFormulaire();
            SelectedEvenement.InsertInBdd();
            //MessageBox.Show("WIP : Bdd_Insert");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            if (ErreursFormulaire())
            {
                return;
            }
            SetSelectedEvenementFromFormulaire();
           // MessageBox.Show("WIP : Bdd_Update");
            // SelectedEvenement.Bdd_Update();
            SelectedEvenement.UpdateInBdd(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

   


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void CB_DateFin_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_DateFin.Checked)
            {
                DatePicker_Fin.Visible = true;
                LB_DateFinHuman .Visible = true;
                LB_DateDebut.Text = "Date Début";
            }
            else
            {
                DatePicker_Fin.Visible = false;
                LB_DateFinHuman.Visible = false;
                LB_DateDebut.Text = "Date";
            }

        }

        private void DatePicker_Debut_ValueChanged(object sender, EventArgs e)
        {

            LB_DateDebutHuman.Text = Global.HumanDateDiffFromToday(DatePicker_Debut.Value.Date);
        }

        private void DatePicker_Fin_ValueChanged(object sender, EventArgs e)
        {
            LB_DateFinHuman.Text = Global.HumanDateDiffFromToday(DatePicker_Fin.Value.Date);
            
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
