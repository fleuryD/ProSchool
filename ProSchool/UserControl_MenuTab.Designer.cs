namespace ProSchool
{
    partial class UserControl_MenuTab
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
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Déconnexion = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.panel1);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(973, 56);
            this.PAN_Header.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Déconnexion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(802, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 52);
            this.panel1.TabIndex = 0;
            // 
            // Déconnexion
            // 
            this.Déconnexion.AutoSize = true;
            this.Déconnexion.Location = new System.Drawing.Point(46, 23);
            this.Déconnexion.Name = "Déconnexion";
            this.Déconnexion.Size = new System.Drawing.Size(35, 13);
            this.Déconnexion.TabIndex = 0;
            this.Déconnexion.Text = "label1";
            // 
            // UserControl_MenuTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PAN_Header);
            this.Name = "UserControl_MenuTab";
            this.Size = new System.Drawing.Size(973, 217);
            this.PAN_Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Déconnexion;
    }
}
