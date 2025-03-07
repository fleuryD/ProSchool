namespace ProSchool
{
    partial class F_Calendar_Evenements
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
            this.FLP_Evenements = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Titre = new System.Windows.Forms.Label();
            this.BT_AddEvenement = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP_Evenements
            // 
            this.FLP_Evenements.AutoScroll = true;
            this.FLP_Evenements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLP_Evenements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Evenements.Location = new System.Drawing.Point(0, 59);
            this.FLP_Evenements.Name = "FLP_Evenements";
            this.FLP_Evenements.Size = new System.Drawing.Size(1021, 679);
            this.FLP_Evenements.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BT_AddEvenement);
            this.panel1.Controls.Add(this.LB_Titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 59);
            this.panel1.TabIndex = 2;
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(10, 16);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(286, 24);
            this.LB_Titre.TabIndex = 0;
            this.LB_Titre.Text = "Agenda : Evenements à venir";
            // 
            // BT_AddEvenement
            // 
            this.BT_AddEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddEvenement.Location = new System.Drawing.Point(794, 10);
            this.BT_AddEvenement.Name = "BT_AddEvenement";
            this.BT_AddEvenement.Size = new System.Drawing.Size(108, 38);
            this.BT_AddEvenement.TabIndex = 2;
            this.BT_AddEvenement.Text = "+ Ajouter";
            this.BT_AddEvenement.UseVisualStyleBackColor = true;
            this.BT_AddEvenement.Click += new System.EventHandler(this.BT_AddEvenement_Click);
            // 
            // F_Calendar_Evenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 738);
            this.Controls.Add(this.FLP_Evenements);
            this.Controls.Add(this.panel1);
            this.Name = "F_Calendar_Evenements";
            this.Text = "F_Calendar_Evenements";
            this.Load += new System.EventHandler(this.F_Calendar_Evenements_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FLP_Evenements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Button BT_AddEvenement;
    }
}