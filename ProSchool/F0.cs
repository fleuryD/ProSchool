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
    public partial class F0 : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        Boolean ModeDebug = false;

      //  private int PersonnelIdAutoconnect = 1;       // Girona
        private int PersonnelIdAutoconnect = 20;        // Roger (prof 4 classes)

        private List<BoutonMenu> BtMenus;

        private BoutonMenu SelectedBTM;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F0()
        {
            InitializeComponent();
        }

        private void F_0_Load(object sender, EventArgs e)
        {
           // TesterFont();
           
            Global.User = new Utilisateur();

            FLP_NewMenu1.Visible = false;
            FLP_NewMenu2.Visible = false;

            if ( ModeDebug && PersonnelIdAutoconnect > 0)
            {
                Personnel Pers = Personnel.GetPersonnelById(PersonnelIdAutoconnect);

                Global.User.Personnel = Pers;
                Global.User.IsConnected = true;
                Global.User.Personnel.SetClasses();
                REFRESH_ALL();
            }
            else
            {
                F_User_Login Frm = new F_User_Login();
                var result = Frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    REFRESH_ALL();
                }
                else
                {
                    this.Close();
                }
            }
      
        }

                    

        private void REFRESH_ALL()
        {

            Personnel UserPersonnel = Global.User.Personnel;
            TSBT_UserLogOut.Text = UserPersonnel.Nom + " : Déconnexion";


            FLP_NewMenu1.Visible = true;
            Init_List_BtMenus();
            Creer_Menu1();
            OuvrirMenu_1(SelectedBTM);        // !! SelectedBTM est initialisé dans Init_List_BtMenus() !!



        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  NOUVEAU MENU    ■■■■■■■■■■■■■■■■■■■■■■■■
        
        private void Init_List_BtMenus()
        {
            BtMenus = new List<BoutonMenu>();

            BoutonMenu BTM1_Acceuil = new BoutonMenu(Global.Color_Menu_Accueil, "F_TableauDeBord", "Accueil");   //niveau: 1, id: 1, ParentBoutonMenuId: 0, , code: "M1_Accueil"
            BtMenus.Add(BTM1_Acceuil);
            BtMenus.Add(new BoutonMenu(BTM1_Acceuil, "F_TableauDeBord", "Tableau de Bord"));
         //   if(ModeDebug || Global.User.Personnel.Id == 17)
        //    {
                BtMenus.Add(new BoutonMenu(BTM1_Acceuil, "F_About", "Aides, mise à jour, Todo"));
         //   }
                

            BoutonMenu BTM1_Eleves = new BoutonMenu(Global.Color_Menu_Eleves, "F_Classes_Liste", "Elèves / Classes");
            BtMenus.Add(BTM1_Eleves);
            SelectedBTM = BtMenus[BtMenus.Count() - 1];     //■■■■   ■■■■   ■■■■    A PLACER APRES LE BTM de demarrage ■■■■   ■■■■   ■■■■   
            BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Eleves_Liste", "Elèves"));
            BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Classes_Liste", "Classes"));
            BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Accompagnements", "Accompagnements"));
            BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Suivis", "Suivi / Entretiens"));
            if (ModeDebug || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Responsables_Liste", "Responsables"));
                BtMenus.Add(new BoutonMenu(BTM1_Eleves, "F_Wip", "Trombinoscope"));
            }
            if (Global.User.Personnel.Id == 1 || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Eleves, "ADD_ELEVE", "Ajouter élève"));
            }

            BoutonMenu BTM1_Absences = new BoutonMenu(Global.Color_Menu_Absences, "F_Appels_Faire_v2", "Absences / Appels");
            BtMenus.Add(BTM1_Absences);
            BtMenus.Add(new BoutonMenu(BTM1_Absences, "F_Appels_Faire_v2", "Faire l'appel"));
            BtMenus.Add(new BoutonMenu(BTM1_Absences, "F_Appels_Stats", "Stats Absences (Nouveau !)"));
            BtMenus.Add(new BoutonMenu(BTM1_Absences, "F_Appels_Recap", "Voir les Appels"));
            BtMenus.Add(new BoutonMenu(BTM1_Absences, "F_Appels_RecapAbsences", "Recap (nombre d'abs. par élèves)"));
            if (ModeDebug || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Absences, "F_Appels_Faire", "Faire l'appel (Ancienne version)"));
            }


                //    SelectedBTM2 = BtMenus[7];


                BoutonMenu BTM1_Personnels = new BoutonMenu(Global.Color_Menu_Personnels, "F_Personnels_Liste", "Profs / Personnel");
            BtMenus.Add(BTM1_Personnels);
            BtMenus.Add(new BoutonMenu(BTM1_Personnels, "F_Personnels_Liste", "Personnel"));
            if (ModeDebug || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Personnels, "F_Wip", "Abences (du personnel)"));
                BtMenus.Add(new BoutonMenu(BTM1_Personnels, "F_Wip", "Planning / EDT "));
            }


            BoutonMenu BTM1_Communication = new BoutonMenu(Global.Color_Menu_Communication, "F_Chatte", "Communication");
            BtMenus.Add(BTM1_Communication);
            BtMenus.Add(new BoutonMenu(BTM1_Communication, "F_Chatte", "Chatte"));
            if (ModeDebug || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Communication, "F_Wip", "Pigeons"));
            }

            BoutonMenu BTM1_Agenda = new BoutonMenu(Global.Color_Menu_Agenda, "F_Calendar", "Agenda / Bloc Notes");
            BtMenus.Add(BTM1_Agenda);
            BtMenus.Add(new BoutonMenu(BTM1_Agenda, "F_Calendar", "Calendrier"));
            BtMenus.Add(new BoutonMenu(BTM1_Agenda, "F_Calendar_Evenements", "Evenements"));
            if (ModeDebug || Global.User.Personnel.Id == 17)
            {
                BtMenus.Add(new BoutonMenu(BTM1_Agenda, "F_Wip", "Bloc-Note"));
            }

            if (Global.User.Personnel.Id == 1 || Global.User.Personnel.Id == 17)
            {
                BoutonMenu BTM1_Options = new BoutonMenu(Global.Color_Menu_Options, "F_Options_Importer", "Options");
                BtMenus.Add(BTM1_Options);
                BtMenus.Add(new BoutonMenu(BTM1_Options, "F_Options_Importer", "Importer les élèves, classes et résponsables depuis Onde/Base Elèves"));
                BtMenus.Add(new BoutonMenu(BTM1_Options, "F_Wip", "Vérifier Erreurs/Infos manquantes BDD"));
                BtMenus.Add(new BoutonMenu(BTM1_Options, "F_Wip", "Accompagnements"));
                BtMenus.Add(new BoutonMenu(BTM1_Options, "F_Options_User_Autorisations", "User_Autorisations"));
            }

        }

        private void OpenFormFromStr(string strFormToOpen)
        {
            switch (strFormToOpen)
            {
                case "F_TableauDeBord":
                    OuvrirForm(new F_TableauDeBord());
                    break;
                case "F_About":
                    OuvrirForm(new F_About());
                    break;
                case "F_Eleves_Liste":
                    OuvrirForm(new F_Eleves_Liste());
                    break;
                case "F_Calendar":
                    OuvrirForm(new F_Calendar());
                    break;
                case "F_Calendar_Evenements":
                    OuvrirForm(new F_Calendar_Evenements());
                    break;
                case "F_Accompagnements":
                    OuvrirForm(new F_Accompagnements_Recap());
                    break;
                case "F_Suivis":
                    OuvrirForm(new F_Suivis());
                    break;
                case "F_Responsables_Liste":
                    OuvrirForm(new F_Responsables_Liste());
                    break;
                case "F_Classes_Liste":
                    OuvrirForm(new F_Classes_Liste());
                    break;

                case "F_Appels_Faire":
                    OuvrirForm(new F_Appels_Faire());
                    break;
                case "F_Appels_Faire_v2":
                    OuvrirForm(new F_Appels_Faire_v2());
                    break;
                case "F_Appels_Stats":
                    OuvrirForm(new F_Appels_Stats());
                    break;
                case "F_Appels_Recap":
                    OuvrirForm(new F_Appels_Recap());
                    break;
                case "F_Appels_RecapAbsences":
                    OuvrirForm(new F_Appels_RecapAbsences());
                    break;
                case "F_Personnels_Liste":
                    OuvrirForm(new F_Personnels_Liste());
                    break;
                case "F_Options_Importer":
                    OuvrirForm(new F_Options_Importer());
                    break;
                case "F_Options_User_Autorisations":
                    OuvrirForm(new F_Options_User_Autorisations());
                    break;

                case "F_Chatte":
                    OuvrirForm(new F_Chatte());
                    break;
                case "ADD_ELEVE":

                    foreach (Form child in this.panel1.Controls)
                    {
                        child.Close();
                    }

                    F_Eleve_Add Frm = new F_Eleve_Add();
                    Frm.ShowDialog();
                    break;
                case "F_XXXXXXXXXXX7":
                    OuvrirForm(new F_Wip());
                    break;
                case "F_XXXXXXXXXXX8":
                    OuvrirForm(new F_Wip());
                    break;
                case "F_XXXXXXXXXXX9":
                    OuvrirForm(new F_Wip());
                    break;

                default:
                    OuvrirForm(new F_Wip());
                    break;
            }
        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ 

        private void Creer_Menu1()
        {
            FLP_NewMenu1.Controls.Clear();
            foreach (BoutonMenu BTM in BtMenus)
            {
                if (BTM.Niveau == 1)
                {

                    BTM.Label = new Label();

                    BTM.Label.Text = BTM.Text;
                    BTM.Label.AutoSize = true;
                    BTM.Label.BackColor = Color.FromArgb(128, 255, 128);
                    BTM.Label.Cursor = Cursors.Hand;
                    BTM.Label.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
                    BTM.Label.Margin = new Padding(10, 0, 0, 0);
                    BTM.Label.Padding = new Padding(10, 10, 10, 10);

                    if(BTM.StrFormToOpen == "F_Wip")
                    {
                        BTM.Label.ForeColor = Color.Red;
                    }

                    BTM.Label.MouseEnter += new EventHandler((s, e2) => BTM_OnMouseEnter(s, e2, BTM));
                    BTM.Label.MouseLeave += new EventHandler((s, e2) => BTM_OnMouseLeave(s, e2, BTM));
                    BTM.Label.Click += new EventHandler((s, e2) => BTM_1_Click(s, e2, BTM));

                    FLP_NewMenu1.Controls.Add(BTM.Label);
                }

            }


        }
        
        private void Creer_Menu2_from_BTM1(BoutonMenu BTM1)
        {

            foreach (BoutonMenu BTM in BtMenus)
            {
                if (BTM.BtParent == BTM1)
                {
                    BTM.Label = new Label();

                    BTM.Label.Text = BTM.Text;
                    BTM.Label.AutoSize = true;
                    BTM.Label.BackColor = BTM1.BackColor;
                    BTM.Label.ForeColor = Color.White;
                    if (BTM.Selected)
                    {
                        BTM.Label.BackColor = Color.White;
                        BTM.Label.ForeColor = Color.Black;
                    }
                    BTM.Label.Cursor = Cursors.Hand;
                    BTM.Label.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
                    BTM.Label.Margin = new Padding(10, 10, 0, 0);
                    BTM.Label.Padding = new Padding(10, 5, 10, 10);

                    if (BTM.StrFormToOpen == "F_Wip")
                    {
                        BTM.Label.ForeColor = Color.Red;
                    }

                    BTM.Label.MouseEnter += new EventHandler((s, e2) => BTM_OnMouseEnter(s, e2, BTM));
                    BTM.Label.MouseLeave += new EventHandler((s, e2) => BTM_OnMouseLeave(s, e2, BTM));
                    BTM.Label.Click += new EventHandler((s, e2) => BTM_2_Click(s, e2, BTM));

                    FLP_NewMenu2.Controls.Add(BTM.Label);
                }
              
            }


        }



        private void OuvrirMenu_1(BoutonMenu BTM1)
        {



            foreach (Control Ctrl in FLP_NewMenu1.Controls)
            {
                Ctrl.BackColor = Color.White;
                Ctrl.ForeColor = Color.Black;

            }
            BTM1.Label.BackColor = BTM1.BackColor;
            FLP_NewMenu2.BackColor = BTM1.BackColor;


            FLP_NewMenu2.Controls.Clear();

            foreach (BoutonMenu BTM in BtMenus)
            {
                BTM.Selected = false;
                if (BTM.BtParent == BTM1)
                {
                    if (BTM.StrFormToOpen == BTM1.StrFormToOpen )
                    {
                        BTM.Selected = true;
                     //   BTM.Label.ForeColor = Color.White;
                    }
                }
                
            }

            BTM1.Selected = true;
            BTM1.Label.ForeColor = Color.White;
            Creer_Menu2_from_BTM1(BTM1);
            FLP_NewMenu2.Visible = true;
            OpenFormFromStr(BTM1.StrFormToOpen);

        }


        private void BTM_1_Click(object s, EventArgs e2, BoutonMenu BTM)
        {
            OuvrirMenu_1(BTM);
        }

        private void BTM_2_Click(object s, EventArgs e2, BoutonMenu BTM2)
        {
          //  MessageBox.Show(BTM2.Label.Text);

            foreach (Control Ctrl in FLP_NewMenu2.Controls)
            {
                Ctrl.BackColor = BTM2.BackColor;
                Ctrl.ForeColor = Color.White;
            }
            
            foreach (BoutonMenu BTM_temp in BtMenus)
            {
                if (BTM_temp.Niveau > 1)
                {
                    BTM_temp.Selected = false;
                   
                }
                

            }
            BTM2.Selected = true;
            BTM2.Label.BackColor = Color.White;
            BTM2.Label.ForeColor = Color.Black;
      
        
            //Creer_Menu2_from_BTM1(BTM);
      
            OpenFormFromStr(BTM2.StrFormToOpen);
        }

        
        private void BTM_OnMouseEnter(object sender, EventArgs e, BoutonMenu BTM)
        {
            if (BTM.Niveau == 1)
            {
                if (BTM.Selected)
                    BTM.Label.ForeColor = Color.Gray;
                else
                    BTM.Label.ForeColor = BTM.BackColor;
                 //   BTM.Label.ForeColor = Color.Gray;

            }
            else
            {
                if (BTM.Selected)
                    BTM.Label.ForeColor = Color.Gray;
                else
                    BTM.Label.ForeColor =  Color.Black;
            }

        }
        private void BTM_OnMouseLeave(object sender, EventArgs e, BoutonMenu BTM)
        {
            if (BTM.StrFormToOpen == "F_Wip")
            {
                BTM.Label.ForeColor = Color.Red;
            }
            else
            {

                if (BTM.Niveau == 1)
                {

                    if (BTM.Selected)
                        BTM.Label.ForeColor = Color.White;
                    else
                        BTM.Label.ForeColor = Color.Black;

                }
                else
                {
                    if (BTM.Selected)
                        BTM.Label.ForeColor = BTM.BtParent.BackColor; //Color.Black;
                    else
                        BTM.Label.ForeColor = Color.White;
                }


                    
            }
            
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void TSBT_UserLogOut_Click(object sender, EventArgs e)
        {
            Global.User = new Utilisateur();



            FLP_NewMenu1.Visible = false;
        //    CloseAllMenus();



            foreach (Form child in this.panel1.Controls)
            {
                child.Close();
            }


            F_User_Login Frm = new F_User_Login();
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {

                REFRESH_ALL();
            }
            else
            {
                this.Close();
            }



        }


        private void TesterFont()
        {
            string fontName = "Freestyle Script";
            float fontSize = 12;

            using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                if (fontTester.Name == fontName)
                {
                    //  MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("La police " + fontName + "n'est pas installé");
                }
            }
        }

        private void OuvrirForm(Form MyForm)
        {
            foreach (Form child in this.panel1.Controls)
            {
                child.Close();
            }

            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = panel1;
            MyForm.Top = 0;
            MyForm.Left = 0;
            MyForm.Size = panel1.ClientSize;
            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();
        }

        private void TSBT_UserConnexion_Click(object sender, EventArgs e)
        {


            
            F_User_Connexion Frm = new F_User_Connexion();
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {


            }

    





        }

    
 






        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
