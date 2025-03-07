namespace ProSchool
{
    partial class UserControl_AppelEleveRecap
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
            this.LB_EleveNomPrenom = new System.Windows.Forms.Label();
            this.AppelMatin = new System.Windows.Forms.Label();
            this.AppelAprem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_EleveNomPrenom
            // 
            this.LB_EleveNomPrenom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_EleveNomPrenom.Dock = System.Windows.Forms.DockStyle.Left;
            this.LB_EleveNomPrenom.Location = new System.Drawing.Point(0, 0);
            this.LB_EleveNomPrenom.Name = "LB_EleveNomPrenom";
            this.LB_EleveNomPrenom.Size = new System.Drawing.Size(195, 21);
            this.LB_EleveNomPrenom.TabIndex = 0;
            this.LB_EleveNomPrenom.Text = "LB_EleveNomPrenom";
            this.LB_EleveNomPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_EleveNomPrenom.Click += new System.EventHandler(this.LB_EleveNomPrenom_Click);
            // 
            // AppelMatin
            // 
            this.AppelMatin.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppelMatin.Location = new System.Drawing.Point(195, 0);
            this.AppelMatin.Name = "AppelMatin";
            this.AppelMatin.Size = new System.Drawing.Size(87, 21);
            this.AppelMatin.TabIndex = 0;
            this.AppelMatin.Text = "?";
            this.AppelMatin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppelAprem
            // 
            this.AppelAprem.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppelAprem.Location = new System.Drawing.Point(282, 0);
            this.AppelAprem.Name = "AppelAprem";
            this.AppelAprem.Size = new System.Drawing.Size(87, 21);
            this.AppelAprem.TabIndex = 0;
            this.AppelAprem.Text = "?";
            this.AppelAprem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl_AppelEleveRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.AppelAprem);
            this.Controls.Add(this.AppelMatin);
            this.Controls.Add(this.LB_EleveNomPrenom);
            this.Name = "UserControl_AppelEleveRecap";
            this.Size = new System.Drawing.Size(369, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_EleveNomPrenom;
        private System.Windows.Forms.Label AppelMatin;
        private System.Windows.Forms.Label AppelAprem;
    }
}
