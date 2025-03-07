using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class UserControl_Suivi : UserControl
    {

                              
        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private Suivi suiv;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public UserControl_Suivi(Suivi suiv)
        {
            InitializeComponent();
            this.suiv = suiv;

            Eleve Elv = Eleve.GetEleveByIdFromBdd(suiv.EleveId);
            LB_Eleves.Text = Elv.Nom + " " + Elv.Prenom;


            LB_Date.Text = suiv.DateHeure;
            LB_Genre.Text = suiv.Genre;
        //    LB_Contenu.Text = suiv.Contenu;
            TXT_Contenu.Text = suiv.Contenu;
            TXT_Decision.Text = suiv.Decision;

            if (suiv.Contenu == "")
            {
                TXT_Contenu.Visible = false;
                LB_Contenu.Visible = false;
            }
            if (suiv.Decision == "")
            {
                TXT_Decision.Visible = false;
                LB_Decision.Visible = false;
            }

            LB_EleveFamille.Text = suiv.EleveOuFamille;
            if (suiv.EleveOuFamille == "")
            {
                LB_EleveFamille_Label.Visible = false;
            }


            Ajuster_TextBox_to_contenu(TXT_Decision);
            Ajuster_TextBox_to_contenu(TXT_Contenu);


            Color bkColor = new Color();

            switch (suiv.Genre){
                case "zzz":
                    bkColor = Color.FromArgb(255, 255, 240);
                    break;

                default:
                    bkColor = Color.FromArgb(200, 200, 200);
                    break;
            }

        }

        private void Ajuster_TextBox_to_contenu(TextBox TXTB)
        {
            Size sz = new Size(TXTB.ClientSize.Width, int.MaxValue);
            TextFormatFlags flags = TextFormatFlags.WordBreak;
            int padding = 3;
            int borders = TXTB.Height - TXTB.ClientSize.Height;
            sz = TextRenderer.MeasureText(TXTB.Text, TXTB.Font, sz, flags);
            int h = sz.Height + borders + padding;
            if (TXTB.Top + h > this.ClientSize.Height - 10)
            {
                h = this.ClientSize.Height - 10 - TXTB.Top;
            }
            TXTB.Height = h;
        }

    

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
