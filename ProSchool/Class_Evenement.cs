using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Evenement
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private String m_genre;
        private String m_dateDebut;
        private String m_dateFin;
        private String m_nom;
        private String m_infos;

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public Evenement()
        {

        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public Evenement(int id, String genre, String dateDebut, String dateFin, String nom, String infos)
        {
            this.m_id = id;
            this.m_genre = genre;
            this.m_dateDebut = dateDebut;
            this.m_dateFin = dateFin;
            this.m_nom = nom;
            this.m_infos = infos;
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un Evenement depuis bdd

        public Evenement(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_genre = rdr["genre"].ToString();
            this.m_dateDebut = rdr["date_debut"].ToString();
            this.m_dateFin = rdr["date_fin"].ToString();
            this.m_nom = rdr["nom"].ToString();
            this.m_infos = rdr["infos"].ToString();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■
        
       [Obsolete("A MODERNISER")]
        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO evenements " +
                                       "(genre,  date_debut,  date_fin,  nom,  infos) " +
                                "VALUES (@genre, @date_debut, @date_fin, @nom, @infos)";

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

            command.Parameters.AddWithValue("@genre", this.m_genre);
            command.Parameters.AddWithValue("@date_debut", this.m_dateDebut);
            command.Parameters.AddWithValue("@date_fin", this.m_dateFin);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@infos", this.m_infos);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }


        [Obsolete("A MODERNISER")]
        public void UpdateInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);



            command.CommandText = "UPDATE evenements SET " +
                "nom = @nom, " +
                "genre = @genre, " +
                "date_debut = @date_debut, " +
                "date_fin = @date_fin, " +
                "infos = @infos " +
                "WHERE id = @id";


            command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@genre", this.m_genre);
            command.Parameters.AddWithValue("@date_debut", this.m_dateDebut);
            command.Parameters.AddWithValue("@date_fin", this.m_dateFin);
            command.Parameters.AddWithValue("@infos", this.m_infos);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }

        [Obsolete("A MODERNISER")]
        public void DeleteInBdd()
        {

            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();

                SQLiteCommand command = new SQLiteCommand(maConnexion);
                command.CommandText = "DELETE FROM evenements WHERE id=" + this.m_id + "";
                command.ExecuteNonQuery();

          

                maConnexion.Close();
            }
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC    ■■■■■■■■■■■■■■■■■■■■■■■■


        public static List<Evenement> Bdd_GetEvenements_Futurs(SQLiteConnection maConnexion = null)
        {
            String DateToday = DateTime.Today.ToString("yyyy-MM-dd");

            return BddGetList(maConnexion, @"SELECT * FROM evenements WHERE date_debut >= '"+ DateToday + "' OR (date_fin != '' AND date_fin >= '" + DateToday + "') ORDER BY date_debut ASC");
        }
        public static List<Evenement> Bdd_GetEvenements_OrderByDate(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM evenements ORDER BY date_debut ASC");
        }

        public static Evenement Bdd_GetEvenement_ById(int _EvenementId, SQLiteConnection maConnexion = null)
        {
            return BddGetobj(maConnexion, @"SELECT * FROM evenements WHERE id = '" + _EvenementId + "'");
        }


        // ■ ■ ■ ■ ■ ■ ■ ■ ■ BDD - PRIVATE ■ ■ ■ ■ ■ ■ ■ ■ ■

        private static List<Evenement> BddGetList(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            List<Evenement> ListTemp = new List<Evenement>();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListTemp.Add(new Evenement(r));
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ListTemp;

        }


        private static Evenement BddGetobj(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }
            Evenement ObjTemp = new Evenement();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ObjTemp = new Evenement(r);
            }
            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ObjTemp;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC : ANCIENNES VERSIONS A MODIFIER    ■■■■■■■■■■■■■■■■■■■■■■■■

        [Obsolete("Use Bdd_GetEvenements_OrderByDate")]
        public static List<Evenement> GetListEvenementsFromBdd()
        {
            List<Evenement> EvenementsTemp = new List<Evenement>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM evenements ORDER By date_debut ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        EvenementsTemp.Add(new Evenement(r));
                    }
                }
                connect.Close();
            }
            return EvenementsTemp;
        }



        public static List<Evenement> GetListEvenementsVacancesFeriesFromBdd()
        {
            List<Evenement> EvenementsTemp = new List<Evenement>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM evenements WHERE genre='Vacances'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        EvenementsTemp.Add(new Evenement(r));
                    }
                }
                connect.Close();

            }
            return EvenementsTemp;
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public String Genre { get => m_genre; set => m_genre = value; }
        public String DateDebut { get => m_dateDebut; set => m_dateDebut = value; }
        public String DateFin { get => m_dateFin; set => m_dateFin = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public String Infos { get => m_infos; set => m_infos = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
