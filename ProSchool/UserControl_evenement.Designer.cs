namespace ProSchool
{
    partial class UserControl_Evenement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_EvenementEdit = new System.Windows.Forms.Button();
            this.RichTXT_Date = new System.Windows.Forms.RichTextBox();
            this.LB_Infos = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Genre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BT_EvenementEdit);
            this.panel1.Controls.Add(this.RichTXT_Date);
            this.panel1.Controls.Add(this.LB_Infos);
            this.panel1.Controls.Add(this.LB_Nom);
            this.panel1.Controls.Add(this.LB_Genre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(277, 100);
            this.panel1.TabIndex = 0;
            // 
            // BT_EvenementEdit
            // 
            this.BT_EvenementEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_EvenementEdit.Location = new System.Drawing.Point(205, 31);
            this.BT_EvenementEdit.Name = "BT_EvenementEdit";
            this.BT_EvenementEdit.Size = new System.Drawing.Size(53, 23);
            this.BT_EvenementEdit.TabIndex = 2;
            this.BT_EvenementEdit.Text = "modifier";
            this.BT_EvenementEdit.UseVisualStyleBackColor = true;
            // 
            // RichTXT_Date
            // 
            this.RichTXT_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RichTXT_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTXT_Date.Location = new System.Drawing.Point(6, 5);
            this.RichTXT_Date.Name = "RichTXT_Date";
            this.RichTXT_Date.ReadOnly = true;
            this.RichTXT_Date.Size = new System.Drawing.Size(263, 20);
            this.RichTXT_Date.TabIndex = 1;
            this.RichTXT_Date.Text = "Dateeee";
            // 
            // LB_Infos
            // 
            this.LB_Infos.AutoSize = true;
            this.LB_Infos.BackColor = System.Drawing.Color.White;
            this.LB_Infos.Location = new System.Drawing.Point(8, 78);
            this.LB_Infos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LB_Infos.Name = "LB_Infos";
            this.LB_Infos.Size = new System.Drawing.Size(49, 13);
            this.LB_Infos.TabIndex = 0;
            this.LB_Infos.Text = "LB_Infos";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.ForeColor = System.Drawing.Color.Blue;
            this.LB_Nom.Location = new System.Drawing.Point(8, 53);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(48, 13);
            this.LB_Nom.TabIndex = 0;
            this.LB_Nom.Text = "LB_Nom";
            // 
            // LB_Genre
            // 
            this.LB_Genre.AutoSize = true;
            this.LB_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Genre.Location = new System.Drawing.Point(8, 32);
            this.LB_Genre.Name = "LB_Genre";
            this.LB_Genre.Size = new System.Drawing.Size(63, 13);
            this.LB_Genre.TabIndex = 0;
            this.LB_Genre.Text = "LB_Genre";
            // 
            // UserControl_Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Evenement";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(283, 106);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RichTXT_Date;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Genre;
        private System.Windows.Forms.Label LB_Infos;
        private System.Windows.Forms.Button BT_EvenementEdit;
    }
}
