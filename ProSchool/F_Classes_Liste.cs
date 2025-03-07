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
    public partial class F_Classes_Liste : Form
    {

        /*
         * 
        LB_Eleve_Id
        LB_Eleve_Nom
        LB_Eleve_Prenom
        LB_Eleve_DateNaissance
        LB_Eleve_Sexe
        LB_Eleve_Ine

        LB_Eleve_Cycle
        LB_Eleve_Niveau
        LB_Eleve_ClasseId
        LB_Eleve_Classe
        LB_Eleve_Attestation
        LB_Eleve_AutorisationPhoto
        LB_Eleve_DecisionPassage
        LB_Eleve_Dispositifs
         * 
         * 
         */

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Classe> Classes;
        private Classe SelectedClasse;
        private List<Eleve> SelectedEleves;
        private Boolean InitOk;

        private Color Color1 = Global.Color_Menu_Eleves;
        private Color Color2 = Global.Color_Menu_Eleves2;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Classes_Liste()
        {
            InitializeComponent();

            this.DGV_Eleves.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Eleves_CellDoubleClick);
        }

        private void F_Classes_Liste_Load(object sender, EventArgs e)
        {
            InitOk = false;

            PAN_Header1.Visible = false;
            DGV_Eleves.Visible = false;

            LB_ClasseNom.ForeColor = Color1;
            LB_ClasseCycles.ForeColor = Color1;
            LB_ClasseProfs.ForeColor = Color1;
            CTXTMI_Eleves_Selection.ForeColor = Color1;
            LB_ClasseDelegues.ForeColor = Color1;
            LB_Help_ClicDroit1.BackColor = Color2;
            LB_Help_ClicDroit2.BackColor = Color2;
            LB_Help_Profs.BackColor = Color2;
            DGV_Eleves.BackgroundColor = Color2;
            DGV_Classes.BackgroundColor = Color2;

            //   LB_ElevesCount.Text = SelectedClasse.Eleves.Count() + " élèves dans la classe";
            //  Classes = Classe.Bdd_GetClasses_OrderByName();

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            Classes = Classe.Bdd_GetClasses_OrderByCycle(maConnexion);
            if (Classes.Count() == 0)
            {
                MessageBox.Show("Il n'y a aucune Classe dans la liste.\r\n\r\nAllez dans \"Parametres\\Importer\"");
            }

            foreach(Classe Cl in Classes)
            {
                Cl.SetPersonnels(maConnexion);
            }
            maConnexion.Close();

            Setup_DGV_Classes();
            Populate_DGV_Classes();

            Setup_DGV_Eleves();

            DGV_Classes.ClearSelection();
            InitOk = true;
        }  
        
        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Classes    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Classes()
        {


            DGV_Classes.ColumnCount = 0;

            DGV_Classes.EnableHeadersVisualStyles = false;  // pour changer la couleur du header
            DGV_Classes.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Classes.Font.FontFamily, 11f, FontStyle.Bold);            
            DGV_Classes.ColumnHeadersDefaultCellStyle.ForeColor = Color1;
            DGV_Classes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //  DGV_Classes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;


            DGV_Classes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Classes.ColumnHeadersHeight = 80;

            DGV_Classes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Classes.RowHeadersVisible = false;
            DGV_Classes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Classes.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Classes.GridColor = Color.Black;

            DGV_Classes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    DGV_Classes.MultiSelect = false;
            DGV_Classes.AllowUserToAddRows = false;

            DGV_Classes.DefaultCellStyle.SelectionBackColor = Color1;
            DGV_Classes.DefaultCellStyle.SelectionForeColor = Color.White;


            Global.DGV_AddCol(DGV_Classes, "id", "");
            Global.DGV_AddCol(DGV_Classes, "identifiant", "");
            Global.DGV_AddCol(DGV_Classes, "nom", "Classe");
            Global.DGV_AddCol(DGV_Classes, "cycles", "Cycles");
            Global.DGV_AddCol(DGV_Classes, "profs", "Profs");
            Global.DGV_AddCol(DGV_Classes, "personnels", "Personnels");

            //DGV_Classes.Columns["xxxxxxxx"].Width = 350;

           
            DGV_Classes.Columns["id"].Visible = false;
            DGV_Classes.Columns["identifiant"].Visible = false;
            
          


        }
               
        private void Populate_DGV_Classes()
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
              




                String str_profs = "";
                String str_personnels = "";
                foreach (Personnel Pers in Obj.Personnels)
                {              

                    if (Pers.Genre == "Prof")
                    {
                        if (str_profs != "")
                        {
                            str_profs += ", ";
                        }
                        str_profs += Pers.Nom;  // Pers.Prenom + " " + 
                    }
                    else
                    {
                        if (str_personnels != "")
                        {
                            str_personnels += ", ";
                        }
                        str_personnels +=  Pers.Nom;    //  Pers.Prenom + " " +
                        str_personnels += " (" + Pers.Genre + ")";
                    }
                }



                DGV_Classes.Rows[index].Cells["profs"].Value = str_profs;
                DGV_Classes.Rows[index].Cells["personnels"].Value = str_personnels;
             
              
            }
            DGV_Classes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Classes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            AjustSplitContWidth();
        }
        
        private void DGV_Classes_SelectionChanged(object sender, EventArgs e)
        {

        
            if (InitOk)
            {
                
                if (DGV_Classes.SelectedRows.Count == 0)
                {

                    PAN_Header1.Visible = false;
                    DGV_Eleves.Visible = false;
                    return;
                }
                else if (DGV_Classes.SelectedRows.Count == 1)
                {
                    // ON UTILISE Classe.Identifiant et pas Classe.Id
                    int SelectedClasseId = int.Parse(DGV_Classes.CurrentRow.Cells[1].Value.ToString());

                    SelectedClasse = Classes.Where(X => X.Identifiant == SelectedClasseId).First();
               
                    RemplirFicheEtDGVClasse();

                    PAN_Header1.Visible = true;
                    DGV_Eleves.Visible = true;

                }
                else
                {

                    PAN_Header1.Visible = false;
                    DGV_Eleves.Visible = false;
                }


            }


           

        }


        public void AjustSplitContWidth()
        {
            int Width = 18;
            foreach (DataGridViewColumn Col in DGV_Classes.Columns)
            {
                if (Col.Visible)
                {
                    Width += Col.Width;
                }
            }

            splitContainer1.SplitterDistance = Width;
        }

        private void RemplirFicheEtDGVClasse()
        {

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();

            SelectedClasse.SetEleves(maConnexion);
            foreach (Eleve Elv in SelectedClasse.Eleves)
            {
                Elv.Accompagnements = Accompagnement.GetListAccompagnementsByEleveId(Elv.Id);
                Elv.Suivis = Suivi.Bdd_GetSuivis_ByEleveId(Elv.Id, maConnexion);
           
            }

                maConnexion.Close();

            String str_personnels = Personnel.GetStringListPersonnels(SelectedClasse.Personnels);
            /*
           String str_personnels = "";
           foreach (Personnel Pers in SelectedClasse.Personnels)
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
            */

           
            String str_delegues = "";
            foreach (Eleve Elv in SelectedClasse.Eleves.Where(i => i.Delegue == true))
            {
                if (str_delegues != "")
                {
                    str_delegues += ", ";
                }
                str_delegues += Elv.Nom + " " + Elv.Prenom;

            }

           LB_ElevesCount.Text = SelectedClasse.Eleves.Count() + " élèves dans la classe";
           LB_ClasseNom.Text = SelectedClasse.Nom;
           LB_ClasseCycles.Text = SelectedClasse.Cycles;
           LB_ClasseProfs.Text = str_personnels;
           LB_ClasseDelegues.Text = str_delegues;

           
            Populate_DGV_Eleves();

            DGV_Eleves.ClearSelection();



        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Eleves    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Eleves()
        {


            DGV_Eleves.ColumnCount = 0;

            DGV_Eleves.EnableHeadersVisualStyles = false;  // pour changer la couleur du header
            DGV_Eleves.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Eleves.Font.FontFamily, 9f, FontStyle.Bold);
            DGV_Eleves.ColumnHeadersDefaultCellStyle.ForeColor = Color1;
            DGV_Eleves.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //  DGV_Classes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;

            DGV_Eleves.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Eleves.ColumnHeadersHeight = 40;

            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV_Eleves.RowHeadersVisible = false;
            DGV_Eleves.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Eleves.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Eleves.GridColor = Color.Black;

            DGV_Eleves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          //  DGV_Eleves.MultiSelect = false;
            DGV_Eleves.AllowUserToAddRows = false;


            DGV_Eleves.DefaultCellStyle.SelectionBackColor = Color1;
            DGV_Eleves.DefaultCellStyle.SelectionForeColor = Color.White;

            DGV_Eleves.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            Global.DGV_AddCol(DGV_Eleves, "id", "");
            Global.DGV_AddCol(DGV_Eleves, "nom", "Nom");
            Global.DGV_AddCol(DGV_Eleves, "prenom", "Prénom");
            Global.DGV_AddCol(DGV_Eleves, "dateNaissance", "Date de\r\nNaissance");
            Global.DGV_AddCol(DGV_Eleves, "sexe", "Sexe");
            Global.DGV_AddCol(DGV_Eleves, "ine", "INE");
            Global.DGV_AddCol(DGV_Eleves, "cycle", "Cycle");
            Global.DGV_AddCol(DGV_Eleves, "niveau", "Niveau");
            Global.DGV_AddCol(DGV_Eleves, "classeId", "");
            Global.DGV_AddCol(DGV_Eleves, "attestation", "Attestation\r\nd'assurance");
            Global.DGV_AddCol(DGV_Eleves, "autorisationPhoto", "Autorisation\r\nPhoto");
            Global.DGV_AddCol(DGV_Eleves, "decisionPassage", "");
            Global.DGV_AddCol(DGV_Eleves, "dispositifs", "");
            Global.DGV_AddCol(DGV_Eleves, "delegue", "Délégué");
            Global.DGV_AddCol(DGV_Eleves, "dpExterne", "DP\r\nExterne");
            Global.DGV_AddCol(DGV_Eleves, "garderie", "Garderie");
            Global.DGV_AddCol(DGV_Eleves, "alae", "ALAE");
            Global.DGV_AddCol(DGV_Eleves, "accompagnements", "Accompagnements");
            Global.DGV_AddCol(DGV_Eleves, "suivis", "Suivis");



            //DGV_Eleves.Columns["xxxxxxxx"].Width = 350;

            DGV_Eleves.Columns["id"].Visible = false;
            DGV_Eleves.Columns["classeId"].Visible = false;
            DGV_Eleves.Columns["ine"].Visible = false;
            DGV_Eleves.Columns["decisionPassage"].Visible = false;;
            DGV_Eleves.Columns["dispositifs"].Visible = false;
            DGV_Eleves.Columns["cycle"].Visible = false;



        }

        private void Populate_DGV_Eleves()
        {

            DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Eleves.Rows.Clear();


            foreach (Eleve Elv in SelectedClasse.Eleves)
            {

                var index = DGV_Eleves.Rows.Add();
                Elv.DgvRow = DGV_Eleves.Rows[index];

                DGV_Eleves.Rows[index].Cells["id"].Value = Elv.Id;
                DGV_Eleves.Rows[index].Cells["nom"].Value = Elv.Nom;
                DGV_Eleves.Rows[index].Cells["prenom"].Value = Elv.Prenom;
                DGV_Eleves.Rows[index].Cells["dateNaissance"].Value = Elv.DateNaissance;
                DGV_Eleves.Rows[index].Cells["sexe"].Value = Elv.Sexe;
                DGV_Eleves.Rows[index].Cells["ine"].Value = Elv.Ine;
                DGV_Eleves.Rows[index].Cells["cycle"].Value = Elv.Cycle;
                DGV_Eleves.Rows[index].Cells["niveau"].Value = Elv.Niveau;
                DGV_Eleves.Rows[index].Cells["classeId"].Value = Elv.ClasseId;
                DGV_Eleves.Rows[index].Cells["attestation"].Value = Elv.Attestation;
                DGV_Eleves.Rows[index].Cells["autorisationPhoto"].Value = Elv.AutorisationPhoto;
                DGV_Eleves.Rows[index].Cells["decisionPassage"].Value = Elv.DecisionPassage;
                DGV_Eleves.Rows[index].Cells["dispositifs"].Value = Elv.Dispositifs;
                DGV_Eleves.Rows[index].Cells["garderie"].Value = Elv.Garderie;
                DGV_Eleves.Rows[index].Cells["alae"].Value = Elv.Alae;




                if (Elv.Accompagnements.Count() > 0)
                {
                    DGV_Eleves.Rows[index].Cells["accompagnements"].Value = Elv.Accompagnements.Count().ToString();
                    DGV_Eleves.Rows[index].Cells["accompagnements"].Style.BackColor = Color2;
                }

                if (Elv.Suivis.Count() > 0)
                {
                    DGV_Eleves.Rows[index].Cells["suivis"].Value = Elv.Suivis.Count().ToString();
                    DGV_Eleves.Rows[index].Cells["suivis"].Style.BackColor = Color2;
                }


                if (Elv.Delegue)
                {
                    DGV_Eleves.Rows[index].Cells["delegue"].Value = "OUI";
                    DGV_Eleves.Rows[index].Cells["delegue"].Style.BackColor = Color2;
                }

                DGV_Eleves.Rows[index].Cells["dpExterne"].Value = Elv.DpExterne;
                if (Elv.DpExterne == "DP")
                {
                    DGV_Eleves.Rows[index].Cells["dpExterne"].Style.BackColor = Color2;
                }
                if (Elv.Garderie == "OUI")
                {
                    DGV_Eleves.Rows[index].Cells["garderie"].Style.BackColor = Color2;
                }
                if (Elv.Alae == "OUI")
                {
                    DGV_Eleves.Rows[index].Cells["alae"].Style.BackColor = Color2;
                }

                // Elv.Dgv_row = DGV_Eleves.Rows[index];
                // DGV_Eleves.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                DGV_Eleves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DGV_Eleves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        private void DGV_Eleves_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ///////////////////////////////////// si la ligne survolé n'est pas séléctionné: on desselectionne les autres
                int currentMouseOverRowId = DGV_Eleves.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRowId < 0)
                {
                    return;
                }
                if (!DGV_Eleves.Rows[currentMouseOverRowId].Selected)
                {
                    DGV_Eleves.ClearSelection();
                }
                DGV_Eleves.Rows[currentMouseOverRowId].Selected = true;                // on  selectionne la ligne survolé
                /////////////////////////////////////



                SelectedEleves = new List<Eleve>();
                // MessageBox.Show(DGV_Eleves.SelectedRows.Count.ToString());
                foreach (DataGridViewRow row in DGV_Eleves.SelectedRows)
                {
                    SelectedEleves.Add(SelectedClasse.Eleves.Where(X => X.DgvRow == row).First());
                }


                if (SelectedEleves.Count() == 1)
                {
                    CTXTMI_Eleves_Selection.Text = SelectedEleves.First().Nom + " " + SelectedEleves.First().Prenom;
                    CTXTMI_Eleve_Accompagnements.Enabled = true;
                    CTXTMI_Eleve_Suivis.Enabled = true;
                }
                else
                {
                    CTXTMI_Eleves_Selection.Text = SelectedEleves.Count() + " élèves séléctionnés";
                    CTXTMI_Eleve_Accompagnements.Enabled = false;
                    CTXTMI_Eleve_Suivis.Enabled = false;
                }



                CTXTM_Eleves.Show(DGV_Eleves, new Point(e.X, e.Y));

            }
        }

        private void DGV_Eleves_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ColIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;

            if (RowIndex < 0)
            {
                return;
            }

            if (DGV_Eleves.Columns[ColIndex].Name == "accompagnements")
            {

                MessageBox.Show("Accompagnement");
            }


            MessageBox.Show("ColIndex:" + ColIndex + " - RowIndex = " + RowIndex);

          


        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  CTXT MENU - Eleves    ■■■■■■■■■■■■■■■■■■■■■■■■



        private void CTXTMI_Eleves_DelegueOui_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   Délégué = OUI   pour: \r\n";
            foreach(Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- "+ Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les délégués", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Delegue = true;
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_DelegueNon_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   Délégué = NON   pour: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les délégués", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Delegue = false;
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_Dp_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous passer ces élèves en DEMI-PENSIONNAIRES: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les DP/Externes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.DpExterne = "DP";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_Externe_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous passer ces élèves en EXTERNES : \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les DP/Externes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.DpExterne = "EXT";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_GarderieOui_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   GARDERIE = OUI   pour: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les Garderies", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Garderie = "OUI";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_GarderieNon_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   GARDERIE = NON   pour: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les Garderies", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Garderie = "";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_AlaeOui_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   ALAE = OUI   pour: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les ALAE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Alae = "OUI";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }

        private void CTXTMI_Eleves_AlaeNon_Click(object sender, EventArgs e)
        {
            String StrMessage = "Voulez-vous mettre   ALAE = NON   pour: \r\n";
            foreach (Eleve Elv in SelectedEleves)
            {
                StrMessage += "\r\n- " + Elv.Nom + " " + Elv.Prenom;
            }


            DialogResult dr = MessageBox.Show(StrMessage, "Modifier les ALAE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (Eleve Elv in SelectedEleves)
                {
                    Elv.Alae = "";
                    Elv.UpdateInBdd(maConnexion);
                }
                maConnexion.Close();
                RemplirFicheEtDGVClasse();
            }
        }




        private void CTXTMI_Eleve_Accompagnements_Click(object sender, EventArgs e)
        {
            Eleve Elv = SelectedEleves.First();
            List<Accompagnement> Accompagnements = Accompagnement.Bdd_GetAccompagnements_OrderByPosition();
            using (var form = new F_Accompagnement_Eleve(Elv, Accompagnements))
            {
                var result2 = form.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    RemplirFicheEtDGVClasse();
                }
            }
        }

        private void CTXTMI_Eleve_Suivis_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Work In Progress\r\n\r\nEn attendant, vous pouvez acceder au suivi de l'élève dans le menu : \r\nElèves/Classes > Elèves");


            using (F_Suivis_1Eleve form = new F_Suivis_1Eleve(SelectedEleves.First()))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                  //  SelectedEleve = Eleve.GetEleveByIdFromBdd(SelectedEleve.Id);   // pour rafraichir l'eleve
                    MessageBox.Show("RAFRAICHIR LA PAGE !");
                    //   RemplirFicheEleve(SelectedEleve);
                }
            }

        }

      





        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
