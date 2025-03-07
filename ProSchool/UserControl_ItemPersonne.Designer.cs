namespace ProSchool
{
    partial class UserControl_ItemPersonne
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
            this.LB_Nom = new System.Windows.Forms.Label();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoEllipsis = true;
            this.LB_Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nom.Location = new System.Drawing.Point(2, 2);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(392, 22);
            this.LB_Nom.TabIndex = 0;
            this.LB_Nom.Text = "nomprenom1111111111111222222222233333333334444444455556666666";
            this.LB_Nom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Supprimer.ForeColor = System.Drawing.Color.Red;
            this.BT_Supprimer.Location = new System.Drawing.Point(394, 2);
            this.BT_Supprimer.Margin = new System.Windows.Forms.Padding(0);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(69, 22);
            this.BT_Supprimer.TabIndex = 1;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // UserControl_ItemPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.BT_Supprimer);
            this.Name = "UserControl_ItemPersonne";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(465, 26);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Button BT_Supprimer;
    }
}
