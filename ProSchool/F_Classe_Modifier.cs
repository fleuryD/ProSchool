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
    public partial class F_Classe_Modifier : Form
    {
        private Classe SelectedClasse;

      

        public F_Classe_Modifier(Classe _selectedClasse)
        {
            InitializeComponent();


            this.SelectedClasse = _selectedClasse;
            refresh();
        }


        private void refresh()
        {

            SetSizePans();

            LB_ClasseNom.Text = SelectedClasse.Nom;
            LB_ClasseCycles.Text = SelectedClasse.Cycles;



            PAN_ItemsProfs.Controls.Clear();
            PAN_ItemsPersonnels.Controls.Clear();
            PAN_ItemsDelegues.Controls.Clear();

            foreach (Personnel Pers in SelectedClasse.Personnels)
            {
                UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Pers);
                UCItemPers.Dock = DockStyle.Top;
                // UCItemPers.ButtonSupprimerClick += new EventHandler(UCItemPers_ButtonSupprimerClick);


                if (Pers.Genre == "Prof")
                {
                    PAN_ItemsProfs.Controls.Add(UCItemPers);
                }
                else
                {
                    PAN_ItemsPersonnels.Controls.Add(UCItemPers);
                }
            }



            List<Eleve> ElevesClasses = Eleve.GetListElevesFromBddByClasseIdentifiant(SelectedClasse.Identifiant);
            IEnumerable<Eleve> ElevesDelegues = ElevesClasses.Where(i => i.Delegue == true);   //.FirstOrDefault()
            foreach (Eleve Elv in ElevesDelegues)
            {
                UserControl_ItemPersonne UCItemPers = new UserControl_ItemPersonne(Elv);
                UCItemPers.Dock = DockStyle.Top;
                PAN_ItemsDelegues.Controls.Add(UCItemPers);
                //UCItemPers.ButtonSupprimerClick += new EventHandler(UCItemPers_ButtonSupprimerClick);
                UCItemPers.ButtonSupprimerClick += new EventHandler((sender, e) => ButtonSupprimer_Delegue_Click(sender, e, Elv.Id));

            }
        }

        protected void SupprimerDelegue(int eleve_id)
        {

            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "update eleves set delegue = '0' where id=@id";
            command.Parameters.AddWithValue("@id", eleve_id);
            command.ExecuteNonQuery();
            maConnexion.Close();

            refresh();
        }
        protected void ButtonSupprimer_Delegue_Click(object sender, EventArgs e, int eleve_id)
        {
            SupprimerDelegue(eleve_id);

        }

        private void F_Classe_Modifier_Resize(object sender, EventArgs e)
        {
            SetSizePans();
        }


        private void SetSizePans()
        {
            double Pourcent = 0.32;

            PAN_Profs.Width = Convert.ToInt32(this.Width * Pourcent);
           /// PAN_Personnels.Width = Convert.ToInt32(this.Width * Pourcent);
            PAN_Delegues.Width = Convert.ToInt32(this.Width * Pourcent);

        }

        private void BT_AddDelegue_Click(object sender, EventArgs e)
        {
            List<Eleve> ElevesClasses = Eleve.GetListElevesFromBddByClasseIdentifiant(SelectedClasse.Identifiant);
            F_SelectPersonnelsEleves Frm = new F_SelectPersonnelsEleves(ElevesClasses);
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {

                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (int eleve_id in Frm.ListIds)
                {
                    //   MessageBox.Show(id.ToString());
                    SQLiteCommand command = new SQLiteCommand(maConnexion);

                    command.CommandText = "update eleves set delegue = '1' where id=@id";
                    command.Parameters.AddWithValue("@id", eleve_id);
                    command.ExecuteNonQuery();
                                        
                }

                maConnexion.Close();
                refresh();
            }
            
        }


        private void BT_AddPersonnel_Click(object sender, EventArgs e)
        {
            List<Personnel> Personnels = Personnel.GetListPersonnelsFromBdd();
            F_SelectPersonnelsEleves Frm = new F_SelectPersonnelsEleves(Personnels);
            var result = Frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*
                SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
                foreach (int eleve_id in Frm.ListIds)
                {
                    //   MessageBox.Show(id.ToString());
                    SQLiteCommand command = new SQLiteCommand(maConnexion);

                    command.CommandText = "update eleves set delegue = '1' where id=@id";
                    command.Parameters.AddWithValue("@id", eleve_id);
                    command.ExecuteNonQuery();

                }
              
                maConnexion.Close();
                  */
                refresh();
            }

        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
