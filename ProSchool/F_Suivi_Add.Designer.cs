namespace ProSchool
{
    partial class F_Suivi_Add
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
            this.FLP_Footer = new System.Windows.Forms.FlowLayoutPanel();
            this.BT_EntretienUpdate = new System.Windows.Forms.Button();
            this.BT_SuiviAdd = new System.Windows.Forms.Button();
            this.BT_EntretienDelete = new System.Windows.Forms.Button();
            this.BT_EntretienCanceil = new System.Windows.Forms.Button();
            this.TXT_Contenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Heure = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Eleve = new System.Windows.Forms.Label();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PAN_Commentaire = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_WithEleve = new System.Windows.Forms.CheckBox();
            this.CB_WithFamille = new System.Windows.Forms.CheckBox();
            this.COMBO_Genre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_Decision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FLP_Footer.SuspendLayout();
            this.PAN_Header.SuspendLayout();
            this.PAN_Commentaire.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP_Footer
            // 
            this.FLP_Footer.BackColor = System.Drawing.Color.White;
            this.FLP_Footer.Controls.Add(this.BT_EntretienUpdate);
            this.FLP_Footer.Controls.Add(this.BT_SuiviAdd);
            this.FLP_Footer.Controls.Add(this.BT_EntretienDelete);
            this.FLP_Footer.Controls.Add(this.BT_EntretienCanceil);
            this.FLP_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLP_Footer.Location = new System.Drawing.Point(0, 515);
            this.FLP_Footer.Name = "FLP_Footer";
            this.FLP_Footer.Size = new System.Drawing.Size(942, 43);
            this.FLP_Footer.TabIndex = 16;
            // 
            // BT_EntretienUpdate
            // 
            this.BT_EntretienUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EntretienUpdate.Location = new System.Drawing.Point(3, 3);
            this.BT_EntretienUpdate.Name = "BT_EntretienUpdate";
            this.BT_EntretienUpdate.Size = new System.Drawing.Size(148, 33);
            this.BT_EntretienUpdate.TabIndex = 8;
            this.BT_EntretienUpdate.Text = "Modifier";
            this.BT_EntretienUpdate.UseVisualStyleBackColor = true;
            this.BT_EntretienUpdate.Click += new System.EventHandler(this.BT_EntretienUpdate_Click);
            // 
            // BT_SuiviAdd
            // 
            this.BT_SuiviAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SuiviAdd.ForeColor = System.Drawing.Color.Blue;
            this.BT_SuiviAdd.Location = new System.Drawing.Point(157, 3);
            this.BT_SuiviAdd.Name = "BT_SuiviAdd";
            this.BT_SuiviAdd.Size = new System.Drawing.Size(148, 33);
            this.BT_SuiviAdd.TabIndex = 5;
            this.BT_SuiviAdd.Text = "Ajouter";
            this.BT_SuiviAdd.UseVisualStyleBackColor = true;
            this.BT_SuiviAdd.Click += new System.EventHandler(this.BT_SuiviAdd_Click);
            // 
            // BT_EntretienDelete
            // 
            this.BT_EntretienDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_EntretienDelete.ForeColor = System.Drawing.Color.Red;
            this.BT_EntretienDelete.Location = new System.Drawing.Point(311, 3);
            this.BT_EntretienDelete.Name = "BT_EntretienDelete";
            this.BT_EntretienDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BT_EntretienDelete.Size = new System.Drawing.Size(105, 33);
            this.BT_EntretienDelete.TabIndex = 9;
            this.BT_EntretienDelete.Text = "Supprimer";
            this.BT_EntretienDelete.UseVisualStyleBackColor = true;
            // 
            // BT_EntretienCanceil
            // 
            this.BT_EntretienCanceil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BT_EntretienCanceil.ForeColor = System.Drawing.Color.Red;
            this.BT_EntretienCanceil.Location = new System.Drawing.Point(422, 3);
            this.BT_EntretienCanceil.Name = "BT_EntretienCanceil";
            this.BT_EntretienCanceil.Size = new System.Drawing.Size(105, 33);
            this.BT_EntretienCanceil.TabIndex = 10;
            this.BT_EntretienCanceil.Text = "Annuler";
            this.BT_EntretienCanceil.UseVisualStyleBackColor = true;
            this.BT_EntretienCanceil.Click += new System.EventHandler(this.BT_EntretienCanceil_Click);
            // 
            // TXT_Contenu
            // 
            this.TXT_Contenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Contenu.Location = new System.Drawing.Point(115, 10);
            this.TXT_Contenu.Multiline = true;
            this.TXT_Contenu.Name = "TXT_Contenu";
            this.TXT_Contenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Contenu.Size = new System.Drawing.Size(813, 203);
            this.TXT_Contenu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Commentaire:";
            // 
            // dateTimePicker_Heure
            // 
            this.dateTimePicker_Heure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Heure.Location = new System.Drawing.Point(288, 35);
            this.dateTimePicker_Heure.Name = "dateTimePicker_Heure";
            this.dateTimePicker_Heure.ShowUpDown = true;
            this.dateTimePicker_Heure.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker_Heure.TabIndex = 10;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(57, 35);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker_Date.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // LB_Eleve
            // 
            this.LB_Eleve.AutoSize = true;
            this.LB_Eleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Eleve.Location = new System.Drawing.Point(192, 8);
            this.LB_Eleve.Name = "LB_Eleve";
            this.LB_Eleve.Size = new System.Drawing.Size(78, 18);
            this.LB_Eleve.TabIndex = 6;
            this.LB_Eleve.Text = "LB_Eleve";
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.dateTimePicker_Heure);
            this.PAN_Header.Controls.Add(this.dateTimePicker_Date);
            this.PAN_Header.Controls.Add(this.label1);
            this.PAN_Header.Controls.Add(this.LB_Eleve);
            this.PAN_Header.Controls.Add(this.label2);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(942, 73);
            this.PAN_Header.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ajouter un entretien pour: ";
            // 
            // PAN_Commentaire
            // 
            this.PAN_Commentaire.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PAN_Commentaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Commentaire.Controls.Add(this.TXT_Contenu);
            this.PAN_Commentaire.Controls.Add(this.label3);
            this.PAN_Commentaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Commentaire.Location = new System.Drawing.Point(0, 153);
            this.PAN_Commentaire.Name = "PAN_Commentaire";
            this.PAN_Commentaire.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Commentaire.Size = new System.Drawing.Size(942, 227);
            this.PAN_Commentaire.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.COMBO_Genre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(942, 80);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_WithEleve);
            this.groupBox1.Controls.Add(this.CB_WithFamille);
            this.groupBox1.Location = new System.Drawing.Point(427, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entretien avec :";
            // 
            // CB_WithEleve
            // 
            this.CB_WithEleve.AutoSize = true;
            this.CB_WithEleve.Location = new System.Drawing.Point(16, 26);
            this.CB_WithEleve.Name = "CB_WithEleve";
            this.CB_WithEleve.Size = new System.Drawing.Size(53, 17);
            this.CB_WithEleve.TabIndex = 10;
            this.CB_WithEleve.Text = "Elève";
            this.CB_WithEleve.UseVisualStyleBackColor = true;
            // 
            // CB_WithFamille
            // 
            this.CB_WithFamille.AutoSize = true;
            this.CB_WithFamille.Location = new System.Drawing.Point(87, 26);
            this.CB_WithFamille.Name = "CB_WithFamille";
            this.CB_WithFamille.Size = new System.Drawing.Size(58, 17);
            this.CB_WithFamille.TabIndex = 11;
            this.CB_WithFamille.Text = "Famille";
            this.CB_WithFamille.UseVisualStyleBackColor = true;
            // 
            // COMBO_Genre
            // 
            this.COMBO_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.COMBO_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Genre.FormattingEnabled = true;
            this.COMBO_Genre.Items.AddRange(new object[] {
            "Visite medicale",
            "Entretien Educatrice",
            "Entretien AS",
            "Equipe educative",
            "Entretien Eleve et/ou Famille",
            "ESS (Equipe Suivi Sco)",
            "Commentaire divers",
            "DRE"});
            this.COMBO_Genre.Location = new System.Drawing.Point(82, 42);
            this.COMBO_Genre.Name = "COMBO_Genre";
            this.COMBO_Genre.Size = new System.Drawing.Size(153, 21);
            this.COMBO_Genre.TabIndex = 9;
            this.COMBO_Genre.SelectedIndexChanged += new System.EventHandler(this.COMBO_Genre_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(18, 39);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "(( Personnel Posteur ))";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TXT_Decision);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(942, 135);
            this.panel2.TabIndex = 19;
            // 
            // TXT_Decision
            // 
            this.TXT_Decision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Decision.Location = new System.Drawing.Point(82, 10);
            this.TXT_Decision.Multiline = true;
            this.TXT_Decision.Name = "TXT_Decision";
            this.TXT_Decision.Size = new System.Drawing.Size(846, 111);
            this.TXT_Decision.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Decision";
            // 
            // F_Suivi_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 558);
            this.Controls.Add(this.PAN_Commentaire);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLP_Footer);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Suivi_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Suivi";
            this.Load += new System.EventHandler(this.F_Suivi_Add_Load);
            this.FLP_Footer.ResumeLayout(false);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.PAN_Commentaire.ResumeLayout(false);
            this.PAN_Commentaire.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_Footer;
        private System.Windows.Forms.Button BT_EntretienUpdate;
        private System.Windows.Forms.Button BT_SuiviAdd;
        private System.Windows.Forms.Button BT_EntretienDelete;
        private System.Windows.Forms.TextBox TXT_Contenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Heure;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Eleve;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PAN_Commentaire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox COMBO_Genre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_Decision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_WithEleve;
        private System.Windows.Forms.CheckBox CB_WithFamille;
        private System.Windows.Forms.Button BT_EntretienCanceil;
    }
}