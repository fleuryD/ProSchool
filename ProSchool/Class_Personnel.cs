using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Personnel
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private String m_nom;
        private String m_prenom;
        private String m_pseudo;
        private String m_genre;
        private String m_password;
        private String m_sexe;
        private String m_telephonePortable;
        private String m_telephoneDomicile;
        private String m_mail;
        private String m_mail2;
        private String m_adresse;


        private List<Classe> m_classes; // NOT IN BDD
        private List<Eleve> m_eleves; // NOT IN BDD     (pour les AVS)


        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Personnel()
        {
            this.m_nom = "?";
            this.m_prenom = "?";
        }


        public Personnel(String nom, String prenom, String pseudo, String genre, String password, String sexe, String telephonePortable, String telephoneDomicile, String mail, String mail2, String adresse)
        {
         //   this.m_id = id;
            this.m_nom = nom;
            this.m_prenom = prenom;
            this.m_pseudo = pseudo;
            this.m_genre = genre;
            this.m_password = password;
            this.m_sexe = sexe;
            this.m_telephonePortable = telephonePortable;
            this.m_telephoneDomicile = telephoneDomicile;
            this.m_mail = mail;
            this.m_mail2 = mail2;
            this.m_adresse = adresse;
        }



        public Personnel(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_nom = rdr["nom"].ToString();
            this.m_prenom = rdr["prenom"].ToString();
            this.m_pseudo = rdr["pseudo"].ToString();
            this.m_genre = rdr["genre"].ToString();
            this.m_password = rdr["password"].ToString();
            this.m_sexe = rdr["sexe"].ToString();
            this.m_telephonePortable = rdr["telephone_portable"].ToString();
            this.m_telephoneDomicile = rdr["telephone_domicile"].ToString();
            this.m_mail = rdr["mail"].ToString();
            this.m_mail2 = rdr["mail2"].ToString();
            this.m_adresse = rdr["adresse"].ToString();

            this.m_classes = new List<Classe>();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO personnels " +
                                       "(   nom,  prenom,  pseudo,  genre,  password,  sexe,  telephone_portable,  telephone_domicile,  mail,  mail2,  adresse) " +
                                "VALUES ( @nom, @prenom, @pseudo, @genre, @password, @sexe, @telephone_portable, @telephone_domicile, @mail, @mail2, @adresse)";

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

      /////////////      command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@pseudo", this.m_pseudo);
            command.Parameters.AddWithValue("@genre", this.m_genre);
            command.Parameters.AddWithValue("@password", this.m_password);
            command.Parameters.AddWithValue("@sexe", this.m_sexe);
            command.Parameters.AddWithValue("@telephone_portable", this.m_telephonePortable);
            command.Parameters.AddWithValue("@telephone_domicile", this.m_telephoneDomicile);
            command.Parameters.AddWithValue("@mail", this.m_mail);
            command.Parameters.AddWithValue("@mail2", this.m_mail2);
            command.Parameters.AddWithValue("@adresse", this.m_adresse);


            command.ExecuteNonQuery();
            this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }


        public void UpdateInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);



            command.CommandText = "UPDATE personnels SET "+
                "nom = @nom, " +
                "prenom = @prenom, " +
                "pseudo = @pseudo, " +
                "genre = @genre, " +
                "password = @password, " +
                "sexe = @sexe, " +
                "telephone_portable = @telephone_portable, " +
                "telephone_domicile = @telephone_domicile, " +
                "mail = @mail, " +
                "mail2 = @mail2, " +
                "adresse = @adresse " +
                "WHERE id = @id";


            command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@prenom", this.m_prenom);
            command.Parameters.AddWithValue("@pseudo", this.m_pseudo);
            command.Parameters.AddWithValue("@genre", this.m_genre);
            command.Parameters.AddWithValue("@password", this.m_password);
            command.Parameters.AddWithValue("@sexe", this.m_sexe);
            command.Parameters.AddWithValue("@telephone_portable", this.m_telephonePortable);
            command.Parameters.AddWithValue("@telephone_domicile", this.m_telephoneDomicile);
            command.Parameters.AddWithValue("@mail", this.m_mail);
            command.Parameters.AddWithValue("@mail2", this.m_mail2);
            command.Parameters.AddWithValue("@adresse", this.m_adresse);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }

          /*
          *  Supprime aussi les foreign keys --- SAUF POUR SUIVI
          */
        public void DeleteInBdd()
        {
     
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();

                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM personnels WHERE id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM classes_personnels WHERE personnel_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM eleves_personnels WHERE personnel_id=" + this.m_id + "";
                command.ExecuteNonQuery();

                maConnexion.Close();
            }
        }

        public void SetClasses()
        {
            m_classes = new List<Classe>();

            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM classes_personnels Where personnel_id = '" + this.m_id + "'";     //
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        int ClasseId = r.GetInt32(r.GetOrdinal("classe_id"));
                        m_classes.Add(Classe.Bdd_GetClasse_ById(ClasseId));
                    }
                }

                connect.Close();
            }
        }
        public void SetEleves()
        {
            m_eleves = new List<Eleve>();

            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM eleves_personnels Where personnel_id = '" + this.m_id + "'";     //
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        int EleveId = r.GetInt32(r.GetOrdinal("eleve_id"));
                        m_eleves.Add(Eleve.GetEleveByIdFromBdd(EleveId));
                    }
                }
                connect.Close();
            }
        }



        public static String GetStringListPersonnels(List<Personnel> Perss)
        {

            String str_profs = "";
            String str_personnels = "";

            foreach (Personnel Pers in Perss)
            {

                if (Pers.Genre == "Prof")
                {
                    if (str_profs != "")
                    {
                        str_profs += ", ";
                    }
                    str_profs += Pers.Prenom + " " + Pers.Nom;  // Pers.Prenom + " " + 
                }
                else
                {
                    if (str_personnels != "")
                    {
                        str_personnels += ", ";
                    }
                    str_personnels += Pers.Nom;    //  Pers.Prenom + " " +
                    str_personnels += " (" + Pers.Genre + ")";
                }
            }

            return str_profs + " + " + str_personnels;
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  OBSOLOTES    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static List<Personnel> GetListPersonnelsFromBdd()
        {
            List<Personnel> PersonnelsTemp = new List<Personnel>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM personnels ORDER BY nom ASC, prenom ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        PersonnelsTemp.Add(new Personnel(r));
                    }
                }
                connect.Close();
            }
            return PersonnelsTemp;
        }

        public static Personnel GetPersonnelById(int PersonnelId)
        {
            Personnel PersonnelTemp = new Personnel();

            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM personnels WHERE id = '" + PersonnelId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        PersonnelTemp = new Personnel(r);
                    }
                }
                connect.Close();
            }

            return PersonnelTemp;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public String Prenom { get => m_prenom; set => m_prenom = value; }
        public String Pseudo { get => m_pseudo; set => m_pseudo = value; }
        public String Genre { get => m_genre; set => m_genre = value; }
        public String Password { get => m_password; set => m_password = value; }
        public String Sexe { get => m_sexe; set => m_sexe = value; }
        public String TelephonePortable { get => m_telephonePortable; set => m_telephonePortable = value; }
        public String TelephoneDomicile { get => m_telephoneDomicile; set => m_telephoneDomicile = value; }
        public String Mail { get => m_mail; set => m_mail = value; }
        public String Mail2 { get => m_mail2; set => m_mail2 = value; }
        public String Adresse { get => m_adresse; set => m_adresse = value; }
        public List<Classe> Classes { get => m_classes; set => m_classes = value; }
        public List<Eleve> Eleves { get => m_eleves; set => m_eleves = value; }

       

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
