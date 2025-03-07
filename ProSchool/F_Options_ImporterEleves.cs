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
    public partial class F_Options_ImporterEleves : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private string csv;
        private List<Eleve> ElevesOld;
        private List<Eleve> ElevesNew;

        private List<Eleve> ElevesMix;

        private List<Eleve> ElevesDelete ;
        private List<Eleve> ElevesCreate;
        private List<Eleve> ElevesUpdate;
        private List<Eleve> ElevesUnchanged;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_Options_ImporterEleves(string csv)
        {
            InitializeComponent();
            this.csv = csv;
        }

        private void F_Options_ImporterEleves_Load(object sender, EventArgs e)
        {

            PAN_BddInsert.Visible = false;

         
            Setup_DGV_Eleves(this.DGV_ElevesNew);
            
            ElevesOld = Eleve.GetListElevesFromBdd();
            ElevesNew = GetElevesFromCsv(csv);

            mixerEleves();

            LB_Resume.Text = ElevesCreate.Count() + "   élèves à ajouter" + "\r\n";
            LB_Resume.Text += ElevesDelete.Count() + "   élèves à supprimer" + "\r\n";
            LB_Resume.Text += ElevesUpdate.Count() + "   élèves à modifier" + "\r\n";
            LB_Resume.Text += ElevesUnchanged.Count() + "   élèves sans changement" + "\r\n";

            //   Populate_DGV_Eleves(this.DGV_ElevesNew, ElevesNew);
            Populate_DGV_Eleves(this.DGV_ElevesNew, ElevesMix);

            LB_CountElevesOld.Text = ElevesOld.Count() + " Eleves";
            LB_CountElevesNew.Text = ElevesNew.Count() + " Eleves";
            

            PAN_BddInsert.Visible = true;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        public void mixerEleves()
        {
            ElevesMix = new List<Eleve>();

            ElevesDelete = new List<Eleve>();
            ElevesCreate = new List<Eleve>();
            ElevesUpdate = new List<Eleve>();
            ElevesUnchanged = new List<Eleve>();

            foreach (Eleve Elv_New in ElevesNew)
            {
                Elv_New.ImportInfos = "---";

                foreach (Eleve Elv_Old in ElevesOld)
                {
                    if (Elv_New.Ine == Elv_Old.Ine)
                    {

                        Elv_New.ImportInfos = "";
                        Elv_New.Id = Elv_Old.Id;
             
                        if (Elv_New.Nom != Elv_Old.Nom)
                        {
                            Elv_New.ImportInfos += "Nom, ";
                        }
                        if (Elv_New.Prenom != Elv_Old.Prenom)
                        {
                            Elv_New.ImportInfos += "Prenom, ";
                        }
                        if (Elv_New.DateNaissance != Elv_Old.DateNaissance)
                        {
                            Elv_New.ImportInfos += "DateNaissance, ";
                        }






                        //Elv_New.ImportInfos = "MatchNew";
                        Elv_Old.ImportInfos = "MatchOld";
                        break;
                    }


                }
              

                if (Elv_New.ImportInfos == "---")
                {
                    Elv_New.ImportInfos = "Nouvel élève";
                    ElevesCreate.Add(Elv_New);

                }  
                else if (Elv_New.ImportInfos != "")
                {
                    ElevesUpdate.Add(Elv_New);

                }
                else
                {
                    ElevesUnchanged.Add(Elv_New);

                }
                ElevesMix.Add(Elv_New);
                
            
            }
            
            foreach (Eleve Elv_Old in ElevesOld)
            {
                if (Elv_Old.ImportInfos != "MatchOld")
                {
                    Elv_Old.ImportInfos = "A Supprimer";
                    ElevesDelete.Add(Elv_Old);
                    ElevesMix.Add(Elv_Old);
                }
            }
            
        }

        private List<Eleve> GetElevesFromCsv(string csv)
        {

            List<Eleve>  ElevesNewTemp = new List<Eleve>();

            foreach (var line in CsvReader.ReadFromText(csv))
            {
                // Header is handled, each line will contain the actual row data
                var firstCell = line[0];

                Eleve Elev = new Eleve();

                //    Elev.Id = line["XXXXXXXXXXXXXXXXXX"];
                Elev.Id = 123;
                Elev.Nom = line["Nom élève"];
                Elev.Prenom = line["Prénom élève"];
                Elev.DateNaissance = line["Date naissance"];
                Elev.Sexe = line["Sexe"];
                Elev.Ine = line["INE"];
                Elev.Cycle = line[" Cycle"];    // espace devant cycle ???????????????
                Elev.Niveau = line["Niveau"];
                Elev.ClasseId = (line["Identifiant classe"] != "") ? Int32.Parse(line["Identifiant classe"]) : 0;                                
                //    Elev.Attestation = line["Attestation fournie"];
                Elev.Attestation = "???";
                //     Elev.autorisationPhoto = line["Autorisation photo"];
                Elev.AutorisationPhoto = "???";
                Elev.DecisionPassage = line["Décision de passage"];
                Elev.Dispositifs = line["Dispositif(s)"];

                Elev.Delegue = false;

                ElevesNewTemp.Add(Elev);

                /////////////////////  Elev.InsertInBdd();



            }

            return ElevesNewTemp;
        }


        private void BT_ElevesAdd_Click(object sender, EventArgs e)
        {

        }
        private void BT_ElevesReplace_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM eleves";
            command.ExecuteNonQuery();

            foreach (Eleve Elv in ElevesNew)
            {
                Elv.InsertInBdd(maConnexion);
            }
            maConnexion.Close();
            MessageBox.Show(ElevesOld.Count() + " élèves supprimés \r\n\r\n " + ElevesNew.Count() + " élèves ajoutés");


            this.Close();
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Eleves    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Eleves(DataGridView DGV_Eleves)
        {


            DGV_Eleves.ColumnCount = 14;

            DGV_Eleves.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Eleves.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Eleves.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Eleves.Font, FontStyle.Bold);
            DGV_Eleves.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Eleves.ColumnHeadersHeight = 40;

            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Eleves.RowHeadersVisible = false;
            DGV_Eleves.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Eleves.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Eleves.GridColor = Color.Black;

            DGV_Eleves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Eleves.MultiSelect = false;
            DGV_Eleves.AllowUserToAddRows = false;


            DGV_Eleves.Columns[0].Name = "id";
            DGV_Eleves.Columns[1].Name = "nom";
            DGV_Eleves.Columns[2].Name = "prenom";
            DGV_Eleves.Columns[3].Name = "dateNaissance";
            DGV_Eleves.Columns[4].Name = "sexe";
            DGV_Eleves.Columns[5].Name = "ine";
            DGV_Eleves.Columns[6].Name = "cycle";
            DGV_Eleves.Columns[7].Name = "niveau";
            DGV_Eleves.Columns[8].Name = "classeId";
            DGV_Eleves.Columns[9].Name = "attestation";
            DGV_Eleves.Columns[10].Name = "autorisationPhoto";
            DGV_Eleves.Columns[11].Name = "decisionPassage";
            DGV_Eleves.Columns[12].Name = "dispositifs";
            DGV_Eleves.Columns[13].Name = "ImportInfos";


            //DGV_Eleves.Columns["xxxxxxxx"].Width = 350;

            //DGV_Eleves.Columns["xxxxxxxx"].Visible = false;

        }
               
        private void Populate_DGV_Eleves(DataGridView DGV_Eleves, List<Eleve> Eleves)
        {

            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Eleves.Rows.Clear();

            foreach (Eleve Obj in Eleves)
            {

                var index = DGV_Eleves.Rows.Add();
                DGV_Eleves.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Eleves.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Eleves.Rows[index].Cells["prenom"].Value = Obj.Prenom;
                DGV_Eleves.Rows[index].Cells["dateNaissance"].Value = Obj.DateNaissance;
                DGV_Eleves.Rows[index].Cells["sexe"].Value = Obj.Sexe;
                DGV_Eleves.Rows[index].Cells["ine"].Value = Obj.Ine;
                DGV_Eleves.Rows[index].Cells["cycle"].Value = Obj.Cycle;
                DGV_Eleves.Rows[index].Cells["niveau"].Value = Obj.Niveau;
                DGV_Eleves.Rows[index].Cells["classeId"].Value = Obj.ClasseId;
                DGV_Eleves.Rows[index].Cells["attestation"].Value = Obj.Attestation;
                DGV_Eleves.Rows[index].Cells["autorisationPhoto"].Value = Obj.AutorisationPhoto;
                DGV_Eleves.Rows[index].Cells["decisionPassage"].Value = Obj.DecisionPassage;
                DGV_Eleves.Rows[index].Cells["dispositifs"].Value = Obj.Dispositifs;
                DGV_Eleves.Rows[index].Cells["ImportInfos"].Value = Obj.ImportInfos;

                // Obj.Dgv_row = DGV_Eleves.Rows[index];
                // DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;


                if (Obj.ImportInfos == "")
                {
                    DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }

                if (Obj.ImportInfos == "A Supprimer")
                {
                    DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                }
                if (Obj.ImportInfos == "Nouvel élève")
                {
                    DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                }

            }
            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void BT_ElevesUpdate_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();



            foreach (Eleve CC in ElevesDelete)
            {

                //     utiliser CC.SupprimerInBdd(maConnexion);
                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves WHERE id=" + CC.Id + "";
                command.ExecuteNonQuery();


                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM accompagnements_eleves WHERE Eleve_id=" + CC.Id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM appels WHERE Eleve_id=" + CC.Id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_personnels WHERE Eleve_id=" + CC.Id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_responsables WHERE Eleve_id=" + CC.Id + "";
                command.ExecuteNonQuery();

            }

            foreach (Eleve Elv in ElevesCreate)
            {
                Elv.InsertInBdd(maConnexion);
            }

            foreach (Eleve CC in ElevesUpdate)
            {
                //  MessageBox.Show(CC.Nom);
                CC.UpdateInBdd(maConnexion);
            }



            maConnexion.Close();
            MessageBox.Show(ElevesDelete.Count() + " Eleves supprimées \r\n\r\n " + ElevesCreate.Count() + " Eleves ajoutées \r\n\r\n " + ElevesUpdate.Count() + " Eleves modifiées");


           // F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
           // formm.ShowDialog();

            this.Close();
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
