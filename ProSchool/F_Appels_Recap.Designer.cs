namespace ProSchool
{
    partial class F_Appels_Recap
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
            this.LB_Titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_ErrSelctedDate = new System.Windows.Forms.Label();
            this.BT_PreviousDay = new System.Windows.Forms.Button();
            this.BT_NextDay = new System.Windows.Forms.Button();
            this.BT_Today = new System.Windows.Forms.Button();
            this.PAN_Todo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.FLP_Classes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.PAN_Todo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(10, 7);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(327, 20);
            this.LB_Titre.TabIndex = 3;
            this.LB_Titre.Text = "Récap des appels par jour et par classe";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LB_ErrSelctedDate);
            this.panel1.Controls.Add(this.BT_PreviousDay);
            this.panel1.Controls.Add(this.BT_NextDay);
            this.panel1.Controls.Add(this.BT_Today);
            this.panel1.Controls.Add(this.PAN_Todo);
            this.panel1.Controls.Add(this.DTPicker);
            this.panel1.Controls.Add(this.LB_Titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 91);
            this.panel1.TabIndex = 4;
            // 
            // LB_ErrSelctedDate
            // 
            this.LB_ErrSelctedDate.AutoSize = true;
            this.LB_ErrSelctedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ErrSelctedDate.ForeColor = System.Drawing.Color.Red;
            this.LB_ErrSelctedDate.Location = new System.Drawing.Point(387, 57);
            this.LB_ErrSelctedDate.Name = "LB_ErrSelctedDate";
            this.LB_ErrSelctedDate.Size = new System.Drawing.Size(151, 18);
            this.LB_ErrSelctedDate.TabIndex = 9;
            this.LB_ErrSelctedDate.Text = "LB_ErrSelctedDate";
            // 
            // BT_PreviousDay
            // 
            this.BT_PreviousDay.Location = new System.Drawing.Point(125, 49);
            this.BT_PreviousDay.Name = "BT_PreviousDay";
            this.BT_PreviousDay.Size = new System.Drawing.Size(31, 23);
            this.BT_PreviousDay.TabIndex = 8;
            this.BT_PreviousDay.Text = "<";
            this.BT_PreviousDay.UseVisualStyleBackColor = true;
            this.BT_PreviousDay.Click += new System.EventHandler(this.BT_PreviousDay_Click);
            // 
            // BT_NextDay
            // 
            this.BT_NextDay.Location = new System.Drawing.Point(338, 49);
            this.BT_NextDay.Name = "BT_NextDay";
            this.BT_NextDay.Size = new System.Drawing.Size(31, 23);
            this.BT_NextDay.TabIndex = 7;
            this.BT_NextDay.Text = ">";
            this.BT_NextDay.UseVisualStyleBackColor = true;
            this.BT_NextDay.Click += new System.EventHandler(this.BT_NextDay_Click);
            // 
            // BT_Today
            // 
            this.BT_Today.Location = new System.Drawing.Point(27, 49);
            this.BT_Today.Name = "BT_Today";
            this.BT_Today.Size = new System.Drawing.Size(75, 23);
            this.BT_Today.TabIndex = 6;
            this.BT_Today.Text = "Aujourd\'hui";
            this.BT_Today.UseVisualStyleBackColor = true;
            this.BT_Today.Click += new System.EventHandler(this.BT_Today_Click);
            // 
            // PAN_Todo
            // 
            this.PAN_Todo.AutoSize = true;
            this.PAN_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PAN_Todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Todo.Controls.Add(this.label2);
            this.PAN_Todo.Controls.Add(this.label1);
            this.PAN_Todo.Location = new System.Drawing.Point(497, 10);
            this.PAN_Todo.MinimumSize = new System.Drawing.Size(300, 4);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Size = new System.Drawing.Size(632, 36);
            this.PAN_Todo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Cliquer sur un élève pour voir toutes ses absences et les coord. des responsabl" +
    "es";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Astuce:";
            // 
            // DTPicker
            // 
            this.DTPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker.Location = new System.Drawing.Point(162, 50);
            this.DTPicker.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.DTPicker.MinDate = new System.DateTime(2024, 9, 2, 0, 0, 0, 0);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(170, 20);
            this.DTPicker.TabIndex = 4;
            this.DTPicker.Value = new System.DateTime(2024, 9, 2, 0, 0, 0, 0);
            this.DTPicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // FLP_Classes
            // 
            this.FLP_Classes.AutoScroll = true;
            this.FLP_Classes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP_Classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Classes.Location = new System.Drawing.Point(0, 91);
            this.FLP_Classes.Name = "FLP_Classes";
            this.FLP_Classes.Size = new System.Drawing.Size(1143, 464);
            this.FLP_Classes.TabIndex = 5;
            // 
            // F_Appels_Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 555);
            this.Controls.Add(this.FLP_Classes);
            this.Controls.Add(this.panel1);
            this.Name = "F_Appels_Recap";
            this.Text = "F_Appels_Recap";
            this.Load += new System.EventHandler(this.F_Appels_Recap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.FlowLayoutPanel FLP_Classes;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Today;
        private System.Windows.Forms.Button BT_PreviousDay;
        private System.Windows.Forms.Button BT_NextDay;
        private System.Windows.Forms.Label LB_ErrSelctedDate;
    }
}