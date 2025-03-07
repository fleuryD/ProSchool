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
    public partial class F_SelectPersonnelsEleves : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
        public List<int> ListIds { get; set; }

        private List<Eleve> Eleves;
        private List<Classe> Classes;
        private bool InitOk;
        public Boolean MultiSelect { get; set; }


        private Dictionary<int, Classe> Dico_Idents_Classes;
        private String Mode;   // ELEVE_ACCOMPAGNEMENT

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_SelectPersonnelsEleves()
        {
            InitializeComponent();

            //    Setup_DGV_X_Personnels()();
            //     Populate_DGV_X();
        }


        public F_SelectPersonnelsEleves(List<Eleve> _eleves, Dictionary<int, Classe> _dico_Idents_Classes, string _mode)
        {
            InitOk = false;
            InitializeComponent();
                       

            ListIds = new List<int>();

            this.Eleves = _eleves;
            this.Dico_Idents_Classes = _dico_Idents_Classes;
            this.Mode = _mode;


            if(this.Mode == "ELEVE_ACCOMPAGNEMENT")
            {
                this.Text = "Séléctionner un élève";
                this.LB_Description.Text = "Séléctionner un élève pour lui ajouter des accompagnements";
                LB_Result.Visible = false;
                this.DGV_X.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_X_CellContentDoubleClick);
            }

            Setup_DGV_X_Eleves();
            Populate_DGV_X_Eleves();
            DGV_X.ClearSelection();
        }


 






        public F_SelectPersonnelsEleves(List<Eleve> _eleves)
        {
            InitOk = false;
            InitializeComponent();
            ListIds = new List<int>();

            this.Eleves = _eleves;
            Setup_DGV_X_Eleves();
            Populate_DGV_X_Eleves();
            DGV_X.ClearSelection();
        }

        public F_SelectPersonnelsEleves(List<Classe> _classes)
        {
            InitOk = false;
            InitializeComponent();
            ListIds = new List<int>();

            this.Classes = _classes;

            Setup_DGV_X_Classes();
            Populate_DGV_X_Classes();


            DGV_X.ClearSelection();
        }


        public F_SelectPersonnelsEleves(List<Personnel> _personnels)
        {
            InitOk = false;
            InitializeComponent();
            
          //  ListIds = new List<int>();
          //  this.Eleves = _eleves;
            Setup_DGV_X_Personnels();
           // Populate_DGV_X();
           // DGV_X.ClearSelection();
            
        }

        

        private void F_SelectPersonnelsEleves_Load(object sender, EventArgs e)
        {

            DGV_X.ClearSelection();
            InitOk = true;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void B_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_X    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_X_Personnels()
        {


            DGV_X.ColumnCount = 5;

            DGV_X.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_X.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_X.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_X.Font, FontStyle.Bold);
            DGV_X.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_X.ColumnHeadersHeight = 40;

            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_X.RowHeadersVisible = false;
            DGV_X.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_X.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_X.GridColor = Color.Black;

            DGV_X.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_X.AllowUserToAddRows = false;



            DGV_X.MultiSelect = MultiSelect;

            DGV_X.Columns[0].Name = "id";
            DGV_X.Columns[1].Name = "nom";
            DGV_X.Columns[2].Name = "prenom";
            DGV_X.Columns[3].Name = "niveau";
            DGV_X.Columns[4].Name = "delegue";



            //DGV_X.Columns["id"].Visible = false;

        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_X ELEVES   ■■■■■■■■■■■■■■■■■■■■■■■■


        private void Setup_DGV_X_Eleves()
        {


            DGV_X.ColumnCount = 5;

            DGV_X.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_X.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_X.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_X.Font, FontStyle.Bold);
            DGV_X.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_X.ColumnHeadersHeight = 40;

            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_X.RowHeadersVisible = false;
            DGV_X.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_X.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_X.GridColor = Color.Black;

            DGV_X.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_X.AllowUserToAddRows = false;

            DGV_X.MultiSelect = MultiSelect;

            DGV_X.Columns[0].Name = "id";
            DGV_X.Columns[1].Name = "nom";
            DGV_X.Columns[2].Name = "prenom";
            DGV_X.Columns[3].Name = "classe";
            DGV_X.Columns[4].Name = "niveau";
            

            DGV_X.Columns["id"].Visible = false;

        }

        private void Populate_DGV_X_Eleves()
        {

            DGV_X.Rows.Clear();

            DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (Eleve Obj in Eleves)
            {

                var index = DGV_X.Rows.Add();
                DGV_X.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_X.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_X.Rows[index].Cells["prenom"].Value = Obj.Prenom;
           
                DGV_X.Rows[index].Cells["niveau"].Value = Obj.Niveau;
             

                // Obj.Dgv_row = DGV_X.Rows[index];
                // DGV_X.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;


                if (this.Mode == "ELEVE_ACCOMPAGNEMENT")
                {

                    if (Dico_Idents_Classes.ContainsKey(Obj.ClasseId))
                    {
                        DGV_X.Rows[index].Cells["classe"].Value = Dico_Idents_Classes[Obj.ClasseId].Nom;
                    }


                    if (Obj.Accompagnements.Count() > 0)
                    {
                        DGV_X.Rows[index].DefaultCellStyle.BackColor = Global.Color_Menu_Eleves2;
                    }

                }
            }


            DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        private void DGV_X_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedPersonneId = int.Parse(DGV_X.CurrentRow.Cells[0].Value.ToString());
            ListIds.Add(SelectedPersonneId);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_X CLASSES   ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_X_Classes()
        {

            DGV_X.ColumnCount = 3;

            DGV_X.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_X.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_X.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_X.Font, FontStyle.Bold);
            DGV_X.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_X.ColumnHeadersHeight = 40;

            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_X.RowHeadersVisible = false;
            DGV_X.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_X.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_X.GridColor = Color.Black;

            DGV_X.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //            DGV_X.MultiSelect = false;
            DGV_X.AllowUserToAddRows = false;


            DGV_X.Columns[0].Name = "id";
            DGV_X.Columns[1].Name = "nom";
            DGV_X.Columns[2].Name = "cycles";


            //DGV_X.Columns["id"].Visible = false;
        }

        private void Populate_DGV_X_Classes()
        {

            DGV_X.Rows.Clear();

            DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (Classe Obj in Classes)
            {

                var index = DGV_X.Rows.Add();
                DGV_X.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_X.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_X.Rows[index].Cells["cycles"].Value = Obj.Cycles;
                               

                // Obj.Dgv_row = DGV_X.Rows[index];
                // DGV_X.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }


            DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void DGV_X_SelectionChanged(object sender, EventArgs e)
        {


            if (InitOk)
            {

                ListIds = new List<int>();

                if (DGV_X.SelectedRows.Count == 0)
                {
                    LB_Result.Text = "Aucun eleve/personnel selecrtionné";
                    BT_Selectionner.Enabled = false;

                    return;
                }
                else if (DGV_X.SelectedRows.Count == 1)
                {
           
                    int SelectedPersonneId = int.Parse(DGV_X.CurrentRow.Cells[0].Value.ToString());
                    LB_Result.Text = "SelectedPersonneId = " + SelectedPersonneId;
                    ListIds.Add(SelectedPersonneId);

                    BT_Selectionner.Enabled = true;

                }
                else
                {
                    LB_Result.Text = DGV_X.SelectedRows.Count + " selecrtionné";

                    foreach (DataGridViewRow DGVRow in DGV_X.SelectedRows)
                    {
                        int SelectedPersonneId = int.Parse(DGVRow.Cells[0].Value.ToString());
                        ListIds.Add(SelectedPersonneId);
                    }


                    BT_Selectionner.Enabled = true;

                }


            }




        }

        private void BT_Selectionner_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TXT_DgvSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.Mode == "ELEVE_ACCOMPAGNEMENT")
            {
                String Srch = TXT_DgvSearch.Text.ToLower();

                DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                foreach (DataGridViewRow row in DGV_X.Rows)
                {

                    if (row.Cells["nom"].Value.ToString().ToLower().Contains(Srch))
                        row.Visible = true;
                    else if (row.Cells["prenom"].Value.ToString().ToLower().Contains(Srch))
                        row.Visible = true;
                    else if (row.Cells["classe"].Value.ToString().ToLower().Contains(Srch))
                        row.Visible = true;
                    else if (row.Cells["niveau"].Value.ToString().ToLower().Contains(Srch))
                        row.Visible = true;
                    else
                        row.Visible = false;

                    //More code here
                }

                DGV_X.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DGV_X.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
