using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSchool
{
    public class SuiviGenre
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;
        private String m_nom;
        private Boolean m_enableContenu;
        private Boolean m_enableDecision;
        private Color m_color1;
        private Color m_color2;

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public SuiviGenre()
        {

        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public SuiviGenre(int id, String nom, Boolean enableContenu, Boolean enableDecision, Color color1, Color color2)
        {
            this.m_id = id;
            this.m_nom = nom;
            this.m_enableContenu = enableContenu;
            this.m_enableDecision = enableDecision;
            this.m_color1 = color1;
            this.m_color2 = color2;
        }


        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ Construire un SuiviGenre depuis bdd
        /*
        public SuiviGenre(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_nom = rdr["nom"].ToString();
            this.m_enableContenu =
            this.m_enableDecision =
            this.m_color1 =
            this.m_color2 =
        }
        */

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

       




        /*
        public void InsertInBdd()
        {
            SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
            maConnexion.Open();
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO suivi_genres " +
                                       "( id,  nom,  enable_contenu,  enable_decision,  color1,  color2) " +
                                "VALUES (@id, @nom, @enable_contenu, @enable_decision, @color1, @color2)" +

            ///////////// SUPPRIMER LA LIGNE ID !!!!!!!!!!!!!!!!!!!!

            command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@enable_contenu", this.m_enableContenu);
            command.Parameters.AddWithValue("@enable_decision", this.m_enableDecision);
            command.Parameters.AddWithValue("@color1", this.m_color1);
            command.Parameters.AddWithValue("@color2", this.m_color2);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
            maConnexion.Close();
        }

    */
        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public Boolean EnableContenu { get => m_enableContenu; set => m_enableContenu = value; }
        public Boolean EnableDecision { get => m_enableDecision; set => m_enableDecision = value; }
        public Color Color1 { get => m_color1; set => m_color1 = value; }
        public Color Color2 { get => m_color2; set => m_color2 = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
