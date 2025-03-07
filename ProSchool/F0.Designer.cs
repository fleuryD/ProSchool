namespace ProSchool
{
    partial class F0
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F0));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBT_UserConnexion = new System.Windows.Forms.ToolStripButton();
            this.TSBT_UserLogOut = new System.Windows.Forms.ToolStripButton();
            this.FLP_NewMenu1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FLP_NewMenu2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.FLP_NewMenu1.SuspendLayout();
            this.FLP_NewMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1160, 515);
            this.panel1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBT_UserConnexion,
            this.TSBT_UserLogOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBT_UserConnexion
            // 
            this.TSBT_UserConnexion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBT_UserConnexion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBT_UserConnexion.Image = ((System.Drawing.Image)(resources.GetObject("TSBT_UserConnexion.Image")));
            this.TSBT_UserConnexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBT_UserConnexion.Name = "TSBT_UserConnexion";
            this.TSBT_UserConnexion.Size = new System.Drawing.Size(69, 22);
            this.TSBT_UserConnexion.Text = "Connexion";
            this.TSBT_UserConnexion.Visible = false;
            this.TSBT_UserConnexion.Click += new System.EventHandler(this.TSBT_UserConnexion_Click);
            // 
            // TSBT_UserLogOut
            // 
            this.TSBT_UserLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBT_UserLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBT_UserLogOut.Image = ((System.Drawing.Image)(resources.GetObject("TSBT_UserLogOut.Image")));
            this.TSBT_UserLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBT_UserLogOut.Name = "TSBT_UserLogOut";
            this.TSBT_UserLogOut.Size = new System.Drawing.Size(81, 22);
            this.TSBT_UserLogOut.Text = "Déconnexion";
            this.TSBT_UserLogOut.Click += new System.EventHandler(this.TSBT_UserLogOut_Click);
            // 
            // FLP_NewMenu1
            // 
            this.FLP_NewMenu1.AutoSize = true;
            this.FLP_NewMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_NewMenu1.BackColor = System.Drawing.Color.White;
            this.FLP_NewMenu1.Controls.Add(this.label1);
            this.FLP_NewMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLP_NewMenu1.Location = new System.Drawing.Point(0, 25);
            this.FLP_NewMenu1.Name = "FLP_NewMenu1";
            this.FLP_NewMenu1.Size = new System.Drawing.Size(1160, 36);
            this.FLP_NewMenu1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Temp_BTM_1";
            this.label1.Visible = false;
            // 
            // FLP_NewMenu2
            // 
            this.FLP_NewMenu2.AutoSize = true;
            this.FLP_NewMenu2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_NewMenu2.BackColor = System.Drawing.Color.White;
            this.FLP_NewMenu2.Controls.Add(this.label2);
            this.FLP_NewMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLP_NewMenu2.Location = new System.Drawing.Point(0, 61);
            this.FLP_NewMenu2.Name = "FLP_NewMenu2";
            this.FLP_NewMenu2.Size = new System.Drawing.Size(1160, 36);
            this.FLP_NewMenu2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(123, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temp_BTM_2";
            this.label2.Visible = false;
            // 
            // F0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLP_NewMenu2);
            this.Controls.Add(this.FLP_NewMenu1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "F0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProSchool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_0_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.FLP_NewMenu1.ResumeLayout(false);
            this.FLP_NewMenu1.PerformLayout();
            this.FLP_NewMenu2.ResumeLayout(false);
            this.FLP_NewMenu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBT_UserConnexion;
        private System.Windows.Forms.ToolStripButton TSBT_UserLogOut;
        private System.Windows.Forms.FlowLayoutPanel FLP_NewMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLP_NewMenu2;
        private System.Windows.Forms.Label label2;
    }
}

