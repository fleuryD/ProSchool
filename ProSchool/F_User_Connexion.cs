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
    public partial class F_User_Connexion : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        List<Personnel> Personnels;
      //  Personnel SelectedPersonnel;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_User_Connexion()
        {
            InitializeComponent();
        }

        private void F_User_Connexion_Load(object sender, EventArgs e)
        {
            Personnels = Personnel.GetListPersonnelsFromBdd();
            CreerBtPersonnels();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void CreerBtPersonnels() {
            FLP_BTUsers.Controls.Clear();
            foreach (Personnel Pers in Personnels)
            {
               // UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Pers);
              //  UCItemPers.Dock = DockStyle.Top;

                Button BT_Pers = new Button();
                BT_Pers.Text = Pers.Nom +" " + Pers.Prenom;
                if (Pers.Genre == "Prof")
                {
                    BT_Pers.BackColor = Color.FromArgb(240,240,255);
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

                BT_Pers.Font = new Font(BT_Pers.Font.FontFamily, 16);
                BT_Pers.AutoSize = true;
                //  FLP_BTUsers.Click += new EventHandler(BTUser_Click);
                BT_Pers.Click += (sender2, e2) => BTUser_Click(sender2, e2, Pers);


                FLP_BTUsers.Controls.Add(BT_Pers);
                // UCItemPers.ButtonSupprimerClick += new EventHandler(UCItemPers_ButtonSupprimerClick);

                
           
               

            }
        }

        private void BTUser_Click(object sender, EventArgs e, Personnel Pers)
        {

            Global.User.Personnel = Pers;
            Global.User.IsConnected = true;
            this.DialogResult = DialogResult.OK;
            // MessageBox.Show("WORK IN PROGRESS ! \r\n\r\nDesolé "+ Pers.Prenom + ", mais la connexion ne marche pas encore !");
            this.Close();
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
