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
    public partial class F_User_Login : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        List<Personnel> Personnels;
       // Personnel SelectedPersonnel;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_User_Login()
        {
            InitializeComponent();
        }

        private void F_User_Login_Load(object sender, EventArgs e)
        {
            Personnels = Personnel.GetListPersonnelsFromBdd();
            CreerBtPersonnels();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void CreerBtPersonnels()
        {
            FLP_BTUsers_Profs.Controls.Clear();
            FLP_BTUsers_Rep.Controls.Clear();
            FLP_BTUsers_Autres.Controls.Clear();

            foreach (Personnel Pers in Personnels)
            {
                // UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Pers);
                //  UCItemPers.Dock = DockStyle.Top;

                Button BT_Pers = new Button();
                BT_Pers.Text = Pers.Nom.ToUpper() + " " + Pers.Prenom;


                if (Pers.Genre == "Prof")
                {
                    BT_Pers.BackColor = Color.FromArgb(240, 240, 255);
                }
                else
                {
                    BT_Pers.Text += " (" + Pers.Genre + ")";
                    if (Pers.Genre == "AVS")
                    {
                        BT_Pers.BackColor = Color.FromArgb(255, 222, 255);
                    }
                    else if (Pers.Genre == "Directrice")
                    {
                        BT_Pers.BackColor = Color.LemonChiffon;
                    }

                }
                BT_Pers.FlatStyle = FlatStyle.Flat;
                  BT_Pers.Font = new Font(BT_Pers.Font.FontFamily, 12);
             //   BT_Pers.Font = new Font("Freestyle Script", 20, FontStyle.Regular);
           //     BT_Pers.Font = new Font("DJB Number 2 Pencil", 20, FontStyle.Regular);



                BT_Pers.AutoSize = true;
                //  FLP_BTUsers.Click += new EventHandler(BTUser_Click);
                BT_Pers.Click += (sender2, e2) => BTUser_Click(sender2, e2, Pers);


                if (Pers.Genre == "Prof")
                {
                    FLP_BTUsers_Profs.Controls.Add(BT_Pers);
                }
                else if (Pers.Genre == "Rep+")
                {
                    FLP_BTUsers_Rep.Controls.Add(BT_Pers);
                }
                else 
                {
                    FLP_BTUsers_Autres.Controls.Add(BT_Pers);
                }

                               
            }




            FLP_BTUsers_Profs.AutoSize = true;
            FLP_BTUsers_Rep.AutoSize = true;
            FLP_BTUsers_Autres.AutoSize = true;
        }

        private void BTUser_Click(object sender, EventArgs e, Personnel Pers)
        {

            Global.User.Personnel = Pers;
            Global.User.IsConnected = true;
            Global.User.Personnel.SetClasses();
            this.DialogResult = DialogResult.OK;
        //    MessageBox.Show("WORK IN PROGRESS ! \r\n\r\nDesolé "+ Pers.Prenom + ", mais la connexion ne marche pas encore !");
            this.Close();
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
