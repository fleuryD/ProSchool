using System;
using System.Windows.Forms;

namespace ProSchool
{
    partial class F_Appels_Faire_v2
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PAN_Help_Appel1 = new System.Windows.Forms.Panel();
            this.COMBO_Semaines = new System.Windows.Forms.ComboBox();
            this.LB_DateToday = new System.Windows.Forms.Label();
            this.PAN_Help_Appel2 = new System.Windows.Forms.Panel();
            this.BT_NextWeek = new System.Windows.Forms.Button();
            this.LB_Label_Semaine = new System.Windows.Forms.Label();
            this.PAN_Help_Justifier = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_PreviousWeek = new System.Windows.Forms.Button();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.LB_Label_Classe = new System.Windows.Forms.Label();
            this.COMBO_Classes = new System.Windows.Forms.ComboBox();
            this.BT_AppelTermine = new System.Windows.Forms.Button();
            this.BT_AnnulerAppel = new System.Windows.Forms.Button();
            this.DGV_Appel = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PAN_Help_Appel1.SuspendLayout();
            this.PAN_Help_Appel2.SuspendLayout();
            this.PAN_Help_Justifier.SuspendLayout();
            this.PAN_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appel)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(3, 25);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label13.Size = new System.Drawing.Size(369, 27);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ajouter/Modifier/Justifier une absence d\'un élève:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label12.Location = new System.Drawing.Point(7, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "- Double-cliquez sur une case";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "- Quand vous avez fini, cliquez sur \"Appel terminé\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "- Double-cliquez sur une case jaune pour modifier \"Absent/Retard/Present\" et just" +
    "ifier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(1, 3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label10.Size = new System.Drawing.Size(103, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Faire l\'appel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label9.Location = new System.Drawing.Point(104, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(441, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "- Double-cliquez sur la date du jour (Matin ou Aprem) pour déverrouiller l\'appel." +
    " \r\n   (Les cases de la demi-journée deviennent jaunes.)\r\n";
            // 
            // PAN_Help_Appel1
            // 
            this.PAN_Help_Appel1.AutoSize = true;
            this.PAN_Help_Appel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Appel1.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Appel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Appel1.Controls.Add(this.label10);
            this.PAN_Help_Appel1.Controls.Add(this.label9);
            this.PAN_Help_Appel1.Location = new System.Drawing.Point(3, 3);
            this.PAN_Help_Appel1.Name = "PAN_Help_Appel1";
            this.PAN_Help_Appel1.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Appel1.Size = new System.Drawing.Size(562, 49);
            this.PAN_Help_Appel1.TabIndex = 10;
            // 
            // COMBO_Semaines
            // 
            this.COMBO_Semaines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Semaines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.COMBO_Semaines.FormattingEnabled = true;
            this.COMBO_Semaines.Location = new System.Drawing.Point(448, 10);
            this.COMBO_Semaines.Name = "COMBO_Semaines";
            this.COMBO_Semaines.Size = new System.Drawing.Size(231, 28);
            this.COMBO_Semaines.TabIndex = 5;
            this.COMBO_Semaines.SelectedIndexChanged += new System.EventHandler(this.COMBO_Semaines_SelectedIndexChanged);
            // 
            // LB_DateToday
            // 
            this.LB_DateToday.AutoSize = true;
            this.LB_DateToday.Dock = System.Windows.Forms.DockStyle.Right;
            this.LB_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateToday.Location = new System.Drawing.Point(1025, 0);
            this.LB_DateToday.Name = "LB_DateToday";
            this.LB_DateToday.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LB_DateToday.Size = new System.Drawing.Size(128, 35);
            this.LB_DateToday.TabIndex = 4;
            this.LB_DateToday.Text = "LB_DateToday";
            // 
            // PAN_Help_Appel2
            // 
            this.PAN_Help_Appel2.AutoSize = true;
            this.PAN_Help_Appel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Appel2.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Appel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Appel2.Controls.Add(this.label6);
            this.PAN_Help_Appel2.Controls.Add(this.label5);
            this.PAN_Help_Appel2.Location = new System.Drawing.Point(571, 3);
            this.PAN_Help_Appel2.Name = "PAN_Help_Appel2";
            this.PAN_Help_Appel2.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Appel2.Size = new System.Drawing.Size(491, 51);
            this.PAN_Help_Appel2.TabIndex = 10;
            // 
            // BT_NextWeek
            // 
            this.BT_NextWeek.Location = new System.Drawing.Point(685, 10);
            this.BT_NextWeek.Name = "BT_NextWeek";
            this.BT_NextWeek.Size = new System.Drawing.Size(28, 28);
            this.BT_NextWeek.TabIndex = 18;
            this.BT_NextWeek.Text = ">>";
            this.BT_NextWeek.UseVisualStyleBackColor = true;
            this.BT_NextWeek.Click += new System.EventHandler(this.BT_NextWeek_Click);
            // 
            // LB_Label_Semaine
            // 
            this.LB_Label_Semaine.AutoSize = true;
            this.LB_Label_Semaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Label_Semaine.Location = new System.Drawing.Point(336, 18);
            this.LB_Label_Semaine.Name = "LB_Label_Semaine";
            this.LB_Label_Semaine.Size = new System.Drawing.Size(73, 13);
            this.LB_Label_Semaine.TabIndex = 6;
            this.LB_Label_Semaine.Text = "Semaine du";
            // 
            // PAN_Help_Justifier
            // 
            this.PAN_Help_Justifier.AutoSize = true;
            this.PAN_Help_Justifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Justifier.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Justifier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Justifier.Controls.Add(this.label2);
            this.PAN_Help_Justifier.Controls.Add(this.label13);
            this.PAN_Help_Justifier.Controls.Add(this.label12);
            this.PAN_Help_Justifier.Enabled = false;
            this.PAN_Help_Justifier.Location = new System.Drawing.Point(3, 60);
            this.PAN_Help_Justifier.Name = "PAN_Help_Justifier";
            this.PAN_Help_Justifier.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Justifier.Size = new System.Drawing.Size(389, 80);
            this.PAN_Help_Justifier.TabIndex = 14;
            this.PAN_Help_Justifier.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOUVEAU :";
            // 
            // BT_PreviousWeek
            // 
            this.BT_PreviousWeek.Location = new System.Drawing.Point(415, 10);
            this.BT_PreviousWeek.Name = "BT_PreviousWeek";
            this.BT_PreviousWeek.Size = new System.Drawing.Size(28, 28);
            this.BT_PreviousWeek.TabIndex = 19;
            this.BT_PreviousWeek.Text = "<<";
            this.BT_PreviousWeek.UseVisualStyleBackColor = true;
            this.BT_PreviousWeek.Click += new System.EventHandler(this.BT_PreviousWeek_Click);
            // 
            // PAN_Header
            // 
            this.PAN_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.LB_Label_Classe);
            this.PAN_Header.Controls.Add(this.COMBO_Classes);
            this.PAN_Header.Controls.Add(this.BT_PreviousWeek);
            this.PAN_Header.Controls.Add(this.BT_NextWeek);
            this.PAN_Header.Controls.Add(this.LB_Label_Semaine);
            this.PAN_Header.Controls.Add(this.COMBO_Semaines);
            this.PAN_Header.Controls.Add(this.LB_DateToday);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1157, 50);
            this.PAN_Header.TabIndex = 13;
            // 
            // LB_Label_Classe
            // 
            this.LB_Label_Classe.AutoSize = true;
            this.LB_Label_Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Label_Classe.Location = new System.Drawing.Point(10, 18);
            this.LB_Label_Classe.Name = "LB_Label_Classe";
            this.LB_Label_Classe.Size = new System.Drawing.Size(44, 13);
            this.LB_Label_Classe.TabIndex = 21;
            this.LB_Label_Classe.Text = "Classe";
            // 
            // COMBO_Classes
            // 
            this.COMBO_Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Classes.FormattingEnabled = true;
            this.COMBO_Classes.Location = new System.Drawing.Point(61, 10);
            this.COMBO_Classes.Name = "COMBO_Classes";
            this.COMBO_Classes.Size = new System.Drawing.Size(211, 28);
            this.COMBO_Classes.TabIndex = 20;
            this.COMBO_Classes.SelectedIndexChanged += new System.EventHandler(this.COMBO_Classes_SelectedIndexChanged);
            // 
            // BT_AppelTermine
            // 
            this.BT_AppelTermine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AppelTermine.ForeColor = System.Drawing.Color.Blue;
            this.BT_AppelTermine.Location = new System.Drawing.Point(176, 8);
            this.BT_AppelTermine.Name = "BT_AppelTermine";
            this.BT_AppelTermine.Size = new System.Drawing.Size(162, 31);
            this.BT_AppelTermine.TabIndex = 10;
            this.BT_AppelTermine.Text = "Appel Terminé";
            this.BT_AppelTermine.UseVisualStyleBackColor = true;
            this.BT_AppelTermine.Click += new System.EventHandler(this.BT_AppelTermine_Click);
            // 
            // BT_AnnulerAppel
            // 
            this.BT_AnnulerAppel.ForeColor = System.Drawing.Color.Red;
            this.BT_AnnulerAppel.Location = new System.Drawing.Point(8, 8);
            this.BT_AnnulerAppel.Name = "BT_AnnulerAppel";
            this.BT_AnnulerAppel.Size = new System.Drawing.Size(162, 23);
            this.BT_AnnulerAppel.TabIndex = 11;
            this.BT_AnnulerAppel.Text = "Annuler l\'appel";
            this.BT_AnnulerAppel.UseVisualStyleBackColor = true;
            this.BT_AnnulerAppel.Click += new System.EventHandler(this.BT_AnnulerAppel_Click);
            // 
            // DGV_Appel
            // 
            this.DGV_Appel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Appel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Appel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Appel.Location = new System.Drawing.Point(0, 50);
            this.DGV_Appel.Name = "DGV_Appel";
            this.DGV_Appel.Size = new System.Drawing.Size(1157, 523);
            this.DGV_Appel.TabIndex = 12;
            this.DGV_Appel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Appel_CellDoubleClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.BT_AnnulerAppel);
            this.flowLayoutPanel2.Controls.Add(this.BT_AppelTermine);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 573);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1157, 49);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Appel1);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Appel2);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Justifier);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 622);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1157, 143);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // F_Appels_Faire_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 765);
            this.Controls.Add(this.DGV_Appel);
            this.Controls.Add(this.PAN_Header);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "F_Appels_Faire_v2";
            this.Text = "F_Appels_Faire_v2";
            this.Load += new System.EventHandler(this.F_Appels_Faire_v2_Load);
            this.PAN_Help_Appel1.ResumeLayout(false);
            this.PAN_Help_Appel1.PerformLayout();
            this.PAN_Help_Appel2.ResumeLayout(false);
            this.PAN_Help_Appel2.PerformLayout();
            this.PAN_Help_Justifier.ResumeLayout(false);
            this.PAN_Help_Justifier.PerformLayout();
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appel)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PAN_Help_Appel1;
        private System.Windows.Forms.ComboBox COMBO_Semaines;
        private System.Windows.Forms.Label LB_DateToday;
        private System.Windows.Forms.Panel PAN_Help_Appel2;
        private System.Windows.Forms.Button BT_NextWeek;
        private System.Windows.Forms.Label LB_Label_Semaine;
        private System.Windows.Forms.Panel PAN_Help_Justifier;
        private System.Windows.Forms.Button BT_PreviousWeek;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Button BT_AppelTermine;
        private System.Windows.Forms.Button BT_AnnulerAppel;
        private System.Windows.Forms.DataGridView DGV_Appel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LB_Label_Classe;
        private System.Windows.Forms.ComboBox COMBO_Classes;
        private Label label2;
    }
}