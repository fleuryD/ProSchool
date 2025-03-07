using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class UserControl_Responsable : UserControl
    {

        private Responsable m_repsonsable;
        public UserControl_Responsable()
        {

        }
        public UserControl_Responsable(Responsable Resp)
        {
            InitializeComponent();
            this.m_repsonsable = Resp;


            LB_NomPrenom.Text = Resp.Civilite + " ";
            if (Resp.NomUsage != "")
            {
                LB_NomPrenom.Text +=  "(" + Resp.NomUsage + ") ";
            }
            LB_NomPrenom.Text += Resp.Nom + " " + Resp.Prenom;

            LB_Adresse.Text = Resp.Adresse;
            LB_Adresse2.Text = Resp.CodePostal + " " + Resp.Commune + " " + Resp.Pays;
            LB_TelephoneDomicile.Text = Resp.TelephoneDomicile;
            LB_TelephoneTravail.Text = Resp.TelephoneTravail;
            LB_TelephonePortable.Text = Resp.TelephonePortable;
            LB_Mail.Text = Resp.Mail;


        }

    }
}
