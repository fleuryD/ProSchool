namespace ProSchool
{
    partial class F_Options_ImporterEleves
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
            this.BT_ElevesReplace = new System.Windows.Forms.Button();
            this.BT_ElevesUpdate = new System.Windows.Forms.Button();
            this.BT_ElevesAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PAN_BddInsert = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_CountElevesNew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_CountElevesOld = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_ElevesNew = new System.Windows.Forms.DataGridView();
            this.LB_Resume = new System.Windows.Forms.Label();
            this.PAN_BddInsert.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElevesNew)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ElevesReplace
            // 
            this.BT_ElevesReplace.Location = new System.Drawing.Point(853, 35);
            this.BT_ElevesReplace.Name = "BT_ElevesReplace";
            this.BT_ElevesReplace.Size = new System.Drawing.Size(154, 38);
            this.BT_ElevesReplace.TabIndex = 13;
            this.BT_ElevesReplace.Text = "Supprimer et Remplacer";
            this.BT_ElevesReplace.UseVisualStyleBackColor = true;
            this.BT_ElevesReplace.Click += new System.EventHandler(this.BT_ElevesReplace_Click);
            // 
            // BT_ElevesUpdate
            // 
            this.BT_ElevesUpdate.Location = new System.Drawing.Point(83, 35);
            this.BT_ElevesUpdate.Name = "BT_ElevesUpdate";
            this.BT_ElevesUpdate.Size = new System.Drawing.Size(154, 38);
            this.BT_ElevesUpdate.TabIndex = 12;
            this.BT_ElevesUpdate.Text = "Mettre à jour";
            this.BT_ElevesUpdate.UseVisualStyleBackColor = true;
            this.BT_ElevesUpdate.Click += new System.EventHandler(this.BT_ElevesUpdate_Click);
            // 
            // BT_ElevesAdd
            // 
            this.BT_ElevesAdd.Location = new System.Drawing.Point(462, 35);
            this.BT_ElevesAdd.Name = "BT_ElevesAdd";
            this.BT_ElevesAdd.Size = new System.Drawing.Size(154, 38);
            this.BT_ElevesAdd.TabIndex = 11;
            this.BT_ElevesAdd.Text = "Ajouter\r\nDebug";
            this.BT_ElevesAdd.UseVisualStyleBackColor = true;
            this.BT_ElevesAdd.Click += new System.EventHandler(this.BT_ElevesAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ajouter à l\'ancienne liste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(476, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ne pas utiliser !!\r\n(C\'est pour des test)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PAN_BddInsert
            // 
            this.PAN_BddInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_BddInsert.Controls.Add(this.LB_Resume);
            this.PAN_BddInsert.Controls.Add(this.BT_ElevesReplace);
            this.PAN_BddInsert.Controls.Add(this.BT_ElevesUpdate);
            this.PAN_BddInsert.Controls.Add(this.BT_ElevesAdd);
            this.PAN_BddInsert.Controls.Add(this.label2);
            this.PAN_BddInsert.Controls.Add(this.label5);
            this.PAN_BddInsert.Controls.Add(this.label4);
            this.PAN_BddInsert.Controls.Add(this.label3);
            this.PAN_BddInsert.Controls.Add(this.label6);
            this.PAN_BddInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PAN_BddInsert.Location = new System.Drawing.Point(0, 664);
            this.PAN_BddInsert.Name = "PAN_BddInsert";
            this.PAN_BddInsert.Size = new System.Drawing.Size(1111, 162);
            this.PAN_BddInsert.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mettre à jour l\'ancienne liste d\'élèves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(823, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ecraser l\'ancienne liste d\'élèves";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "A faire en debut d\'année";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Importer / Mettre à jour les élèves";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LB_CountElevesNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LB_CountElevesOld);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 62);
            this.panel1.TabIndex = 18;
            // 
            // LB_CountElevesNew
            // 
            this.LB_CountElevesNew.AutoSize = true;
            this.LB_CountElevesNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CountElevesNew.Location = new System.Drawing.Point(446, 27);
            this.LB_CountElevesNew.Name = "LB_CountElevesNew";
            this.LB_CountElevesNew.Size = new System.Drawing.Size(148, 18);
            this.LB_CountElevesNew.TabIndex = 0;
            this.LB_CountElevesNew.Text = "LB_CountElevesNew";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvelle liste";
            // 
            // LB_CountElevesOld
            // 
            this.LB_CountElevesOld.AutoSize = true;
            this.LB_CountElevesOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CountElevesOld.Location = new System.Drawing.Point(446, 7);
            this.LB_CountElevesOld.Name = "LB_CountElevesOld";
            this.LB_CountElevesOld.Size = new System.Drawing.Size(141, 18);
            this.LB_CountElevesOld.TabIndex = 0;
            this.LB_CountElevesOld.Text = "LB_CountElevesOld";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ancienne liste";
            // 
            // DGV_ElevesNew
            // 
            this.DGV_ElevesNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ElevesNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_ElevesNew.Location = new System.Drawing.Point(0, 62);
            this.DGV_ElevesNew.Name = "DGV_ElevesNew";
            this.DGV_ElevesNew.Size = new System.Drawing.Size(1111, 602);
            this.DGV_ElevesNew.TabIndex = 11;
            // 
            // LB_Resume
            // 
            this.LB_Resume.AutoSize = true;
            this.LB_Resume.Location = new System.Drawing.Point(91, 81);
            this.LB_Resume.Name = "LB_Resume";
            this.LB_Resume.Size = new System.Drawing.Size(134, 52);
            this.LB_Resume.TabIndex = 14;
            this.LB_Resume.Text = "X classe à ajouter\r\nX classe à supprimer\r\nX classe à modifier\r\nX classe sans chan" +
    "gement";
            // 
            // F_Options_ImporterEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 826);
            this.Controls.Add(this.DGV_ElevesNew);
            this.Controls.Add(this.PAN_BddInsert);
            this.Controls.Add(this.panel1);
            this.Name = "F_Options_ImporterEleves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Options_ImporterEleves";
            this.Load += new System.EventHandler(this.F_Options_ImporterEleves_Load);
            this.PAN_BddInsert.ResumeLayout(false);
            this.PAN_BddInsert.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElevesNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ElevesReplace;
        private System.Windows.Forms.Button BT_ElevesUpdate;
        private System.Windows.Forms.Button BT_ElevesAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PAN_BddInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_CountElevesNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_CountElevesOld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_ElevesNew;
        private System.Windows.Forms.Label LB_Resume;
    }
}