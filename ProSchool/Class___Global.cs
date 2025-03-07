using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public class Global
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static Utilisateur User;

        public static String StrSQLiteConnection = @"Data Source=DATA\BDD\proschool_bdd.sqlite;Version=3;";

        /*
        Color.FromArgb(10, 155, 106);   // pronoteColor      Bulletins   vert

        Color.FromArgb(185, 51, 95);    // pronoteColor      Comm        Bordeau
        Color.FromArgb(112, 92, 177);   // pronoteColor      Notes       Mauve 1
        Color.FromArgb(50, 115, 181);   // pronoteColor      stage       Bleu
        Color.FromArgb(2, 129, 166);    // pronoteColor      Compet      bleu canard

        Color.FromArgb(208, 87, 34);    // pronoteColor      QCM         orange fonce
        Color.FromArgb(225, 132, 0);    // pronoteColor      Result      orange 2

        Color.FromArgb(194, 59, 69);    // pronoteColor      Sanc        Rouge


        //////////// Color.FromArgb(147, 122, 51);   // pronoteColor      Stat        Marron
        //////////// Color.FromArgb(21, 135, 134);   // pronoteColor      Ressource   Vert Fonce
        //////////// Color.FromArgb(136, 85, 163);   // pronoteColor      Abs         Mauve 2
        //////////// Color.FromArgb(157, 68, 127);   // pronoteColor      Cahier      Mauve-bordeau
        */


        public static Color Color_Menu_Accueil = Color.FromArgb(10, 155, 106);   // pronoteColor      Bulletins   vert
        public static Color Color_Menu_Accueil2 = Color.FromArgb(206, 235, 225);

        public static Color Color_Menu_Eleves = Color.FromArgb(112, 92, 177);   // pronoteColor      Notes       Mauve 1
        public static Color Color_Menu_Eleves2 = Color.FromArgb(212, 206, 231);

        public static Color Color_Menu_Absences = Color.FromArgb(185, 51, 95);    // pronoteColor      Comm        Bordeau
        public static Color Color_Menu_Personnels = Color.FromArgb(50, 115, 181);   // pronoteColor      stage       Bleu
        public static Color Color_Menu_Communication = Color.FromArgb(2, 129, 166);    // pronoteColor      Compet      bleu canard

        public static Color Color_Menu_Agenda = Color.FromArgb(225, 132, 0);    // pronoteColor      Result      orange 2
        public static Color Color_Menu_Agenda2 = Color.FromArgb(255, 224, 192);


        public static Color Color_Menu_Options = Color.FromArgb(194, 59, 69);    // pronoteColor      Sanc        Rouge


        //■■■■■■■■■■■■■■■■■■■■■■■■  APP_RUN    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static void APP_RUN()
        {

            User = new Utilisateur();
            //  MessageBox.Show("zzzz");
            /*
            USER_IsConnected = false;
            USER_Personnel = null;
            USER_IsAdmin = false;
            */
        }


        public static void APP_REFRESH()
        {

            User = new Utilisateur();
            //  MessageBox.Show("zzzz");
            /*
            USER_IsConnected = false;
            USER_Personnel = null;
            USER_IsAdmin = false;
            */
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  DIVERS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static void DGV_AddCol(DataGridView _DGV, String _Name, String _HeaderText = "")
        {
            _DGV.ColumnCount = _DGV.ColumnCount + 1;


            if (_HeaderText == "")
            {
                _HeaderText = _Name;
            }

            _DGV.Columns[_DGV.ColumnCount - 1].Name = _Name;
            _DGV.Columns[_DGV.ColumnCount - 1].HeaderText = _HeaderText;
        }

        public static void RichTXT_AppendText(RichTextBox RichTXT,  Color color, string text)
        {
            RichTXT.SelectionStart = RichTXT.TextLength;
            RichTXT.SelectionLength = 0;

            RichTXT.SelectionColor = color;
            RichTXT.AppendText(text);
            RichTXT.SelectionColor = RichTXT.ForeColor;

        }

        public static void RichTXT_AppendText(RichTextBox RichTXT, Color color, string text, float FontSize)
        {
            RichTXT.SelectionStart = RichTXT.TextLength;
            RichTXT.SelectionLength = 0;

            RichTXT.SelectionFont = new Font(RichTXT.Font.FontFamily, FontSize);
            RichTXT.SelectionColor = color;
            RichTXT.AppendText(text);
            RichTXT.SelectionColor = RichTXT.ForeColor;
        }



        public static void ParserBbCode(RichTextBox RchTxt)
        {
            //■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■
            int n1 = 0;
            int n2 = RchTxt.Text.Length;

            while ((n1 = RchTxt.Text.IndexOf("[b]", n1)) != -1
                && (n2 = RchTxt.Text.IndexOf("[/b]", n1)) != -1)
            {
                RchTxt.Select(n1 + 3, n2 - n1 - 3);
                using (var boldFont = new Font(RchTxt.SelectionFont, FontStyle.Bold))
                    RchTxt.SelectionFont = boldFont;

                n1 = n2;
            }

            RchTxt.Rtf = RchTxt.Rtf.Replace("[b]", string.Empty);
            RchTxt.Rtf = RchTxt.Rtf.Replace("[/b]", string.Empty);

            //■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■

            n1 = 0;
            n2 = RchTxt.Text.Length;

            while ((n1 = RchTxt.Text.IndexOf("[u]", n1)) != -1
                && (n2 = RchTxt.Text.IndexOf("[/u]", n1)) != -1)
            {
                RchTxt.Select(n1 + 3, n2 - n1 - 3);
                using (var boldFont = new Font(RchTxt.SelectionFont, FontStyle.Underline))
                    RchTxt.SelectionFont = boldFont;

                n1 = n2;
            }

            RchTxt.Rtf = RchTxt.Rtf.Replace("[u]", string.Empty);
            RchTxt.Rtf = RchTxt.Rtf.Replace("[/u]", string.Empty);

            //■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■

            n1 = 0;
            n2 = RchTxt.Text.Length;

            while ((n1 = RchTxt.Text.IndexOf("[i]", n1)) != -1
                && (n2 = RchTxt.Text.IndexOf("[/i]", n1)) != -1)
            {
                RchTxt.Select(n1 + 3, n2 - n1 - 3);
                using (var boldFont = new Font(RchTxt.SelectionFont, FontStyle.Italic))
                    RchTxt.SelectionFont = boldFont;

                n1 = n2;
            }

            RchTxt.Rtf = RchTxt.Rtf.Replace("[i]", string.Empty);
            RchTxt.Rtf = RchTxt.Rtf.Replace("[/i]", string.Empty);


            //■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■ ■■

        }




        public static void Ajust_SplitCont_Width_from_DGV(DataGridView DGV, SplitContainer SplitC, int Ajout)
        {
            int Width = Ajout;
            foreach (DataGridViewColumn Col in DGV.Columns)
            {
                if (Col.Visible)
                {
                    Width += Col.Width;
                }
            }

            SplitC.SplitterDistance = Width;
        }
        public static List<SuiviGenre> GetListSuiviGenres()
        {
            List<SuiviGenre> ListTemp = new List<SuiviGenre>();
            ListTemp.Add(new SuiviGenre(1, "Commentaire divers", true, false, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(2, "Entretien Educatrice", true, true, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(3, "Entretien AS", true, true, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(4, "Entretien Eleve et/ou Famille", true, true, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(5, "Equipe educative", true, true, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(6, "ESS (Equipe Suivi Sco)", true, true, Color.Red, Color.Green));
            ListTemp.Add(new SuiviGenre(7, "Visite medicale", true, true, Color.Red, Color.Green));
            return ListTemp;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  DATES    ■■■■■■■■■■■■■■■■■■■■■■■■

        public static Boolean IsVacances(SQLiteConnection connect, String StrDate)
        {
            Boolean Vac = false;


            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM evenements WHERE genre='Vacances' AND date_debut <='" + StrDate + "' AND date_fin >='" + StrDate + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    Vac = true;
                }

            }
            return Vac;
        }

        public static Boolean IsFerie(SQLiteConnection connect, String StrDate)
        {
            Boolean Fer = false;

            using (SQLiteCommand fmd = connect.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM evenements WHERE genre='Férié' AND date_debut='" + StrDate + "'";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    Fer = true;
                }

            }
            return Fer;
        }

        public static DateTime GetMondayOfCurrentWeek()
        {
            DateTime _today = DateTime.Today;
            DateTime sun = _today.DayOfWeek == DayOfWeek.Sunday ? _today : _today.AddDays(7 - (int)_today.DayOfWeek);
            return sun.AddDays(-6);
        }

        public static DateTime GetMondayFromDateTime(DateTime Dt)
        {
            DateTime sun = Dt.DayOfWeek == DayOfWeek.Sunday ? Dt : Dt.AddDays(7 - (int)Dt.DayOfWeek);
            return sun.AddDays(-6);
        }

        public static DateTime GetNextSundayFromDateTime(DateTime Dt)
        {
            DateTime sun = Dt.DayOfWeek == DayOfWeek.Sunday ? Dt : Dt.AddDays(7 - (int)Dt.DayOfWeek);
            return sun;
        }

        public static DateTime GetFirstDayOfMonth(DateTime Dt)
        {

            DateTime FirstDayOfMonth = new DateTime(Dt.Year, Dt.Month, 1); ;
            return FirstDayOfMonth;
        }

        public static string HumanDateDiffFromToday(DateTime DT)
        {
            String StrReturn = "";

            TimeSpan difference = DT.Subtract(DateTime.Today);

            if (difference.Days == 0)
            {
                StrReturn = "Aujourd'hui";
            }
            else if (difference.Days == 1)
            {
                StrReturn = "Demain";
            }
            else if (difference.Days == -1)
            {
                StrReturn = "Hier";
            }
            else if (difference.Days > 0)
            {
                StrReturn = "Dans " + difference.Days + " jour";
            }
            else if (difference.Days < 0)
            {
                StrReturn = "Il y a " + Math.Abs(difference.Days) + " jour";
            }

            if (Math.Abs(difference.Days) > 1)
            {
                StrReturn += "s";
            }

            return StrReturn;
        }

        public static int CalculAge(DateTime anniversaire)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - anniversaire.Year;
            if (anniversaire > now.AddYears(-age))
                age--;
            return age;
        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
