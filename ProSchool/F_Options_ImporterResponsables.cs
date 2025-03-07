using Csv;
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
    public partial class F_Options_ImporterResponsables : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
               
        private string csv;
        private List<Responsable> ResponsablesOld;
        private List<Responsable> ResponsablesNew;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Options_ImporterResponsables(string csv)
        {
            InitializeComponent();
            this.csv = csv;
        }

        private void F_Options_ImporterResponsables_Load(object sender, EventArgs e)
        {

            PAN_BddInsert.Visible = false;

            Setup_DGV_Responsables(this.DGV_ResponsablesOld);
            Setup_DGV_Responsables(this.DGV_ResponsablesNew);

            ResponsablesOld = Responsable.GetListResponsablesFromBdd();
            ResponsablesNew = GetResponsablesFromCsv(csv);

            Populate_DGV_Responsables(this.DGV_ResponsablesOld, ResponsablesOld);
            Populate_DGV_Responsables(this.DGV_ResponsablesNew, ResponsablesNew);

            LB_CountResponsablesOld.Text = ResponsablesOld.Count() + " Responsables";
            LB_CountResponsablesNew.Text = ResponsablesNew.Count() + " Responsables";


            PAN_BddInsert.Visible = true;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private List<Responsable> GetResponsablesFromCsv(string csv)
        {

            List<Responsable> ResponsablesNewTemp = new List<Responsable>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();

                foreach (var line in CsvReader.ReadFromText(csv))
                {
                    // Header is handled, each line will contain the actual row data
                    var firstCell = line[0];

                    Responsable Resp = new Responsable();
                           
                    Resp.Id = 123;           //    Resp.Id = line["XXXXXXXXXXXXXXXXXX"];
                    Resp.Civilite =  line["Civilité Responsable"];
                    Resp.NomUsage = line["Nom usage responsable"];
                    Resp.Nom = line["Nom responsable"];
                    Resp.Prenom = line["Prénom responsable"];
                    Resp.Adresse = line["Adresse responsable"];
                    Resp.CodePostal = line["CP responsable"];
                    Resp.Commune = line["Commune responsable"];
                    Resp.Pays = line["Pays"];
                    Resp.Mail = line["Courriel"];
                    Resp.TelephoneDomicile = line["Téléphone domicile"];
                    Resp.TelephoneTravail = line["Téléphone travail"];
                    Resp.TelephonePortable = line["Téléphone portable"];



                    Resp.ListEleveId = new List<int>();
                    //     Resp.EleveId = Global.FindEleveIdByNomPrenom(connect, line["Nom de famille élève"], line["Prénom élève"]);

                    if (line["Nom de famille élève 1"] != "")
                    {
                       // MessageBox.Show(line["Nom de famille élève 1"]);

                        Resp.ListEleveId.Add(Eleve.FindEleveIdByNomPrenom(connect, line["Nom de famille élève 1"], line["Prénom élève 1"]));
                    }
                    
                    if (line["Nom de famille élève 2"] != "")
                    {
                        Resp.ListEleveId.Add(Eleve.FindEleveIdByNomPrenom(connect, line["Nom de famille élève 2"], line["Prénom élève 2"]));
                    }
                    if (line["Nom de famille élève 3"] != "")
                    {
                        Resp.ListEleveId.Add(Eleve.FindEleveIdByNomPrenom(connect, line["Nom de famille élève 3"], line["Prénom élève 3"]));
                    }
                    



                    ResponsablesNewTemp.Add(Resp);
                        /////////////////////  Elev.InsertInBdd();


                }

                connect.Close();
            }

            return ResponsablesNewTemp;
        }

        /*
        private void BT_ResponsablesAdd_Click(object sender, EventArgs e)
        {

        }
        private void BT_ResponsablesReplace_Click(object sender, EventArgs e)
        {
            
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM Responsables";
            command.ExecuteNonQuery();

            foreach (Responsable Elv in ResponsablesNew)
            {
                Elv.InsertInBdd(maConnexion);
            }
            maConnexion.Close();
            MessageBox.Show(ResponsablesOld.Count() + " élèves supprimés \r\n\r\n " + ResponsablesNew.Count() + " élèves ajoutés");


            this.Close();
        }
        */


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Responsables    ■■■■■■■■■■■■■■■■■■■■■■■■
        /*
        private void Setup_DGV_Responsables(DataGridView DGV_Responsables)
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
            DGV_Responsables.Columns[1].Name = "nom";
            DGV_Responsables.Columns[2].Name = "prenom";
            DGV_Responsables.Columns[3].Name = "dateNaissance";
            DGV_Responsables.Columns[4].Name = "sexe";
            DGV_Responsables.Columns[5].Name = "ine";
            DGV_Responsables.Columns[6].Name = "cycle";
            DGV_Responsables.Columns[7].Name = "niveau";
            DGV_Responsables.Columns[8].Name = "classeId";
            DGV_Responsables.Columns[9].Name = "attestation";
            DGV_Responsables.Columns[10].Name = "autorisationPhoto";
            DGV_Responsables.Columns[11].Name = "decisionPassage";
            DGV_Responsables.Columns[12].Name = "dispositifs";


            //DGV_Responsables.Columns["xxxxxxxx"].Width = 350;

            //DGV_Responsables.Columns["xxxxxxxx"].Visible = false;

        }

        private void Populate_DGV_Responsables(DataGridView DGV_Responsables, List<Responsable> Responsables)
        {

            DGV_Responsables.Rows.Clear();

            foreach (Responsable Obj in Responsables)
            {

                var index = DGV_Responsables.Rows.Add();
                DGV_Responsables.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Responsables.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Responsables.Rows[index].Cells["prenom"].Value = Obj.Prenom;
             
                // Obj.Dgv_row = DGV_Responsables.Rows[index];
                // DGV_Responsables.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
*/
        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Responsables    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Responsables(DataGridView DGV_Responsables)
        {


            DGV_Responsables.ColumnCount = 14;

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


            DGV_Responsables.Columns[0].Name = "eleves";
            DGV_Responsables.Columns[1].Name = "id";
            DGV_Responsables.Columns[2].Name = "civilite";
            DGV_Responsables.Columns[3].Name = "nomUsage";
            DGV_Responsables.Columns[4].Name = "nom";
            DGV_Responsables.Columns[5].Name = "prenom";
            DGV_Responsables.Columns[6].Name = "adresse";
            DGV_Responsables.Columns[7].Name = "codePostal";
            DGV_Responsables.Columns[8].Name = "commune";
            DGV_Responsables.Columns[9].Name = "pays";
            DGV_Responsables.Columns[10].Name = "mail";
            DGV_Responsables.Columns[11].Name = "telephoneDomicile";
            DGV_Responsables.Columns[12].Name = "telephoneTravail";
            DGV_Responsables.Columns[13].Name = "telephonePortable";


            //DGV_Responsables.Columns["xxxxxxxx"].Width = 350;

            //DGV_Responsables.Columns["xxxxxxxx"].Visible = false;

        }



        private void Populate_DGV_Responsables(DataGridView DGV_Responsables, List<Responsable> Responsables)
        {

            DGV_Responsables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Responsables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Responsables.Rows.Clear();

            foreach (Responsable Obj in Responsables)
            {

             //   MessageBox.Show("Line " + Obj.Nom);
                var index = DGV_Responsables.Rows.Add();
                //DGV_Responsables.Rows[index].Cells["eleves"].Value = Obj.EleveId;
             DGV_Responsables.Rows[index].Cells["eleves"].Value = Obj.ListEleveId.Count();
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

        private void BT_ResponsablesAdd_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            SQLiteCommand command = new SQLiteCommand(maConnexion);

            foreach (Responsable CC in ResponsablesNew)
            {
                CC.InsertInBdd_WithEleves(command, maConnexion);
            }

            maConnexion.Close();
            MessageBox.Show(ResponsablesNew.Count() + " Responsables ajoutées à l'ancienne liste");

      //      F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
      //      formm.ShowDialog();
            this.Close();
        }

        private void BT_ResponsablesReplace_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();


            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM responsables";
            command.ExecuteNonQuery();

            command.CommandText = "DELETE FROM eleves_responsables";
            command.ExecuteNonQuery();



            foreach (Responsable CC in ResponsablesNew)
            {
                CC.InsertInBdd_WithEleves(command, maConnexion);
            }

            maConnexion.Close();
            MessageBox.Show(ResponsablesNew.Count() + " Responsables ajoutées à l'ancienne liste");

            F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
            formm.ShowDialog();
            this.Close();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
