﻿namespace ProSchool
{
    partial class F_Suivis_1Eleve
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
            this.PAN_SuivisSuper = new System.Windows.Forms.Panel();
            this.BT_SuiviAdd = new System.Windows.Forms.Button();
            this.LB_Titre = new System.Windows.Forms.Label();
            this.PAN_Suivis = new System.Windows.Forms.Panel();
            this.FLP_Suivis = new System.Windows.Forms.FlowLayoutPanel();
            this.LB_SuivisTemp = new System.Windows.Forms.Label();
            this.PAN_SuivisSuper.SuspendLayout();
            this.PAN_Suivis.SuspendLayout();
            this.FLP_Suivis.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_SuivisSuper
            // 
            this.PAN_SuivisSuper.AutoSize = true;
            this.PAN_SuivisSuper.BackColor = System.Drawing.Color.White;
            this.PAN_SuivisSuper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_SuivisSuper.Controls.Add(this.LB_Titre);
            this.PAN_SuivisSuper.Controls.Add(this.BT_SuiviAdd);
            this.PAN_SuivisSuper.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_SuivisSuper.Location = new System.Drawing.Point(0, 0);
            this.PAN_SuivisSuper.Name = "PAN_SuivisSuper";
            this.PAN_SuivisSuper.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_SuivisSuper.Size = new System.Drawing.Size(995, 57);
            this.PAN_SuivisSuper.TabIndex = 26;
            // 
            // BT_SuiviAdd
            // 
            this.BT_SuiviAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_SuiviAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SuiviAdd.Location = new System.Drawing.Point(880, 10);
            this.BT_SuiviAdd.Name = "BT_SuiviAdd";
            this.BT_SuiviAdd.Size = new System.Drawing.Size(101, 33);
            this.BT_SuiviAdd.TabIndex = 5;
            this.BT_SuiviAdd.Text = "Ajouter un suivi";
            this.BT_SuiviAdd.UseVisualStyleBackColor = true;
            this.BT_SuiviAdd.Click += new System.EventHandler(this.BT_SuiviAdd_Click);
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LB_Titre.Location = new System.Drawing.Point(13, 16);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_Titre.Size = new System.Drawing.Size(51, 27);
            this.LB_Titre.TabIndex = 1;
            this.LB_Titre.Text = "Suivis";
            // 
            // PAN_Suivis
            // 
            this.PAN_Suivis.AutoScroll = true;
            this.PAN_Suivis.AutoSize = true;
            this.PAN_Suivis.BackColor = System.Drawing.Color.White;
            this.PAN_Suivis.Controls.Add(this.FLP_Suivis);
            this.PAN_Suivis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_Suivis.Location = new System.Drawing.Point(0, 57);
            this.PAN_Suivis.Name = "PAN_Suivis";
            this.PAN_Suivis.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Suivis.Size = new System.Drawing.Size(995, 601);
            this.PAN_Suivis.TabIndex = 9;
            // 
            // FLP_Suivis
            // 
            this.FLP_Suivis.AutoSize = true;
            this.FLP_Suivis.Controls.Add(this.LB_SuivisTemp);
            this.FLP_Suivis.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLP_Suivis.Location = new System.Drawing.Point(10, 10);
            this.FLP_Suivis.Name = "FLP_Suivis";
            this.FLP_Suivis.Size = new System.Drawing.Size(975, 13);
            this.FLP_Suivis.TabIndex = 13;
            // 
            // LB_SuivisTemp
            // 
            this.LB_SuivisTemp.AutoSize = true;
            this.LB_SuivisTemp.Location = new System.Drawing.Point(3, 0);
            this.LB_SuivisTemp.Name = "LB_SuivisTemp";
            this.LB_SuivisTemp.Size = new System.Drawing.Size(81, 13);
            this.LB_SuivisTemp.TabIndex = 0;
            this.LB_SuivisTemp.Text = "LB_SuivisTemp";
            // 
            // F_Suivis_1Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 658);
            this.Controls.Add(this.PAN_Suivis);
            this.Controls.Add(this.PAN_SuivisSuper);
            this.Name = "F_Suivis_1Eleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Suivis_1Eleve";
            this.Load += new System.EventHandler(this.F_Suivis_1Eleve_Load);
            this.PAN_SuivisSuper.ResumeLayout(false);
            this.PAN_SuivisSuper.PerformLayout();
            this.PAN_Suivis.ResumeLayout(false);
            this.PAN_Suivis.PerformLayout();
            this.FLP_Suivis.ResumeLayout(false);
            this.FLP_Suivis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PAN_SuivisSuper;
        private System.Windows.Forms.Panel PAN_Suivis;
        private System.Windows.Forms.FlowLayoutPanel FLP_Suivis;
        private System.Windows.Forms.Label LB_SuivisTemp;
        private System.Windows.Forms.Button BT_SuiviAdd;
        private System.Windows.Forms.Label LB_Titre;
    }
}