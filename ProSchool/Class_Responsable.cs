using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Responsable
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private String m_civilite;
        private String m_nomUsage;
        private String m_nom;
        private String m_prenom;
        private String m_adresse;
        private String m_codePostal;
        private String m_commune;
        private String m_pays;
        private String m_mail;
        private String m_telephoneDomicile;
        private String m_telephoneTravail;
        private String m_telephonePortable;

        private int m_eleveId;     // NOT in BDD  // TEMP
        private List<int> m_listEleveId;     // NOT in BDD  // TEMP

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public Responsable()
        {

            this.m_listEleveId = new List<int>();
        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public Responsable(int id, String civilite, String nomUsage, String nom, String prenom, String adresse, String codePostal, String commune, String pays, String mail, String telephoneDomicile, String telephoneTravail, String telephonePortable)
        {
            this.m_id = id;
            this.m_civilite = civilite;
            this.m_nomUsage = nomUsage;
            this.m_nom = nom;
            this.m_prenom = prenom;
            this.m_adresse = adresse;
            this.m_codePostal = codePostal;
            this.m_commune = commune;
            this.m_pays = pays;
            this.m_mail = mail;
            this.m_telephoneDomicile = telephoneDomicile;
            this.m_telephoneTravail = telephoneTravail;
            this.m_telephonePortable = telephonePortable;

            this.m_listEleveId = new List<int>();
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un Responsable depuis bdd

        public Responsable(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_civilite = rdr["civilite"].ToString();
            this.m_nomUsage = rdr["nom_usage"].ToString();
            this.m_nom = rdr["nom"].ToString();
            this.m_prenom = rdr["prenom"].ToString();
            this.m_adresse = rdr["adresse"].ToString();
            this.m_codePostal = rdr["code_postal"].ToString();
            this.m_commune = rdr["commune"].ToString();
            this.m_pays = rdr["pays"].ToString();
            this.m_mail = rdr["mail"].ToString();
            this.m_telephoneDomicile = rdr["telephone_domicile"].ToString();
            this.m_telephoneTravail = rdr["telephone_travail"].ToString();
            this.m_telephonePortable = rdr["telephone_portable"].ToString();


            this.m_listEleveId = new List<int>();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd_WithEleves(SQLiteCommand command, SQLiteConnection maConnexion)
        {

            command.CommandText = "INSERT INTO responsables " +
                                       "(civilite,  nom_usage,  nom,  prenom,  adresse,  code_postal,  commune,  pays,  mail,  telephone_domicile,  telephone_travail,  telephone_portable) " +
                                "VALUES (@civilite, @nom_usage, @nom, @prenom, @adresse, @code_postal, @commune, @pays, @mail, @telephone_domicile, @telephone_travail, @telephone_portable)";
                                     
            //   command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@civilite", this.m_civilite);
            command.Parameters.AddWithValue("@nom_usage", this.m_nomUsage);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@adresse", this.m_adresse);
            command.Parameters.AddWithValue("@code_postal", this.m_codePostal);
            command.Parameters.AddWithValue("@commune", this.m_commune);
            command.Parameters.AddWithValue("@pays", this.m_pays);
            command.Parameters.AddWithValue("@mail", this.m_mail);
            command.Parameters.AddWithValue("@telephone_domicile", this.m_telephoneDomicile);
            command.Parameters.AddWithValue("@telephone_travail", this.m_telephoneTravail);
            command.Parameters.AddWithValue("@telephone_portable", this.m_telephonePortable);
            
            command.ExecuteNonQuery();

            this.m_id = (int)maConnexion.LastInsertRowId;

            foreach (int eleveId in this.m_listEleveId)
            {
                command.CommandText = "INSERT INTO eleves_responsables (eleve_id,  responsable_id) VALUES (@eleve_id, @responsable_id)";

                command.Parameters.AddWithValue("@eleve_id", eleveId);
                command.Parameters.AddWithValue("@responsable_id", this.m_id);


                command.ExecuteNonQuery();
            }
         

        }


        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO responsables " +
                                       "(civilite,  nom_usage,  nom,  prenom,  adresse,  code_postal,  commune,  pays,  mail,  telephone_domicile,  telephone_travail,  telephone_portable) " +
                                "VALUES (@civilite, @nom_usage, @nom, @prenom, @adresse, @code_postal, @commune, @pays, @mail, @telephone_domicile, @telephone_travail, @telephone_portable)" +

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

            //   command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@civilite", this.m_civilite);
            command.Parameters.AddWithValue("@nom_usage", this.m_nomUsage);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@adresse", this.m_adresse);
            command.Parameters.AddWithValue("@code_postal", this.m_codePostal);
            command.Parameters.AddWithValue("@commune", this.m_commune);
            command.Parameters.AddWithValue("@pays", this.m_pays);
            command.Parameters.AddWithValue("@mail", this.m_mail);
            command.Parameters.AddWithValue("@telephone_domicile", this.m_telephoneDomicile);
            command.Parameters.AddWithValue("@telephone_travail", this.m_telephoneTravail);
            command.Parameters.AddWithValue("@telephone_portable", this.m_telephonePortable);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  OBSOLETES    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static List<Responsable> GetListResponsablesFromBdd()
        {
            List<Responsable> ResponsablesTemp = new List<Responsable>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM responsables ORDER BY nom ASC, prenom ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ResponsablesTemp.Add(new Responsable(r));
                    }
                }
                connect.Close();
            }
            return ResponsablesTemp;
        }

        public static Responsable GetResponsableByIdFromBdd(SQLiteConnection connect, int ResponsableId)
        {
            Responsable ResponsableTemp = new Responsable();

            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM responsables Where id = '" + ResponsableId + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    ResponsableTemp = new Responsable(r);
                }


            }

            return ResponsableTemp;
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public String Civilite { get => m_civilite; set => m_civilite = value; }
        public String NomUsage { get => m_nomUsage; set => m_nomUsage = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public String Prenom { get => m_prenom; set => m_prenom = value; }
        public String Adresse { get => m_adresse; set => m_adresse = value; }
        public String CodePostal { get => m_codePostal; set => m_codePostal = value; }
        public String Commune { get => m_commune; set => m_commune = value; }
        public String Pays { get => m_pays; set => m_pays = value; }
        public String Mail { get => m_mail; set => m_mail = value; }
        public String TelephoneDomicile { get => m_telephoneDomicile; set => m_telephoneDomicile = value; }
        public String TelephoneTravail { get => m_telephoneTravail; set => m_telephoneTravail = value; }
        public String TelephonePortable { get => m_telephonePortable; set => m_telephonePortable = value; }
        public int EleveId { get => m_eleveId; set => m_eleveId = value; }
        public List<int> ListEleveId { get => m_listEleveId; set => m_listEleveId = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
