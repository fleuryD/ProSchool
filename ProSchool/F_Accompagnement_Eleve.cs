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
    public partial class F_Accompagnement_Eleve : Form
    {

        // TUTO : Valeur de retour : https://stackoverflow.com/questions/5233502/how-to-return-a-value-from-a-form-in-c


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private List<Accompagnement> Accompagnements;
        private Eleve SelectedEleve;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Accompagnement_Eleve(Eleve selectedElv, List<Accompagnement> Accs)
        {
            InitializeComponent();

            this.SelectedEleve = selectedElv;
            this.Accompagnements = Accs;
        }

        private void F_Accomagnement_Eleve_Load(object sender, EventArgs e)
        {
            CreerCbAccompagnements();
            LB_EleveNom.Text = this.SelectedEleve.Nom + " " + this.SelectedEleve.Prenom;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void CreerCbAccompagnements()
        {

         //   MessageBox.Show(SelectedEleve.Accompagnements.Count().ToString());


            FLP_CbsAccs.Controls.Clear();
            foreach (Accompagnement Acc in Accompagnements)
            {
                CheckBox CB_Acc = new CheckBox();
                CB_Acc.Text = Acc.Nom;
                CB_Acc.AutoSize = true;
                CB_Acc.Tag = Acc.Id;

                foreach (Accompagnement AccEleves in SelectedEleve.Accompagnements)
                {

                    if (AccEleves.Id == Acc.Id)
                    {
                        CB_Acc.Checked = true;
                        CB_Acc.ForeColor = Color.Blue;
                    }
                }




                FLP_CbsAccs.Controls.Add(CB_Acc);

            }


        }


        private void BT_Valider_Click(object sender, EventArgs e)
        {



            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "DELETE FROM accompagnements_eleves WHERE eleve_id = @eleve_id";
            command.Parameters.AddWithValue("@eleve_id", this.SelectedEleve.Id.ToString());
            command.ExecuteNonQuery();

            foreach (Control Ctrl in FLP_CbsAccs.Controls)
            {
                CheckBox CB = (CheckBox)Ctrl;
                if (CB.Checked)
                {


                    command.CommandText = "INSERT INTO accompagnements_eleves " +
                                     "( eleve_id,  accompagnement_id) " +
                              "VALUES (@eleve_id, @accompagnement_id)";

                    command.Parameters.AddWithValue("@eleve_id", this.SelectedEleve.Id.ToString());
                    command.Parameters.AddWithValue("@accompagnement_id", CB.Tag);


                    command.ExecuteNonQuery();

                }

            }


            maConnexion.Close();
                       

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■




    }
}
