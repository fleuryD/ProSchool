namespace ProSchool
{
    partial class F_Appel_Noter
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
            this.BT_Valider = new System.Windows.Forms.Button();
            this.TXT_Infos = new System.Windows.Forms.TextBox();
            this.RADIO_EtatPresent = new System.Windows.Forms.RadioButton();
            this.RADIO_EtatAbsent = new System.Windows.Forms.RadioButton();
            this.RADIO_EtatRetard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GB_Jutifiee = new System.Windows.Forms.GroupBox();
            this.RADIO_JustifAutre = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifFamille = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifMaladie = new System.Windows.Forms.RadioButton();
            this.RADIO_JustifNon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Eleve = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GB_Jutifiee.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Valider
            // 
            this.BT_Valider.Location = new System.Drawing.Point(160, 307);
            this.BT_Valider.Name = "BT_Valider";
            this.BT_Valider.Size = new System.Drawing.Size(75, 30);
            this.BT_Valider.TabIndex = 2;
            this.BT_Valider.Text = "Valider";
            this.BT_Valider.UseVisualStyleBackColor = true;
            this.BT_Valider.Click += new System.EventHandler(this.BT_Valider_Click);
            // 
            // TXT_Infos
            // 
            this.TXT_Infos.Location = new System.Drawing.Point(12, 263);
            this.TXT_Infos.Name = "TXT_Infos";
            this.TXT_Infos.Size = new System.Drawing.Size(418, 20);
            this.TXT_Infos.TabIndex = 4;
            // 
            // RADIO_EtatPresent
            // 
            this.RADIO_EtatPresent.AutoSize = true;
            this.RADIO_EtatPresent.Location = new System.Drawing.Point(19, 18);
            this.RADIO_EtatPresent.Name = "RADIO_EtatPresent";
            this.RADIO_EtatPresent.Size = new System.Drawing.Size(61, 17);
            this.RADIO_EtatPresent.TabIndex = 5;
            this.RADIO_EtatPresent.TabStop = true;
            this.RADIO_EtatPresent.Text = "Present";
            this.RADIO_EtatPresent.UseVisualStyleBackColor = true;
            this.RADIO_EtatPresent.CheckedChanged += new System.EventHandler(this.RADIO_EtatPresent_CheckedChanged);
            // 
            // RADIO_EtatAbsent
            // 
            this.RADIO_EtatAbsent.AutoSize = true;
            this.RADIO_EtatAbsent.Location = new System.Drawing.Point(120, 18);
            this.RADIO_EtatAbsent.Name = "RADIO_EtatAbsent";
            this.RADIO_EtatAbsent.Size = new System.Drawing.Size(58, 17);
            this.RADIO_EtatAbsent.TabIndex = 6;
            this.RADIO_EtatAbsent.TabStop = true;
            this.RADIO_EtatAbsent.Text = "Absent";
            this.RADIO_EtatAbsent.UseVisualStyleBackColor = true;
            // 
            // RADIO_EtatRetard
            // 
            this.RADIO_EtatRetard.AutoSize = true;
            this.RADIO_EtatRetard.Location = new System.Drawing.Point(220, 18);
            this.RADIO_EtatRetard.Name = "RADIO_EtatRetard";
            this.RADIO_EtatRetard.Size = new System.Drawing.Size(57, 17);
            this.RADIO_EtatRetard.TabIndex = 6;
            this.RADIO_EtatRetard.TabStop = true;
            this.RADIO_EtatRetard.Text = "Retard";
            this.RADIO_EtatRetard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RADIO_EtatPresent);
            this.groupBox1.Controls.Add(this.RADIO_EtatRetard);
            this.groupBox1.Controls.Add(this.RADIO_EtatAbsent);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // GB_Jutifiee
            // 
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifAutre);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifFamille);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifMaladie);
            this.GB_Jutifiee.Controls.Add(this.RADIO_JustifNon);
            this.GB_Jutifiee.Location = new System.Drawing.Point(12, 151);
            this.GB_Jutifiee.Name = "GB_Jutifiee";
            this.GB_Jutifiee.Size = new System.Drawing.Size(420, 63);
            this.GB_Jutifiee.TabIndex = 8;
            this.GB_Jutifiee.TabStop = false;
            this.GB_Jutifiee.Text = "Absence justifiée ?";
            // 
            // RADIO_JustifAutre
            // 
            this.RADIO_JustifAutre.AutoSize = true;
            this.RADIO_JustifAutre.Location = new System.Drawing.Point(316, 25);
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
            this.RADIO_JustifFamille.Location = new System.Drawing.Point(198, 25);
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
            this.RADIO_JustifMaladie.Location = new System.Drawing.Point(119, 25);
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
            this.RADIO_JustifNon.Location = new System.Drawing.Point(19, 25);
            this.RADIO_JustifNon.Name = "RADIO_JustifNon";
            this.RADIO_JustifNon.Size = new System.Drawing.Size(83, 17);
            this.RADIO_JustifNon.TabIndex = 0;
            this.RADIO_JustifNon.TabStop = true;
            this.RADIO_JustifNon.Text = "Non justifiée";
            this.RADIO_JustifNon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Commentaire";
            // 
            // LB_Eleve
            // 
            this.LB_Eleve.AutoSize = true;
            this.LB_Eleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Eleve.Location = new System.Drawing.Point(15, 13);
            this.LB_Eleve.Name = "LB_Eleve";
            this.LB_Eleve.Size = new System.Drawing.Size(85, 20);
            this.LB_Eleve.TabIndex = 10;
            this.LB_Eleve.Text = "LB_Eleve";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Date.Location = new System.Drawing.Point(15, 48);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(67, 16);
            this.LB_Date.TabIndex = 10;
            this.LB_Date.Text = "LB_Date";
            // 
            // F_Appel_Noter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 349);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.LB_Eleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_Jutifiee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXT_Infos);
            this.Controls.Add(this.BT_Valider);
            this.Name = "F_Appel_Noter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AppelNoter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_Jutifiee.ResumeLayout(false);
            this.GB_Jutifiee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Valider;
        private System.Windows.Forms.TextBox TXT_Infos;
        private System.Windows.Forms.RadioButton RADIO_EtatPresent;
        private System.Windows.Forms.RadioButton RADIO_EtatAbsent;
        private System.Windows.Forms.RadioButton RADIO_EtatRetard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GB_Jutifiee;
        private System.Windows.Forms.RadioButton RADIO_JustifAutre;
        private System.Windows.Forms.RadioButton RADIO_JustifFamille;
        private System.Windows.Forms.RadioButton RADIO_JustifMaladie;
        private System.Windows.Forms.RadioButton RADIO_JustifNon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Eleve;
        private System.Windows.Forms.Label LB_Date;
    }
}