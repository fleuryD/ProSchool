namespace ProSchool
{
    partial class UserControl_Suivi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_Decision = new System.Windows.Forms.TextBox();
            this.LB_Decision = new System.Windows.Forms.Label();
            this.TXT_Contenu = new System.Windows.Forms.TextBox();
            this.LB_Contenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LB_Genre = new System.Windows.Forms.Label();
            this.LB_EleveFamille_Label = new System.Windows.Forms.Label();
            this.LB_EleveFamille = new System.Windows.Forms.Label();
            this.BT_SuiviEdit = new System.Windows.Forms.Button();
            this.LB_Eleves = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TXT_Decision);
            this.panel2.Controls.Add(this.LB_Decision);
            this.panel2.Controls.Add(this.TXT_Contenu);
            this.panel2.Controls.Add(this.LB_Contenu);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(885, 235);
            this.panel2.TabIndex = 6;
            // 
            // TXT_Decision
            // 
            this.TXT_Decision.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Decision.Location = new System.Drawing.Point(10, 136);
            this.TXT_Decision.Multiline = true;
            this.TXT_Decision.Name = "TXT_Decision";
            this.TXT_Decision.ReadOnly = true;
            this.TXT_Decision.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_Decision.Size = new System.Drawing.Size(861, 50);
            this.TXT_Decision.TabIndex = 9;
            // 
            // LB_Decision
            // 
            this.LB_Decision.AutoSize = true;
            this.LB_Decision.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Decision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Decision.Location = new System.Drawing.Point(10, 113);
            this.LB_Decision.Name = "LB_Decision";
            this.LB_Decision.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LB_Decision.Size = new System.Drawing.Size(60, 23);
            this.LB_Decision.TabIndex = 10;
            this.LB_Decision.Text = "Decision:";
            // 
            // TXT_Contenu
            // 
            this.TXT_Contenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TXT_Contenu.Location = new System.Drawing.Point(10, 68);
            this.TXT_Contenu.Multiline = true;
            this.TXT_Contenu.Name = "TXT_Contenu";
            this.TXT_Contenu.ReadOnly = true;
            this.TXT_Contenu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_Contenu.Size = new System.Drawing.Size(861, 45);
            this.TXT_Contenu.TabIndex = 6;
            // 
            // LB_Contenu
            // 
            this.LB_Contenu.AutoSize = true;
            this.LB_Contenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Contenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Contenu.Location = new System.Drawing.Point(10, 45);
            this.LB_Contenu.Name = "LB_Contenu";
            this.LB_Contenu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LB_Contenu.Size = new System.Drawing.Size(83, 23);
            this.LB_Contenu.TabIndex = 8;
            this.LB_Contenu.Text = "Commentaire:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LB_Date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 35);
            this.panel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LB_Genre);
            this.flowLayoutPanel1.Controls.Add(this.LB_EleveFamille_Label);
            this.flowLayoutPanel1.Controls.Add(this.LB_EleveFamille);
            this.flowLayoutPanel1.Controls.Add(this.BT_SuiviEdit);
            this.flowLayoutPanel1.Controls.Add(this.LB_Eleves);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // LB_Genre
            // 
            this.LB_Genre.AutoSize = true;
            this.LB_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Genre.Location = new System.Drawing.Point(3, 0);
            this.LB_Genre.Name = "LB_Genre";
            this.LB_Genre.Size = new System.Drawing.Size(91, 20);
            this.LB_Genre.TabIndex = 1;
            this.LB_Genre.Text = "LB_Genre";
            // 
            // LB_EleveFamille_Label
            // 
            this.LB_EleveFamille_Label.AutoSize = true;
            this.LB_EleveFamille_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EleveFamille_Label.Location = new System.Drawing.Point(100, 0);
            this.LB_EleveFamille_Label.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LB_EleveFamille_Label.Name = "LB_EleveFamille_Label";
            this.LB_EleveFamille_Label.Padding = new System.Windows.Forms.Padding(40, 4, 0, 0);
            this.LB_EleveFamille_Label.Size = new System.Drawing.Size(135, 20);
            this.LB_EleveFamille_Label.TabIndex = 1;
            this.LB_EleveFamille_Label.Text = "entretien avec:";
            // 
            // LB_EleveFamille
            // 
            this.LB_EleveFamille.AutoSize = true;
            this.LB_EleveFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EleveFamille.Location = new System.Drawing.Point(235, 0);
            this.LB_EleveFamille.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LB_EleveFamille.Name = "LB_EleveFamille";
            this.LB_EleveFamille.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.LB_EleveFamille.Size = new System.Drawing.Size(125, 20);
            this.LB_EleveFamille.TabIndex = 1;
            this.LB_EleveFamille.Text = "LB_EleveFamille";
            // 
            // BT_SuiviEdit
            // 
            this.BT_SuiviEdit.Enabled = false;
            this.BT_SuiviEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SuiviEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.BT_SuiviEdit.Location = new System.Drawing.Point(443, 3);
            this.BT_SuiviEdit.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.BT_SuiviEdit.Name = "BT_SuiviEdit";
            this.BT_SuiviEdit.Size = new System.Drawing.Size(65, 26);
            this.BT_SuiviEdit.TabIndex = 2;
            this.BT_SuiviEdit.Text = "Modifier";
            this.BT_SuiviEdit.UseVisualStyleBackColor = true;
            // 
            // LB_Eleves
            // 
            this.LB_Eleves.AutoSize = true;
            this.LB_Eleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Eleves.Location = new System.Drawing.Point(514, 0);
            this.LB_Eleves.Name = "LB_Eleves";
            this.LB_Eleves.Size = new System.Drawing.Size(94, 20);
            this.LB_Eleves.TabIndex = 3;
            this.LB_Eleves.Text = "LB_Eleves";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Dock = System.Windows.Forms.DockStyle.Right;
            this.LB_Date.Location = new System.Drawing.Point(772, 0);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Padding = new System.Windows.Forms.Padding(20, 4, 20, 0);
            this.LB_Date.Size = new System.Drawing.Size(89, 17);
            this.LB_Date.TabIndex = 2;
            this.LB_Date.Text = "LB_Date";
            // 
            // UserControl_Suivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(600, 50);
            this.Name = "UserControl_Suivi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(905, 255);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_Decision;
        private System.Windows.Forms.Label LB_Decision;
        private System.Windows.Forms.TextBox TXT_Contenu;
        private System.Windows.Forms.Label LB_Contenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_Genre;
        private System.Windows.Forms.Label LB_EleveFamille;
        private System.Windows.Forms.Label LB_EleveFamille_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BT_SuiviEdit;
        private System.Windows.Forms.Label LB_Eleves;
    }
}
