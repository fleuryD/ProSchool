using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Appel
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private int m_eleveId;
        private String m_jour;
        private String m_demiJournee;
        private String m_etat;
        private String m_justifiee;
        private String m_infos;

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public Appel()
        {
            this.m_id = 0;
            this.m_eleveId = 0;
            this.m_jour = "";
            this.m_demiJournee = "";
            this.m_etat = "";
            this.m_justifiee = "";
            this.m_infos = "";
        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public Appel(int id, int eleveId, String jour, String demiJournee, String etat, String justifiee, String infos)
        {
            this.m_id = id;
            this.m_eleveId = eleveId;
            this.m_jour = jour;
            this.m_demiJournee = demiJournee;
            this.m_etat = etat;
            this.m_justifiee = justifiee;
            this.m_infos = infos;
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un Appel depuis bdd

        public Appel(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_eleveId = rdr.GetInt32(rdr.GetOrdinal("eleve_id"));
            this.m_jour = rdr["jour"].ToString();
            this.m_demiJournee = rdr["demi_journee"].ToString();
            this.m_etat = rdr["etat"].ToString();
            this.m_justifiee = rdr["justifiee"].ToString();
            this.m_infos = rdr["infos"].ToString();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd()
        {
            SQLiteConnection MaConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            MaConnexion.Open();
            this.InsertInBdd(MaConnexion);
            MaConnexion.Close();
        }

        public void InsertInBdd(SQLiteConnection maConnexion)
        {
         //   SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
      //      maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO appels " +
                                       "( eleve_id,  jour,  demi_journee,  etat,  justifiee,  infos) " +
                                "VALUES (@eleve_id, @jour, @demi_journee, @etat, @justifiee, @infos)";


           // command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@eleve_id", this.m_eleveId);
            command.Parameters.AddWithValue("@jour", this.m_jour);
            command.Parameters.AddWithValue("@demi_journee", this.m_demiJournee);
            command.Parameters.AddWithValue("@etat", this.m_etat);
            command.Parameters.AddWithValue("@justifiee", this.m_justifiee);
            command.Parameters.AddWithValue("@infos", this.m_infos);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        //    maConnexion.Close();
        }

        public void UpdateInBdd()
        {
            SQLiteConnection MaConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            MaConnexion.Open();
            this.UpdateInBdd(MaConnexion);
            MaConnexion.Close();
        }

        public void UpdateInBdd(SQLiteConnection maConnexion)
        {
            SQLiteCommand command = new SQLiteCommand(maConnexion);
          

            command.CommandText = "UPDATE appels SET " +
                "etat = @etat, " +
                "justifiee = @justifiee, " +
                "infos = @infos " +
                "WHERE id = @id";


            command.Parameters.AddWithValue("@id", this.m_id);

            command.Parameters.AddWithValue("@etat", this.m_etat);
            command.Parameters.AddWithValue("@justifiee", this.m_justifiee);
            command.Parameters.AddWithValue("@infos", this.m_infos
                );



            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        }


        public void DeleteInBdd()
        {
            SQLiteConnection MaConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            MaConnexion.Open();
            this.DeleteInBdd(MaConnexion);
            MaConnexion.Close();
        }

        public void DeleteInBdd(SQLiteConnection MaConnexion)
        {
            SQLiteCommand command = new SQLiteCommand(MaConnexion);
            command.CommandText = "DELETE FROM appels WHERE id=" + this.m_id + "";
            command.ExecuteNonQuery();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  OBSOLETES    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static List<Appel> GetAppelFromEleveId(int EleveId)
        {

            List<Appel> AppelsTemp = new List<Appel>();
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();
                using (SQLiteCommand fmd = maConnexion.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + EleveId + "'";
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

        public static Appel GetAppel(int EleveId, String Jour, String DemiJour)
        {

            Appel AppelTemp = null;
            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();
                using (SQLiteCommand fmd = maConnexion.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + EleveId + "' AND  jour = '" + Jour + "' AND  demi_journee = '" + DemiJour + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader rdr = fmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        AppelTemp = new Appel(rdr);
                        //StringReturnAppel = rdr["etat"].ToString();
                    }
                }
                maConnexion.Close();
            }



            return AppelTemp;
        }

        public static List<Appel> GetAppelsPeriode(SQLiteConnection MaConnexion, String DateDebut, String DateFin)
        {

            List<Appel> AppelsTemp = new List<Appel>();

            using (SQLiteCommand fmd = MaConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM appels WHERE jour >= '" + DateDebut + "' AND  jour <= '" + DateFin + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader rdr = fmd.ExecuteReader();
                while (rdr.Read())
                {
                    AppelsTemp.Add(new Appel(rdr));
                    //StringReturnAppel = rdr["etat"].ToString();
                }
            }




            return AppelsTemp;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public int EleveId { get => m_eleveId; set => m_eleveId = value; }
        public String Jour { get => m_jour; set => m_jour = value; }
        public String DemiJournee { get => m_demiJournee; set => m_demiJournee = value; }
        public String Etat { get => m_etat; set => m_etat = value; }
        public String Justifiee { get => m_justifiee; set => m_justifiee = value; }
        public String Infos { get => m_infos; set => m_infos = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
