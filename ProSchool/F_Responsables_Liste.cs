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
    public partial class F_Responsables_Liste : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■



        private List<Responsable> Responsables;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Responsables_Liste()
        {
            InitializeComponent();
        }
        private void F_Responsables_Liste_Load(object sender, EventArgs e)
        {
            Responsables = Responsable.GetListResponsablesFromBdd();
            Setup_DGV_Responsables();
            Populate_DGV_Responsables();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Responsables    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Responsables()
        {


            DGV_Responsables.ColumnCount = 13;

            DGV_Responsables.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Responsables.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Responsables.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Responsables.Font, FontStyle.Bold);
            DGV_Responsables.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Responsables.ColumnHeadersHeight = 40;

            DGV_Responsables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Responsables.RowHeadersVisible = false;
            DGV_Responsables.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Responsables.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Responsables.GridColor = Color.Black;

            DGV_Responsables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Responsables.MultiSelect = false;
            DGV_Responsables.AllowUserToAddRows = false;


            DGV_Responsables.Columns[0].Name = "id";
            DGV_Responsables.Columns[1].Name = "civilite";
            DGV_Responsables.Columns[2].Name = "nomUsage";
            DGV_Responsables.Columns[3].Name = "nom";
            DGV_Responsables.Columns[4].Name = "prenom";
            DGV_Responsables.Columns[5].Name = "adresse";
            DGV_Responsables.Columns[6].Name = "codePostal";
            DGV_Responsables.Columns[7].Name = "commune";
            DGV_Responsables.Columns[8].Name = "pays";
            DGV_Responsables.Columns[9].Name = "mail";
            DGV_Responsables.Columns[10].Name = "telephoneDomicile";
            DGV_Responsables.Columns[11].Name = "telephoneTravail";
            DGV_Responsables.Columns[12].Name = "telephonePortable";


            //DGV_Responsables.Columns["xxxxxxxx"].Width = 350;

            //DGV_Responsables.Columns["xxxxxxxx"].Visible = false;

        }



        private void Populate_DGV_Responsables()
        {

            DGV_Responsables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Responsables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Responsables.Rows.Clear();

            foreach (Responsable Obj in Responsables)
            {

                var index = DGV_Responsables.Rows.Add();
                DGV_Responsables.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Responsables.Rows[index].Cells["civilite"].Value = Obj.Civilite;
                DGV_Responsables.Rows[index].Cells["nomUsage"].Value = Obj.NomUsage;
                DGV_Responsables.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Responsables.Rows[index].Cells["prenom"].Value = Obj.Prenom;
                DGV_Responsables.Rows[index].Cells["adresse"].Value = Obj.Adresse;
                DGV_Responsables.Rows[index].Cells["codePostal"].Value = Obj.CodePostal;
                DGV_Responsables.Rows[index].Cells["commune"].Value = Obj.Commune;
                DGV_Responsables.Rows[index].Cells["pays"].Value = Obj.Pays;
                DGV_Responsables.Rows[index].Cells["mail"].Value = Obj.Mail;
                DGV_Responsables.Rows[index].Cells["telephoneDomicile"].Value = Obj.TelephoneDomicile;
                DGV_Responsables.Rows[index].Cells["telephoneTravail"].Value = Obj.TelephoneTravail;
                DGV_Responsables.Rows[index].Cells["telephonePortable"].Value = Obj.TelephonePortable;

                // Obj.Dgv_row = DGV_Responsables.Rows[index];
                // DGV_Responsables.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            DGV_Responsables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Responsables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
