namespace ProSchool
{
    partial class F_Accompagnements_Options
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
            this.DGV_Accompagnements = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_AccompagnementAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accompagnements)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Accompagnements
            // 
            this.DGV_Accompagnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Accompagnements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Accompagnements.Location = new System.Drawing.Point(0, 52);
            this.DGV_Accompagnements.Name = "DGV_Accompagnements";
            this.DGV_Accompagnements.Size = new System.Drawing.Size(676, 552);
            this.DGV_Accompagnements.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(351, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-cliquez sur un accompagnement pour le modifier";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BT_AccompagnementAdd
            // 
            this.BT_AccompagnementAdd.Location = new System.Drawing.Point(431, 12);
            this.BT_AccompagnementAdd.Name = "BT_AccompagnementAdd";
            this.BT_AccompagnementAdd.Size = new System.Drawing.Size(192, 24);
            this.BT_AccompagnementAdd.TabIndex = 5;
            this.BT_AccompagnementAdd.Text = "Créer un nouvel accompagnement";
            this.BT_AccompagnementAdd.UseVisualStyleBackColor = true;
            this.BT_AccompagnementAdd.Click += new System.EventHandler(this.BT_AccompagnementAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BT_AccompagnementAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 52);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BT_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 36);
            this.panel2.TabIndex = 6;
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(594, 4);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(75, 23);
            this.BT_Close.TabIndex = 0;
            this.BT_Close.Text = "Fermer";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ou";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // F_Accompagnements_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 640);
            this.Controls.Add(this.DGV_Accompagnements);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_Accompagnements_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer la liste des accompagnements";
            this.Load += new System.EventHandler(this.F_Accompagnements_Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accompagnements)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Accompagnements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_AccompagnementAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label label2;
    }
}