using System;

namespace ProSchool
{
    partial class F_Calendar
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
            this.FLP_Calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.BT_PreviousMonth = new System.Windows.Forms.Button();
            this.BT_NextMonth = new System.Windows.Forms.Button();
            this.COMBO_Mois = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PAN_CalendarHeader = new System.Windows.Forms.Panel();
            this.PAN_SelectedDay = new System.Windows.Forms.Panel();
            this.PAN_Evenements = new System.Windows.Forms.Panel();
            this.PAN_HeaderSelectedDay = new System.Windows.Forms.Panel();
            this.BT_AddEvenement = new System.Windows.Forms.Button();
            this.LB_DateHuman = new System.Windows.Forms.Label();
            this.LB_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PAN_CalendarHeader.SuspendLayout();
            this.PAN_SelectedDay.SuspendLayout();
            this.PAN_HeaderSelectedDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP_Calendar
            // 
            this.FLP_Calendar.AutoScroll = true;
            this.FLP_Calendar.BackColor = System.Drawing.Color.White;
            this.FLP_Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Calendar.Location = new System.Drawing.Point(0, 56);
            this.FLP_Calendar.Name = "FLP_Calendar";
            this.FLP_Calendar.Padding = new System.Windows.Forms.Padding(10);
            this.FLP_Calendar.Size = new System.Drawing.Size(779, 685);
            this.FLP_Calendar.TabIndex = 1;
            this.FLP_Calendar.Resize += new System.EventHandler(this.FLP_Calendar_Resize);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 11);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(384, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "- Cliquez sur une case pour voir/ajouter les événement du jour";
            // 
            // BT_PreviousMonth
            // 
            this.BT_PreviousMonth.Location = new System.Drawing.Point(16, 14);
            this.BT_PreviousMonth.Name = "BT_PreviousMonth";
            this.BT_PreviousMonth.Size = new System.Drawing.Size(27, 25);
            this.BT_PreviousMonth.TabIndex = 17;
            this.BT_PreviousMonth.Text = "<<";
            this.BT_PreviousMonth.UseVisualStyleBackColor = true;
            this.BT_PreviousMonth.Click += new System.EventHandler(this.BT_PreviousMonth_Click);
            // 
            // BT_NextMonth
            // 
            this.BT_NextMonth.Location = new System.Drawing.Point(308, 14);
            this.BT_NextMonth.Name = "BT_NextMonth";
            this.BT_NextMonth.Size = new System.Drawing.Size(27, 25);
            this.BT_NextMonth.TabIndex = 16;
            this.BT_NextMonth.Text = ">>";
            this.BT_NextMonth.UseVisualStyleBackColor = true;
            this.BT_NextMonth.Click += new System.EventHandler(this.BT_NextMonth_Click);
            // 
            // COMBO_Mois
            // 
            this.COMBO_Mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.COMBO_Mois.FormattingEnabled = true;
            this.COMBO_Mois.Location = new System.Drawing.Point(49, 14);
            this.COMBO_Mois.Name = "COMBO_Mois";
            this.COMBO_Mois.Size = new System.Drawing.Size(253, 25);
            this.COMBO_Mois.TabIndex = 15;
            this.COMBO_Mois.SelectedIndexChanged += new System.EventHandler(this.COMBO_Mois_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FLP_Calendar);
            this.splitContainer1.Panel1.Controls.Add(this.PAN_CalendarHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PAN_SelectedDay);
            this.splitContainer1.Size = new System.Drawing.Size(1217, 745);
            this.splitContainer1.SplitterDistance = 783;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // PAN_CalendarHeader
            // 
            this.PAN_CalendarHeader.BackColor = System.Drawing.Color.White;
            this.PAN_CalendarHeader.Controls.Add(this.label9);
            this.PAN_CalendarHeader.Controls.Add(this.BT_PreviousMonth);
            this.PAN_CalendarHeader.Controls.Add(this.COMBO_Mois);
            this.PAN_CalendarHeader.Controls.Add(this.BT_NextMonth);
            this.PAN_CalendarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_CalendarHeader.Location = new System.Drawing.Point(0, 0);
            this.PAN_CalendarHeader.Name = "PAN_CalendarHeader";
            this.PAN_CalendarHeader.Size = new System.Drawing.Size(779, 56);
            this.PAN_CalendarHeader.TabIndex = 2;
            // 
            // PAN_SelectedDay
            // 
            this.PAN_SelectedDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PAN_SelectedDay.Controls.Add(this.PAN_Evenements);
            this.PAN_SelectedDay.Controls.Add(this.PAN_HeaderSelectedDay);
            this.PAN_SelectedDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_SelectedDay.Location = new System.Drawing.Point(0, 0);
            this.PAN_SelectedDay.Margin = new System.Windows.Forms.Padding(5);
            this.PAN_SelectedDay.Name = "PAN_SelectedDay";
            this.PAN_SelectedDay.Size = new System.Drawing.Size(422, 741);
            this.PAN_SelectedDay.TabIndex = 0;
            // 
            // PAN_Evenements
            // 
            this.PAN_Evenements.AutoScroll = true;
            this.PAN_Evenements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PAN_Evenements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Evenements.Location = new System.Drawing.Point(0, 77);
            this.PAN_Evenements.Name = "PAN_Evenements";
            this.PAN_Evenements.Size = new System.Drawing.Size(422, 664);
            this.PAN_Evenements.TabIndex = 2;
            // 
            // PAN_HeaderSelectedDay
            // 
            this.PAN_HeaderSelectedDay.Controls.Add(this.BT_AddEvenement);
            this.PAN_HeaderSelectedDay.Controls.Add(this.LB_DateHuman);
            this.PAN_HeaderSelectedDay.Controls.Add(this.LB_Date);
            this.PAN_HeaderSelectedDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_HeaderSelectedDay.Location = new System.Drawing.Point(0, 0);
            this.PAN_HeaderSelectedDay.Name = "PAN_HeaderSelectedDay";
            this.PAN_HeaderSelectedDay.Size = new System.Drawing.Size(422, 77);
            this.PAN_HeaderSelectedDay.TabIndex = 0;
            // 
            // BT_AddEvenement
            // 
            this.BT_AddEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddEvenement.Location = new System.Drawing.Point(343, 4);
            this.BT_AddEvenement.Name = "BT_AddEvenement";
            this.BT_AddEvenement.Size = new System.Drawing.Size(47, 38);
            this.BT_AddEvenement.TabIndex = 1;
            this.BT_AddEvenement.Text = "+";
            this.BT_AddEvenement.UseVisualStyleBackColor = true;
            this.BT_AddEvenement.Click += new System.EventHandler(this.BT_AddEvenement_Click);
            // 
            // LB_DateHuman
            // 
            this.LB_DateHuman.AutoSize = true;
            this.LB_DateHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateHuman.Location = new System.Drawing.Point(3, 36);
            this.LB_DateHuman.Name = "LB_DateHuman";
            this.LB_DateHuman.Size = new System.Drawing.Size(113, 18);
            this.LB_DateHuman.TabIndex = 0;
            this.LB_DateHuman.Text = "LB_DateHuman";
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Date.Location = new System.Drawing.Point(3, 7);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(72, 18);
            this.LB_Date.TabIndex = 0;
            this.LB_Date.Text = "LB_Date";
            // 
            // F_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 745);
            this.Controls.Add(this.splitContainer1);
            this.Name = "F_Calendar";
            this.Text = "F_Calendar";
            this.Load += new System.EventHandler(this.F_Calendar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PAN_CalendarHeader.ResumeLayout(false);
            this.PAN_CalendarHeader.PerformLayout();
            this.PAN_SelectedDay.ResumeLayout(false);
            this.PAN_HeaderSelectedDay.ResumeLayout(false);
            this.PAN_HeaderSelectedDay.PerformLayout();
            this.ResumeLayout(false);

        }

     

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLP_Calendar;
        private System.Windows.Forms.ComboBox COMBO_Mois;
        private System.Windows.Forms.Button BT_NextMonth;
        private System.Windows.Forms.Button BT_PreviousMonth;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PAN_CalendarHeader;
        private System.Windows.Forms.Panel PAN_SelectedDay;
        private System.Windows.Forms.Panel PAN_HeaderSelectedDay;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Button BT_AddEvenement;
        private System.Windows.Forms.Label LB_DateHuman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PAN_Evenements;
    }
}