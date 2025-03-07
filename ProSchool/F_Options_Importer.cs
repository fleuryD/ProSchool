using Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class F_Options_Importer : Form
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

    //    List<Eleve> Eleves;
    //    List<Classe> Classes;

        //■■■■■■■■■■■■■■■■■■■■■■■■  INIT / LOAD    ■■■■■■■■■■■■■■■■■■■■■■■■

        public F_Options_Importer()
        {
            InitializeComponent();
        }

        private void F_Options_ImporterEleves_Load(object sender, EventArgs e)
        {

        }

        //■■■■■■■■■■■■■■■■■■■■■■■■  XXXXXXXXXXXX    ■■■■■■■■■■■■■■■■■■■■■■■■


        private void BT_OpenCsvEleves_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Ouvrir le fichier CSV - Eleves";
            dialog.Filter = "Fichier CSV (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;

                var csv = File.ReadAllText(dialog.FileName, Encoding.Default);

                F_Options_ImporterClasses formm = new F_Options_ImporterClasses(csv);
                formm.ShowDialog();


             //   ReadCsv(csv);
               
            }
        }

        private void BT_OpenCsvResponsables_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Ouvrir le fichier CSV - Responsables";
            dialog.Filter = "Fichier CSV (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;

                var csv = File.ReadAllText(dialog.FileName, Encoding.Default);

           ////////////     MessageBox.Show(csv.ToString());


                F_Options_ImporterResponsables formm = new F_Options_ImporterResponsables(csv);
                formm.ShowDialog();


            }
        }



                     


        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■


    }
}
