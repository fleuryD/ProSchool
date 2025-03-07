namespace ProSchool
{
    partial class F_Options_Importer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Options_Importer));
            this.LB_Titre = new System.Windows.Forms.Label();
            this.BT_OpenCsvEleves = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_OpenCsvResponsables = new System.Windows.Forms.Button();
            this.PAN_Help_Etape1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PAN_Help_Etape1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(39, 20);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(509, 20);
            this.LB_Titre.TabIndex = 3;
            this.LB_Titre.Text = "Importer les élèves et les classes depuis \"Onde / Base Eleves\"";
            // 
            // BT_OpenCsvEleves
            // 
            this.BT_OpenCsvEleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_OpenCsvEleves.ForeColor = System.Drawing.Color.Green;
            this.BT_OpenCsvEleves.Location = new System.Drawing.Point(43, 322);
            this.BT_OpenCsvEleves.Name = "BT_OpenCsvEleves";
            this.BT_OpenCsvEleves.Size = new System.Drawing.Size(203, 32);
            this.BT_OpenCsvEleves.TabIndex = 6;
            this.BT_OpenCsvEleves.Text = "Sélèctionner CSV élèves";
            this.BT_OpenCsvEleves.UseVisualStyleBackColor = true;
            this.BT_OpenCsvEleves.Click += new System.EventHandler(this.BT_OpenCsvEleves_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.SystemColors.Control;
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.LB_Titre);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1164, 55);
            this.PAN_Header.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BT_OpenCsvResponsables);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 229);
            this.panel2.TabIndex = 12;
            // 
            // BT_OpenCsvResponsables
            // 
            this.BT_OpenCsvResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BT_OpenCsvResponsables.ForeColor = System.Drawing.Color.Blue;
            this.BT_OpenCsvResponsables.Location = new System.Drawing.Point(43, 112);
            this.BT_OpenCsvResponsables.Name = "BT_OpenCsvResponsables";
            this.BT_OpenCsvResponsables.Size = new System.Drawing.Size(203, 32);
            this.BT_OpenCsvResponsables.TabIndex = 0;
            this.BT_OpenCsvResponsables.Text = "Sélèctionner CSV résponsables";
            this.BT_OpenCsvResponsables.UseVisualStyleBackColor = true;
            this.BT_OpenCsvResponsables.Click += new System.EventHandler(this.BT_OpenCsvResponsables_Click);
            // 
            // PAN_Help_Etape1
            // 
            this.PAN_Help_Etape1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Etape1.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Etape1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Etape1.Controls.Add(this.BT_OpenCsvEleves);
            this.PAN_Help_Etape1.Controls.Add(this.label8);
            this.PAN_Help_Etape1.Controls.Add(this.label10);
            this.PAN_Help_Etape1.Controls.Add(this.label9);
            this.PAN_Help_Etape1.Controls.Add(this.label7);
            this.PAN_Help_Etape1.Controls.Add(this.label6);
            this.PAN_Help_Etape1.Controls.Add(this.label5);
            this.PAN_Help_Etape1.Controls.Add(this.label2);
            this.PAN_Help_Etape1.Controls.Add(this.label4);
            this.PAN_Help_Etape1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Help_Etape1.Location = new System.Drawing.Point(0, 55);
            this.PAN_Help_Etape1.Name = "PAN_Help_Etape1";
            this.PAN_Help_Etape1.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Etape1.Size = new System.Drawing.Size(1164, 385);
            this.PAN_Help_Etape1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(40, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(663, 80);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "CSVExtraction - Eleves - 2019-08-22.csv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Je vous conseille de lui donner un nom explicite :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = ".../ProSchool/DATA/IMPORT/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vous pouvez enregistrez ce fichier dans ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exportez au format .csv la liste des élèves.\r\n(Cette liste contient aussi la list" +
    "e des classes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dans \"Onde\" (Outil Numérique Pour la Direction d\'Ecole):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label4.Size = new System.Drawing.Size(278, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Etape 1 : Export CSV depuis \"Onde\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(252, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "L\'import des RESPONSABLES bug !\r\n\r\nC\'est long, ça peut planter et il n\'ajoute qu\'" +
    "un seul élève par responsable\r\n\r\nWork In Progress !!!";
            // 
            // F_Options_Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PAN_Help_Etape1);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Options_Importer";
            this.Text = "F_Options_ImporterEleves";
            this.Load += new System.EventHandler(this.F_Options_ImporterEleves_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PAN_Help_Etape1.ResumeLayout(false);
            this.PAN_Help_Etape1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Button BT_OpenCsvEleves;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PAN_Help_Etape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BT_OpenCsvResponsables;
        private System.Windows.Forms.Label label1;
    }
}