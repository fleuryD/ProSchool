namespace ProSchool
{
    partial class F_Calendar_EvenementtAdd
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
            this.LB_Titre = new System.Windows.Forms.Label();
            this.DatePicker_Debut = new System.Windows.Forms.DateTimePicker();
            this.DatePicker_Fin = new System.Windows.Forms.DateTimePicker();
            this.CB_DateFin = new System.Windows.Forms.CheckBox();
            this.TXT_Infos = new System.Windows.Forms.TextBox();
            this.LB_DateDebut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.COMBO_Genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Nom = new System.Windows.Forms.TextBox();
            this.LB_Erreurs = new System.Windows.Forms.Label();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Create = new System.Windows.Forms.Button();
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.LB_DateDebutHuman = new System.Windows.Forms.Label();
            this.LB_DateFinHuman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LB_Titre.Location = new System.Drawing.Point(0, 0);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(642, 52);
            this.LB_Titre.TabIndex = 0;
            this.LB_Titre.Text = "Ajouter / Modifier un évènement";
            this.LB_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatePicker_Debut
            // 
            this.DatePicker_Debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.DatePicker_Debut.Location = new System.Drawing.Point(154, 83);
            this.DatePicker_Debut.Name = "DatePicker_Debut";
            this.DatePicker_Debut.Size = new System.Drawing.Size(300, 25);
            this.DatePicker_Debut.TabIndex = 1;
            this.DatePicker_Debut.ValueChanged += new System.EventHandler(this.DatePicker_Debut_ValueChanged);
            // 
            // DatePicker_Fin
            // 
            this.DatePicker_Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.DatePicker_Fin.Location = new System.Drawing.Point(154, 126);
            this.DatePicker_Fin.Name = "DatePicker_Fin";
            this.DatePicker_Fin.Size = new System.Drawing.Size(300, 25);
            this.DatePicker_Fin.TabIndex = 2;
            this.DatePicker_Fin.ValueChanged += new System.EventHandler(this.DatePicker_Fin_ValueChanged);
            // 
            // CB_DateFin
            // 
            this.CB_DateFin.AutoSize = true;
            this.CB_DateFin.Checked = true;
            this.CB_DateFin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_DateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DateFin.Location = new System.Drawing.Point(38, 128);
            this.CB_DateFin.Name = "CB_DateFin";
            this.CB_DateFin.Size = new System.Drawing.Size(77, 20);
            this.CB_DateFin.TabIndex = 3;
            this.CB_DateFin.Text = "Date Fin";
            this.CB_DateFin.UseVisualStyleBackColor = true;
            this.CB_DateFin.CheckedChanged += new System.EventHandler(this.CB_DateFin_CheckedChanged);
            // 
            // TXT_Infos
            // 
            this.TXT_Infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TXT_Infos.Location = new System.Drawing.Point(130, 403);
            this.TXT_Infos.Multiline = true;
            this.TXT_Infos.Name = "TXT_Infos";
            this.TXT_Infos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_Infos.Size = new System.Drawing.Size(491, 103);
            this.TXT_Infos.TabIndex = 5;
            // 
            // LB_DateDebut
            // 
            this.LB_DateDebut.AutoSize = true;
            this.LB_DateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateDebut.Location = new System.Drawing.Point(35, 87);
            this.LB_DateDebut.Name = "LB_DateDebut";
            this.LB_DateDebut.Size = new System.Drawing.Size(113, 16);
            this.LB_DateDebut.TabIndex = 6;
            this.LB_DateDebut.Text = "Date / Date début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Infos";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(38, 196);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Important";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(38, 235);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(583, 20);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Super Mega important (en cochant ceci, ce message apparaitra en haut de la fentre" +
    " des profs)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Genre";
            // 
            // COMBO_Genre
            // 
            this.COMBO_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.COMBO_Genre.FormattingEnabled = true;
            this.COMBO_Genre.Items.AddRange(new object[] {
            "Divers",
            "Anniversaire",
            "Vacances",
            "Jour férié",
            "Rendez-vous",
            "Absence personnel"});
            this.COMBO_Genre.Location = new System.Drawing.Point(130, 298);
            this.COMBO_Genre.Name = "COMBO_Genre";
            this.COMBO_Genre.Size = new System.Drawing.Size(206, 25);
            this.COMBO_Genre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom / Désciption";
            // 
            // TXT_Nom
            // 
            this.TXT_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TXT_Nom.Location = new System.Drawing.Point(130, 349);
            this.TXT_Nom.Name = "TXT_Nom";
            this.TXT_Nom.Size = new System.Drawing.Size(206, 23);
            this.TXT_Nom.TabIndex = 10;
            // 
            // LB_Erreurs
            // 
            this.LB_Erreurs.AutoSize = true;
            this.LB_Erreurs.ForeColor = System.Drawing.Color.Red;
            this.LB_Erreurs.Location = new System.Drawing.Point(56, 528);
            this.LB_Erreurs.Name = "LB_Erreurs";
            this.LB_Erreurs.Size = new System.Drawing.Size(59, 13);
            this.LB_Erreurs.TabIndex = 18;
            this.LB_Erreurs.Text = "LB_Erreurs";
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.ForeColor = System.Drawing.Color.Red;
            this.BT_Supprimer.Location = new System.Drawing.Point(236, 583);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BT_Supprimer.TabIndex = 17;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Update.ForeColor = System.Drawing.Color.Blue;
            this.BT_Update.Location = new System.Drawing.Point(543, 583);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 16;
            this.BT_Update.Text = "Modifier";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Create
            // 
            this.BT_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Create.ForeColor = System.Drawing.Color.Green;
            this.BT_Create.Location = new System.Drawing.Point(462, 583);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(75, 23);
            this.BT_Create.TabIndex = 15;
            this.BT_Create.Text = "Ajouter";
            this.BT_Create.UseVisualStyleBackColor = true;
            this.BT_Create.Click += new System.EventHandler(this.BT_Create_Click);
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BT_Annuler.Location = new System.Drawing.Point(14, 582);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BT_Annuler.TabIndex = 14;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // LB_DateDebutHuman
            // 
            this.LB_DateDebutHuman.AutoSize = true;
            this.LB_DateDebutHuman.Location = new System.Drawing.Point(471, 89);
            this.LB_DateDebutHuman.Name = "LB_DateDebutHuman";
            this.LB_DateDebutHuman.Size = new System.Drawing.Size(112, 13);
            this.LB_DateDebutHuman.TabIndex = 19;
            this.LB_DateDebutHuman.Text = "LB_DateDebutHuman";
            // 
            // LB_DateFinHuman
            // 
            this.LB_DateFinHuman.AutoSize = true;
            this.LB_DateFinHuman.Location = new System.Drawing.Point(471, 133);
            this.LB_DateFinHuman.Name = "LB_DateFinHuman";
            this.LB_DateFinHuman.Size = new System.Drawing.Size(97, 13);
            this.LB_DateFinHuman.TabIndex = 19;
            this.LB_DateFinHuman.Text = "LB_DateFinHuman";
            // 
            // F_Calendar_EvenementtAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 626);
            this.Controls.Add(this.LB_DateFinHuman);
            this.Controls.Add(this.LB_DateDebutHuman);
            this.Controls.Add(this.LB_Erreurs);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Create);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.TXT_Nom);
            this.Controls.Add(this.COMBO_Genre);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_DateDebut);
            this.Controls.Add(this.TXT_Infos);
            this.Controls.Add(this.CB_DateFin);
            this.Controls.Add(this.DatePicker_Fin);
            this.Controls.Add(this.DatePicker_Debut);
            this.Controls.Add(this.LB_Titre);
            this.Name = "F_Calendar_EvenementtAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Calendar_EvenementtAdd";
            this.Load += new System.EventHandler(this.F_Calendar_EvenementtAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.DateTimePicker DatePicker_Debut;
        private System.Windows.Forms.DateTimePicker DatePicker_Fin;
        private System.Windows.Forms.CheckBox CB_DateFin;
        private System.Windows.Forms.TextBox TXT_Infos;
        private System.Windows.Forms.Label LB_DateDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox COMBO_Genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Nom;
        private System.Windows.Forms.Label LB_Erreurs;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.Label LB_DateDebutHuman;
        private System.Windows.Forms.Label LB_DateFinHuman;
    }
}