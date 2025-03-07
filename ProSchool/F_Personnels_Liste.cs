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
    public partial class F_Personnels_Liste : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        List<Personnel> Personnels;
        Personnel SelectedPersonnel;

        private bool InitOk;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■
        public F_Personnels_Liste()
        {
            InitializeComponent();
        }

        private void F_Personnels_Liste_Load(object sender, EventArgs e)
        {

            RefreshForm();
        }

        private void RefreshFormAndSelect(int SelectedPersonnelId)
        {
            RefreshForm();
            DGV_Personnels.ClearSelection();
            /*
            SelectedPersonnel = null;
            foreach (Personnel Pers in Personnels)
            {
                if (Pers.Id == SelecetdPersonnelId)
                {
                    SelectedPersonnel = Pers;
                    break;
                }
            }

            if (SelectedPersonnel == null)
            {
                MessageBox.Show("SelectedPersonnel == null");       /////// DEBUG
                return;
            }
            
            */
            foreach (DataGridViewRow Row in DGV_Personnels.Rows)
            { 
                int pers_id = int.Parse(Row.Cells[0].Value.ToString());
                if (pers_id == SelectedPersonnelId)
                {
                    Row.Selected = true;
                    SelectedPersonnel = Personnel.GetPersonnelById(SelectedPersonnelId);

                 //   MessageBox.Show(SelectedPersonnel.Nom + " <<<<<<<<<<<<<<<<<<<< ");
                    break;
                }
            }
            
            //
          //  MessageBox.Show(SelectedPersonnel.Nom + " xxxxxxxxxxxxxx " + SelectedPersonnel.Eleves.Count());
            RemplirFicheSelectedPersonnel();


            Filtrer();

        }

        private void RefreshForm()
        {

            InitOk = false;

            PAN_Personnel.Visible = false;
            PAN_Eleves.Visible = false;
            PAN_Classes.Visible = false;


            Personnels = Personnel.GetListPersonnelsFromBdd();
            Setup_DGV_Personnels();
            Populate_DGV_Personnels();
            DGV_Personnels.ClearSelection();


          //  Filtrer();
            InitOk = true;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Personnels    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Personnels()
        {


            DGV_Personnels.ColumnCount = 14;

            DGV_Personnels.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Personnels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Personnels.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Personnels.Font, FontStyle.Bold);
            DGV_Personnels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Personnels.ColumnHeadersHeight = 40;

            DGV_Personnels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Personnels.RowHeadersVisible = false;
            DGV_Personnels.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Personnels.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Personnels.GridColor = Color.Black;

            DGV_Personnels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Personnels.MultiSelect = true;
            DGV_Personnels.AllowUserToAddRows = false;


            DGV_Personnels.Columns[0].Name = "id";
            DGV_Personnels.Columns[1].Name = "nom";
            DGV_Personnels.Columns[1].HeaderText = "Nom";

            DGV_Personnels.Columns[2].Name = "prenom";
            DGV_Personnels.Columns[3].Name = "pseudo";
            DGV_Personnels.Columns[4].Name = "genre";

            DGV_Personnels.Columns[5].Name = "classes";
            DGV_Personnels.Columns[6].Name = "eleves";

            DGV_Personnels.Columns[7].Name = "password";
            DGV_Personnels.Columns[8].Name = "sexe";

            DGV_Personnels.Columns[9].Name = "telephonePortable";
            DGV_Personnels.Columns[9].HeaderText = "tel. Portable";

            DGV_Personnels.Columns[10].Name = "telephoneDomicile";
            DGV_Personnels.Columns[10].HeaderText = "tel. Domicile";

            DGV_Personnels.Columns[11].Name = "mail";
            DGV_Personnels.Columns[12].Name = "mail2";
            DGV_Personnels.Columns[13].Name = "adresse";


            //DGV_Personnels.Columns["xxxxxxxx"].Width = 350;

            //DGV_Personnels.Columns["xxxxxxxx"].Visible = false;

        }
               
        private void Populate_DGV_Personnels()
        {

            DGV_Personnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Personnels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Personnels.Rows.Clear();

            foreach (Personnel Obj in Personnels)
            {
                Obj.SetClasses();
                String str_classes = "";
                foreach (Classe Cl in Obj.Classes)
                {
                    str_classes += Cl.Nom + ", ";
                }

                Obj.SetEleves();
                String str_eleves = "";
                if (Obj.Eleves.Count() <3)
                {
                    foreach (Eleve Elv in Obj.Eleves)
                    {
                        str_eleves += Elv.Nom + " " + Elv.Prenom + ", ";
                    }
                }
                else
                {
                    str_eleves = Obj.Eleves.Count() + " élèves";
                }

                



                var index = DGV_Personnels.Rows.Add();
                DGV_Personnels.Rows[index].Cells["id"].Value = Obj.Id;
                DGV_Personnels.Rows[index].Cells["nom"].Value = Obj.Nom;
                DGV_Personnels.Rows[index].Cells["prenom"].Value = Obj.Prenom;
                DGV_Personnels.Rows[index].Cells["pseudo"].Value = Obj.Pseudo;
                DGV_Personnels.Rows[index].Cells["genre"].Value = Obj.Genre;
                

                //DGV_Personnels.Rows[index].Cells["password"].Value = Obj.Password;
                DGV_Personnels.Rows[index].Cells["sexe"].Value = Obj.Sexe;
                DGV_Personnels.Rows[index].Cells["telephonePortable"].Value = Obj.TelephonePortable;
                DGV_Personnels.Rows[index].Cells["telephoneDomicile"].Value = Obj.TelephoneDomicile;
                DGV_Personnels.Rows[index].Cells["mail"].Value = Obj.Mail;
                DGV_Personnels.Rows[index].Cells["mail2"].Value = Obj.Mail2;
                DGV_Personnels.Rows[index].Cells["adresse"].Value = Obj.Adresse;


                DGV_Personnels.Rows[index].Cells["classes"].Value = str_classes;
                DGV_Personnels.Rows[index].Cells["eleves"].Value = str_eleves;




                if (Obj.Genre == "Prof")
                {
                    DGV_Personnels.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 230);
                }
                else if (Obj.Genre == "Rep+")
                {
                    DGV_Personnels.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 255);
                }
                else if (Obj.Genre == "AVS")
                {
                    DGV_Personnels.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
                }
                else if (Obj.Genre == "RASED")
                {
                    DGV_Personnels.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                }
                else if (Obj.Genre == "Directeur" || Obj.Genre == "Directrice")
                {
                    DGV_Personnels.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 255);
                }

                // Obj.Dgv_row = DGV_Personnels.Rows[index];
                // 
            }

            DGV_Personnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Personnels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        
        private void DGV_Personnels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DGV_Personnels.SelectedRows.Count == 1)
            {
                int SelectedPersonnelId = int.Parse(DGV_Personnels.CurrentRow.Cells[0].Value.ToString());
                SelectedPersonnel = Personnel.GetPersonnelById(SelectedPersonnelId);
                ModifierSelectedPersonnel();
            }
        }

        private void DGV_Personnels_SelectionChanged(object sender, EventArgs e)
        {
            if (InitOk)
            {
           //     MessageBox.Show("DGV_Personnels_SelectionChanged");

                if (DGV_Personnels.SelectedRows.Count == 0)
                {
                    PAN_Personnel.Visible = false;
                    PAN_Eleves.Visible = false;
                    PAN_Classes.Visible = false;
                    return;
                }

               else if (DGV_Personnels.SelectedRows.Count > 1)
                {
                    PAN_Personnel.Visible = false;
                    PAN_Eleves.Visible = false;
                    PAN_Classes.Visible = false;
                    return;
                }
                else if (DGV_Personnels.SelectedRows.Count == 1)
                {
                    int SelectedPersonnelId = int.Parse(DGV_Personnels.CurrentRow.Cells[0].Value.ToString());
                    SelectedPersonnel = Personnel.GetPersonnelById(SelectedPersonnelId);


                    RemplirFicheSelectedPersonnel();

                }

            }
        }
        
        private void DGV_Personnels_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int currentMouseOverRow = DGV_Personnels.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    DGV_Personnels.ClearSelection();        //////// A MODIFIER : Impossible de faire click droit sur selection multiple
                    DGV_Personnels.Rows[currentMouseOverRow].Selected = true;

                    int SelectedPersonnelId = int.Parse(DGV_Personnels.Rows[currentMouseOverRow].Cells[0].Value.ToString());
                    SelectedPersonnel = Personnel.GetPersonnelById(SelectedPersonnelId);

                    RemplirFicheSelectedPersonnel();

                    CMenuItem_Nom.Text = SelectedPersonnel.Nom + " " + SelectedPersonnel.Prenom;
                    CtxtMENU_Personnel.Show(DGV_Personnels, new Point(e.X, e.Y));
                   // CtxtMenuSt_Personnel.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

               

            }
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  PERSONNEL    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            ModifierSelectedPersonnel();
        }

        private void BT_PersonnelAdd_Click(object sender, EventArgs e)
        {
            using (var form = new F_Personnels_Add())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int newPersId = form.Retrun_CreatedPersonnelId;

                    RefreshFormAndSelect(newPersId);
                }
            }
        }

        private void CMenuItem_Delete_Click(object sender, EventArgs e)
        {
            String StrMessage = "Supprimer " + SelectedPersonnel.Nom + " " + SelectedPersonnel.Prenom + " ?";

            DialogResult dr = MessageBox.Show(StrMessage, "Supprimer un personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                SelectedPersonnel.DeleteInBdd();
                RefreshForm();
            }
        }

        private void CMenuItem__Edit_Click(object sender, EventArgs e)
        {
            ModifierSelectedPersonnel();
        }
        
        private void ModifierSelectedPersonnel()
        {

            TXT_Nom.ReadOnly = false;
            TXT_Prenom.ReadOnly = false;


            using (var form = new F_Personnels_Add(SelectedPersonnel))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshForm();
                }
            }
        }
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  Personnel.ELEVES    ■■■■■■■■■■■■■■■■■■■■■■■■
        

        private void BT_AddEleves_Click(object sender, EventArgs e)
        {
            SelectedPersonnel.SetEleves();

       //     MessageBox.Show("SelectedPersonnel.Eleves : " + SelectedPersonnel.Eleves.Count());
            List<Eleve> ElevesTemp = Eleve.GetListElevesFromBdd();
            List<Eleve> Eleves = new List<Eleve>();

            foreach (Eleve Elv in ElevesTemp)
            {
                Boolean existeDeja = false;
                foreach (Eleve ElvPers in SelectedPersonnel.Eleves)
                {
                    if (ElvPers.Id == Elv.Id)
                    {
                        existeDeja = true;
                        break;
                    }
                    
                }
                if (!existeDeja)
                {
                    Eleves.Add(Elv);
                }
                
            }


            F_SelectPersonnelsEleves Frm = new F_SelectPersonnelsEleves(Eleves);
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {

                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (int eleve_id in Frm.ListIds)
                {

                    //   MessageBox.Show(eleve_id.ToString());
                    SQLiteCommand command = new SQLiteCommand(maConnexion);

                    command.CommandText = "INSERT INTO eleves_personnels " +
                                               "(eleve_id,  personnel_id,  genre) " +
                                        "VALUES (@eleve_id, @personnel_id, @genre)";


                    command.Parameters.AddWithValue("@eleve_id", eleve_id);
                    command.Parameters.AddWithValue("@personnel_id", SelectedPersonnel.Id);
                    command.Parameters.AddWithValue("@genre", SelectedPersonnel.Genre);

                    command.ExecuteNonQuery();


                }

                maConnexion.Close();
                RefreshFormAndSelect(SelectedPersonnel.Id);

            }
        }

        private void ButtonSupprimer_Eleve_Click(object sender, EventArgs e, Personnel Pers, Eleve Elv)
        {



            String StrMessage = "Supprimer l'élève :  " + Elv.Nom + " " + Elv.Prenom;
            StrMessage += "\r\nPour :  " + SelectedPersonnel.Nom + " " + SelectedPersonnel.Prenom + " ?";

            DialogResult dr = MessageBox.Show(StrMessage, "Supprimer un personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_personnels WHERE personnel_id=" + Pers.Id + " AND eleve_id = " + Elv.Id;
                command.ExecuteNonQuery();
                maConnexion.Close();

                RefreshFormAndSelect(Pers.Id);
            }


     
        }
        
        private void CMenuItem_EditEleves_Click(object sender, EventArgs e)
        {



        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  Personnel.CLASSES    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void BT_AddClasses_Click(object sender, EventArgs e)
        {
            SelectedPersonnel.SetClasses();
            //     MessageBox.Show("SelectedPersonnel.Eleves : " + SelectedPersonnel.Eleves.Count());
            List<Classe> ClassesTemp = Classe.Bdd_GetClasses_OrderByName();
            List<Classe> Classes = new List<Classe>();

            foreach (Classe Cl in ClassesTemp)
            {
                Boolean existeDeja = false;
                foreach (Classe ClassPers in SelectedPersonnel.Classes)
                {
                    if (ClassPers.Id == Cl.Id)
                    {
                        existeDeja = true;
                        break;
                    }

                }
                if (!existeDeja)
                {
                    Classes.Add(Cl);
                }

            }

      
            F_SelectPersonnelsEleves Frm = new F_SelectPersonnelsEleves(Classes);
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                

                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (int classe_id in Frm.ListIds)
                {

                    //   MessageBox.Show(eleve_id.ToString());
                    SQLiteCommand command = new SQLiteCommand(maConnexion);

                    command.CommandText = "INSERT INTO classes_personnels " +
                                               "(classe_id,  personnel_id,  genre) " +
                                        "VALUES (@classe_id, @personnel_id, @genre)";


                    command.Parameters.AddWithValue("@classe_id", classe_id);
                    command.Parameters.AddWithValue("@personnel_id", SelectedPersonnel.Id);
                    command.Parameters.AddWithValue("@genre", SelectedPersonnel.Genre);

                    command.ExecuteNonQuery();


                }

                maConnexion.Close();
                RefreshFormAndSelect(SelectedPersonnel.Id);
              
              
            }

        }


        private void ButtonSupprimer_Classe_Click(object sender, EventArgs e, Personnel Pers, Classe Cl)
        {



            String StrMessage = "Supprimer la class :  " + Cl.Nom ;
            StrMessage += "\r\nPour :  " + SelectedPersonnel.Nom + " " + SelectedPersonnel.Prenom + " ?";

            DialogResult dr = MessageBox.Show(StrMessage, "Supprimer un personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM classes_personnels WHERE personnel_id=" + Pers.Id + " AND classe_id = " + Cl.Id;
                command.ExecuteNonQuery();
                maConnexion.Close();

                RefreshFormAndSelect(Pers.Id);
            }



        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void RemplirFicheSelectedPersonnel()
        {

            
            PAN_Personnel.Visible = true;
            PAN_Eleves.Visible = true;
            PAN_Classes.Visible = true;

            SelectedPersonnel.SetEleves();
            SelectedPersonnel.SetClasses();


       //     MessageBox.Show(SelectedPersonnel.Nom + " --- " + SelectedPersonnel.Eleves.Count());

            LB_Nom.Text = SelectedPersonnel.Nom + " " + SelectedPersonnel.Prenom;

            TXT_Nom.Text = SelectedPersonnel.Nom;
            TXT_Prenom.Text = SelectedPersonnel.Prenom;


            if (SelectedPersonnel.Genre == "Prof" || SelectedPersonnel.Genre == "Rep+")
            {
                PAN_Eleves.Visible = false;
            }
            else
            {
                PAN_Eleves.Visible = true;

                PAN_ItemsEleves.Controls.Clear();
                foreach (Eleve Elv in SelectedPersonnel.Eleves)
                {
                    UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Elv);
                    UCItemPers.Dock = DockStyle.Top;
                    PAN_ItemsEleves.Controls.Add(UCItemPers);
                    UCItemPers.ButtonSupprimerClick += new EventHandler((sender, e) => ButtonSupprimer_Eleve_Click(sender, e, SelectedPersonnel, Elv));
                }
            }



            if (SelectedPersonnel.Genre == "AVS")
            {
                PAN_Classes.Visible = false;
            }
            else
            {
                PAN_Classes.Visible = true;



                PAN_ItemsClasses.Controls.Clear();
                foreach (Classe Cl in SelectedPersonnel.Classes)
                {
                    UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Cl);
                    UCItemPers.Dock = DockStyle.Top;
                    PAN_ItemsClasses.Controls.Add(UCItemPers);
                    UCItemPers.ButtonSupprimerClick += new EventHandler((sender, e) => ButtonSupprimer_Classe_Click(sender, e, SelectedPersonnel, Cl));

                }

            }

        }

    
        private void Filtrer()
        {

            DGV_Personnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Personnels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewRow Rrr in DGV_Personnels.Rows)
            {
                Rrr.Visible = true;


                if (Rrr.Cells["genre"].Value.ToString() == "Prof")
                {
                    if( !CB_ShowProfs.Checked) 
                        Rrr.Visible = false;
                }
                else if (Rrr.Cells["genre"].Value.ToString() == "Rep+")
                {
                    if (!CB_ShowRepPlus.Checked)
                        Rrr.Visible = false;
                }
                else if (Rrr.Cells["genre"].Value.ToString() == "AVS")
                {
                    if (!CB_ShowAvs.Checked)  
                        Rrr.Visible = false;
                }
                else
                {
                    if (!CB_ShowAutres.Checked)  
                        Rrr.Visible = false;
                }


            }


            DGV_Personnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Personnels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void CB_Filtres_CheckedChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

      






        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
