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
    public partial class UserControl_Menu : UserControl
    {


        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■




        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public UserControl_Menu()
        {
            InitializeComponent();


            this.LB_Menu1_Eleves.Click += new EventHandler((s, e)           => MenuClick(s, e, LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Liste));
            this.LB_Menu2_Eleves_Liste.Click += new EventHandler((s, e)     => MenuClick(s, e, LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Liste));
            this.LB_Menu2_Eleves_Dossier.Click += new EventHandler((s, e)   => MenuClick(s, e, LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Dossier));
            this.LB_Menu2_Eleves_Suivi.Click += new EventHandler((s, e)     => MenuClick(s, e, LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Suivi));
            
            this.LB_Menu1_Classes.Click += new EventHandler((s, e)                  => MenuClick(s, e, LB_Menu1_Classes, FLP_Menu2_Classes, LB_Menu2_Classes_Liste));
            this.LB_Menu2_Classes_Liste.Click += new EventHandler((s, e)            => MenuClick(s, e, LB_Menu1_Classes, FLP_Menu2_Classes, LB_Menu2_Classes_Liste));
            this.LB_Menu2_Classes_Delegues.Click += new EventHandler((s, e)         => MenuClick(s, e, LB_Menu1_Classes, FLP_Menu2_Classes, LB_Menu2_Classes_Delegues));
            this.LB_Menu2_Classes_Trombinoscope.Click += new EventHandler((s, e)    => MenuClick(s, e, LB_Menu1_Classes, FLP_Menu2_Classes, LB_Menu2_Classes_Trombinoscope));
            
            this.LB_Menu1_Appels.Click += new EventHandler((s, e)                   => MenuClick(s, e, LB_Menu1_Appels, FLP_Menu2_Appels, LB_Menu2_Appels_RecapAbsences));
            this.LB_Menu2_Appels_RecapAbsences.Click += new EventHandler((s, e)     => MenuClick(s, e, LB_Menu1_Appels, FLP_Menu2_Appels, LB_Menu2_Appels_RecapAbsences));
            this.LB_Menu2_Appels_Recap.Click += new EventHandler((s, e)             => MenuClick(s, e, LB_Menu1_Appels, FLP_Menu2_Appels, LB_Menu2_Appels_Recap));
            this.LB_Menu2_Appels_faire.Click += new EventHandler((s, e)             => MenuClick(s, e, LB_Menu1_Appels, FLP_Menu2_Appels, LB_Menu2_Appels_faire));
            
            this.LB_Menu1_Personnel.Click += new EventHandler((s, e)            => MenuClick(s, e, LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Liste));
            this.LB_Menu2_Personnel_Liste.Click += new EventHandler((s, e)      => MenuClick(s, e, LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Liste));
            this.LB_Menu2_Personnel_Profs.Click += new EventHandler((s, e)      => MenuClick(s, e, LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Profs));
            this.LB_Menu2_Personnel_Absences.Click += new EventHandler((s, e)   => MenuClick(s, e, LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Absences));
            this.LB_Menu2_Personnel_Planning.Click += new EventHandler((s, e)   => MenuClick(s, e, LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Planning));
            
            this.LB_Menu1_Responsables.Click += new EventHandler((s, e)         => MenuClick(s, e, LB_Menu1_Responsables, FLP_Menu2_Responsables, LB_Menu2_Responsables_Liste));
            this.LB_Menu2_Responsables_Liste.Click += new EventHandler((s, e)   => MenuClick(s, e, LB_Menu1_Responsables, FLP_Menu2_Responsables, LB_Menu2_Responsables_Liste));
            
            this.LB_Menu1_Communication.Click += new EventHandler((s, e)           => MenuClick(s, e, LB_Menu1_Communication, FLP_Menu2_Communication, LB_Menu2_Communication_Pigeon));
            this.LB_Menu2_Communication_Pigeon.Click += new EventHandler((s, e)    => MenuClick(s, e, LB_Menu1_Communication, FLP_Menu2_Communication, LB_Menu2_Communication_Pigeon));
            this.LB_Menu2_Communication_Chatte.Click += new EventHandler((s, e)    => MenuClick(s, e, LB_Menu1_Communication, FLP_Menu2_Communication, LB_Menu2_Communication_Chatte));
            
            this.LB_Menu1_Agenda.Click += new EventHandler((s, e)               => MenuClick(s, e, LB_Menu1_Agenda, FLP_Menu2_Agenda, LB_Menu2_Agenda_Calendrier));
            this.LB_Menu2_Agenda_Calendrier.Click += new EventHandler((s, e)    => MenuClick(s, e, LB_Menu1_Agenda, FLP_Menu2_Agenda, LB_Menu2_Agenda_Calendrier));
            this.LB_Menu2_Agenda_BlocNote.Click += new EventHandler((s, e)      => MenuClick(s, e, LB_Menu1_Agenda, FLP_Menu2_Agenda, LB_Menu2_Agenda_BlocNote));






            foreach (Label Ctrl_LbMenu1 in this.FLP_Menu1.Controls)
            {
                Ctrl_LbMenu1.MouseEnter += new EventHandler((s, e) => OnMouseEnter_LB_Menu1(s, e, Ctrl_LbMenu1));
                Ctrl_LbMenu1.MouseLeave += new EventHandler((s, e) => OnMouseLeave_LB_Menu1(s, e, Ctrl_LbMenu1));
            }
                       
            foreach (FlowLayoutPanel Flp in this.PAN_Menu2.Controls)
            {
                foreach (Label Ctrl_LbMenu2 in Flp.Controls)
                {
                    Ctrl_LbMenu2.MouseEnter += new EventHandler((s, e) => OnMouseEnter_LB_Menu2(s, e, Ctrl_LbMenu2));
                    Ctrl_LbMenu2.MouseLeave += new EventHandler((s, e) => OnMouseLeave_LB_Menu2(s, e, Ctrl_LbMenu2));
                }
            }

        }

        private void MenuClick(object s, EventArgs e, Label LB_Menu1, FlowLayoutPanel FLP_Menu, Label LB_Menu2)
        {
            OpenMenu2(LB_Menu1, FLP_Menu, LB_Menu2);
        }


        private void UserControl_Menu_Load(object sender, EventArgs e)
        {
            OpenMenu2(LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Liste);
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void OpenMenu2(Label LB_Menu1, FlowLayoutPanel FLP_Menu2, Label LB_Menu2)
        {
            foreach (Control Ctrl_LB in FLP_Menu1.Controls)
            {
                Ctrl_LB.BackColor = SystemColors.Control;
            }

            foreach (Label Ctrl_LbMenu2 in FLP_Menu2.Controls)
            {
                Ctrl_LbMenu2.BackColor = FLP_Menu2.BackColor;
            }


            LB_Menu1.BackColor = FLP_Menu2.BackColor;
            LB_Menu2.BackColor = Color.White;


            this.FLP_Menu2_Eleves.Visible = false;
            this.FLP_Menu2_Classes.Visible = false;
            this.FLP_Menu2_Appels.Visible = false;
            this.FLP_Menu2_Personnel.Visible = false;
            this.FLP_Menu2_Responsables.Visible = false;
            this.FLP_Menu2_Communication.Visible = false;
            this.FLP_Menu2_Agenda.Visible = false;


            FLP_Menu2.Visible = true;




        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  BT_LABEL - EVENT    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void OnMouseEnter_LB_Menu1(object sender, EventArgs e, Label lB_Menu1)
        {
            lB_Menu1.ForeColor = Color.DarkGoldenrod;
        }
        private void OnMouseLeave_LB_Menu1(object sender, EventArgs e, Label lB_Menu1)
        {
            lB_Menu1.ForeColor = Color.Black;
        }

        private void OnMouseEnter_LB_Menu2(object sender, EventArgs e, Label lB_Menu1)
        {
            lB_Menu1.ForeColor = Color.White;
        }
        private void OnMouseLeave_LB_Menu2(object sender, EventArgs e, Label lB_Menu1)
        {
            lB_Menu1.ForeColor = Color.Black;
        }


        //■■■■■■■■■■■■■■■■■■■■■■■■  UNUSED    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void MenuClick(object sender, EventArgs e, String Str)
        {
            // MessageBox.Show(Str);




            switch (Str)
            {
                case "Eleves_Liste":
                    OpenMenu2(LB_Menu1_Eleves, FLP_Menu2_Eleves, LB_Menu2_Eleves_Liste);
                    break;

                case "Classes":
                    OpenMenu2(LB_Menu1_Classes, FLP_Menu2_Classes, LB_Menu2_Classes_Liste);
                    break;

                case "Appels":
                    OpenMenu2(LB_Menu1_Appels, FLP_Menu2_Appels, LB_Menu2_Appels_RecapAbsences);
                    break;

                case "Personnel":
                    OpenMenu2(LB_Menu1_Personnel, FLP_Menu2_Personnel, LB_Menu2_Personnel_Liste);
                    break;

                case "Responsables":
                    OpenMenu2(LB_Menu1_Responsables, FLP_Menu2_Responsables, LB_Menu2_Responsables_Liste);
                    break;

                case "Communication":
                    OpenMenu2(LB_Menu1_Communication, FLP_Menu2_Communication, LB_Menu2_Communication_Pigeon);
                    break;

                case "Agenda":
                    OpenMenu2(LB_Menu1_Agenda, FLP_Menu2_Agenda, LB_Menu2_Agenda_Calendrier);
                    break;


            }


        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■
    }
}
