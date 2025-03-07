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
    public partial class F_TableauDeBord : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Color Color1 = Global.Color_Menu_Accueil;
        private Color Color2 = Global.Color_Menu_Accueil2;



        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_TableauDeBord()
        {
            InitializeComponent();
        }


        private void F_TableauDeBord_Load(object sender, EventArgs e)
        {
            REFRESH_ALL();
            RichTXT_DOUDOU.Text = "";
            Global.RichTXT_AppendText(RichTXT_DOUDOU, Color1, "ProSchool", 30f);
            RichTXT_DOUDOU.SelectionAlignment = HorizontalAlignment.Center;

            LB_Titre_Abs.ForeColor = Color1;
            LB_Titre_Agenda.ForeColor = Color1;
            LB_Titre_Classes.ForeColor = Color1;
           // LB_Titre_Duruyz.ForeColor = Color1;
            LB_Titre_Infos.ForeColor = Color1;
            LB_Titre_Mess.ForeColor = Color1;
            LB_Titre_TdB.ForeColor = Color1;
            FLP_Evenements.BackColor = Color2;


            List<Evenement> EvenementsFuture = Evenement.Bdd_GetEvenements_Futurs();
            FLP_Evenements.Controls.Clear();
            /*
            foreach (Evenement Evnt in EvenementsFuture)
            {
                UserControl_Evenement UC_Event = new UserControl_Evenement(Evnt);
                FLP_Evenements.Controls.Add(UC_Event);
            }
            */
            int maxWidth = FLP_Evenements.Width - 50;
          //  int maxWidth = 200;

            foreach (Evenement Evnt in EvenementsFuture)
            {
                UserControl_Evenement UC_Event = new UserControl_Evenement(Evnt);
                UC_Event.BT_Edit.Visible = false;
                FLP_Evenements.Controls.Add(UC_Event);
             //   UC_Event.Dock = DockStyle.Bottom;
                UC_Event.SetAutoSize(maxWidth);
                

            }


            Global.ParserBbCode(RICHTXT_Maj);

        }



        private void REFRESH_ALL()
        {
            if (Global.User.IsConnected)
            {
                Personnel UserPersonnel = Global.User.Personnel;

                LB_Pers_Nom.Text = UserPersonnel.Nom;
                LB_Pers_Prenom.Text = UserPersonnel.Prenom;
                LB_Pers_Pseudo.Text = UserPersonnel.Pseudo;
                LB_Pers_Genre.Text = UserPersonnel.Genre;
                LB_Pers_Sexe.Text = UserPersonnel.Sexe;
                LB_Pers_Password.Text = UserPersonnel.Password;
                LB_Pers_Telephone_portable.Text = UserPersonnel.TelephonePortable;
                LB_Pers_Telephone_domicile.Text = UserPersonnel.TelephoneDomicile;
                LB_Pers_Mail.Text = UserPersonnel.Mail;
                LB_Pers_Mail2.Text = UserPersonnel.Mail2;
                LB_Pers_Adresse.Text = UserPersonnel.Adresse;

               // Global.User.Personnel.SetClasses();  // dans connexion

                LB_MesClasses.Text = "";

                foreach (Classe Cl in Global.User.Personnel.Classes)
                {
                    LB_MesClasses.Text += Cl.Nom + "\r\n";
                }
                    

                LB_Titre_TdB.Text = UserPersonnel.Nom + " " + UserPersonnel.Prenom; //"Mon Tableau de bord :: " + 
            }
            else
            {

                /*
                PAN_ConnectezVous.Visible = true;
                PAN_Module_Agenda.Visible = false;
                PAN_Module_Absences.Visible = false;
                PAN_Module_MesClasses.Visible = false;
                PAN_Module_Messagerie.Visible = false;
                PAN_Module_UserInfos.Visible = false;
                LB_Titre_TdB.Text = "Tableau de bord :: Utilisateur non connecté";
                */
            }


        }

        private void BT_PersonnelEdit_Click(object sender, EventArgs e)
        {
            using (var form = new F_Personnels_Add(Global.User.Personnel))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    REFRESH_ALL();
                }
            }
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■




    }
}
