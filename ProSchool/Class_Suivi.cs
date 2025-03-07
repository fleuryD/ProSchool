using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Suivi
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
        
        public int Id { get; set; }
        public int EleveId { get; set; }
        public int PersonnelId { get; set; }
        public String Genre { get; set; }
        public int GenreId { get; set; }
        public String DateHeure { get; set; }
        public String Contenu { get; set; }
        public String Decision { get; set; }
        public String EleveOuFamille { get; set; }


        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Suivi()
        {

        }


        public Suivi(SQLiteDataReader rdr)
        {
            Id = rdr.GetInt32(rdr.GetOrdinal("id"));
            EleveId = rdr.GetInt32(rdr.GetOrdinal("eleve_id"));
            PersonnelId = rdr.GetInt32(rdr.GetOrdinal("personnel_id"));
            Genre = rdr["genre"].ToString();
            GenreId = rdr.GetInt32(rdr.GetOrdinal("genre_id"));
            DateHeure = rdr["date_heure"].ToString();
            Contenu = rdr["contenu"].ToString();
            Decision = rdr["decision"].ToString();
            EleveOuFamille = rdr["eleve_ou_famille"].ToString();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        public void Bdd_Insert(SQLiteConnection maConnexion = null)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO suivis " +
                                       "(eleve_id,  personnel_id,  genre,  genre_id,  date_heure,  contenu,  decision,  eleve_ou_famille) " +
                                "VALUES (@eleve_id, @personnel_id, @genre, @genre_id, @date_heure, @contenu, @decision, @eleve_ou_famille)";
            
          //  command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@eleve_id", EleveId);
            command.Parameters.AddWithValue("@personnel_id", PersonnelId);
            command.Parameters.AddWithValue("@genre", Genre);
            command.Parameters.AddWithValue("@genre_id", GenreId);
            command.Parameters.AddWithValue("@date_heure", DateHeure);
            command.Parameters.AddWithValue("@contenu", Contenu);
            command.Parameters.AddWithValue("@decision", Decision);
            command.Parameters.AddWithValue("@eleve_ou_famille", EleveOuFamille);


            command.ExecuteNonQuery();
            //  Id = (int)maConnexion.LastInsertRowId;
            if (ConnexACreer)
            {
                maConnexion.Close();
            }

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC    ■■■■■■■■■■■■■■■■■■■■■■■■


        public static List<Suivi> Bdd_GetSuivis_OrderByX(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM suivis ORDER BY date_heure ASC");
        }
        
        public static List<Suivi> Bdd_GetSuivis_ByEleveId(int EleveId, SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM suivis  WHERE eleve_id = '" + EleveId + "' ORDER BY date_heure ASC");
        }
               
        public static Suivi Bdd_GetSuivi_ById(int _SuiviId, SQLiteConnection maConnexion = null)
        {
            return BddGetobj(maConnexion, @"SELECT * FROM suivis WHERE id = '" + _SuiviId + "'");
        }


        // ■ ■ ■ ■ ■ ■ ■ ■ ■ BDD - PRIVATE ■ ■ ■ ■ ■ ■ ■ ■ ■

        private static List<Suivi> BddGetList(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            List<Suivi> ListTemp = new List<Suivi>();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListTemp.Add(new Suivi(r));
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ListTemp;

        }
        
        private static Suivi BddGetobj(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }
            Suivi ObjTemp = new Suivi();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ObjTemp = new Suivi(r);
            }
            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ObjTemp;
        }
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
