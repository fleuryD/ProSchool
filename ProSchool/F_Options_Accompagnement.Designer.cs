namespace ProSchool
{
    partial class F_Options_Accompagnement
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
            this.LB_Titre = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.SystemColors.Control;
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.LB_Titre);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(800, 45);
            this.PAN_Header.TabIndex = 10;
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(10, 7);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(320, 20);
            this.LB_Titre.TabIndex = 3;
            this.LB_Titre.Text = "Editer la liste des \"Accompagnements\"";
            // 
            // F_Options_Accompagnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Options_Accompagnement";
            this.Text = "F_Options_Accompagnement";
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Label LB_Titre;
    }
}