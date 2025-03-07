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
    public partial class UserControl_ItemPersonne : UserControl
    {
        private Personnel Pers;
        private Eleve Elv;
        private Classe Cl;


        public event EventHandler ButtonSupprimerClick;

        public UserControl_ItemPersonne(Personnel _pers)
        {
            InitializeComponent();
            this.Pers = _pers;
            LB_Nom.Text = Pers.Nom + " " + Pers.Prenom;
            LB_Nom.Text += " (" + Pers.Genre + ")";
        }

        public UserControl_ItemPersonne(Eleve _elv)
        {
            InitializeComponent();
            this.Elv = _elv;
            LB_Nom.Text = Elv.Nom + " " + Elv.Prenom;
        }

        public UserControl_ItemPersonne(Classe _cl)
        {
            InitializeComponent();
            this.Cl = _cl;
            LB_Nom.Text = _cl.Nom;
        }




        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            if (this.ButtonSupprimerClick != null)
                this.ButtonSupprimerClick(this, e);
        }
    }
}
