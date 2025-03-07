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
    public partial class F_Eleves_Liste_DgvOptions : Form
    {
        private DataGridView DGV_Eleves;
        private bool InitOk = false;
        private SplitContainer splitContainer1;

        public F_Eleves_Liste_DgvOptions(DataGridView DGV, SplitContainer _splitContainer1)
        {
            InitOk = false;
            InitializeComponent();
            this.DGV_Eleves = DGV;
            this.splitContainer1 = _splitContainer1;


            CB_Col_Id.Checked = this.DGV_Eleves.Columns["id"].Visible;
            CB_Col_dateNaissance.Checked = this.DGV_Eleves.Columns["dateNaissance"].Visible;
            CB_Col_sexe.Checked = this.DGV_Eleves.Columns["sexe"].Visible;
            CB_Col_ine.Checked = this.DGV_Eleves.Columns["ine"].Visible;
            CB_Col_cycle.Checked = this.DGV_Eleves.Columns["cycle"].Visible;
            CB_Col_niveau.Checked = this.DGV_Eleves.Columns["niveau"].Visible;
            CB_Col_classe.Checked = this.DGV_Eleves.Columns["classe"].Visible;
            CB_Col_attestation.Checked = this.DGV_Eleves.Columns["attestation"].Visible;
            CB_Col_autorisationPhoto.Checked = this.DGV_Eleves.Columns["autorisationPhoto"].Visible;
            CB_Col_decisionPassage.Checked = this.DGV_Eleves.Columns["decisionPassage"].Visible;
            CB_Col_dispositifs.Checked = this.DGV_Eleves.Columns["dispositifs"].Visible;


            CB_Col_delegue.Checked = this.DGV_Eleves.Columns["delegue"].Visible;
            CB_Col_dpExt.Checked = this.DGV_Eleves.Columns["dpExterne"].Visible;
            CB_Col_garderie.Checked = this.DGV_Eleves.Columns["garderie"].Visible;
            CB_Col_alae.Checked = this.DGV_Eleves.Columns["alae"].Visible;

            CB_Col_date_entree.Checked = this.DGV_Eleves.Columns["date_entree"].Visible;
            CB_Col_date_sortie.Checked = this.DGV_Eleves.Columns["date_sortie"].Visible;
            CB_Col_import_genre.Checked = this.DGV_Eleves.Columns["import_genre"].Visible;




            InitOk = true;

        }

      

        private void CB_Colonnes_CheckedChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {

            
            this.DGV_Eleves.Columns["id"].Visible = CB_Col_Id.Checked;

            this.DGV_Eleves.Columns["dateNaissance"].Visible = CB_Col_dateNaissance.Checked;
            this.DGV_Eleves.Columns["sexe"].Visible = CB_Col_sexe.Checked;
            this.DGV_Eleves.Columns["ine"].Visible = CB_Col_ine.Checked; 
            this.DGV_Eleves.Columns["cycle"].Visible = CB_Col_cycle.Checked; 
            this.DGV_Eleves.Columns["niveau"].Visible = CB_Col_niveau.Checked; 
            this.DGV_Eleves.Columns["classe"].Visible = CB_Col_classe.Checked;
            this.DGV_Eleves.Columns["attestation"].Visible = CB_Col_attestation.Checked; 
            this.DGV_Eleves.Columns["autorisationPhoto"].Visible = CB_Col_autorisationPhoto.Checked; 
            this.DGV_Eleves.Columns["decisionPassage"].Visible = CB_Col_decisionPassage.Checked; 
            this.DGV_Eleves.Columns["dispositifs"].Visible = CB_Col_dispositifs.Checked;


            this.DGV_Eleves.Columns["delegue"].Visible = CB_Col_delegue.Checked;
            this.DGV_Eleves.Columns["dpExterne"].Visible = CB_Col_dpExt.Checked;
            this.DGV_Eleves.Columns["garderie"].Visible = CB_Col_garderie.Checked;
            this.DGV_Eleves.Columns["alae"].Visible = CB_Col_alae.Checked;

            this.DGV_Eleves.Columns["date_entree"].Visible = CB_Col_date_entree.Checked;
            this.DGV_Eleves.Columns["date_sortie"].Visible = CB_Col_date_sortie.Checked;
            this.DGV_Eleves.Columns["import_genre"].Visible = CB_Col_import_genre.Checked;


            Global.Ajust_SplitCont_Width_from_DGV(DGV_Eleves, splitContainer1, 30);

            }

        }

    }
}
