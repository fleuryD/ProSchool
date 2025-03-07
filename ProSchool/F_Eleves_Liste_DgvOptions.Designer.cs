namespace ProSchool
{
    partial class F_Eleves_Liste_DgvOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Col_Id = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.CB_Col_dateNaissance = new System.Windows.Forms.CheckBox();
            this.CB_Col_sexe = new System.Windows.Forms.CheckBox();
            this.CB_Col_ine = new System.Windows.Forms.CheckBox();
            this.CB_Col_cycle = new System.Windows.Forms.CheckBox();
            this.CB_Col_niveau = new System.Windows.Forms.CheckBox();
            this.CB_Col_classe = new System.Windows.Forms.CheckBox();
            this.CB_Col_attestation = new System.Windows.Forms.CheckBox();
            this.CB_Col_autorisationPhoto = new System.Windows.Forms.CheckBox();
            this.CB_Col_decisionPassage = new System.Windows.Forms.CheckBox();
            this.CB_Col_dispositifs = new System.Windows.Forms.CheckBox();
            this.CB_Col_delegue = new System.Windows.Forms.CheckBox();
            this.CB_Col_alae = new System.Windows.Forms.CheckBox();
            this.CB_Col_dpExt = new System.Windows.Forms.CheckBox();
            this.CB_Col_garderie = new System.Windows.Forms.CheckBox();
            this.CB_Col_import_genre = new System.Windows.Forms.CheckBox();
            this.CB_Col_date_entree = new System.Windows.Forms.CheckBox();
            this.CB_Col_date_sortie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afficher les colonnes";
            // 
            // CB_Col_Id
            // 
            this.CB_Col_Id.AutoSize = true;
            this.CB_Col_Id.Location = new System.Drawing.Point(49, 87);
            this.CB_Col_Id.Name = "CB_Col_Id";
            this.CB_Col_Id.Size = new System.Drawing.Size(34, 17);
            this.CB_Col_Id.TabIndex = 1;
            this.CB_Col_Id.Text = "id";
            this.CB_Col_Id.UseVisualStyleBackColor = true;
            this.CB_Col_Id.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(49, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "nom";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(49, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "prenom";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // CB_Col_dateNaissance
            // 
            this.CB_Col_dateNaissance.AutoSize = true;
            this.CB_Col_dateNaissance.Location = new System.Drawing.Point(49, 158);
            this.CB_Col_dateNaissance.Name = "CB_Col_dateNaissance";
            this.CB_Col_dateNaissance.Size = new System.Drawing.Size(97, 17);
            this.CB_Col_dateNaissance.TabIndex = 4;
            this.CB_Col_dateNaissance.Text = "dateNaissance";
            this.CB_Col_dateNaissance.UseVisualStyleBackColor = true;
            this.CB_Col_dateNaissance.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_sexe
            // 
            this.CB_Col_sexe.AutoSize = true;
            this.CB_Col_sexe.Location = new System.Drawing.Point(49, 182);
            this.CB_Col_sexe.Name = "CB_Col_sexe";
            this.CB_Col_sexe.Size = new System.Drawing.Size(48, 17);
            this.CB_Col_sexe.TabIndex = 5;
            this.CB_Col_sexe.Text = "sexe";
            this.CB_Col_sexe.UseVisualStyleBackColor = true;
            this.CB_Col_sexe.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_ine
            // 
            this.CB_Col_ine.AutoSize = true;
            this.CB_Col_ine.Location = new System.Drawing.Point(48, 205);
            this.CB_Col_ine.Name = "CB_Col_ine";
            this.CB_Col_ine.Size = new System.Drawing.Size(40, 17);
            this.CB_Col_ine.TabIndex = 6;
            this.CB_Col_ine.Text = "ine";
            this.CB_Col_ine.UseVisualStyleBackColor = true;
            this.CB_Col_ine.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_cycle
            // 
            this.CB_Col_cycle.AutoSize = true;
            this.CB_Col_cycle.Location = new System.Drawing.Point(48, 228);
            this.CB_Col_cycle.Name = "CB_Col_cycle";
            this.CB_Col_cycle.Size = new System.Drawing.Size(51, 17);
            this.CB_Col_cycle.TabIndex = 7;
            this.CB_Col_cycle.Text = "cycle";
            this.CB_Col_cycle.UseVisualStyleBackColor = true;
            this.CB_Col_cycle.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_niveau
            // 
            this.CB_Col_niveau.AutoSize = true;
            this.CB_Col_niveau.Location = new System.Drawing.Point(48, 252);
            this.CB_Col_niveau.Name = "CB_Col_niveau";
            this.CB_Col_niveau.Size = new System.Drawing.Size(58, 17);
            this.CB_Col_niveau.TabIndex = 8;
            this.CB_Col_niveau.Text = "niveau";
            this.CB_Col_niveau.UseVisualStyleBackColor = true;
            this.CB_Col_niveau.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_classe
            // 
            this.CB_Col_classe.AutoSize = true;
            this.CB_Col_classe.Location = new System.Drawing.Point(48, 276);
            this.CB_Col_classe.Name = "CB_Col_classe";
            this.CB_Col_classe.Size = new System.Drawing.Size(56, 17);
            this.CB_Col_classe.TabIndex = 9;
            this.CB_Col_classe.Text = "classe";
            this.CB_Col_classe.UseVisualStyleBackColor = true;
            this.CB_Col_classe.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_attestation
            // 
            this.CB_Col_attestation.AutoSize = true;
            this.CB_Col_attestation.Location = new System.Drawing.Point(48, 299);
            this.CB_Col_attestation.Name = "CB_Col_attestation";
            this.CB_Col_attestation.Size = new System.Drawing.Size(75, 17);
            this.CB_Col_attestation.TabIndex = 10;
            this.CB_Col_attestation.Text = "attestation";
            this.CB_Col_attestation.UseVisualStyleBackColor = true;
            this.CB_Col_attestation.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_autorisationPhoto
            // 
            this.CB_Col_autorisationPhoto.AutoSize = true;
            this.CB_Col_autorisationPhoto.Location = new System.Drawing.Point(49, 322);
            this.CB_Col_autorisationPhoto.Name = "CB_Col_autorisationPhoto";
            this.CB_Col_autorisationPhoto.Size = new System.Drawing.Size(108, 17);
            this.CB_Col_autorisationPhoto.TabIndex = 11;
            this.CB_Col_autorisationPhoto.Text = "autorisationPhoto";
            this.CB_Col_autorisationPhoto.UseVisualStyleBackColor = true;
            this.CB_Col_autorisationPhoto.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_decisionPassage
            // 
            this.CB_Col_decisionPassage.AutoSize = true;
            this.CB_Col_decisionPassage.Location = new System.Drawing.Point(49, 346);
            this.CB_Col_decisionPassage.Name = "CB_Col_decisionPassage";
            this.CB_Col_decisionPassage.Size = new System.Drawing.Size(106, 17);
            this.CB_Col_decisionPassage.TabIndex = 12;
            this.CB_Col_decisionPassage.Text = "decisionPassage";
            this.CB_Col_decisionPassage.UseVisualStyleBackColor = true;
            this.CB_Col_decisionPassage.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_dispositifs
            // 
            this.CB_Col_dispositifs.AutoSize = true;
            this.CB_Col_dispositifs.Location = new System.Drawing.Point(49, 370);
            this.CB_Col_dispositifs.Name = "CB_Col_dispositifs";
            this.CB_Col_dispositifs.Size = new System.Drawing.Size(71, 17);
            this.CB_Col_dispositifs.TabIndex = 13;
            this.CB_Col_dispositifs.Text = "dispositifs";
            this.CB_Col_dispositifs.UseVisualStyleBackColor = true;
            this.CB_Col_dispositifs.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_delegue
            // 
            this.CB_Col_delegue.AutoSize = true;
            this.CB_Col_delegue.Location = new System.Drawing.Point(48, 414);
            this.CB_Col_delegue.Name = "CB_Col_delegue";
            this.CB_Col_delegue.Size = new System.Drawing.Size(66, 17);
            this.CB_Col_delegue.TabIndex = 10;
            this.CB_Col_delegue.Text = "Delegue";
            this.CB_Col_delegue.UseVisualStyleBackColor = true;
            this.CB_Col_delegue.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_alae
            // 
            this.CB_Col_alae.AutoSize = true;
            this.CB_Col_alae.Location = new System.Drawing.Point(48, 483);
            this.CB_Col_alae.Name = "CB_Col_alae";
            this.CB_Col_alae.Size = new System.Drawing.Size(53, 17);
            this.CB_Col_alae.TabIndex = 11;
            this.CB_Col_alae.Text = "ALAE";
            this.CB_Col_alae.UseVisualStyleBackColor = true;
            this.CB_Col_alae.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_dpExt
            // 
            this.CB_Col_dpExt.AutoSize = true;
            this.CB_Col_dpExt.Location = new System.Drawing.Point(48, 437);
            this.CB_Col_dpExt.Name = "CB_Col_dpExt";
            this.CB_Col_dpExt.Size = new System.Drawing.Size(83, 17);
            this.CB_Col_dpExt.TabIndex = 12;
            this.CB_Col_dpExt.Text = "DP_Externe";
            this.CB_Col_dpExt.UseVisualStyleBackColor = true;
            this.CB_Col_dpExt.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_garderie
            // 
            this.CB_Col_garderie.AutoSize = true;
            this.CB_Col_garderie.Location = new System.Drawing.Point(48, 460);
            this.CB_Col_garderie.Name = "CB_Col_garderie";
            this.CB_Col_garderie.Size = new System.Drawing.Size(66, 17);
            this.CB_Col_garderie.TabIndex = 13;
            this.CB_Col_garderie.Text = "Garderie";
            this.CB_Col_garderie.UseVisualStyleBackColor = true;
            this.CB_Col_garderie.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_import_genre
            // 
            this.CB_Col_import_genre.AutoSize = true;
            this.CB_Col_import_genre.Location = new System.Drawing.Point(48, 568);
            this.CB_Col_import_genre.Name = "CB_Col_import_genre";
            this.CB_Col_import_genre.Size = new System.Drawing.Size(87, 17);
            this.CB_Col_import_genre.TabIndex = 11;
            this.CB_Col_import_genre.Text = "import_genre";
            this.CB_Col_import_genre.UseVisualStyleBackColor = true;
            this.CB_Col_import_genre.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_date_entree
            // 
            this.CB_Col_date_entree.AutoSize = true;
            this.CB_Col_date_entree.Location = new System.Drawing.Point(48, 522);
            this.CB_Col_date_entree.Name = "CB_Col_date_entree";
            this.CB_Col_date_entree.Size = new System.Drawing.Size(83, 17);
            this.CB_Col_date_entree.TabIndex = 12;
            this.CB_Col_date_entree.Text = "date_entree";
            this.CB_Col_date_entree.UseVisualStyleBackColor = true;
            this.CB_Col_date_entree.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // CB_Col_date_sortie
            // 
            this.CB_Col_date_sortie.AutoSize = true;
            this.CB_Col_date_sortie.Location = new System.Drawing.Point(48, 545);
            this.CB_Col_date_sortie.Name = "CB_Col_date_sortie";
            this.CB_Col_date_sortie.Size = new System.Drawing.Size(78, 17);
            this.CB_Col_date_sortie.TabIndex = 13;
            this.CB_Col_date_sortie.Text = "date_sortie";
            this.CB_Col_date_sortie.UseVisualStyleBackColor = true;
            this.CB_Col_date_sortie.CheckedChanged += new System.EventHandler(this.CB_Colonnes_CheckedChanged);
            // 
            // F_Eleves_Liste_DgvOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 617);
            this.Controls.Add(this.CB_Col_date_sortie);
            this.Controls.Add(this.CB_Col_garderie);
            this.Controls.Add(this.CB_Col_dispositifs);
            this.Controls.Add(this.CB_Col_date_entree);
            this.Controls.Add(this.CB_Col_dpExt);
            this.Controls.Add(this.CB_Col_import_genre);
            this.Controls.Add(this.CB_Col_decisionPassage);
            this.Controls.Add(this.CB_Col_alae);
            this.Controls.Add(this.CB_Col_autorisationPhoto);
            this.Controls.Add(this.CB_Col_delegue);
            this.Controls.Add(this.CB_Col_attestation);
            this.Controls.Add(this.CB_Col_classe);
            this.Controls.Add(this.CB_Col_niveau);
            this.Controls.Add(this.CB_Col_cycle);
            this.Controls.Add(this.CB_Col_ine);
            this.Controls.Add(this.CB_Col_sexe);
            this.Controls.Add(this.CB_Col_dateNaissance);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.CB_Col_Id);
            this.Controls.Add(this.label1);
            this.Name = "F_Eleves_Liste_DgvOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Eleves_Liste_DgvOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Col_Id;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox CB_Col_dateNaissance;
        private System.Windows.Forms.CheckBox CB_Col_sexe;
        private System.Windows.Forms.CheckBox CB_Col_ine;
        private System.Windows.Forms.CheckBox CB_Col_cycle;
        private System.Windows.Forms.CheckBox CB_Col_niveau;
        private System.Windows.Forms.CheckBox CB_Col_classe;
        private System.Windows.Forms.CheckBox CB_Col_attestation;
        private System.Windows.Forms.CheckBox CB_Col_autorisationPhoto;
        private System.Windows.Forms.CheckBox CB_Col_decisionPassage;
        private System.Windows.Forms.CheckBox CB_Col_dispositifs;
        private System.Windows.Forms.CheckBox CB_Col_delegue;
        private System.Windows.Forms.CheckBox CB_Col_alae;
        private System.Windows.Forms.CheckBox CB_Col_dpExt;
        private System.Windows.Forms.CheckBox CB_Col_garderie;
        private System.Windows.Forms.CheckBox CB_Col_import_genre;
        private System.Windows.Forms.CheckBox CB_Col_date_entree;
        private System.Windows.Forms.CheckBox CB_Col_date_sortie;
    }
}