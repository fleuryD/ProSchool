namespace ProSchool
{
    partial class F_Accompagnements_Recap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_EleveAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_EditListeAccompagnements = new System.Windows.Forms.Button();
            this.CB_HideEmptyCol = new System.Windows.Forms.CheckBox();
            this.DGV_Accompagnements = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accompagnements)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BT_EleveAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BT_EditListeAccompagnements);
            this.panel1.Controls.Add(this.CB_HideEmptyCol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(1255, 54);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ou";
            // 
            // BT_EleveAdd
            // 
            this.BT_EleveAdd.Location = new System.Drawing.Point(628, 11);
            this.BT_EleveAdd.Name = "BT_EleveAdd";
            this.BT_EleveAdd.Size = new System.Drawing.Size(147, 23);
            this.BT_EleveAdd.TabIndex = 19;
            this.BT_EleveAdd.Text = "Ajouter un élève";
            this.BT_EleveAdd.UseVisualStyleBackColor = true;
            this.BT_EleveAdd.Click += new System.EventHandler(this.BT_EleveAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(399, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double clique sur un élève pour modifier ses accompagnements";
            // 
            // BT_EditListeAccompagnements
            // 
            this.BT_EditListeAccompagnements.Location = new System.Drawing.Point(874, 11);
            this.BT_EditListeAccompagnements.Name = "BT_EditListeAccompagnements";
            this.BT_EditListeAccompagnements.Size = new System.Drawing.Size(201, 23);
            this.BT_EditListeAccompagnements.TabIndex = 18;
            this.BT_EditListeAccompagnements.Text = "Editer la liste des accompagnements";
            this.BT_EditListeAccompagnements.UseVisualStyleBackColor = true;
            this.BT_EditListeAccompagnements.Click += new System.EventHandler(this.BT_EditListeAccompagnements_Click);
            // 
            // CB_HideEmptyCol
            // 
            this.CB_HideEmptyCol.AutoSize = true;
            this.CB_HideEmptyCol.Checked = true;
            this.CB_HideEmptyCol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_HideEmptyCol.Location = new System.Drawing.Point(18, 14);
            this.CB_HideEmptyCol.Name = "CB_HideEmptyCol";
            this.CB_HideEmptyCol.Size = new System.Drawing.Size(157, 17);
            this.CB_HideEmptyCol.TabIndex = 17;
            this.CB_HideEmptyCol.Text = "Masquer les colonnes vides";
            this.CB_HideEmptyCol.UseVisualStyleBackColor = true;
            this.CB_HideEmptyCol.CheckedChanged += new System.EventHandler(this.CB_HideEmptyCol_CheckedChanged);
            // 
            // DGV_Accompagnements
            // 
            this.DGV_Accompagnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Accompagnements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Accompagnements.Location = new System.Drawing.Point(0, 54);
            this.DGV_Accompagnements.Name = "DGV_Accompagnements";
            this.DGV_Accompagnements.Size = new System.Drawing.Size(1255, 396);
            this.DGV_Accompagnements.TabIndex = 3;
            // 
            // F_Accompagnements_Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.DGV_Accompagnements);
            this.Controls.Add(this.panel1);
            this.Name = "F_Accompagnements_Recap";
            this.Text = "F_Accompagnement";
            this.Load += new System.EventHandler(this.F_Accompagnements_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accompagnements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Accompagnements;
        private System.Windows.Forms.CheckBox CB_HideEmptyCol;
        private System.Windows.Forms.Button BT_EditListeAccompagnements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_EleveAdd;
        private System.Windows.Forms.Label label2;
    }
}