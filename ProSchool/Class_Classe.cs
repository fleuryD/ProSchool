using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csv;

namespace ProSchool
{
    public class Classe
    {
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■


        private int m_id;
        private int m_identifiant;
        private String m_nom;
        private String m_cycles;

        private List<Personnel> m_personnels; // NOT IN BDD
        private List<Eleve> m_eleves; // NOT IN BDD


        private String m_importInfos;  // NOT IN BDD
        private String m_importNewNom;  // NOT IN BDD
        private String m_importNewcycles;  // NOT IN BDD
        private int m_importNewIdentifiant;  // NOT IN BDD
               
        

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Classe()
        {

        }
        
        public Classe(int id, int identifiant, String nom, String cycles)
        {
            this.m_id = id;
            this.m_identifiant = identifiant;
            this.m_nom = nom;
            this.m_cycles = cycles;
        }
               
        public Classe(SQLiteDataReader rdr)
        {
            this.m_id = rdr.GetInt32(rdr.GetOrdinal("id"));
            this.m_identifiant = rdr.GetInt32(rdr.GetOrdinal("identifiant"));
            this.m_nom = rdr["nom"].ToString();
            this.m_cycles = rdr["cycles"].ToString();
        }

        public Classe(ICsvLine CsvLine)
        {
            this.m_id = 666;
            this.m_identifiant = Int32.Parse(CsvLine["Identifiant classe"]);
            this.m_nom = CsvLine["Libellé classe"];
            this.m_cycles = "??"; // "---" + Libelle + "---";


            String[] Cycs = new String[3] { "CE2-CM1-CM2", "CE1", "CP" };
            foreach (String Cyc in Cycs)
            {
                if (this.m_nom.Contains(Cyc))
                {
                    this.m_nom = this.m_nom.Replace(Cyc+" ", "");
                    this.m_cycles = Cyc;
                }
            }


        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  CRUD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void InsertInBdd(SQLiteConnection maConnexion)
        {

            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO classes " +
                                       "(identifiant,  nom,  cycles) " +
                                "VALUES (@identifiant, @nom, @cycles)";

          //command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@identifiant", this.m_identifiant);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@cycles", this.m_cycles);

            command.ExecuteNonQuery();
          //this.m_id = (int)maConnexion.LastInsertRowId;
        }

        public void InsertInBdd_WithId(SQLiteConnection maConnexion)
        {
            SQLiteCommand command = new SQLiteCommand(maConnexion);

            command.CommandText = "INSERT INTO classes " +
                                       "(id, identifiant,  nom,  cycles) " +
                                "VALUES (@id, @identifiant, @nom, @cycles)";

            command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@identifiant", this.m_identifiant);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@cycles", this.m_cycles);

            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        }
        
        public void UpdateInBdd(SQLiteConnection maConnexion)
        {
            SQLiteCommand command = new SQLiteCommand(maConnexion);
            

            command.CommandText = "UPDATE classes SET " +
                "identifiant = @identifiant, " +
                "nom = @nom, " +
                "identifiant = @identifiant, " +
                "cycles = @cycles " +
                "WHERE id = @id";


            command.Parameters.AddWithValue("@id", this.m_id);
            command.Parameters.AddWithValue("@nom", this.m_nom);
            command.Parameters.AddWithValue("@identifiant", this.m_identifiant);
            command.Parameters.AddWithValue("@cycles", this.m_cycles);
            command.Parameters.AddWithValue("@identifiant", this.m_identifiant);


            command.ExecuteNonQuery();
            //  this.m_id = (int)maConnexion.LastInsertRowId;
        }
        
        public void SupprimerInBdd(SQLiteConnection maConnexion)
        {

            SQLiteCommand command = new SQLiteCommand(maConnexion);
            command.CommandText = "DELETE FROM classes WHERE id=" + this.m_id + "";
            command.ExecuteNonQuery();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■

        public void SetPersonnels(SQLiteConnection maConnexion=null)
        {

            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }


            m_personnels = new List<Personnel>();


            using (SQLiteCommand fmd = maConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM classes_personnels Where classe_id = '" + this.m_id + "'";     //
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    int PersonnelId = r.GetInt32(r.GetOrdinal("personnel_id"));
                    m_personnels.Add(Personnel.GetPersonnelById(PersonnelId));
                }
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }

        }

        public void SetEleves(SQLiteConnection maConnexion = null)
        {
            m_eleves = Eleve.Bdd_GetEleves_ByClasseIdentifiant_OrderByNom(this.Identifiant, maConnexion);
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  STATIC    ■■■■■■■■■■■■■■■■■■■■■■■■


        public static List<Classe> Bdd_GetClasses_OrderByName(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM classes ORDER BY nom ASC");
        }

        public static List<Classe> Bdd_GetClasses_OrderByCycle(SQLiteConnection maConnexion = null)
        {
            return BddGetList(maConnexion, @"SELECT * FROM classes ORDER BY cycles ASC, nom ASC");
        }


        public static Classe Bdd_GetClasse_ById(int ClasseId, SQLiteConnection maConnexion = null)
        {
            return BddGetobj(maConnexion, @"SELECT * FROM classes WHERE id = '" + ClasseId + "'");

        }


        // ■ ■ ■ ■ ■ ■ ■ ■ ■ BDD - PRIVATE ■ ■ ■ ■ ■ ■ ■ ■ ■


        private static List<Classe> BddGetList(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            List<Classe> ListTemp = new List<Classe>();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;     // ORDER BY nom ASC, prenom ASC
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ListTemp.Add(new Classe(r));
            }

            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ListTemp;
        }

        private static Classe BddGetobj(SQLiteConnection maConnexion, String StrSql)
        {
            Boolean ConnexACreer = (maConnexion == null);

            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            Classe ObjTemp = new Classe();
            SQLiteCommand fmd = maConnexion.CreateCommand();
            fmd.CommandText = StrSql;
            fmd.CommandType = CommandType.Text;
            SQLiteDataReader r = fmd.ExecuteReader();
            while (r.Read())
            {
                ObjTemp = new Classe(r);
            }


            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return ObjTemp;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  CLASSES    ■■■■■■■■■■■■■■■■■■■■■■■■

        /*
    [Obsolete("Utiliser : Classe.Bdd_GetClasses_OrderByName")]
    public static List<Classe> GetListClassesFromBdd()
    {
        List<Classe> ClassesTemp = new List<Classe>();
        using (SQLiteConnection connect = new SQLiteConnection(Global.StrSQLiteConnection))
        {
            connect.Open();
            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM classes";     // ORDER BY nom ASC, prenom ASC
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    ClassesTemp.Add(new Classe(r));
                }
            }
            connect.Close();
        }
        return ClassesTemp;
    }
    */

        /*
        [Obsolete("Utiliser : Bdd_GetClasse_ById")]
        public static Classe GetClasselById(int ClasseId)
        {
            Classe ClasseTemp = new Classe();

            using (SQLiteConnection connect = new SQLiteConnection(StrSQLiteConnection))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT * FROM classes WHERE id = '" + ClasseId + "'";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ClasseTemp = new Classe(r);
                    }
                }
            }

            return ClasseTemp;
        }
        
    */

        public static Dictionary<int, Classe> Get_Dico_Idents_Classes_FromBdd(SQLiteConnection maConnexion = null)
        {

            Boolean ConnexACreer = (maConnexion == null);
            if (ConnexACreer)
            {
                maConnexion = new SQLiteConnection(Global.StrSQLiteConnection);
                maConnexion.Open();
            }

            Dictionary<int, Classe> Dico_Idents_Classes = new Dictionary<int, Classe>();

            using (SQLiteCommand fmd = maConnexion.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM classes";     // ORDER BY nom ASC, prenom ASC
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    Classe Cl = new Classe(r);
                    Dico_Idents_Classes.Add(Cl.Identifiant, Cl);
                }
            }


            if (ConnexACreer)
            {
                maConnexion.Close();
            }
            return Dico_Idents_Classes;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public int Identifiant { get => m_identifiant; set => m_identifiant = value; }
        public String Nom { get => m_nom; set => m_nom = value; }
        public String Cycles { get => m_cycles; set => m_cycles = value; }
        public List<Personnel> Personnels { get => m_personnels; set => m_personnels = value; }
        public string ImportInfos { get => m_importInfos; set => m_importInfos = value; }
        public string ImportNewNom { get => m_importNewNom; set => m_importNewNom = value; }
        public string ImportNewcycles { get => m_importNewcycles; set => m_importNewcycles = value; }
        public int ImportNewIdentifiant { get => m_importNewIdentifiant; set => m_importNewIdentifiant = value; }
        public List<Eleve> Eleves { get => m_eleves; set => m_eleves = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
