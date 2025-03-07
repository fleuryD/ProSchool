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
    public partial class F_Eleves_Absences : Form
    {
        private Eleve SelectedEleve;


        public F_Eleves_Absences(Eleve _selectedEleve)
        {
            InitializeComponent();
            this.SelectedEleve = _selectedEleve;
        }

        private void F_Eleves_Absences_Load(object sender, EventArgs e)
        {
            LB_Eleve.Text = SelectedEleve.Nom + " " + SelectedEleve.Prenom;
            BT_ResponsablesShow.Text = SelectedEleve.Responsables.Count() + " responsable(s)";

            LB_Resume.Text = "";
            LB_Resume.Text += SelectedEleve.Appels.Where(p => p.Etat == "Absent").Count() + " demi-journée(s) d'absence";
            LB_Resume.Text += "\r\n" + SelectedEleve.Appels.Where(p => p.Etat == "Retard").Count() + " retard(s)";

           



            foreach (Appel App in SelectedEleve.Appels.Where(p => p.Etat != "Present"))
            {

                //Today.ToLongDateString();   //today.ToLongDateString() + " >>>> " + today.ToString("dddd dd MMMM") + " >>>> " + today.ToString("yyyy-MM-dd");
                DateTime Jour = Convert.ToDateTime(App.Jour);

                RichTXT_AppendText(Jour.ToString("dddd dd MMMM") + " (" + App.DemiJournee + ")", Color.Black);
                RichTXT_AppendText(" - ", Color.Black);

                if (App.Etat == "Absent")
                {
                    RichTXT_AppendText(App.Etat, Color.Red);
                }
                else
                {
                    RichTXT_AppendText(App.Etat, Color.Blue);
                }

                RichTXT_AppendText(" - ", Color.Black);

                if (App.Justifiee != "")
                {
                    RichTXT_AppendText("Justifié(e) : ", Color.Green);
                    RichTXT_AppendText(App.Justifiee, Color.Green);
                }
                else
                {
                    RichTXT_AppendText("Non justifié(e)", Color.Red);
                }

                if (App.Infos != "")
                {
                    RichTXT_AppendText(" (" + App.Infos + ")", Color.DarkGreen);
                }

                RichTXT_AppendText("\r\n", Color.Black);

            }


        }


        public void RichTXT_AppendText(string text, Color color)
        {
            RichTXT_Absences.SelectionStart = RichTXT_Absences.TextLength;
            RichTXT_Absences.SelectionLength = 0;

            RichTXT_Absences.SelectionColor = color;
            RichTXT_Absences.AppendText(text);
            RichTXT_Absences.SelectionColor = RichTXT_Absences.ForeColor;
            
        }

        private void BT_ResponsablesShow_Click(object sender, EventArgs e)
        {
            F_Responsables_Eleve Frm = new F_Responsables_Eleve(SelectedEleve);
            Frm.ShowDialog();
        }

        private void PAN_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_Eleve_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_Resume_Click(object sender, EventArgs e)
        {

        }

        private void RichTXT_Absences_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
