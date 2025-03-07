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
    public partial class F_Options_ImporterClasses : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private string csv;
        private List<Classe> ClassesOld;
        private List<Classe> ClassesNew;
        private List<Classe> ClassesMix;

        private List<Classe> ClassesDelete;
        private List<Classe> ClassesCreate;
        private List<Classe> ClassesUpdate;
        private List<Classe> ClassesUnchanged;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Options_ImporterClasses(string csv)
        {
            InitializeComponent();
            this.csv = csv;
        }

        private void F_Options_ImporterClasses_Load(object sender, EventArgs e)
        {

            PAN_BddInsert.Visible = false;

          //  Setup_DGV_Classes(this.DGV_ClassesOld);
            Setup_DGV_Classes(this.DGV_ClassesNew);

            ClassesOld = Classe.Bdd_GetClasses_OrderByName();
            ClassesNew = GetClassesFromCsv(csv);


            mixerClassesOldNew();

            LB_Resume.Text = ClassesCreate.Count() + "   classe à ajouter" + "\r\n";
            LB_Resume.Text += ClassesDelete.Count() + "   classe à supprimer" + "\r\n";
            LB_Resume.Text += ClassesUpdate.Count() + "   classe à modifier" + "\r\n";
            LB_Resume.Text += ClassesUnchanged.Count() + "   classe sans changement" + "\r\n";



        //    Populate_DGV_Classes(this.DGV_ClassesOld, ClassesOld);
        //     Populate_DGV_Classes(this.DGV_ClassesNew, ClassesNew);
            Populate_DGV_Classes(this.DGV_ClassesNew, ClassesMix);
            
            LB_CountClassesOld.Text = ClassesOld.Count() + " classes";
            LB_CountClassesNew.Text = ClassesNew.Count() + " classes";


            PAN_BddInsert.Visible = true;
        }
        

        public void mixerClassesOldNew()
        {
            ClassesMix = new List<Classe>();

            ClassesDelete = new List<Classe>();
            ClassesCreate = new List<Classe>();
            ClassesUpdate = new List<Classe>();
            ClassesUnchanged = new List<Classe>();

            foreach (Classe Cl_New in ClassesNew)
            {
                Cl_New.ImportInfos = "---";

                foreach (Classe Cl_Old in ClassesOld)
                {
                    if (Cl_New.Nom == Cl_Old.Nom)   //if (Cl_New.Identifiant == Cl_Old.Identifiant)
                    {

                        Cl_New.ImportInfos = "";
                        Cl_New.Id = Cl_Old.Id;
                        Cl_New.ImportNewNom = "";
                        Cl_New.ImportNewcycles = "";
                        /*
                        if (Cl_New.Nom != Cl_Old.Nom)
                        {
                            Cl_New.ImportNewNom = Cl_New.Nom;
                            Cl_New.Nom = Cl_Old.Nom;
                            Cl_New.ImportInfos = "Modifications";
                        }
                        */
                        if (Cl_New.Identifiant != Cl_Old.Identifiant)
                        {
                            Cl_New.ImportNewIdentifiant = Cl_New.Identifiant;
                            Cl_New.Identifiant = Cl_Old.Identifiant;
                            Cl_New.ImportInfos = "Modifications";
                        }
                        if (Cl_New.Cycles != Cl_Old.Cycles)
                        {
                            Cl_New.ImportNewcycles = Cl_New.Cycles;
                            Cl_New.Cycles = Cl_Old.Cycles;
                            Cl_New.ImportInfos = "Modifications";
                        }



                        Cl_Old.ImportInfos = "MatchOld";
                        break;
                    }


                }


                if (Cl_New.ImportInfos == "---")
                {
                    Cl_New.ImportInfos = "Nouvelle Classe";
                    ClassesCreate.Add(Cl_New);

                }
                else if (Cl_New.ImportInfos == "Modifications")
                {
                    if (Cl_New.ImportNewNom != "")
                        Cl_New.Nom = Cl_New.ImportNewNom;
                    if (Cl_New.ImportNewcycles != "")
                        Cl_New.Cycles = Cl_New.ImportNewcycles;
                    ClassesUpdate.Add(Cl_New);

                }
                else
                {
                    ClassesUnchanged.Add(Cl_New);

                }
                ClassesMix.Add(Cl_New);
            }

            foreach (Classe Cl_Old in ClassesOld)
            {
                if (Cl_Old.ImportInfos != "MatchOld")
                {
                    Cl_Old.ImportInfos = "A Supprimer";
                    ClassesDelete.Add(Cl_Old);
                    ClassesMix.Add(Cl_Old);
                }
            }


        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■
        private List<Classe> GetClassesFromCsv(string csv)
        {
            List<Classe> ClassesNewTemp = new List<Classe>();

            int ClasseId = 0;
            ClassesNewTemp = new List<Classe>();

            Classe ClasseVide = new Classe();
            ClasseVide.Id = ClasseId;
            ClasseVide.Identifiant = 0;
            ClasseVide.Nom = "Elèves sans classe";
            ClasseVide.Cycles = "";
            ClassesNewTemp.Add(ClasseVide);

            foreach (var line in CsvReader.ReadFromText(csv))
            {
                if (line["Libellé classe"] != "")
                {
                    Classe Cl = new Classe(line);

                    Boolean existeDeja = false;
                    foreach (Classe CC in ClassesNewTemp)
                    {
                        if (Cl.Nom == CC.Nom)
                        {
                            existeDeja = true;
                            break;
                        }
                    }
                    if (!existeDeja)
                    {
                        ClasseId++;
                        Cl.Id = ClasseId;
                        ClassesNewTemp.Add(Cl);
                    }
                }
            }
            return ClassesNewTemp;
        }
         
        private void BT_ClassesAdd_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();                       
            foreach (Classe CC in ClassesNew)
            {
                CC.InsertInBdd(maConnexion);
            }
            maConnexion.Close();
            MessageBox.Show(ClassesNew.Count() + " classes ajoutées à l'ancienne liste de classes");


            F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
            formm.ShowDialog();

            this.Close();

        }

        private void BT_ClassesReplace_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM classes";
            command.ExecuteNonQuery();
            
            foreach (Classe CC in ClassesNew)
            {
                CC.InsertInBdd_WithId(maConnexion);
            }
            maConnexion.Close();
            MessageBox.Show(ClassesOld.Count() + " classes supprimées \r\n\r\n " + ClassesNew.Count() + " classes ajoutées");


            F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
            formm.ShowDialog();

            this.Close();

        }
               
        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Classes    ■■■■■■■■■■■■■■■■■■■■■■■■
        private void Setup_DGV_Classes(DataGridView DGV_Classes)
        {

            DGV_Classes.ColumnCount = 7;

            DGV_Classes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Classes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Classes.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Classes.Font, FontStyle.Bold);
            DGV_Classes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Classes.ColumnHeadersHeight = 40;

            DGV_Classes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Classes.RowHeadersVisible = false;
            DGV_Classes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Classes.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Classes.GridColor = Color.Black;

            DGV_Classes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Classes.MultiSelect = false;
            DGV_Classes.AllowUserToAddRows = false;

            DGV_Classes.Columns[0].Name = "id";
            DGV_Classes.Columns[1].Name = "identifiant";
            DGV_Classes.Columns[2].Name = "nom";
            DGV_Classes.Columns[3].Name = "nouveau nom";
            DGV_Classes.Columns[4].Name = "cycles";
            DGV_Classes.Columns[5].Name = "nouveau cycles";
            DGV_Classes.Columns[6].Name = "import";

            //DGV_Classes.Columns["xxxxxxxx"].Width = 350;
            //DGV_Classes.Columns["xxxxxxxx"].Visible = false;

        }

        private void Populate_DGV_Classes(DataGridView DGV_Classes, List<Classe> Classes)
        {


            DGV_Classes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Classes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Classes.Rows.Clear();

            foreach (Classe Obj in Classes)
            {

                var index = DGV_Classes.Rows.Add();
                DGV_Classes.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Classes.Rows[index].Cells["identifiant"].Value = Obj.Identifiant;
                DGV_Classes.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Classes.Rows[index].Cells["cycles"].Value = Obj.Cycles;
                DGV_Classes.Rows[index].Cells["nouveau nom"].Value = Obj.ImportNewNom;
                DGV_Classes.Rows[index].Cells["nouveau cycles"].Value = Obj.ImportNewcycles;
                DGV_Classes.Rows[index].Cells["import"].Value = Obj.ImportInfos;


                // Obj.Dgv_row = DGV_Classes.Rows[index];



                if (Obj.ImportInfos == "")
                {
                    DGV_Classes.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }

                if (Obj.ImportInfos == "A Supprimer")
                {
                    DGV_Classes.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255,200,200);
                }
                if (Obj.ImportInfos == "Nouvelle Classe")
                {
                    DGV_Classes.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255,255,200);
                }

            }

            DGV_Classes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Classes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void BT_ClassesUpdate_Click(object sender, EventArgs e)
        {
            PAN_BddInsert.Visible = false;
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();



            foreach (Classe CC in ClassesDelete)
            {

                //     utiliser CC.SupprimerInBdd(maConnexion);
                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM classes WHERE id=" + CC.Id + "";
                command.ExecuteNonQuery();


                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM classes_personnels WHERE classe_id=" + CC.Id + "";
                command.ExecuteNonQuery();

            }

            foreach (Classe CC in ClassesCreate)
            {
                CC.InsertInBdd(maConnexion);
            }
            
            foreach (Classe CC in ClassesUpdate)
            {
              //  MessageBox.Show(CC.Nom);
                CC.UpdateInBdd(maConnexion);
            }



            maConnexion.Close();
            MessageBox.Show(ClassesDelete.Count() + " classes supprimées \r\n\r\n " + ClassesCreate.Count() + " classes ajoutées \r\n\r\n " + ClassesUpdate.Count() + " classes modifiées");


            F_Options_ImporterEleves formm = new F_Options_ImporterEleves(csv);
            formm.ShowDialog();

            this.Close();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
