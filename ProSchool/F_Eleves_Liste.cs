
using System.Data;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Eleves_Liste : Form
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Color Color1 = Global.Color_Menu_Eleves;
        private Color Color2 = Global.Color_Menu_Eleves2;
        private bool InitOk;
        private List<Eleve> Eleves;
        private List<Accompagnement> Accompagnements;
        private Eleve SelectedEleve;

        private Dictionary<int, Classe> Dico_Idents_Classes;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

            
        public F_Eleves_Liste()
        {
            InitializeComponent();


            LB_Eleve_Id.ForeColor = Color1;
            LB_Eleve_Nom.ForeColor = Color1;
            LB_Eleve_Prenom.ForeColor = Color.Black;
            LB_Eleve_DateNaissance.ForeColor = Color1;
            LB_Eleve_Age.ForeColor = Color.Black;
            LB_Eleve_Sexe.ForeColor = Color1;
            LB_Eleve_Ine.ForeColor = Color1;
            LB_Profs.ForeColor = Color1;
            LB_Eleve_Cycle.ForeColor = Color1;
            LB_Eleve_Niveau.ForeColor = Color1;
            LB_Eleve_ClasseId.ForeColor = Color1;
            LB_Eleve_Classe.ForeColor = Color1;
            LB_Eleve_Attestation.ForeColor = Color1;
            LB_Eleve_AutorisationPhoto.ForeColor = Color1;
            LB_Eleve_DecisionPassage.ForeColor = Color1;
            LB_Eleve_Dispositifs.ForeColor = Color1;
            LB_Alae.ForeColor = Color1;
            LB_Delegue.ForeColor = Color1;
            LB_Garderie.ForeColor = Color1;
            LB_DpExt.ForeColor = Color1;

       //     FLP_Classe.BackColor = Color2;

        }
        
        private void F_Eleves_Liste_Load(object sender, EventArgs e)
        {



            InitOk = false;

          //  PAN_HeaderNom.Visible = true;
            PAN_Header.Visible = true;
          //  PAN_Module_Accompagnements.Visible = false;
        //    PAN_Todo.Visible = false;
            PAN_Nom.Visible = false;
            FLP_Classe.Visible = false;
            FLP_Personnels.Visible = false;
            FLP_Attest.Visible = false;
            FLP_SexeAge.Visible = false;
            PAN_SuivisSuper.Visible = false;
            FLP_AlaeGarderie.Visible = false;
          //  PAN_Module_Absence.Visible = false;
            BT_EleveDelete.Visible = false;


            FLP_Modules.Visible = false;

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            Eleves = Eleve.Bdd_GetEleves_OrderByNom(maConnexion);
            Accompagnements = Accompagnement.Bdd_GetAccompagnements_OrderByPosition(maConnexion);
            Dico_Idents_Classes = Classe.Get_Dico_Idents_Classes_FromBdd(maConnexion);

            maConnexion.Close();

            if (Eleves.Count() == 0)
            {
                MessageBox.Show("Il n'y a aucun élève dans la liste.\r\n\r\nAllez dans \"Parametres\\Importer\"");
            }

            Setup_DGV_Eleves();
            Populate_DGV_Eleves();

            Global.Ajust_SplitCont_Width_from_DGV(DGV_Eleves, splitContainer1, 30);

            DGV_Eleves.ClearSelection();
            InitOk = true;

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Eleves    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Eleves()
        {


            DGV_Eleves.ColumnCount = 20;

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
            DGV_Eleves.Columns[8].Name = "classe";
            DGV_Eleves.Columns[9].Name = "attestation";
            DGV_Eleves.Columns[10].Name = "autorisationPhoto";
            DGV_Eleves.Columns[11].Name = "decisionPassage";
            DGV_Eleves.Columns[12].Name = "dispositifs";


            DGV_Eleves.Columns[13].Name = "delegue";
            DGV_Eleves.Columns[14].Name = "dpExterne";
            DGV_Eleves.Columns[15].Name = "garderie";
            DGV_Eleves.Columns[16].Name = "alae";



            DGV_Eleves.Columns[17].Name = "date_entree";
            DGV_Eleves.Columns[18].Name = "date_sortie";
            DGV_Eleves.Columns[19].Name = "import_genre";



            //DGV_Eleves.Columns["xxxxxxxx"].Width = 350;
            
                 DGV_Eleves.Columns["id"].Visible = false;
                DGV_Eleves.Columns["sexe"].Visible = false;
                DGV_Eleves.Columns["ine"].Visible = false;
                DGV_Eleves.Columns["cycle"].Visible = false;
                DGV_Eleves.Columns["dateNaissance"].Visible = false;
                DGV_Eleves.Columns["attestation"].Visible = false;
                DGV_Eleves.Columns["autorisationPhoto"].Visible = false;
                DGV_Eleves.Columns["decisionPassage"].Visible = false;
                DGV_Eleves.Columns["dispositifs"].Visible = false;
                DGV_Eleves.Columns["delegue"].Visible = false;
                DGV_Eleves.Columns["dpExterne"].Visible = false;
                DGV_Eleves.Columns["garderie"].Visible = false;
                DGV_Eleves.Columns["alae"].Visible = false;
                DGV_Eleves.Columns["date_entree"].Visible = false;
                DGV_Eleves.Columns["date_sortie"].Visible = false;
                DGV_Eleves.Columns["import_genre"].Visible = false;
                


        }
               
        private void Populate_DGV_Eleves()
        {

            DGV_Eleves.Rows.Clear();

            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

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
                if (Dico_Idents_Classes.ContainsKey(Obj.ClasseId))
                {
                    DGV_Eleves.Rows[index].Cells["classe"].Value = Dico_Idents_Classes[Obj.ClasseId].Nom;
                }
                DGV_Eleves.Rows[index].Cells["attestation"].Value = Obj.Attestation;
                DGV_Eleves.Rows[index].Cells["autorisationPhoto"].Value = Obj.AutorisationPhoto;
                DGV_Eleves.Rows[index].Cells["decisionPassage"].Value = Obj.DecisionPassage;
                DGV_Eleves.Rows[index].Cells["dispositifs"].Value = Obj.Dispositifs;
                DGV_Eleves.Rows[index].Cells["dpExterne"].Value = Obj.DpExterne;
                DGV_Eleves.Rows[index].Cells["garderie"].Value = Obj.Garderie;
                DGV_Eleves.Rows[index].Cells["alae"].Value = Obj.Alae;
                DGV_Eleves.Rows[index].Cells["date_entree"].Value = Obj.DateEntree;
                DGV_Eleves.Rows[index].Cells["date_sortie"].Value = Obj.DateSortie;
                DGV_Eleves.Rows[index].Cells["import_genre"].Value = Obj.ImportGenre;

                //DGV_Eleves.Rows[index].Cells["delegue"].Value = Obj.Delegue.ToString();
                if (Obj.Delegue)
                {
                    DGV_Eleves.Rows[index].Cells["delegue"].Value = "OUI";
                }

                DGV_Eleves.Rows[index].Cells["dpExterne"].Value = Obj.DpExterne;
                if (Obj.DpExterne == "DP")
                {
                    DGV_Eleves.Rows[index].Cells["dpExterne"].Style.BackColor = Color.LightPink;
                }


                // Obj.Dgv_row = DGV_Eleves.Rows[index];
                // DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }


            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void DGV_Eleves_SelectionChanged(object sender, EventArgs e)
        {

            if (InitOk)
            {

                if (DGV_Eleves.SelectedRows.Count == 0)
                {
                    return;
                }
                else if (DGV_Eleves.SelectedRows.Count == 1)
                {
                    int SelectedEleveId = int.Parse(DGV_Eleves.CurrentRow.Cells[0].Value.ToString());

                    SelectedEleve = Eleve.GetEleveByIdFromBdd(SelectedEleveId);
                    RemplirFicheEleve(SelectedEleve);
                }

            }

        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void RemplirFicheEleve(Eleve Elv)
        {
     //      PAN_HeaderNom.Visible = false;
            PAN_Header.Visible = false;
     //       PAN_Module_Accompagnements.Visible = true;
      //      PAN_Todo.Visible = true;
            PAN_Nom.Visible = true;
            FLP_Classe.Visible = true;
            FLP_Personnels.Visible = true;
            FLP_SexeAge.Visible = true;
            PAN_Suivis.Visible = true;
            FLP_Attest.Visible = true;
            PAN_SuivisSuper.Visible = true;
            FLP_AlaeGarderie.Visible = true;
           // PAN_Module_Absence.Visible = true;
            BT_EleveDelete.Visible = true;

            FLP_Modules.Visible = true;



            LB_Eleve_Id.Text = "# " + Elv.Id;
            LB_Eleve_Nom.Text = Elv.Nom;
            LB_Eleve_Prenom.Text = Elv.Prenom;
            LB_Eleve_DateNaissance.Text = Elv.DateNaissance;
            if (!String.IsNullOrEmpty(Elv.DateNaissance))
                LB_Eleve_Age.Text = "(" + Global.CalculAge(DateTime.Parse(Elv.DateNaissance)) + " ans)";
            if (Elv.Sexe == "M")
            {
                LB_Eleve_Sexe.Text = "Garçon";
            }
            else if (Elv.Sexe == "F")
            {
                LB_Eleve_Sexe.Text = "Fille";
            }
            else
            {
                LB_Eleve_Sexe.Text = Elv.Sexe;
            }
            
            LB_Eleve_Ine.Text = Elv.Ine;


            LB_Eleve_Cycle.Text = Elv.Cycle;
            LB_Eleve_Niveau.Text = Elv.Niveau;
            LB_Eleve_ClasseId.Text = Elv.ClasseId.ToString() + " / " + Dico_Idents_Classes[Elv.ClasseId].Id; 
            LB_Eleve_Classe.Text = Dico_Idents_Classes[Elv.ClasseId].Nom; ;
            LB_Eleve_Attestation.Text = Elv.Attestation;
            LB_Eleve_AutorisationPhoto.Text = Elv.AutorisationPhoto;
            LB_Eleve_DecisionPassage.Text = Elv.DecisionPassage;
            LB_Eleve_Dispositifs.Text = Elv.Dispositifs;


            LB_Alae.Text = Elv.Alae;
            LB_Delegue.Text = (Elv.Delegue) ? "Oui" : "Non";
            LB_Garderie.Text = Elv.Garderie;
            LB_DpExt.Text = Elv.DpExterne;



            BT_ResponsablesShow.Text = Elv.Responsables.Count() + " responsable(s)";


            SelectedEleve.SetPersonnels();
            Dico_Idents_Classes[Elv.ClasseId].SetPersonnels();
            String str_personnels = "";

            foreach (Personnel Pers in Dico_Idents_Classes[Elv.ClasseId].Personnels)
            {
                if (str_personnels != "")
                {
                    str_personnels += ", ";
                }
                str_personnels += Pers.Nom;
                if (Pers.Genre != "Prof")
                {
                    str_personnels += " (" + Pers.Genre + ")";
                }
            }


            foreach (Personnel Pers in SelectedEleve.Personnels)
            {
                if (str_personnels != "")
                {
                    str_personnels += ", ";
                }
                str_personnels += Pers.Nom + " (" + Pers.Genre + ")";
            
            }

            LB_Profs.Text = "" + str_personnels;

          

            Elv.Accompagnements = Accompagnement.GetListAccompagnementsByEleveId(Elv.Id);   //// <<<<<<<<<<<<<<<<<<<<<<<<<<< maConnexion
            LB_Accs_Temp.Text = "";
            foreach (Accompagnement Acc in Elv.Accompagnements)
            {
                LB_Accs_Temp.Text += "- " + Acc.Nom + "\r\n" ;
            }



            LB_SuivisTempSmall.Text = "";
            foreach (Suivi Suiv in Elv.Suivis)
            {
                LB_SuivisTempSmall.Text += "- " + Suiv.Genre + "\r\n";
            }
            



            PAN_Suivis.Controls.Clear();
            foreach (Suivi Suiv in Elv.Suivis)
            {
                UserControl_Suivi UC_Suiv = new UserControl_Suivi(Suiv);
                UC_Suiv.Dock = DockStyle.Top;
                PAN_Suivis.Controls.Add(UC_Suiv);
            }



            Elv.Appels = Appel.GetAppelFromEleveId(Elv.Id);
            LB_AppelsEleve.Text = "";
            LB_AppelsEleve.Text += Elv.Appels.Where(p => p.Etat == "Absent").Count() + " demi-journée(s) d'absence";
            LB_AppelsEleve.Text += "\r\n" + Elv.Appels.Where(p => p.Etat == "Retard").Count() + " retard(s)";

        }

        private void BT_SuiviAdd_Click(object sender, EventArgs e)
        {

            using (var form = new F_Suivi_Add(SelectedEleve))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    SelectedEleve = Eleve.GetEleveByIdFromBdd(SelectedEleve.Id);   // pour rafraichir l'eleve
                    RemplirFicheEleve(SelectedEleve);
                }


            }

        }

        private void BT_AccompagnementEdit_Click(object sender, EventArgs e)
        {

            using (var form = new F_Accompagnement_Eleve(SelectedEleve, Accompagnements))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //   string val = form.ReturnValue1;            //values preserved after close

                    //Do something here with these values

                    //for example
                    //    MessageBox.Show(val);


                    RemplirFicheEleve(SelectedEleve);
                }
            }



        }

        private void TXT_DgvSearch_TextChanged(object sender, EventArgs e)
        {
            String Srch = TXT_DgvSearch.Text.ToLower();

            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewRow row in DGV_Eleves.Rows)
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

            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            F_Eleves_Liste_DgvOptions Frm = new F_Eleves_Liste_DgvOptions(DGV_Eleves, splitContainer1);
            Frm.ShowDialog();
        }

        private void BT_ResponsablesShow_Click(object sender, EventArgs e)
        {
            F_Responsables_Eleve Frm = new F_Responsables_Eleve(SelectedEleve);
            Frm.ShowDialog();
        }

     

        private void BT_AbsencesDgv_Click(object sender, EventArgs e)
        {

            F_Eleves_Absences_Dgv Frm = new F_Eleves_Absences_Dgv(SelectedEleve);
            Frm.ShowDialog();
        }

        private void BT_EleveDelete_Click(object sender, EventArgs e)
        {
            F_Eleve_Delete Frm = new F_Eleve_Delete(SelectedEleve);
            Frm.ShowDialog();
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void BT_SuivisShow_Click(object sender, EventArgs e)
        {
            F_Suivis_1Eleve Frm = new F_Suivis_1Eleve(SelectedEleve);
            Frm.ShowDialog();
        }

        private void BT_EleveEdit_Click(object sender, EventArgs e)
        {

        }





        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
