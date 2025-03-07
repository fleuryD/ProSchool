namespace ProSchool
{
    partial class F_SelectPersonnelsEleves
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
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.LB_Description = new System.Windows.Forms.Label();
            this.PAN_DGV_Header = new System.Windows.Forms.Panel();
            this.PAN_Footer = new System.Windows.Forms.Panel();
            this.LB_Result = new System.Windows.Forms.Label();
            this.B_Annuler = new System.Windows.Forms.Button();
            this.BT_Selectionner = new System.Windows.Forms.Button();
            this.DGV_X = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_DgvSearch = new System.Windows.Forms.TextBox();
            this.PAN_Header.SuspendLayout();
            this.PAN_DGV_Header.SuspendLayout();
            this.PAN_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_X)).BeginInit();
            this.SuspendLayout();
            // 
            // PAN_Header
            // 
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.LB_Description);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(555, 42);
            this.PAN_Header.TabIndex = 0;
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Description.Location = new System.Drawing.Point(11, 11);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(336, 16);
            this.LB_Description.TabIndex = 0;
            this.LB_Description.Text = "Séléctionner un ou plusieurs personnels/eleves";
            // 
            // PAN_DGV_Header
            // 
            this.PAN_DGV_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_DGV_Header.Controls.Add(this.label16);
            this.PAN_DGV_Header.Controls.Add(this.TXT_DgvSearch);
            this.PAN_DGV_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_DGV_Header.Location = new System.Drawing.Point(0, 42);
            this.PAN_DGV_Header.Name = "PAN_DGV_Header";
            this.PAN_DGV_Header.Size = new System.Drawing.Size(555, 38);
            this.PAN_DGV_Header.TabIndex = 0;
            // 
            // PAN_Footer
            // 
            this.PAN_Footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Footer.Controls.Add(this.LB_Result);
            this.PAN_Footer.Controls.Add(this.B_Annuler);
            this.PAN_Footer.Controls.Add(this.BT_Selectionner);
            this.PAN_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PAN_Footer.Location = new System.Drawing.Point(0, 577);
            this.PAN_Footer.Name = "PAN_Footer";
            this.PAN_Footer.Size = new System.Drawing.Size(555, 50);
            this.PAN_Footer.TabIndex = 0;
            // 
            // LB_Result
            // 
            this.LB_Result.AutoSize = true;
            this.LB_Result.Location = new System.Drawing.Point(42, 14);
            this.LB_Result.Name = "LB_Result";
            this.LB_Result.Size = new System.Drawing.Size(56, 13);
            this.LB_Result.TabIndex = 1;
            this.LB_Result.Text = "LB_Result";
            // 
            // B_Annuler
            // 
            this.B_Annuler.ForeColor = System.Drawing.Color.Red;
            this.B_Annuler.Location = new System.Drawing.Point(308, 14);
            this.B_Annuler.Name = "B_Annuler";
            this.B_Annuler.Size = new System.Drawing.Size(75, 23);
            this.B_Annuler.TabIndex = 0;
            this.B_Annuler.Text = "Annuler";
            this.B_Annuler.UseVisualStyleBackColor = true;
            this.B_Annuler.Click += new System.EventHandler(this.B_Annuler_Click);
            // 
            // BT_Selectionner
            // 
            this.BT_Selectionner.Enabled = false;
            this.BT_Selectionner.ForeColor = System.Drawing.Color.Blue;
            this.BT_Selectionner.Location = new System.Drawing.Point(420, 14);
            this.BT_Selectionner.Name = "BT_Selectionner";
            this.BT_Selectionner.Size = new System.Drawing.Size(87, 23);
            this.BT_Selectionner.TabIndex = 0;
            this.BT_Selectionner.Text = "Valider";
            this.BT_Selectionner.UseVisualStyleBackColor = true;
            this.BT_Selectionner.Click += new System.EventHandler(this.BT_Selectionner_Click);
            // 
            // DGV_X
            // 
            this.DGV_X.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_X.Location = new System.Drawing.Point(0, 80);
            this.DGV_X.Name = "DGV_X";
            this.DGV_X.Size = new System.Drawing.Size(555, 497);
            this.DGV_X.TabIndex = 1;
            this.DGV_X.SelectionChanged += new System.EventHandler(this.DGV_X_SelectionChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rechercher par nom, prénom, classe ou niveau";
            // 
            // TXT_DgvSearch
            // 
            this.TXT_DgvSearch.Location = new System.Drawing.Point(248, 7);
            this.TXT_DgvSearch.Name = "TXT_DgvSearch";
            this.TXT_DgvSearch.Size = new System.Drawing.Size(228, 20);
            this.TXT_DgvSearch.TabIndex = 2;
            this.TXT_DgvSearch.TextChanged += new System.EventHandler(this.TXT_DgvSearch_TextChanged);
            // 
            // F_SelectPersonnelsEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 627);
            this.Controls.Add(this.DGV_X);
            this.Controls.Add(this.PAN_Footer);
            this.Controls.Add(this.PAN_DGV_Header);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_SelectPersonnelsEleves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_SelectPersonnelsEleves";
            this.Load += new System.EventHandler(this.F_SelectPersonnelsEleves_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.PAN_DGV_Header.ResumeLayout(false);
            this.PAN_DGV_Header.PerformLayout();
            this.PAN_Footer.ResumeLayout(false);
            this.PAN_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_X)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel PAN_DGV_Header;
        private System.Windows.Forms.Panel PAN_Footer;
        private System.Windows.Forms.DataGridView DGV_X;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Button B_Annuler;
        private System.Windows.Forms.Button BT_Selectionner;
        private System.Windows.Forms.Label LB_Result;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_DgvSearch;
    }
}