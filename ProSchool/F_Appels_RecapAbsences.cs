using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Appels_RecapAbsences : Form
    {
      



        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private List<Eleve> Eleves;

        private Dictionary<int, Classe> Dico_Idents_Classes;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Appels_RecapAbsences()
        {
            InitializeComponent();
        }

        private void F_Appels_RecapAbsences_Load(object sender, EventArgs e)
        {


            Dico_Idents_Classes = Classe.Get_Dico_Idents_Classes_FromBdd();

            Eleves = Eleve.GetListElevesFromBdd();

            using (SQLiteConnection maConnexion = new SQLiteConnection(Global.StrSQLiteConnection))
            {
                maConnexion.Open();


                foreach (Eleve Elv in Eleves)
                {
                    Elv.Appels = new List<Appel>();
                    using (SQLiteCommand fmd = maConnexion.CreateCommand())
                    {
                        fmd.CommandText = @"SELECT * FROM appels WHERE eleve_id = '" + Elv.Id +"'";
                        fmd.CommandType = CommandType.Text;
                        SQLiteDataReader rdr = fmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Elv.Appels.Add(new Appel(rdr));
                        }
                    }

                }


              
                maConnexion.Close();
            }




            Setup_DGV_Absences();
            Populate_DGV_Absences();
        }
  


        //■■■■■■■■■■■■■■■■■■■■■■■■  DGV_Absences    ■■■■■■■■■■■■■■■■■■■■■■■■

        private void Setup_DGV_Absences()
        {


            DGV_Absences.ColumnCount = 11;

            DGV_Absences.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGV_Absences.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //DGV_Absences.ColumnHeadersDefaultCellStyle.Font = new Font(DGV_Absences.Font, FontStyle.Bold);
            DGV_Absences.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV_Absences.ColumnHeadersHeight = 40;

            DGV_Absences.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Absences.RowHeadersVisible = false;
            DGV_Absences.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGV_Absences.EditMode = DataGridViewEditMode.EditProgrammatically;
            //DGV_Absences.GridColor = Color.Black;

            DGV_Absences.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Absences.MultiSelect = true;
            DGV_Absences.AllowUserToAddRows = false;


            DGV_Absences.Columns[0].Name = "id";
            DGV_Absences.Columns[1].Name = "Elève";
            DGV_Absences.Columns[2].Name = "Classe";
            DGV_Absences.Columns[3].Name = "Absences et Retards";
            DGV_Absences.Columns[4].Name = "Absences";
            DGV_Absences.Columns[5].Name = "Absences Non justifiées";
            DGV_Absences.Columns[6].Name = "Absences justifiées";
            DGV_Absences.Columns[7].Name = "Retards";
            DGV_Absences.Columns[8].Name = "Retards Non justifiés";
            DGV_Absences.Columns[9].Name = "Retards justifiés";
            DGV_Absences.Columns[10].Name = "Present";

            /*
            foreach (String StrDate in ListeDates)
            {
                DGV_Absences.ColumnCount +=2;
                DGV_Absences.Columns[DGV_Absences.ColumnCount - 2].Name = StrDate + " Matin";
                DGV_Absences.Columns[DGV_Absences.ColumnCount - 1].Name = StrDate + " Aprem";
//                DGV_Absences.Columns[DGV_Absences.ColumnCount - 1].Width = 50;

            }
            */
            //     DGV_Absences.Columns["xxxxxxxx"].Width = 350;
            //DGV_Absences.Columns["xxxxxxxx"].Visible = false;

        }

        private void Populate_DGV_Absences()
        {

            DGV_Absences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV_Absences.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            DGV_Absences.Rows.Clear();

            foreach (Eleve Elv in Eleves)
            {

                //   Elv.Accompagnements = Global.GetListAccompagnementsByEleveId(Elv.Id);

                int CountAbsencesRetards = 0;

                int Count_Abs_J = 0;
                int Count_Abs_NJ = 0;
                int Count_Ret_J = 0;
                int Count_Ret_NJ = 0;
                int Count_Pres = 0;





                foreach (Appel Apl in Elv.Appels)
                {
                    if (Apl.Etat != "Present")
                    {
                        CountAbsencesRetards++;
                    }

                    if (Apl.Etat == "Present")
                    {
                        Count_Pres++;
                    }
                    else if (Apl.Etat == "Absent")
                    {
                        if (Apl.Justifiee == "")
                        {
                            Count_Abs_NJ++;
                        }
                        else
                        {
                            Count_Abs_J++;
                        }

                    }
                    else if (Apl.Etat == "Retard")
                    {
                        if (Apl.Justifiee == "")
                        {
                            Count_Ret_NJ++;
                        }
                        else
                        {
                            Count_Ret_J++;
                        }

                    }



                }

                 


                if (CountAbsencesRetards > 0)
                {
                    Boolean Visible = false;

                    if (CB_ShowAbsJ.Checked)
                        if (Count_Abs_J > 0)
                            Visible = true;

                    if (CB_ShowAbsNJ.Checked)
                        if (Count_Abs_NJ > 0)
                            Visible = true;

                    if (CB_ShowRetJ.Checked)
                        if (Count_Ret_J > 0)
                            Visible = true;

                    if (CB_ShowRetNJ.Checked)
                        if (Count_Ret_NJ > 0)
                            Visible = true;



                    if (Visible)
                    {
                        var index = DGV_Absences.Rows.Add();
                        DGV_Absences.Rows[index].Cells["id"].Value = Elv.Id;
                        DGV_Absences.Rows[index].Cells["Elève"].Value = Elv.Nom + " " + Elv.Prenom;
                        //    DGV_Absences.Rows[index].Cells["Classe"].Value = "" + Elv.Appels.Count();
                        if (Dico_Idents_Classes.ContainsKey(Elv.ClasseId))
                        {
                            DGV_Absences.Rows[index].Cells["Classe"].Value = Dico_Idents_Classes[Elv.ClasseId].Nom;
                        }


                        DGV_Absences.Rows[index].Cells["Absences et Retards"].Value = Count_Ret_NJ + Count_Ret_J + Count_Abs_J + Count_Abs_NJ;

                        DGV_Absences.Rows[index].Cells["Absences"].Value = Count_Abs_J + Count_Abs_NJ;
                        DGV_Absences.Rows[index].Cells["Absences Non justifiées"].Value = Count_Abs_NJ;
                        DGV_Absences.Rows[index].Cells["Absences justifiées"].Value = Count_Abs_J;

                        DGV_Absences.Rows[index].Cells["Retards"].Value = Count_Ret_NJ + Count_Ret_J;
                        DGV_Absences.Rows[index].Cells["Retards Non justifiés"].Value = Count_Ret_NJ;
                        DGV_Absences.Rows[index].Cells["Retards justifiés"].Value = Count_Ret_J;

                        DGV_Absences.Rows[index].Cells["Present"].Value = "" + Count_Pres;

                    }



                }

            }



            DGV_Absences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Absences.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    

        private void DGV_Absences_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //  int ColIndex = e.ColumnIndex;
            int RowIndex = e.RowIndex;

            if (RowIndex == -1)
            {
                return;
            }


            DataGridViewRow Row = DGV_Absences.Rows[RowIndex];
            int eleveId = Int32.Parse(Row.Cells[0].Value.ToString());
            Eleve SelectedEleve = Eleve.GetEleveByIdFromBdd(eleveId);
            SelectedEleve.Appels = Appel.GetAppelFromEleveId(SelectedEleve.Id);
            F_Eleves_Absences_Dgv Frm = new F_Eleves_Absences_Dgv(SelectedEleve);
            Frm.ShowDialog();


        }

        private void CB_Filtre_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (!CB_ShowRetJ.Checked && !CB_ShowRetNJ.Checked)
            {
                DGV_Absences.Columns["Retards"].Visible = false;
                DGV_Absences.Columns["Retards Non justifiés"].Visible = false;
                DGV_Absences.Columns["Retards justifiés"].Visible = false;
            }
            else
            {
                DGV_Absences.Columns["Retards"].Visible = true;
                DGV_Absences.Columns["Retards Non justifiés"].Visible = true;
                DGV_Absences.Columns["Retards justifiés"].Visible = true;
            }
            */
            Populate_DGV_Absences();


        }




        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
