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
    public partial class UserControl_AppelClasseRecap : UserControl
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Classe Cl;
        private String SelectedJour;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public UserControl_AppelClasseRecap(Classe _cl, String _SelectedJour)
        {
            InitializeComponent();
            this.Cl = _cl;
            this.SelectedJour = _SelectedJour;
            LB_Date.Visible = false;

            LB_ClasseNom.Text = Cl.Nom;
            LB_Date.Text = SelectedJour;


            List<Eleve> ElevesClasse = Eleve.GetListElevesFromBddByClasseIdentifiant(Cl.Identifiant);

            int CountAppelMatin = 0;
            int CountAppelAprem = 0;
            int CountAppel = 0;
            Boolean TousPresentsMatin = true;
            Boolean TousPresentsAprem = true;
            Boolean ShowListeEleves = false;



            foreach (Eleve Elv in ElevesClasse)
            {
                Elv.Appels = GetAppelFromEleveId_and_jour(Elv.Id, SelectedJour);
                CountAppel += Elv.Appels.Count();
                foreach (Appel Apl in Elv.Appels)
                {
                    if (Apl.DemiJournee == "Matin")
                    {
                        CountAppelMatin++;
                        if (Apl.Etat != "Present")
                        {
                            TousPresentsMatin = false;
                            ShowListeEleves = true;
                        }
                    }
                    if (Apl.DemiJournee == "Aprem")
                    {
                        CountAppelAprem++;
                        if (Apl.Etat != "Present")
                        {
                            TousPresentsAprem = false;
                            ShowListeEleves = true;
                        }
                    }
                }
            }

            if (CountAppelMatin == 0)
            {
                LB_RecapMatin.Text = "Matin : L'appel n'a pas été fait !";
                LB_RecapMatin.ForeColor = Color.Red;
            }
            else
            {
                LB_RecapMatin.Text = "Matin : Appel fait !";
                LB_RecapMatin.ForeColor = Color.Green;
                if (TousPresentsMatin)
                {
                    LB_RecapMatin.Text = "Matin : Pas d'absence ni de retard  !";
                }
            }


            if (CountAppelAprem == 0)
            {
                LB_RecapAprem.Text = "Aprem : L'appel n'a pas été fait !";
                LB_RecapAprem.ForeColor = Color.Red;
            }
            else
            {
                LB_RecapAprem.Text = "Aprem : Appel fait !";
                LB_RecapAprem.ForeColor = Color.Green;
                if (TousPresentsAprem)
                {
                    LB_RecapAprem.Text = "Aprem : Pas d'absence ni de retard  !";
                }
            }






            if (!ShowListeEleves)
            {
                PAN_Appels.Visible = false;
            }
            else
            {

                PAN_Appels.Controls.Clear();
                foreach (Eleve Elv in ElevesClasse)
                {
                    //  Appel AplMatin = Elv.Appels.Where
                    UserControl_AppelEleveRecap UC_AER = new UserControl_AppelEleveRecap(Elv);
                    UC_AER.Dock = DockStyle.Bottom;
                    PAN_Appels.Controls.Add(UC_AER);
                }

            }

               

        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private List<Appel> GetAppelFromEleveId_and_jour(int _EleveId, String _SelectedJour)
        {

            List<Appel> AppelsTemp = new List<Appel>();
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();
                using (SQLiteCommand fmd = maConnexion.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + _EleveId + "' AND jour = '" + _SelectedJour + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader rdr = fmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        AppelsTemp.Add(new Appel(rdr));
                        //StringReturnAppel = rdr["etat"].ToString();
                    }
                }
                maConnexion.Close();
            }



            return AppelsTemp;
        }
        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■



    }
}
