namespace ProSchool
{
    partial class UserControl_AppelClasseRecap
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
            this.LB_ClasseNom = new System.Windows.Forms.Label();
            this.PAN_Appels = new System.Windows.Forms.Panel();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_RecapMatin = new System.Windows.Forms.Label();
            this.LB_RecapAprem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_ClasseNom
            // 
            this.LB_ClasseNom.AutoSize = true;
            this.LB_ClasseNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_ClasseNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ClasseNom.Location = new System.Drawing.Point(10, 10);
            this.LB_ClasseNom.Name = "LB_ClasseNom";
            this.LB_ClasseNom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_ClasseNom.Size = new System.Drawing.Size(131, 30);
            this.LB_ClasseNom.TabIndex = 0;
            this.LB_ClasseNom.Text = "LB_ClasseNom";
            // 
            // PAN_Appels
            // 
            this.PAN_Appels.AutoSize = true;
            this.PAN_Appels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Appels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Appels.Location = new System.Drawing.Point(10, 109);
            this.PAN_Appels.MinimumSize = new System.Drawing.Size(400, 4);
            this.PAN_Appels.Name = "PAN_Appels";
            this.PAN_Appels.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Appels.Size = new System.Drawing.Size(407, 139);
            this.PAN_Appels.TabIndex = 1;
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Date.Location = new System.Drawing.Point(10, 40);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_Date.Size = new System.Drawing.Size(49, 23);
            this.LB_Date.TabIndex = 2;
            this.LB_Date.Text = "LB_Date";
            // 
            // LB_RecapMatin
            // 
            this.LB_RecapMatin.AutoSize = true;
            this.LB_RecapMatin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_RecapMatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecapMatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_RecapMatin.Location = new System.Drawing.Point(10, 63);
            this.LB_RecapMatin.Name = "LB_RecapMatin";
            this.LB_RecapMatin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_RecapMatin.Size = new System.Drawing.Size(97, 23);
            this.LB_RecapMatin.TabIndex = 4;
            this.LB_RecapMatin.Text = "LB_RecapMatin";
            // 
            // LB_RecapAprem
            // 
            this.LB_RecapAprem.AutoSize = true;
            this.LB_RecapAprem.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_RecapAprem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecapAprem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_RecapAprem.Location = new System.Drawing.Point(10, 86);
            this.LB_RecapAprem.Name = "LB_RecapAprem";
            this.LB_RecapAprem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_RecapAprem.Size = new System.Drawing.Size(101, 23);
            this.LB_RecapAprem.TabIndex = 5;
            this.LB_RecapAprem.Text = "LB_RecapAprem";
            // 
            // UserControl_AppelClasseRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PAN_Appels);
            this.Controls.Add(this.LB_RecapAprem);
            this.Controls.Add(this.LB_RecapMatin);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.LB_ClasseNom);
            this.MinimumSize = new System.Drawing.Size(250, 4);
            this.Name = "UserControl_AppelClasseRecap";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(427, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ClasseNom;
        private System.Windows.Forms.Panel PAN_Appels;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_RecapMatin;
        private System.Windows.Forms.Label LB_RecapAprem;
    }
}
