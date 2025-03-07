using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class Utilisateur
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

     //   private int m_id;    //  NOT in BDD
        private Boolean m_isConnected;    //  NOT in BDD
        private Personnel m_personnel;    //  NOT in BDD

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public Utilisateur()
        {
            this.m_isConnected = false;
            this.m_personnel = null;
        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public Utilisateur(int id, Boolean isConnected, Personnel personnel)
        {
         //   this.m_id = id;
            this.m_isConnected = isConnected;
            this.m_personnel = personnel;
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un User depuis bdd
        /*
        public User(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal(""));
            this.m_isConnected =
            this.m_personnel =
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO  " +
                                       "( ,  ,  ) " +
                                "VALUES (@, @, @)" +

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

            command.Parameters.AddWithValue("@", this.m_id);
            command.Parameters.AddWithValue("@", this.m_isConnected);
            command.Parameters.AddWithValue("@", this.m_personnel);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }

    */
        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


     //   public int Id { get => m_id; set => m_id = value; }
        public Boolean IsConnected { get => m_isConnected; set => m_isConnected = value; }
        public Personnel Personnel { get => m_personnel; set => m_personnel = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
