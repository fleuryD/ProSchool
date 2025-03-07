namespace ProSchool
{
    partial class F_User_Connexion
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
            this.FLP_BTUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP_BTUsers
            // 
            this.FLP_BTUsers.AutoScroll = true;
            this.FLP_BTUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLP_BTUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_BTUsers.Location = new System.Drawing.Point(0, 56);
            this.FLP_BTUsers.Name = "FLP_BTUsers";
            this.FLP_BTUsers.Size = new System.Drawing.Size(844, 332);
            this.FLP_BTUsers.TabIndex = 0;
            // 
            // PAN_Header
            // 
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.label3);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(844, 56);
            this.PAN_Header.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 33);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliquez sur votre nom pour vous vconneter";
            // 
            // F_User_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 421);
            this.Controls.Add(this.FLP_BTUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_User_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_User_Connexion";
            this.Load += new System.EventHandler(this.F_User_Connexion_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP_BTUsers;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}