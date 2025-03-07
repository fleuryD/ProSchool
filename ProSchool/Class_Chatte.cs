using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    // add reference to System.ComponentModel.DataAnnotations assembly to utilize the Data Annotation feature as below.
using System.ComponentModel;
using SQLite.Net.Attributes;
using System.Data.SQLite;
using System.Data;

namespace ProSchool
{

    public class Chatte
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private int m_personnelId;
        private String m_dateHeure;
        private String m_contenu;

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public Chatte()
        {

        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public Chatte(int personnelId, String dateHeure, String contenu)
        {

            this.m_personnelId = personnelId;
            this.m_dateHeure = dateHeure;
            this.m_contenu = contenu;
        }

        public Chatte(int id, int personnelId, String dateHeure, String contenu)
        {
            this.m_id = id;
            this.m_personnelId = personnelId;
            this.m_dateHeure = dateHeure;
            this.m_contenu = contenu;
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un Chatte depuis bdd

        public Chatte(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_personnelId = rdr.GetInt32(rdr.GetOrdinal("personnel_id"));
            this.m_dateHeure = rdr["date_heure"].ToString();
            this.m_contenu = rdr["contenu"].ToString();
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO chattes " +
                                       "(personnel_id,  date_heure,  contenu) " +
                                "VALUES (@personnel_id, @date_heure, @contenu)";


            command.Parameters.AddWithValue("@personnel_id", this.m_personnelId);
            command.Parameters.AddWithValue("@date_heure", this.m_dateHeure);
            command.Parameters.AddWithValue("@contenu", this.m_contenu);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  OBSOLETES    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static List<Chatte> GetListChattesFromBdd()
        {
            List<Chatte> ChattesTemp = new List<Chatte>();
            using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM chattes ORDER BY date_heure ASC";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ChattesTemp.Add(new Chatte(r));
                    }
                }
                connect.Close();
            }
            return ChattesTemp;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public int PersonnelId { get => m_personnelId; set => m_personnelId = value; }
        public String DateHeure { get => m_dateHeure; set => m_dateHeure = value; }
        public String Contenu { get => m_contenu; set => m_contenu = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■




    }
}
