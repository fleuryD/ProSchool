using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProSchool
{
    public partial class UserControl_AppelEleveRecap : UserControl
    {
        private Eleve Elv;

      
        public UserControl_AppelEleveRecap(Eleve _elv)
        {
            InitializeComponent();
            this.Elv = _elv;

            LB_EleveNomPrenom.Text = Elv.Nom + " " + Elv.Prenom;


            this.Visible = false;

            foreach (Appel Apl in Elv.Appels)
            {
                if (Apl.DemiJournee == "Matin")
                {
                    AppelMatin.Text = Apl.Etat;
                    if (Apl.Etat == "Absent")
                    {
                        AppelMatin.ForeColor = Color.Red;
                        this.Visible = true;
                    }
                    else if (Apl.Etat == "Retard")
                    {
                        AppelMatin.ForeColor = Color.Orange;
                        this.Visible = true;
                    }
                    else if (Apl.Etat == "Present")
                    {
                        AppelMatin.ForeColor = Color.Green;
                    }
                }
                if (Apl.DemiJournee == "Aprem")
                {
                    AppelAprem.Text = Apl.Etat;
                    if (Apl.Etat == "Absent")
                    {
                        AppelAprem.ForeColor = Color.Red;
                        this.Visible = true;
                    }
                    else if (Apl.Etat == "Retard")
                    {
                        AppelAprem.ForeColor = Color.Orange;
                        this.Visible = true;
                    }
                    else if (Apl.Etat == "Present")
                    {
                        AppelAprem.ForeColor = Color.Green;
                    }
                }


            }


        }

        private void LB_EleveNomPrenom_Click(object sender, EventArgs e)
        {
            Elv.Appels = Appel.GetAppelFromEleveId(Elv.Id);
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                Elv.Responsables = new List<Responsable>();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves_responsables Where eleve_id = '" + Elv.Id + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        int respid = r.GetInt32(r.GetOrdinal("responsable_id"));
                        Elv.Responsables.Add(Responsable.GetResponsableByIdFromBdd(connect, respid));
                    }
                }
                connect.Close();

            }
            F_Eleves_Absences Frm = new F_Eleves_Absences(Elv);
            Frm.ShowDialog();
        }
    }
}
