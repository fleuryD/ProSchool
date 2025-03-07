using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_About : Form
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■
        public struct Todo
        {
            public String Genre;
            public String Infos;

            public Todo(string _genre, string _infos)
            {
                Genre = _genre;
                Infos = _infos;
            }
        }

        public struct Maj
        {
            public String Version;
            public String Genre;
            public String Infos;

            public Maj(String _version, string _genre, string _infos)
            {
                Version = _version;
                Genre = _genre;
                Infos = _infos;
            }
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■


        public F_About()
        {
            InitializeComponent();
        }

        private void F_About_Load(object sender, EventArgs e)
        {



            List<Todo> Todos = GetListTodos();
            List<Maj> Majs = GetListMajs();

            //■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   

            String StrTodos = "\r\n[b]      TODO :[/b]\r\n\r\n";
            String PreviousGenre = "azeazeazeaze";
                       
            foreach (Todo TD in Todos.OrderBy(X => X.Genre))
            {
                if (PreviousGenre != TD.Genre)
                {
                    PreviousGenre = TD.Genre;
                    StrTodos += "[b]\r\n•  " + TD.Genre + " :[/b]\r\n";
                }

                StrTodos += "[b]   ➔ [/b]" + TD.Infos + "\r\n";
            }

            //■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   

            String StrMajs = "\r\n[b]      MISES A JOUR :[/b]\r\n\r\n";
            String PreviousVersion = "azeazeazeaze";

            foreach (Maj TD in Majs.OrderByDescending(X =>X.Version))
            {
                if (PreviousVersion != TD.Version)
                {
                    PreviousVersion = TD.Version;
                    StrMajs += "[b]\r\n•  " + TD.Version + " :[/b]\r\n";
                }

                StrMajs += "[b]   ➔ " + TD.Genre + " •• [/b]" + TD.Infos + "\r\n";
            }

            //■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   ■■■■   


            RICHTXT_Help.Text = GetStringHelp();
            Global.ParserBbCode(RICHTXT_Help);

            RICHTXT_Todo.Text = StrTodos;
            Global.ParserBbCode(RICHTXT_Todo);

            RICHTXT_Maj.Text = StrMajs;
            Global.ParserBbCode(RICHTXT_Maj);


            RICHTXT_Todo.Width = this.Width / 3;
            RICHTXT_Help.Width = this.Width / 3;

        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■



        private String GetStringHelp()
        {
            String RC = "\r\n";

            String StrHelp = "\r\n[b]      AIDES, ASTUCES :[/b]\r\n\r\n";


             StrHelp += RC;


            StrHelp += "[b] • LES TABLEAUX[/b]" + RC + RC;
            StrHelp += "     ➔ Vous pouvez copier-coller dans excel (presque) tous les tableaux (ex : liste d'élèves, classes...) :" + RC;
            StrHelp += "                - Cliquez sur une ligne du tableau" + RC;
            StrHelp += "                - [b]Control + A[/b] : pour séléctionner toutes les lignes" + RC;
            StrHelp += "                - [b]Control + C[/b] : pour copier" + RC;
            StrHelp += "                - Dans Excel, selectionnéz une cellule" + RC;
            StrHelp += "                - [b]Control + V[/b] : pour coller" + RC;


            StrHelp += RC;

            StrHelp += RC;


            StrHelp += " • [b]\"ProSchool\"[/b], ça se pronnonce [i]\"Duruize\"[/i] et pas [i]\"Duruizède\"[/i]  !" + RC;

            

            StrHelp += RC;

            return StrHelp;
        }

        private List<Maj> GetListMajs()
        {
            List<Maj> Majs = new List<Maj>();

            Majs.Add(new Maj("0.62", "About", "debut - BBCode : Todo, Mises à jour et Help"));
 
            Majs.Add(new Maj("0.61",  "About", "Debut Todo BBCode"));

            Majs.Add(new Maj("0.61", "Agenda", "Modification de l'apparence"));
            Majs.Add(new Maj("0.61", "Agenda", "Selection automatique de SelectedDate"));
            Majs.Add(new Maj("0.61", "Agenda", "Modification/Suppression des evenements OK"));
            Majs.Add(new Maj("0.61", "Optimisation", "Fermeture de toutes les conenxion ouvertes"));

            Majs.Add(new Maj("0.60", "Optimisation", "Debut : Fermeture de toutes les conenxion ouvertes (Classes OK)"));

            Majs.Add(new Maj("0.59", "Agenda", "Debut : Modification des evenements"));
            Majs.Add(new Maj("0.59", "Agenda", "Nouvel affichage des evenements"));
            Majs.Add(new Maj("0.59", "Agenda", "Nouvel affichage du calendrier"));


            Majs.Add(new Maj("0.58", "Suivi", "Affichage des Suivis dans un module dans Eleves"));
            Majs.Add(new Maj("0.58", "Classes", "Voir les Suivis depuis Classes > Eleves"));
            Majs.Add(new Maj("0.57", "Classes", "Voir les Accompagnements depuis Classes > Eleves"));
            Majs.Add(new Maj("0.55", "Accompagnements", "Editer la liste des Accompagnements."));
            Majs.Add(new Maj("0.54", "Accompagnements", "Accompagnements (Recap) : OK : (Ajouter élèves, modifier Eleve.Accompagnements)"));
            Majs.Add(new Maj("0.53", "Agenda", "Affichage des évènements à venir dans l'agenda du Tableau de bord"));
            Majs.Add(new Maj("0.52", "Suivi", "Nouveau : Suivis/Entretiens (Récap)"));
            Majs.Add(new Maj("0.48", "Classes", "Possibilité de changer: DP/Externe, Garderie, ALAE, Délégué (dans le menu Eleves > Classes)"));


            Majs.Add(new Maj("0.44", "Interface", "Mode Debug (disable Autoconnect + Show/Hide menu Wip)"));
            Majs.Add(new Maj("0.44", "Absences_Appel", "Nouveau : Absences : Stat"));
            Majs.Add(new Maj("0.44", "Absences_Appel", "Faire l'appel - Nouvelle Version"));
            Majs.Add(new Maj("0.44", "Absences_Appel", "-> Justifier/Ajouter/Modifier Absence"));
            Majs.Add(new Maj("0.44", "Absences_Appel", "-> Affichage Justifié/Non-Justifié"));
            Majs.Add(new Maj("0.44", "Absences_Appel", "-> Tri des élèves par niveau"));


            Majs.Add(new Maj("0.43", "Elèves", "Suppression d'élève"));
            Majs.Add(new Maj("0.42", "Elèves", "Table \"eleves\":  ajout de \"date_entree\", \"date_sortie\", \"import_genre\""));
            Majs.Add(new Maj("0.42", "Interface", "debut de \"F_Options_User_Autorisations\""));
            Majs.Add(new Maj("0.39", "Interface", "Nouveau menu +ou-OK"));
            Majs.Add(new Maj("0.38", "Communication", "Chatte OK"));
            Majs.Add(new Maj("0.37", "Absences_Appel", "Recap des absences des élèves"));
            Majs.Add(new Maj("0.35", "Absences_Appel", "Début affichage absence élèves en mode calendrier"));
            Majs.Add(new Maj("0.34", "Interface", "Connexion utilisateur"));
            Majs.Add(new Maj("0.33", "Interface", "Debut Tableau de bord"));
            Majs.Add(new Maj("0.32", "Agenda", "Ajout d'evenement dans l'Agenda"));
            Majs.Add(new Maj("0.31", "Agenda", "Début de l'agenda"));
            Majs.Add(new Maj("0.32", "Elèves", "Correction du bug qui faisait qu'on pouvait ajouter 10 fois le meme nouvel eleve"));
            Majs.Add(new Maj("0.??", "Absences_Appel", "Faire l'appel : Nouvel façon de selectionner la semaine"));




            return Majs;
        }

        private List<Todo> GetListTodos()
        {
            List<Todo> Todos = new List<Todo>();

            Todos.Add(new Todo("Communication", "Infos importantes en Header"));

            Todos.Add(new Todo("Elèves", "Eleves : date entree/sortie + ajouter manuellement"));

            Todos.Add(new Todo("Agenda_Evènements", "Dans le calendrier et Les evenements futur : la page se recharge meme quand j'annule"));
            Todos.Add(new Todo("Agenda_Evènements", "Gestion des erreurs dans l'ajout/Modif d'evenement"));

            Todos.Add(new Todo("Suivi", "Modification / Suppression"));


            Todos.Add(new Todo("Classes", "Selectionner automatiquement la classe du user"));
            Todos.Add(new Todo("Classes", "Afficher les absences"));
            Todos.Add(new Todo("Classes", "Clique droit -> Assurance / photo"));

            Todos.Add(new Todo("Elèves", "Finir Ajout/modifier/Supprimer eleves"));
            Todos.Add(new Todo("Elèves", "import"));
            Todos.Add(new Todo("Elèves", "Reutiliser le meme clique droit que dans classe"));
            Todos.Add(new Todo("Elèves", "Afficher les PAI"));
            Todos.Add(new Todo("Elèves", "Eleves_Liste: DGV.MultiSelect = true (pour copier tableau)"));

            Todos.Add(new Todo("Interface", "Enregistrer les options des tableau dans preferences utilisateurs"));



            Todos.Add(new Todo("Connexion_User_TDB", "Mot de passe"));
            Todos.Add(new Todo("Connexion_User_TDB", "David : \"Cliquez sur toutes les photos d'ornithoriqn pour continuer\""));

            Todos.Add(new Todo("Communication", "Pigeons"));
            Todos.Add(new Todo("Communication", "Infos importantes en Header"));

            Todos.Add(new Todo("Options_Preferences", "Preferences Global"));
            Todos.Add(new Todo("Options_Preferences", "Preference User"));

            Todos.Add(new Todo("Optimisation", "Mettre les variables et listes dans la fonction (et pas dans les declaration) quand c possible pour liberer de la memoire"));


            Todos.Add(new Todo("Accompagnements", ""));

            Todos.Add(new Todo("Divers", ""));
            //   Todos.Add(new Todo("XXXXXXXXXX", "xxxxxxxxxxxxxxx"));



            return Todos;
        }








        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
















    }
}
