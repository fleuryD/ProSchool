namespace ProSchool
{
    partial class F_Accompagnement_Edit
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
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.BT_Create = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.NUM_Id = new System.Windows.Forms.NumericUpDown();
            this.TXT_Nom = new System.Windows.Forms.TextBox();
            this.TXT_NomSimple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUM_Position = new System.Windows.Forms.NumericUpDown();
            this.LB_Erreurs = new System.Windows.Forms.Label();
            this.LB_Titre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_NbreEleves = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Position)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.ForeColor = System.Drawing.Color.Red;
            this.BT_Annuler.Location = new System.Drawing.Point(20, 355);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BT_Annuler.TabIndex = 0;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // BT_Create
            // 
            this.BT_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Create.ForeColor = System.Drawing.Color.Green;
            this.BT_Create.Location = new System.Drawing.Point(283, 355);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(75, 23);
            this.BT_Create.TabIndex = 1;
            this.BT_Create.Text = "Créer";
            this.BT_Create.UseVisualStyleBackColor = true;
            this.BT_Create.Click += new System.EventHandler(this.BT_Create_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Update.ForeColor = System.Drawing.Color.Blue;
            this.BT_Update.Location = new System.Drawing.Point(364, 355);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 2;
            this.BT_Update.Text = "Modifier";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.ForeColor = System.Drawing.Color.Red;
            this.BT_Supprimer.Location = new System.Drawing.Point(151, 355);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BT_Supprimer.TabIndex = 3;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // NUM_Id
            // 
            this.NUM_Id.Location = new System.Drawing.Point(74, 74);
            this.NUM_Id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUM_Id.Name = "NUM_Id";
            this.NUM_Id.Size = new System.Drawing.Size(73, 20);
            this.NUM_Id.TabIndex = 4;
            // 
            // TXT_Nom
            // 
            this.TXT_Nom.Location = new System.Drawing.Point(74, 120);
            this.TXT_Nom.Name = "TXT_Nom";
            this.TXT_Nom.Size = new System.Drawing.Size(339, 20);
            this.TXT_Nom.TabIndex = 5;
            // 
            // TXT_NomSimple
            // 
            this.TXT_NomSimple.Location = new System.Drawing.Point(74, 146);
            this.TXT_NomSimple.Name = "TXT_NomSimple";
            this.TXT_NomSimple.Size = new System.Drawing.Size(123, 20);
            this.TXT_NomSimple.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nom Simple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position";
            // 
            // NUM_Position
            // 
            this.NUM_Position.Location = new System.Drawing.Point(74, 211);
            this.NUM_Position.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUM_Position.Name = "NUM_Position";
            this.NUM_Position.Size = new System.Drawing.Size(62, 20);
            this.NUM_Position.TabIndex = 12;
            // 
            // LB_Erreurs
            // 
            this.LB_Erreurs.AutoSize = true;
            this.LB_Erreurs.ForeColor = System.Drawing.Color.Red;
            this.LB_Erreurs.Location = new System.Drawing.Point(20, 254);
            this.LB_Erreurs.Name = "LB_Erreurs";
            this.LB_Erreurs.Size = new System.Drawing.Size(59, 13);
            this.LB_Erreurs.TabIndex = 13;
            this.LB_Erreurs.Text = "LB_Erreurs";
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(27, 28);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(77, 20);
            this.LB_Titre.TabIndex = 14;
            this.LB_Titre.Text = "LB_Titre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 173);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(431, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Le \"nom simple\" doit être assez court pour être afficher en en-tête du tableau";
            // 
            // LB_NbreEleves
            // 
            this.LB_NbreEleves.AutoSize = true;
            this.LB_NbreEleves.Location = new System.Drawing.Point(20, 317);
            this.LB_NbreEleves.Name = "LB_NbreEleves";
            this.LB_NbreEleves.Size = new System.Drawing.Size(81, 13);
            this.LB_NbreEleves.TabIndex = 16;
            this.LB_NbreEleves.Text = "LB_NbreEleves";
            // 
            // F_Accompagnement_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.LB_NbreEleves);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_Titre);
            this.Controls.Add(this.LB_Erreurs);
            this.Controls.Add(this.NUM_Position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_NomSimple);
            this.Controls.Add(this.TXT_Nom);
            this.Controls.Add(this.NUM_Id);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Create);
            this.Controls.Add(this.BT_Annuler);
            this.Name = "F_Accompagnement_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Accompagnement_Edit";
            this.Load += new System.EventHandler(this.F_Accompagnement_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.NumericUpDown NUM_Id;
        private System.Windows.Forms.TextBox TXT_Nom;
        private System.Windows.Forms.TextBox TXT_NomSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUM_Position;
        private System.Windows.Forms.Label LB_Erreurs;
        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_NbreEleves;
    }
}