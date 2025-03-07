namespace ProSchool
{
    partial class F_Eleves_Absences_Dgv
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
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.BT_ResponsablesShow = new System.Windows.Forms.Button();
            this.LB_Eleve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Resume = new System.Windows.Forms.Label();
            this.RichTXT_Absences = new System.Windows.Forms.RichTextBox();
            this.FLP_Calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB_Jutifiee = new System.Windows.Forms.GroupBox();
            this.RADIO_JustifAutre = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifFamille = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifMaladie = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifNon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RADIO_EtatPresent = new System.Windows.Forms.RadioButton();
            this.RADIO_EtatRetard = new System.Windows.Forms.RadioButton();
            this.RADIO_EtatAbsent = new System.Windows.Forms.RadioButton();
            this.TXT_Infos = new System.Windows.Forms.TextBox();
            this.BT_Valider = new System.Windows.Forms.Button();
            this.RADIO_Etat_AppelNonFait = new System.Windows.Forms.RadioButton();
            this.LB_SelectedAppelCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GB_Jutifiee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.BT_ResponsablesShow);
            this.PAN_Header.Controls.Add(this.LB_Eleve);
            this.PAN_Header.Controls.Add(this.label2);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1058, 39);
            this.PAN_Header.TabIndex = 20;
            // 
            // BT_ResponsablesShow
            // 
            this.BT_ResponsablesShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_ResponsablesShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ResponsablesShow.Location = new System.Drawing.Point(940, 0);
            this.BT_ResponsablesShow.Name = "BT_ResponsablesShow";
            this.BT_ResponsablesShow.Size = new System.Drawing.Size(114, 35);
            this.BT_ResponsablesShow.TabIndex = 21;
            this.BT_ResponsablesShow.Text = "XX Responsables";
            this.BT_ResponsablesShow.UseVisualStyleBackColor = true;
            this.BT_ResponsablesShow.Click += new System.EventHandler(this.BT_ResponsablesShow_Click);
            // 
            // LB_Eleve
            // 
            this.LB_Eleve.AutoSize = true;
            this.LB_Eleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Eleve.Location = new System.Drawing.Point(172, 8);
            this.LB_Eleve.Name = "LB_Eleve";
            this.LB_Eleve.Size = new System.Drawing.Size(78, 18);
            this.LB_Eleve.TabIndex = 6;
            this.LB_Eleve.Text = "LB_Eleve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Absences et Retards de";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LB_Resume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1058, 41);
            this.panel1.TabIndex = 21;
            // 
            // LB_Resume
            // 
            this.LB_Resume.AutoSize = true;
            this.LB_Resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LB_Resume.Location = new System.Drawing.Point(13, 10);
            this.LB_Resume.Name = "LB_Resume";
            this.LB_Resume.Size = new System.Drawing.Size(85, 17);
            this.LB_Resume.TabIndex = 0;
            this.LB_Resume.Text = "LB_Resume";
            // 
            // RichTXT_Absences
            // 
            this.RichTXT_Absences.Dock = System.Windows.Forms.DockStyle.Top;
            this.RichTXT_Absences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTXT_Absences.Location = new System.Drawing.Point(0, 80);
            this.RichTXT_Absences.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.RichTXT_Absences.Name = "RichTXT_Absences";
            this.RichTXT_Absences.ReadOnly = true;
            this.RichTXT_Absences.Size = new System.Drawing.Size(1058, 146);
            this.RichTXT_Absences.TabIndex = 22;
            this.RichTXT_Absences.Text = "";
            // 
            // FLP_Calendar
            // 
            this.FLP_Calendar.AutoScroll = true;
            this.FLP_Calendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLP_Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Calendar.Location = new System.Drawing.Point(0, 226);
            this.FLP_Calendar.Name = "FLP_Calendar";
            this.FLP_Calendar.Size = new System.Drawing.Size(748, 546);
            this.FLP_Calendar.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LB_SelectedAppelCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.GB_Jutifiee);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.TXT_Infos);
            this.panel2.Controls.Add(this.BT_Valider);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(748, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 546);
            this.panel2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(18, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 98);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "- Cliquez sur une ou plusieurs demi-journée(s) pour les séléctionner: Elles devie" +
    "nnent rouges.\r\n\r\n- Chosissez les options ci-dessous \r\n\r\n- Cliquez sur \"VALIDER\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modifier / Ajouter des absences:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Commentaire";
            // 
            // GB_Jutifiee
            // 
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifAutre);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifFamille);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifMaladie);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifNon);
            this.GB_Jutifiee.Location = new System.Drawing.Point(132, 281);
            this.GB_Jutifiee.Name = "GB_Jutifiee";
            this.GB_Jutifiee.Size = new System.Drawing.Size(125, 128);
            this.GB_Jutifiee.TabIndex = 22;
            this.GB_Jutifiee.TabStop = false;
            this.GB_Jutifiee.Text = "Justification";
            // 
            // RADIO_JustifAutre
            // 
            this.RADIO_JustifAutre.AutoSize = true;
            this.RADIO_JustifAutre.Location = new System.Drawing.Point(9, 94);
            this.RADIO_JustifAutre.Name = "RADIO_JustifAutre";
            this.RADIO_JustifAutre.Size = new System.Drawing.Size(50, 17);
            this.RADIO_JustifAutre.TabIndex = 3;
            this.RADIO_JustifAutre.TabStop = true;
            this.RADIO_JustifAutre.Text = "Autre";
            this.RADIO_JustifAutre.UseVisualStyleBackColor = true;
            // 
            // RADIO_JustifFamille
            // 
            this.RADIO_JustifFamille.AutoSize = true;
            this.RADIO_JustifFamille.Location = new System.Drawing.Point(9, 71);
            this.RADIO_JustifFamille.Name = "RADIO_JustifFamille";
            this.RADIO_JustifFamille.Size = new System.Drawing.Size(101, 17);
            this.RADIO_JustifFamille.TabIndex = 2;
            this.RADIO_JustifFamille.TabStop = true;
            this.RADIO_JustifFamille.Text = "Raison Familiale";
            this.RADIO_JustifFamille.UseVisualStyleBackColor = true;
            // 
            // RADIO_JustifMaladie
            // 
            this.RADIO_JustifMaladie.AutoSize = true;
            this.RADIO_JustifMaladie.Location = new System.Drawing.Point(9, 48);
            this.RADIO_JustifMaladie.Name = "RADIO_JustifMaladie";
            this.RADIO_JustifMaladie.Size = new System.Drawing.Size(62, 17);
            this.RADIO_JustifMaladie.TabIndex = 1;
            this.RADIO_JustifMaladie.TabStop = true;
            this.RADIO_JustifMaladie.Text = "Maladie";
            this.RADIO_JustifMaladie.UseVisualStyleBackColor = true;
            // 
            // RADIO_JustifNon
            // 
            this.RADIO_JustifNon.AutoSize = true;
            this.RADIO_JustifNon.Location = new System.Drawing.Point(9, 25);
            this.RADIO_JustifNon.Name = "RADIO_JustifNon";
            this.RADIO_JustifNon.Size = new System.Drawing.Size(83, 17);
            this.RADIO_JustifNon.TabIndex = 0;
            this.RADIO_JustifNon.TabStop = true;
            this.RADIO_JustifNon.Text = "Non justifiée";
            this.RADIO_JustifNon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RADIO_Etat_AppelNonFait);
            this.groupBox1.Controls.Add(this.RADIO_EtatPresent);
            this.groupBox1.Controls.Add(this.RADIO_EtatRetard);
            this.groupBox1.Controls.Add(this.RADIO_EtatAbsent);
            this.groupBox1.Location = new System.Drawing.Point(18, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 129);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appel";
            // 
            // RADIO_EtatPresent
            // 
            this.RADIO_EtatPresent.AutoSize = true;
            this.RADIO_EtatPresent.Location = new System.Drawing.Point(11, 42);
            this.RADIO_EtatPresent.Name = "RADIO_EtatPresent";
            this.RADIO_EtatPresent.Size = new System.Drawing.Size(61, 17);
            this.RADIO_EtatPresent.TabIndex = 5;
            this.RADIO_EtatPresent.TabStop = true;
            this.RADIO_EtatPresent.Text = "Present";
            this.RADIO_EtatPresent.UseVisualStyleBackColor = true;
            // 
            // RADIO_EtatRetard
            // 
            this.RADIO_EtatRetard.AutoSize = true;
            this.RADIO_EtatRetard.Location = new System.Drawing.Point(11, 88);
            this.RADIO_EtatRetard.Name = "RADIO_EtatRetard";
            this.RADIO_EtatRetard.Size = new System.Drawing.Size(57, 17);
            this.RADIO_EtatRetard.TabIndex = 6;
            this.RADIO_EtatRetard.TabStop = true;
            this.RADIO_EtatRetard.Text = "Retard";
            this.RADIO_EtatRetard.UseVisualStyleBackColor = true;
            // 
            // RADIO_EtatAbsent
            // 
            this.RADIO_EtatAbsent.AutoSize = true;
            this.RADIO_EtatAbsent.Location = new System.Drawing.Point(11, 65);
            this.RADIO_EtatAbsent.Name = "RADIO_EtatAbsent";
            this.RADIO_EtatAbsent.Size = new System.Drawing.Size(58, 17);
            this.RADIO_EtatAbsent.TabIndex = 6;
            this.RADIO_EtatAbsent.TabStop = true;
            this.RADIO_EtatAbsent.Text = "Absent";
            this.RADIO_EtatAbsent.UseVisualStyleBackColor = true;
            // 
            // TXT_Infos
            // 
            this.TXT_Infos.Location = new System.Drawing.Point(20, 441);
            this.TXT_Infos.Name = "TXT_Infos";
            this.TXT_Infos.Size = new System.Drawing.Size(237, 20);
            this.TXT_Infos.TabIndex = 20;
            // 
            // BT_Valider
            // 
            this.BT_Valider.Location = new System.Drawing.Point(20, 489);
            this.BT_Valider.Name = "BT_Valider";
            this.BT_Valider.Size = new System.Drawing.Size(75, 31);
            this.BT_Valider.TabIndex = 19;
            this.BT_Valider.Text = "Valider";
            this.BT_Valider.UseVisualStyleBackColor = true;
            this.BT_Valider.Click += new System.EventHandler(this.BT_Valider_Click);
            // 
            // RADIO_Etat_AppelNonFait
            // 
            this.RADIO_Etat_AppelNonFait.AutoSize = true;
            this.RADIO_Etat_AppelNonFait.Enabled = false;
            this.RADIO_Etat_AppelNonFait.Location = new System.Drawing.Point(11, 19);
            this.RADIO_Etat_AppelNonFait.Name = "RADIO_Etat_AppelNonFait";
            this.RADIO_Etat_AppelNonFait.Size = new System.Drawing.Size(90, 17);
            this.RADIO_Etat_AppelNonFait.TabIndex = 7;
            this.RADIO_Etat_AppelNonFait.TabStop = true;
            this.RADIO_Etat_AppelNonFait.Text = "Appel non fait";
            this.RADIO_Etat_AppelNonFait.UseVisualStyleBackColor = true;
            // 
            // LB_SelectedAppelCount
            // 
            this.LB_SelectedAppelCount.AutoSize = true;
            this.LB_SelectedAppelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SelectedAppelCount.Location = new System.Drawing.Point(18, 161);
            this.LB_SelectedAppelCount.Name = "LB_SelectedAppelCount";
            this.LB_SelectedAppelCount.Size = new System.Drawing.Size(216, 16);
            this.LB_SelectedAppelCount.TabIndex = 24;
            this.LB_SelectedAppelCount.Text = "XX demi-journée(s) séléctionnée(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Modifier les XX demi-journées séléctionnées";
            // 
            // F_Eleves_Absences_Dgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 772);
            this.Controls.Add(this.FLP_Calendar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RichTXT_Absences);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Eleves_Absences_Dgv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Eleves_Absences_DGV";
            this.Load += new System.EventHandler(this.F_Eleves_Absences_Dgv_Load);
            this.Resize += new System.EventHandler(this.Calendar_Resize);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GB_Jutifiee.ResumeLayout(false);
            this.GB_Jutifiee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Button BT_ResponsablesShow;
        private System.Windows.Forms.Label LB_Eleve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Resume;
        private System.Windows.Forms.RichTextBox RichTXT_Absences;
        private System.Windows.Forms.FlowLayoutPanel FLP_Calendar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GB_Jutifiee;
        private System.Windows.Forms.RadioButton RADIO_JustifAutre;
        private System.Windows.Forms.RadioButton RADIO_JustifFamille;
        private System.Windows.Forms.RadioButton RADIO_JustifMaladie;
        private System.Windows.Forms.RadioButton RADIO_JustifNon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RADIO_Etat_AppelNonFait;
        private System.Windows.Forms.RadioButton RADIO_EtatPresent;
        private System.Windows.Forms.RadioButton RADIO_EtatRetard;
        private System.Windows.Forms.RadioButton RADIO_EtatAbsent;
        private System.Windows.Forms.TextBox TXT_Infos;
        private System.Windows.Forms.Button BT_Valider;
        private System.Windows.Forms.Label LB_SelectedAppelCount;
        private System.Windows.Forms.Label label4;
    }
}