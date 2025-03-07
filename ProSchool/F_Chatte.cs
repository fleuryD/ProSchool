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
    public partial class F_Chatte : Form
    {



        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Chatte> Chattes;
        private List<Personnel> Personnels;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Chatte()
        {
            InitializeComponent();
        }


        private void F_Chatte_Load(object sender, EventArgs e)
        {
            Chattes = Chatte.GetListChattesFromBdd();
            Personnels = Personnel.GetListPersonnelsFromBdd();

            foreach(Chatte Ch in Chattes)
            {
                AfficherChatte(Ch);
            }
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■



        private void AfficherChatte(Chatte Ch)
        {
            Personnel Pers = Personnels.Where(p => p.Id == Ch.PersonnelId).FirstOrDefault();




            String StrContenu = Ch.Contenu;
            StrContenu = StrContenu.Replace("\r\n", "\t\t\r\n");
            
  

            Global.RichTXT_AppendText(RTXT_Chat, Color.DarkGreen, Ch.DateHeure + "\t");
            Global.RichTXT_AppendText(RTXT_Chat, Color.Blue, Pers.Nom + " " + Pers.Prenom + "\r\n\r\n");
            Global.RichTXT_AppendText(RTXT_Chat, Color.Black, StrContenu + "\r\n");
            Global.RichTXT_AppendText(RTXT_Chat, Color.Black, "_____________________________________________________\r\n");
         
        }

        private void BT_Envoyer_Click(object sender, EventArgs e)
        {
            String StrSend = TXT_Send.Text;
            
            Chatte Cht = new Chatte(Global.User.Personnel.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), StrSend);
            Cht.InsertInBdd();

            AfficherChatte(Cht);
            TXT_Send.Text = "";

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
