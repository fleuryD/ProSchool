using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Accompagnement
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public int Id { get; set; }
        public String Nom { get; set; }
        public String NomSimple { get; set; }
        public int Position { get; set; }

     //   public List<Eleve> Eleves { get; set; }     //  NOT in BDD
        public int EleveCount { get; set; }		//  NOT in BDD


        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■
        public Accompagnement()
        {


        }

        public Accompagnement(SQLiteDataReader rdr)
        {
            Id = rdr.GetInt32(rdr.GetOrdinal("id"));
            Nom = rdr["nom"].ToString();
            NomSimple = rdr["nom_simple"].ToString();
            Position = rdr.GetInt32(rdr.GetOrdinal("position"));
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  CRUD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void Bdd_Insert(SQLiteConnection maConnexion = null)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO accompagnements " +
                                       "(nom,  nom_simple,  position) " +
                                "VALUES (@nom, @nom_simple, @position)";
            
        //    command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@nom", Nom);
            command.Parameters.AddWithValue("@nom_simple", NomSimple);
            command.Parameters.AddWithValue("@position", Position);
            
            command.ExecuteNonQuery();
            //  Id = (int)maConnexion.LastInsertRowId;
            if (ConnexACreer)
            {
                maConnexion.Close();
            }

        }
               
        public void Bdd_Update(SQLiteConnection maConnexion = null)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "UPDATE accompagnements SET " +

              
                "nom = @nom, " +
                "nom_simple = @nom_simple, " +
                "position = @position " +
                "WHERE id = @id";
                       

            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@nom", Nom);
            command.Parameters.AddWithValue("@nom_simple", NomSimple);
            command.Parameters.AddWithValue("@position", Position);

            command.ExecuteNonQuery();

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
        }
        
        public void Bdd_Delete(SQLiteConnection maConnexion = null)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM accompagnements WHERE id=" + Id + "";
            command.ExecuteNonQuery();


            command.CommandText = "DELETE FROM accompagnements_eleves WHERE accompagnement_id=" + Id + "";
            command.ExecuteNonQuery();

            if (ConnexACreer)
            {
                maConnexion.Close();
            }

        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void SetEleveCount(SQLiteConnection maConnexion)
        {
            

            SQLiteCommand cmd = maConnexion.CreateCommand();
            cmd.CommandText = "SELECT count(id) FROM accompagnements_eleves WHERE accompagnement_id = '"+Id+"';";
            cmd.CommandType = CommandType.Text;
            
            EleveCount = Convert.ToInt32(cmd.ExecuteScalar());
            
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC    ■■■■■■■■■■■■■■■■■■■■■■■■
               

        public static List<Accompagnement> Bdd_GetAccompagnements_OrderByPosition(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM accompagnements ORDER BY position ASC, nom ASC");
        }

        public static Accompagnement Bdd_GetAccompagnement_ById(int _AccompagnementId, SQLiteConnection maConnexion = null)
        {
            return BddGetobj(maConnexion, @"SELECT * FROM accompagnements WHERE id = '" + _AccompagnementId + "'");
        }


        // ■ ■ ■ ■ ■ ■ ■ ■ ■ BDD - PRIVATE ■ ■ ■ ■ ■ ■ ■ ■ ■

        private static List<Accompagnement> BddGetList(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            List<Accompagnement> ListTemp = new List<Accompagnement>();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListTemp.Add(new Accompagnement(r));
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ListTemp;

        }


        private static Accompagnement BddGetobj(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }
            Accompagnement ObjTemp = new Accompagnement();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ObjTemp = new Accompagnement(r);
            }
            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ObjTemp;
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  OBSOLETE    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static List<Accompagnement> GetListAccompagnementsByEleveId(int EleveId, SQLiteConnection maConnexion = null)
        {

            List<Accompagnement> AccompagnementsTemp = new List<Accompagnement>();

            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }
            using (SQLiteCommand fmd = maConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM accompagnements_eleves WHERE eleve_id = '" + EleveId + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    AccompagnementsTemp.Add(Accompagnement.Bdd_GetAccompagnement_ById(r.GetInt32(r.GetOrdinal("accompagnement_id")), maConnexion));
                }
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }


            return AccompagnementsTemp;
        }
        

        public static List<Accompagnement> GetListAccompagnementsByEleveId(int EleveId, List<Accompagnement> AccAll, SQLiteConnection connect)
        {

            List<Accompagnement> AccompagnementsTemp = new List<Accompagnement>();


            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM accompagnements_eleves WHERE eleve_id = '" + EleveId + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    int AccId = r.GetInt32(r.GetOrdinal("accompagnement_id"));
                   // AccompagnementsTemp.Add(GetAccompagnementById(AccId, connect));
                    AccompagnementsTemp.Add(AccAll.Where(X=>X.Id == AccId).First());
                }
            }

            return AccompagnementsTemp;
        }
        
        /*
        public static List<Accompagnement> GetListAccompagnementsByEleveId(int EleveId, SQLiteConnection connect)
        {

            List<Accompagnement> AccompagnementsTemp = new List<Accompagnement>();


            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM accompagnements_eleves WHERE eleve_id = '" + EleveId + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    int AccId = r.GetInt32(r.GetOrdinal("accompagnement_id"));
                    AccompagnementsTemp.Add(GetAccompagnementById(AccId, connect));
                }
            }

            return AccompagnementsTemp;
        }




        private static Accompagnement GetAccompagnementById(int AccId, SQLiteConnection connect)
        {
            Accompagnement AccTemp = new Accompagnement();


            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM accompagnements WHERE id = '" + AccId + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    AccTemp = new Accompagnement(r);
                }
            }

            return AccTemp;
        }



        private static Accompagnement GetAccompagnementById(int AccId)
        {
            Accompagnement AccTemp = new Accompagnement();

            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM accompagnements WHERE id = '" + AccId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        AccTemp = new Accompagnement(r);
                    }
                }
                connect.Close();
            }

            return AccTemp;
        }
           */ 

        
        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
