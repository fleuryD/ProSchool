using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Accompagnements_Options : Form
    {




        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Accompagnement> Accompagnements;
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Accompagnements_Options()
        {
            InitializeComponent();

            this.DGV_Accompagnements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Accompagnements_CellDoubleClick);
          //  this.BT_AccompagnementAdd.Click += new System.EventHandler(this.BT_AccompagnementAdd_Click);

        }

        private void F_Accompagnements_Options_Load(object sender, EventArgs e)
        {
            REFRESH_ALL();
        }

        private void REFRESH_ALL()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            Accompagnements = Accompagnement.Bdd_GetAccompagnements_OrderByPosition(maConnexion);
            foreach(Accompagnement Acc in Accompagnements)
            {
                Acc.SetEleveCount(maConnexion);
            }

            maConnexion.Close();

            Setup_DGV_Accompagnements();
            Populate_DGV_Accompagnements();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  EVENTS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void DGV_Accompagnements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show("Not Implemented : DGV_Accompagnements_CellDoubleClick");
            if (DGV_Accompagnements.SelectedRows.Count == 1)
            {
                int SelectedAccompagnementId = int.Parse(DGV_Accompagnements.CurrentRow.Cells[0].Value.ToString());
                Accompagnement SelectedAccompagnement = Accompagnements.Where(X => X.Id == SelectedAccompagnementId).First();    
                F_Accompagnement_Edit Frm = new F_Accompagnement_Edit(SelectedAccompagnement);
                var result = Frm.ShowDialog();
                /*
                if (result == DialogResult.OK)
                {
                    REFRESH_ALL();
                }
                */
                REFRESH_ALL();  // On refresh dans tous les cas, car : si on clik sur "modifier un acc" , mais qu'on annul (au comfirmBox), l'ACC a été modifié
            }

        }

        private void BT_AccompagnementAdd_Click(object sender, EventArgs e)
        {            
            F_Accompagnement_Edit Frm = new F_Accompagnement_Edit();
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                REFRESH_ALL();
            }
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Accompagnements    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Accompagnements()
        {


            DGV_Accompagnements.ColumnCount = 0;

            DGV_Accompagnements.EnableHeadersVisualStyles = false;  // pour changer la couleur du header
            DGV_Accompagnements.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Accompagnements.Font.FontFamily, 11f, FontStyle.Bold);
        //    DGV_Accompagnements.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
        //   DGV_Accompagnements.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            DGV_Accompagnements.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Accompagnements.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Accompagnements.ColumnHeadersHeight = 40;

            //DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Accompagnements.RowHeadersVisible = false;
            DGV_Accompagnements.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Accompagnements.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Accompagnements.GridColor = Color.Black;

            DGV_Accompagnements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Accompagnements.MultiSelect = false;
            DGV_Accompagnements.AllowUserToAddRows = false;


            Global.DGV_AddCol(DGV_Accompagnements, "id", "Id");
            Global.DGV_AddCol(DGV_Accompagnements, "nom", "Nom");
            Global.DGV_AddCol(DGV_Accompagnements, "nomSimple", "Nom Simple");
            Global.DGV_AddCol(DGV_Accompagnements, "position", "");
            Global.DGV_AddCol(DGV_Accompagnements, "elevesCount", "Nombre d'élèves");


            //DGV_Accompagnements.Columns["xxxxxxxx"].Width = 350;

            DGV_Accompagnements.Columns["id"].Visible = false;

        }
        

        private void Populate_DGV_Accompagnements()
        {

            DGV_Accompagnements.Rows.Clear();
            DGV_Accompagnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (Accompagnement Obj in Accompagnements)
            {

                var index = DGV_Accompagnements.Rows.Add();
                // Obj.Dgv_row = DGV_Accompagnements.Rows[index];
                DGV_Accompagnements.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Accompagnements.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Accompagnements.Rows[index].Cells["nomSimple"].Value = Obj.NomSimple;
                DGV_Accompagnements.Rows[index].Cells["position"].Value = Obj.Position;
                DGV_Accompagnements.Rows[index].Cells["elevesCount"].Value = Obj.EleveCount;

                // DGV_Accompagnements.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            DGV_Accompagnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Accompagnements.ClearSelection();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }






        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX     ■■■■■■■■■■■■■■■■■■■■■■■■



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■








    }
}
