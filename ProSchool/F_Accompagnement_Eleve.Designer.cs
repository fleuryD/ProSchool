namespace ProSchool
{
    partial class F_Accompagnement_Eleve
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
            this.LB_EleveNom = new System.Windows.Forms.Label();
            this.BT_Valider = new System.Windows.Forms.Button();
            this.FLP_CbsAccs = new System.Windows.Forms.FlowLayoutPanel();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.PAN_Footer = new System.Windows.Forms.Panel();
            this.PAN_Header.SuspendLayout();
            this.PAN_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accompagnements:";
            // 
            // LB_EleveNom
            // 
            this.LB_EleveNom.AutoSize = true;
            this.LB_EleveNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EleveNom.ForeColor = System.Drawing.Color.Brown;
            this.LB_EleveNom.Location = new System.Drawing.Point(192, 7);
            this.LB_EleveNom.Name = "LB_EleveNom";
            this.LB_EleveNom.Size = new System.Drawing.Size(95, 20);
            this.LB_EleveNom.TabIndex = 1;
            this.LB_EleveNom.Text = "**ELEVE**";
            // 
            // BT_Valider
            // 
            this.BT_Valider.Location = new System.Drawing.Point(790, 24);
            this.BT_Valider.Name = "BT_Valider";
            this.BT_Valider.Size = new System.Drawing.Size(75, 23);
            this.BT_Valider.TabIndex = 2;
            this.BT_Valider.Text = "Valider";
            this.BT_Valider.UseVisualStyleBackColor = true;
            this.BT_Valider.Click += new System.EventHandler(this.BT_Valider_Click);
            // 
            // FLP_CbsAccs
            // 
            this.FLP_CbsAccs.BackColor = System.Drawing.Color.White;
            this.FLP_CbsAccs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLP_CbsAccs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_CbsAccs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP_CbsAccs.Location = new System.Drawing.Point(10, 52);
            this.FLP_CbsAccs.Name = "FLP_CbsAccs";
            this.FLP_CbsAccs.Padding = new System.Windows.Forms.Padding(10);
            this.FLP_CbsAccs.Size = new System.Drawing.Size(875, 452);
            this.FLP_CbsAccs.TabIndex = 4;
            // 
            // PAN_Header
            // 
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.label1);
            this.PAN_Header.Controls.Add(this.LB_EleveNom);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(10, 10);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(875, 42);
            this.PAN_Header.TabIndex = 5;
            // 
            // PAN_Footer
            // 
            this.PAN_Footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Footer.Controls.Add(this.BT_Valider);
            this.PAN_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PAN_Footer.Location = new System.Drawing.Point(10, 504);
            this.PAN_Footer.Name = "PAN_Footer";
            this.PAN_Footer.Size = new System.Drawing.Size(875, 63);
            this.PAN_Footer.TabIndex = 5;
            // 
            // F_Accompagnement_Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 577);
            this.Controls.Add(this.FLP_CbsAccs);
            this.Controls.Add(this.PAN_Footer);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Accompagnement_Eleve";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier les accompagnement de l\'élève";
            this.Load += new System.EventHandler(this.F_Accomagnement_Eleve_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.PAN_Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_EleveNom;
        private System.Windows.Forms.Button BT_Valider;
        private System.Windows.Forms.FlowLayoutPanel FLP_CbsAccs;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel PAN_Footer;
    }
}