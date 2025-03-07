namespace ProSchool
{
    partial class F_Eleves_Absences
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
            this.BT_ResponsablesShow = new System.Windows.Forms.Button();
            this.LB_Eleve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Resume = new System.Windows.Forms.Label();
            this.RichTXT_Absences = new System.Windows.Forms.RichTextBox();
            this.PAN_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_Header
            // 
            this.PAN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.BT_ResponsablesShow);
            this.PAN_Header.Controls.Add(this.LB_Eleve);
            this.PAN_Header.Controls.Add(this.label2);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(800, 39);
            this.PAN_Header.TabIndex = 16;
            this.PAN_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.PAN_Header_Paint);
            // 
            // BT_ResponsablesShow
            // 
            this.BT_ResponsablesShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_ResponsablesShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ResponsablesShow.Location = new System.Drawing.Point(682, 0);
            this.BT_ResponsablesShow.Name = "BT_ResponsablesShow";
            this.BT_ResponsablesShow.Size = new System.Drawing.Size(114, 35);
            this.BT_ResponsablesShow.TabIndex = 21;
            this.BT_ResponsablesShow.Text = "XX Responsables";
            this.BT_ResponsablesShow.UseVisualStyleBackColor = true;
            this.BT_ResponsablesShow.Click += new System.EventHandler(this.BT_ResponsablesShow_Click);
            // 
            // LB_Eleve
            // 
            this.LB_Eleve.AutoSize = true;
            this.LB_Eleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Eleve.Location = new System.Drawing.Point(172, 8);
            this.LB_Eleve.Name = "LB_Eleve";
            this.LB_Eleve.Size = new System.Drawing.Size(78, 18);
            this.LB_Eleve.TabIndex = 6;
            this.LB_Eleve.Text = "LB_Eleve";
            this.LB_Eleve.Click += new System.EventHandler(this.LB_Eleve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Absences et Retards de";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LB_Resume);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // LB_Resume
            // 
            this.LB_Resume.AutoSize = true;
            this.LB_Resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LB_Resume.Location = new System.Drawing.Point(13, 10);
            this.LB_Resume.Name = "LB_Resume";
            this.LB_Resume.Size = new System.Drawing.Size(85, 17);
            this.LB_Resume.TabIndex = 0;
            this.LB_Resume.Text = "LB_Resume";
            this.LB_Resume.Click += new System.EventHandler(this.LB_Resume_Click);
            // 
            // RichTXT_Absences
            // 
            this.RichTXT_Absences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTXT_Absences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTXT_Absences.Location = new System.Drawing.Point(0, 80);
            this.RichTXT_Absences.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.RichTXT_Absences.Name = "RichTXT_Absences";
            this.RichTXT_Absences.ReadOnly = true;
            this.RichTXT_Absences.Size = new System.Drawing.Size(800, 370);
            this.RichTXT_Absences.TabIndex = 19;
            this.RichTXT_Absences.Text = "";
            this.RichTXT_Absences.TextChanged += new System.EventHandler(this.RichTXT_Absences_TextChanged);
            // 
            // F_Eleves_Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTXT_Absences);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Eleves_Absences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absences et retards";
            this.Load += new System.EventHandler(this.F_Eleves_Absences_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Label LB_Eleve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Resume;
        private System.Windows.Forms.RichTextBox RichTXT_Absences;
        private System.Windows.Forms.Button BT_ResponsablesShow;
    }
}