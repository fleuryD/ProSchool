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
    public partial class F_Accompagnements_Recap : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Eleve> Eleves;
        private List<Accompagnement> Accompagnements;
        private Dictionary<int, Classe> Dico_Idents_Classes;

        private Color Color1 = Global.Color_Menu_Eleves;
        private Color Color2 = Global.Color_Menu_Eleves2;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Accompagnements_Recap()
        {
            InitializeComponent();

            this.DGV_Accompagnements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Accompagnements_CellDoubleClick);
        }


        private void F_Accompagnements_Load(object sender, EventArgs e)
        {
            REFRESH_ALL();


        }


        private void REFRESH_ALL()
        {
         //   DateTime start = DateTime.Now;

            DGV_Accompagnements.Rows.Clear();



            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            Eleves = Eleve.Bdd_GetEleves_OrderByNom(maConnexion);
            Dico_Idents_Classes = Classe.Get_Dico_Idents_Classes_FromBdd(maConnexion);
            Accompagnements = Accompagnement.Bdd_GetAccompagnements_OrderByPosition(maConnexion);

            foreach (Eleve Elv in Eleves)
            {
                Elv.Accompagnements = Accompagnement.GetListAccompagnementsByEleveId(Elv.Id, Accompagnements, maConnexion);
            }

            maConnexion.Close();


         //   TimeSpan dur = DateTime.Now - start;
          //  LB_Debug.Text = dur.ToString();

            Setup_DGV_Accompagnements();
            Populate_DGV_Accompagnements();

            ToggleEmptyColumns();

           // dur = DateTime.Now - start;
          //  LB_Debug.Text += "\r\n" + dur.ToString();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Accompagnements    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Accompagnements()
        {


            DGV_Accompagnements.ColumnCount = 3;


            DGV_Accompagnements.EnableHeadersVisualStyles = false;  // pour changer la couleur du header
            DGV_Accompagnements.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Accompagnements.Font.FontFamily, 8f, FontStyle.Regular);
            DGV_Accompagnements.ColumnHeadersDefaultCellStyle.ForeColor = Color1;
           // DGV_Accompagnements.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         
            DGV_Accompagnements.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Accompagnements.ColumnHeadersHeight = 40;
            
            DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Accompagnements.RowHeadersVisible = false;
            DGV_Accompagnements.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Accompagnements.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Accompagnements.GridColor = Color.Black;

            DGV_Accompagnements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Accompagnements.MultiSelect = true;
            DGV_Accompagnements.AllowUserToAddRows = false;

            DGV_Accompagnements.DefaultCellStyle.SelectionBackColor = Color1;
            DGV_Accompagnements.DefaultCellStyle.SelectionForeColor = Color.White;


            DGV_Accompagnements.Columns[0].Name = "id";
            DGV_Accompagnements.Columns[1].Name = "Elève";
            DGV_Accompagnements.Columns[2].Name = "Classe";

            foreach(Accompagnement Acc in Accompagnements)
            {
                DGV_Accompagnements.ColumnCount++;
                DGV_Accompagnements.Columns[DGV_Accompagnements.ColumnCount - 1].Name = Acc.NomSimple;
                DGV_Accompagnements.Columns[DGV_Accompagnements.ColumnCount - 1].Width = 55;
            }


            //  DGV_Accompagnements.Columns["xxxxxxxx"].Width = 350;
            DGV_Accompagnements.Columns["id"].Visible = false;

        }

        private void Populate_DGV_Accompagnements()
        {

            DGV_Accompagnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Accompagnements.Rows.Clear();

            foreach (Eleve Elv in Eleves.Where(X => X.Accompagnements.Count() > 0))
            {
                var index = DGV_Accompagnements.Rows.Add();
                DGV_Accompagnements.Rows[index].Cells["id"].Value = Elv.Id;
                DGV_Accompagnements.Rows[index].Cells["Elève"].Value = Elv.Nom + " " + Elv.Prenom;
                DGV_Accompagnements.Rows[index].Cells["Classe"].Value = "";
                if (Dico_Idents_Classes.ContainsKey(Elv.ClasseId))
                {
                    DGV_Accompagnements.Rows[index].Cells["classe"].Value = Dico_Idents_Classes[Elv.ClasseId].Nom;
                }

                foreach (Accompagnement AccEleve in Elv.Accompagnements)
                {
                    DGV_Accompagnements.Rows[index].Cells[AccEleve.NomSimple].Value = "OUI";
                    DGV_Accompagnements.Rows[index].Cells[AccEleve.NomSimple].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGV_Accompagnements.Rows[index].Cells[AccEleve.NomSimple].Style.BackColor = Color2;
                    //DGV_Accompagnements.Rows[index].Cells[AccEleve.NomSimple].Style.SelectionBackColor = Color2;
                    //DGV_Accompagnements.Rows[index].Cells[AccEleve.NomSimple].Style.SelectionForeColor = Color.Black;
                }

                // Obj.Dgv_row = DGV_Accompagnements.Rows[index];
                // DGV_Accompagnements.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }



            //      DGV_Accompagnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Accompagnements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Accompagnements.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Accompagnements.Columns["Elève"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Accompagnements.Columns["classe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            DGV_Accompagnements.ClearSelection();
        }

        private void CB_HideEmptyCol_CheckedChanged(object sender, EventArgs e)
        {

            ToggleEmptyColumns();


        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void ToggleEmptyColumns()
        {



            for(int colIndex = 3; colIndex < DGV_Accompagnements.ColumnCount; colIndex++)
            {

                if (CB_HideEmptyCol.Checked)
                {
                    Boolean colVide = true;
                    for (int rowIndex = 0; rowIndex < DGV_Accompagnements.RowCount; rowIndex++)
                    {
                        if (DGV_Accompagnements.Rows[rowIndex].Cells[colIndex].Value != null)
                        {
                            colVide = false;
                            break;
                        }
                    }
                    if (colVide)
                    {
                        DGV_Accompagnements.Columns[colIndex].Visible = false;
                    }
                }
                else
                {
                    DGV_Accompagnements.Columns[colIndex].Visible = true;
                }

                



            }



        }

        private void BT_EditListeAccompagnements_Click(object sender, EventArgs e)
        {

            using (F_Accompagnements_Options form = new F_Accompagnements_Options())
            {
                var result = form.ShowDialog();
                /*
                if (result == DialogResult.OK)
                {
                    REFRESH_ALL();
                }
                */
            }
            REFRESH_ALL();

        }

        private void BT_EleveAdd_Click(object sender, EventArgs e)
        {
            F_SelectPersonnelsEleves Frm = new F_SelectPersonnelsEleves(Eleves, Dico_Idents_Classes, "ELEVE_ACCOMPAGNEMENT");
            Frm.MultiSelect = false;
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int NewSelectedEleveId = Frm.ListIds.First();

                Ouvrir_F_Accompagnement_Eleve(NewSelectedEleveId);


            }
             
        }

        private void DGV_Accompagnements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Accompagnements.SelectedRows.Count == 1)
            {
                int SelectedEleveId = int.Parse(DGV_Accompagnements.CurrentRow.Cells[0].Value.ToString());
                Ouvrir_F_Accompagnement_Eleve(SelectedEleveId);
            }
        }



        private void Ouvrir_F_Accompagnement_Eleve(int EleveId)
        {

            Eleve SelectedEleve = Eleves.Where(X => X.Id == EleveId).First();
            using (var form = new F_Accompagnement_Eleve(SelectedEleve, Accompagnements))
            {
                var result2 = form.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    REFRESH_ALL();
                }
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
