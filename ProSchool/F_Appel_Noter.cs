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
    public partial class F_Appel_Noter : Form
    {
        private string strEleve;
        private Appel Apl;

        public F_Appel_Noter()
        {
        }

        public F_Appel_Noter(string _strEleve, Appel _apl)
        {
            InitializeComponent();
            this.strEleve = _strEleve;
            this.Apl = _apl;

            LB_Eleve.Text = strEleve;
            LB_Date.Text = Apl.Jour + " (" + Apl.DemiJournee + ")";


            if (Apl.Etat == "Present")
            {
                RADIO_EtatPresent.Checked = true;
            }
            else if (Apl.Etat == "Absent")
            {
                RADIO_EtatAbsent.Checked = true;
            }
            else if (Apl.Etat == "Retard")
            {
                RADIO_EtatRetard.Checked = true;
            }

            TXT_Infos.Text = Apl.Infos;


            if (Apl.Justifiee == "Maladie")
            {
                RADIO_JustifMaladie.Checked = true;
            }
            else if (Apl.Justifiee == "Famille")
            {
                RADIO_JustifFamille.Checked = true;
            }
            else if (Apl.Justifiee == "Autre")
            {
                RADIO_JustifAutre.Checked = true;
            }
            else
            {
                RADIO_JustifNon.Checked = true;
            }

        }

        private void BT_Valider_Click(object sender, EventArgs e)
        {


            if (RADIO_EtatAbsent.Checked)
            {
                Apl.Etat = "Absent";
            }
            else if (RADIO_EtatRetard.Checked)
            {
                Apl.Etat = "Retard";
            }
            else
            {
                Apl.Etat = "Present";
            }


            Apl.Infos = TXT_Infos.Text;



            if (RADIO_JustifMaladie.Checked)
            {
                Apl.Justifiee = "Maladie";
            }
            else if (RADIO_JustifFamille.Checked)
            {
                Apl.Justifiee = "Famille";
            }
            else if (RADIO_JustifAutre.Checked)
            {
                Apl.Justifiee = "Autre";
            }
            else
            {
                Apl.Justifiee = "";
            }

            if (Apl.Etat == "Present")
            {
                Apl.Justifiee = "";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void RADIO_EtatPresent_CheckedChanged(object sender, EventArgs e)
        {
            GB_Jutifiee.Visible = !RADIO_EtatPresent.Checked;
        }
    }
}
