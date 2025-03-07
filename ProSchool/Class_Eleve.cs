using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csv;

namespace ProSchool
{

    public class Eleve
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
    
        private int m_id;
        private String m_nom;
        private String m_prenom;
        private String m_dateNaissance;
        private String m_sexe;
        private String m_ine;
        private String m_cycle;
        private String m_niveau;
        private int m_classeId;
        private String m_attestation;
        private String m_autorisationPhoto;
        private String m_decisionPassage;
        private String m_dispositifs;
        private Boolean m_delegue;
        private String m_dpExterne;
        private String m_garderie;
        private String m_alae;
        private String m_dateEntree;
        private String m_dateSortie;
        private String m_importGenre;
        private String m_importInfos;                   //  NOT in BDD
        private List<Responsable> m_responsables;       //  NOT in BDD
        private List<Accompagnement> m_accompagnements; //  NOT in BDD
        private List<Suivi> m_suivis;                   //  NOT in BDD
        private List<Personnel> m_personnels;           //  NOT in BDD
        private List<Appel> m_appels;                   //  NOT in BDD
        private DataGridViewRow m_dgvRow;               //  NOT in BDD

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Eleve()
        {

        }

        public Eleve(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_nom = rdr["nom"].ToString();
            this.m_prenom = rdr["prenom"].ToString();
            this.m_dateNaissance = rdr["date_naissance"].ToString();
            this.m_sexe = rdr["sexe"].ToString();
            this.m_ine = rdr["ine"].ToString();
            this.m_cycle = rdr["cycle"].ToString();
            this.m_niveau = rdr["niveau"].ToString();
            this.m_classeId = rdr.GetInt32(rdr.GetOrdinal("classe_id"));
            this.m_attestation = rdr["attestation"].ToString();
            this.m_autorisationPhoto = rdr["autorisation_photo"].ToString();
            this.m_decisionPassage = rdr["decision_passage"].ToString();
            this.m_dispositifs = rdr["dispositifs"].ToString();
            this.m_delegue = (rdr["delegue"].ToString() == "1") ? true : false;
            this.m_dpExterne = rdr["dp_externe"].ToString();
            this.m_garderie = rdr["garderie"].ToString();
            this.m_alae = rdr["alae"].ToString();
            this.m_dateEntree = rdr["date_entree"].ToString();
            this.m_dateSortie = rdr["date_sortie"].ToString();
            this.m_importGenre = rdr["import_genre"].ToString();


            this.m_responsables = new List<Responsable>();
            this.m_suivis = new List<Suivi>();
            //    this.m_accompagnements =
            //    this.m_personnels =
            //    this.m_appels =
            //    this.m_importInfos = rdr[""].ToString();

        }
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  CRUD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd()
        {
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();
                this.InsertInBdd(maConnexion);

                maConnexion.Close();
            }
        }

        public void InsertInBdd(SQLiteConnection maConnexion)
        {
        
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO eleves " +
                                       "(nom,  prenom,  date_naissance,  sexe,  ine,  cycle,  niveau,  classe_id,  attestation,  autorisation_photo,  decision_passage,  dispositifs, date_entree, date_sortie, import_genre) " +
                                "VALUES (@nom, @prenom, @date_naissance, @sexe, @ine, @cycle, @niveau, @classe_id, @attestation, @autorisation_photo, @decision_passage, @dispositifs, @date_entree, @date_sortie, @import_genre)";

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

          //  command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@date_naissance", this.m_dateNaissance);
            command.Parameters.AddWithValue("@sexe", this.m_sexe);
            command.Parameters.AddWithValue("@ine", this.m_ine);
            command.Parameters.AddWithValue("@cycle", this.m_cycle);
            command.Parameters.AddWithValue("@niveau", this.m_niveau);
            command.Parameters.AddWithValue("@classe_id", this.m_classeId);
            command.Parameters.AddWithValue("@attestation",  this.m_attestation);
            command.Parameters.AddWithValue("@autorisation_photo", this.m_autorisationPhoto);
            command.Parameters.AddWithValue("@decision_passage", this.m_decisionPassage);
            command.Parameters.AddWithValue("@dispositifs", this.m_dispositifs);
            //command.Parameters.AddWithValue("@delegue", 0);
            // dp_externe
            // garderie
            //alae
            command.Parameters.AddWithValue("@date_entree", this.m_dateEntree);
            command.Parameters.AddWithValue("@date_sortie", this.m_dateSortie);
            command.Parameters.AddWithValue("@import_genre", this.m_importGenre);

            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        }

        public void UpdateInBdd()
        {
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();
                this.UpdateInBdd(maConnexion);

                maConnexion.Close();
            }
        }

            public void UpdateInBdd(SQLiteConnection maConnexion)
        {
            SQLiteCommand command = new SQLiteCommand(maConnexion);
//            ,  ,  ,  ,  ine,  cycle,  niveau,  classe_id,  attestation,  autorisation_photo,  decision_passage,  dispositifs) " +

            command.CommandText = "UPDATE eleves SET " +
                "nom = @nom, " +
                "prenom = @prenom, " +
                "date_naissance = @date_naissance, " +
                "sexe = @sexe, " +
                "ine = @ine, " +
                "delegue = @delegue, " +
                "dp_externe = @dp_externe, " +
                "garderie = @garderie, " +
                "alae = @alae, " +
                "cycle = @cycle, " +
                "niveau = @niveau, " +
                "classe_id = @classe_id, " +
                "attestation = @attestation, " +
                "autorisation_photo = @autorisation_photo, " +
                "decision_passage = @decision_passage, " +
                "dispositifs = @dispositifs " +
                "WHERE id = @id";


            command.Parameters.AddWithValue("@id", this.m_id);

            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@date_naissance", this.m_dateNaissance);
            command.Parameters.AddWithValue("@sexe", this.m_sexe);
            command.Parameters.AddWithValue("@ine", this.m_ine);
            command.Parameters.AddWithValue("@cycle", this.m_cycle);
            command.Parameters.AddWithValue("@delegue", this.m_delegue);
            command.Parameters.AddWithValue("@dp_externe", this.m_dpExterne);
            command.Parameters.AddWithValue("@garderie", this.m_garderie);
            command.Parameters.AddWithValue("@alae", this.m_alae);
            command.Parameters.AddWithValue("@niveau", this.m_niveau);
            command.Parameters.AddWithValue("@classe_id", this.m_classeId);
            command.Parameters.AddWithValue("@attestation", 0); // this.m_attestation);
            command.Parameters.AddWithValue("@autorisation_photo", 0); // , this.m_autorisationPhoto);
            command.Parameters.AddWithValue("@decision_passage", this.m_decisionPassage);
            command.Parameters.AddWithValue("@dispositifs", this.m_dispositifs);



            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        }
        
        public void DeleteInBdd()
        {

            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();

                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves WHERE id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM accompagnements_eleves WHERE eleve_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM appels WHERE eleve_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_personnels WHERE eleve_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_responsables WHERE eleve_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM suivis WHERE eleve_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                maConnexion.Close();
            }
        }

   
        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void SetPersonnels()
        {
            m_personnels = new List<Personnel>();

            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves_personnels Where eleve_id = '" + this.m_id + "'";     //
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        int PersonnelId = r.GetInt32(r.GetOrdinal("personnel_id"));
                        m_personnels.Add(Personnel.GetPersonnelById(PersonnelId));
                    }
                }
                connect.Close();
            }
        }
        
        public void SetAppelsFromPeriode(SQLiteConnection maConnexion, String DateDebut, String DateFin)
        {
            this.m_appels = new List<Appel>();
            using (SQLiteCommand fmd = maConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + this.m_id + "' AND jour >= '" + DateDebut + "' AND jour <= '" + DateFin + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader rdr = fmd.ExecuteReader();
                while (rdr.Read())
                {
                    this.m_appels.Add(new Appel(rdr));
                  //  StringReturnAppel = rdr["etat"].ToString();
                }
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC    ■■■■■■■■■■■■■■■■■■■■■■■■


        public static List<Eleve> Bdd_GetEleves_ByClasseIdentifiant_OrderByNom(int ClasseIdentifiant, SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM eleves WHERE classe_id = '" + ClasseIdentifiant + "' ORDER BY nom ASC, prenom ASC");
        }

        public static List<Eleve> Bdd_GetEleves_OrderByNom(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM eleves ORDER BY nom ASC, prenom ASC");
        }

        public static Eleve Bdd_GetEleve_ById(int _EleveId, SQLiteConnection maConnexion = null)
        {
            return BddGetobj(maConnexion, @"SELECT * FROM eleves WHERE id = '" + _EleveId + "'");
        }


        // ■ ■ ■ ■ ■ ■ ■ ■ ■ BDD - PRIVATE ■ ■ ■ ■ ■ ■ ■ ■ ■

        private static List<Eleve> BddGetList(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            List<Eleve> ListTemp = new List<Eleve>();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListTemp.Add(new Eleve(r));
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ListTemp;

        }


        private static Eleve BddGetobj(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }
            Eleve ObjTemp = new Eleve();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ObjTemp = new Eleve(r);
            }
            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ObjTemp;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC : OBSOLETE   ■■■■■■■■■■■■■■■■■■■■■■■■

            /*
        [Obsolete("USE : Bdd_GetEleves_OrderByNom")]
        public static List<Eleve> GetBddList()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            List<Eleve> ListTemp = GetBddList(maConnexion);
            maConnexion.Close();

            return ListTemp;
        }
        */

        [Obsolete("USE : Bdd_GetEleves_OrderByNom")]
        public static List<Eleve> GetBddList(SQLiteConnection maConnexion)
        {
            return GetBddList(maConnexion, @"SELECT * FROM eleves ORDER BY nom ASC");
        }



        [Obsolete("USE : Bdd_GetEleves_OrderByNom")]
        public static List<Eleve> GetBddList(SQLiteConnection connect, String StrSql)
        {
            List<Eleve> ListObjets = new List<Eleve>();
            SQLiteCommand fmd = connect.CreateCommand();

            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListObjets.Add(new Eleve(r));
            }

            return ListObjets;
        }

        [Obsolete("USE : Bdd_GetEleves_OrderByNom")]
        public static List<Eleve> GetListElevesFromBdd()
        {
            List<Eleve> ElevesTemp = new List<Eleve>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves ORDER BY nom ASC, prenom ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ElevesTemp.Add(new Eleve(r));
                    }
                }
                connect.Close();
            }
            return ElevesTemp;
        }



        /// Charge aussi les responsables, et suivis
        public static Eleve GetEleveByIdFromBdd(int EleveId)
        {
            Eleve EleveTemp = new Eleve();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();


                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves Where id = '" + EleveId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        EleveTemp = new Eleve(r);
                    }


                }

                //  List<int> ResponsablesIds = new List<int>();
                //   List<Responsable> Responsables = new List<Responsable>();

                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    fmd.CommandText = @"SELECT * FROM eleves_responsables Where eleve_id = '" + EleveId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        int respid = r.GetInt32(r.GetOrdinal("responsable_id"));
                        //ResponsablesIds.Add(respid);
                        EleveTemp.Responsables.Add(Responsable.GetResponsableByIdFromBdd(connect, respid));

                    }

                }


                using (SQLiteCommand fmd = connect.CreateCommand())
                {

                    fmd.CommandText = @"SELECT * FROM suivis Where eleve_id = '" + EleveId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        //   int respid = r.GetInt32(r.GetOrdinal("responsable_id"));
                        //ResponsablesIds.Add(respid);
                        EleveTemp.Suivis.Add(new Suivi(r));

                    }

                }


                connect.Close();

            }
            return EleveTemp;
        }


        public static List<Eleve> GetListElevesFromBddByClasseIdentifiant_SortByNiveau(int ClasseIdentifiant)
        {
            List<Eleve> ElevesTemp = new List<Eleve>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves WHERE classe_id = '" + ClasseIdentifiant + "' ORDER BY niveau ASC, nom ASC, prenom ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ElevesTemp.Add(new Eleve(r));
                    }
                }
                connect.Close();
            }
            return ElevesTemp;
        }


        public static List<Eleve> GetListElevesFromBddByClasseIdentifiant(int ClasseIdentifiant)
        {
            List<Eleve> ElevesTemp = new List<Eleve>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves WHERE classe_id = '" + ClasseIdentifiant + "' ORDER BY nom ASC, prenom ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ElevesTemp.Add(new Eleve(r));
                    }
                }
                connect.Close();
            }
            return ElevesTemp;
        }

        public static int FindEleveIdByNomPrenom(SQLiteConnection connect, String EleveNom, String ElevePrenom)
        {
            int EleveId = 0;

            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM eleves WHERE nom = '" + EleveNom + "' AND prenom = '" + ElevePrenom + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader rdr = fmd.ExecuteReader();
                while (rdr.Read())
                {
                    EleveId = rdr.GetInt32(rdr.GetOrdinal("id"));
                }
            }

            return EleveId;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public String Prenom { get => m_prenom; set => m_prenom = value; }
        public String DateNaissance { get => m_dateNaissance; set => m_dateNaissance = value; }
        public String Sexe { get => m_sexe; set => m_sexe = value; }
        public String Ine { get => m_ine; set => m_ine = value; }
        public String Cycle { get => m_cycle; set => m_cycle = value; }
        public String Niveau { get => m_niveau; set => m_niveau = value; }
        public int ClasseId { get => m_classeId; set => m_classeId = value; }
        public String Attestation { get => m_attestation; set => m_attestation = value; }
        public String AutorisationPhoto { get => m_autorisationPhoto; set => m_autorisationPhoto = value; }
        public String DecisionPassage { get => m_decisionPassage; set => m_decisionPassage = value; }
        public String Dispositifs { get => m_dispositifs; set => m_dispositifs = value; }
        public Boolean Delegue { get => m_delegue; set => m_delegue = value; }
        public String DpExterne { get => m_dpExterne; set => m_dpExterne = value; }
        public String Garderie { get => m_garderie; set => m_garderie = value; }
        public String Alae { get => m_alae; set => m_alae = value; }
        public String DateEntree { get => m_dateEntree; set => m_dateEntree = value; }
        public String DateSortie { get => m_dateSortie; set => m_dateSortie = value; }
        public String ImportGenre { get => m_importGenre; set => m_importGenre = value; }
        public List<Responsable> Responsables { get => m_responsables; set => m_responsables = value; }
        public List<Accompagnement> Accompagnements { get => m_accompagnements; set => m_accompagnements = value; }
        public List<Suivi> Suivis { get => m_suivis; set => m_suivis = value; }
        public List<Personnel> Personnels { get => m_personnels; set => m_personnels = value; }
        public List<Appel> Appels { get => m_appels; set => m_appels = value; }
        public String ImportInfos { get => m_importInfos; set => m_importInfos = value; }
        public DataGridViewRow DgvRow { get => m_dgvRow; set => m_dgvRow = value; }


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }


}
