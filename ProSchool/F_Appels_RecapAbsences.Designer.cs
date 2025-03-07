using System;
using System.Windows.Forms;

namespace ProSchool
{
    partial class F_Appels_RecapAbsences
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
            this.PAN_Todo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Absences = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_ShowAbsJ = new System.Windows.Forms.CheckBox();
            this.CB_ShowAbsNJ = new System.Windows.Forms.CheckBox();
            this.CB_ShowRetJ = new System.Windows.Forms.CheckBox();
            this.CB_ShowRetNJ = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COMBO_Classe = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.PAN_Todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Absences)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(23, 15);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(233, 20);
            this.LB_Titre.TabIndex = 3;
            this.LB_Titre.Text = "Récap des absences élèves";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.LB_Titre);
            this.panel1.Controls.Add(this.PAN_Todo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 126);
            this.panel1.TabIndex = 5;
            // 
            // PAN_Todo
            // 
            this.PAN_Todo.AutoSize = true;
            this.PAN_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PAN_Todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Todo.Controls.Add(this.label2);
            this.PAN_Todo.Controls.Add(this.label1);
            this.PAN_Todo.Location = new System.Drawing.Point(27, 80);
            this.PAN_Todo.MinimumSize = new System.Drawing.Size(300, 4);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Size = new System.Drawing.Size(700, 36);
            this.PAN_Todo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Double Clique sur une ligne pour voir le detail des absences de l\'élève et les " +
    "coord. des responsables";
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
            // DGV_Absences
            // 
            this.DGV_Absences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Absences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Absences.Location = new System.Drawing.Point(0, 126);
            this.DGV_Absences.Name = "DGV_Absences";
            this.DGV_Absences.Size = new System.Drawing.Size(1133, 442);
            this.DGV_Absences.TabIndex = 6;
            this.DGV_Absences.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Absences_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.COMBO_Classe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_ShowRetNJ);
            this.groupBox1.Controls.Add(this.CB_ShowRetJ);
            this.groupBox1.Controls.Add(this.CB_ShowAbsNJ);
            this.groupBox1.Controls.Add(this.CB_ShowAbsJ);
            this.groupBox1.Location = new System.Drawing.Point(262, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrer";
            // 
            // CB_ShowAbsJ
            // 
            this.CB_ShowAbsJ.AutoSize = true;
            this.CB_ShowAbsJ.Location = new System.Drawing.Point(349, 19);
            this.CB_ShowAbsJ.Name = "CB_ShowAbsJ";
            this.CB_ShowAbsJ.Size = new System.Drawing.Size(116, 17);
            this.CB_ShowAbsJ.TabIndex = 0;
            this.CB_ShowAbsJ.Text = "Absences justifiées";
            this.CB_ShowAbsJ.UseVisualStyleBackColor = true;
            this.CB_ShowAbsJ.CheckedChanged += new System.EventHandler(this.CB_Filtre_CheckedChanged);
            // 
            // CB_ShowAbsNJ
            // 
            this.CB_ShowAbsNJ.AutoSize = true;
            this.CB_ShowAbsNJ.Checked = true;
            this.CB_ShowAbsNJ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ShowAbsNJ.Location = new System.Drawing.Point(349, 43);
            this.CB_ShowAbsNJ.Name = "CB_ShowAbsNJ";
            this.CB_ShowAbsNJ.Size = new System.Drawing.Size(137, 17);
            this.CB_ShowAbsNJ.TabIndex = 1;
            this.CB_ShowAbsNJ.Text = "Absences non justifiées";
            this.CB_ShowAbsNJ.UseVisualStyleBackColor = true;
            this.CB_ShowAbsNJ.CheckedChanged += new System.EventHandler(this.CB_Filtre_CheckedChanged);
            // 
            // CB_ShowRetJ
            // 
            this.CB_ShowRetJ.AutoSize = true;
            this.CB_ShowRetJ.Location = new System.Drawing.Point(497, 19);
            this.CB_ShowRetJ.Name = "CB_ShowRetJ";
            this.CB_ShowRetJ.Size = new System.Drawing.Size(106, 17);
            this.CB_ShowRetJ.TabIndex = 2;
            this.CB_ShowRetJ.Text = "Retards justifiées";
            this.CB_ShowRetJ.UseVisualStyleBackColor = true;
            this.CB_ShowRetJ.CheckedChanged += new System.EventHandler(this.CB_Filtre_CheckedChanged);
            // 
            // CB_ShowRetNJ
            // 
            this.CB_ShowRetNJ.AutoSize = true;
            this.CB_ShowRetNJ.Location = new System.Drawing.Point(497, 43);
            this.CB_ShowRetNJ.Name = "CB_ShowRetNJ";
            this.CB_ShowRetNJ.Size = new System.Drawing.Size(127, 17);
            this.CB_ShowRetNJ.TabIndex = 3;
            this.CB_ShowRetNJ.Text = "Retards non justifiées";
            this.CB_ShowRetNJ.UseVisualStyleBackColor = true;
            this.CB_ShowRetNJ.CheckedChanged += new System.EventHandler(this.CB_Filtre_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe:";
            // 
            // COMBO_Classe
            // 
            this.COMBO_Classe.FormattingEnabled = true;
            this.COMBO_Classe.Location = new System.Drawing.Point(64, 30);
            this.COMBO_Classe.Name = "COMBO_Classe";
            this.COMBO_Classe.Size = new System.Drawing.Size(255, 21);
            this.COMBO_Classe.TabIndex = 5;
            // 
            // F_Appels_RecapAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 568);
            this.Controls.Add(this.DGV_Absences);
            this.Controls.Add(this.panel1);
            this.Name = "F_Appels_RecapAbsences";
            this.Text = "F_Appels_RecapAbsences";
            this.Load += new System.EventHandler(this.F_Appels_RecapAbsences_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Absences)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Absences;
        private GroupBox groupBox1;
        private CheckBox CB_ShowAbsNJ;
        private CheckBox CB_ShowAbsJ;
        private ComboBox COMBO_Classe;
        private Label label3;
        private CheckBox CB_ShowRetNJ;
        private CheckBox CB_ShowRetJ;
    }
}