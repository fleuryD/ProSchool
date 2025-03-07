namespace ProSchool
{
    partial class F_Responsables_Liste
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
            this.PAN_Todo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Responsables = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PAN_DgvHeader = new System.Windows.Forms.Panel();
            this.PAN_Responsables = new System.Windows.Forms.Panel();
            this.FLP_Responsables = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.PAN_Todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Responsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PAN_Responsables.SuspendLayout();
            this.FLP_Responsables.SuspendLayout();
            this.PAN_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(12, 9);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(194, 20);
            this.LB_Titre.TabIndex = 0;
            this.LB_Titre.Text = "Liste des responsables";
            // 
            // PAN_Todo
            // 
            this.PAN_Todo.AutoSize = true;
            this.PAN_Todo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.PAN_Todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Todo.Controls.Add(this.label2);
            this.PAN_Todo.Controls.Add(this.label1);
            this.PAN_Todo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Todo.Location = new System.Drawing.Point(0, 64);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Todo.Size = new System.Drawing.Size(79, 69);
            this.PAN_Todo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "xxxxxxxxxxxxxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TODO";
            // 
            // DGV_Responsables
            // 
            this.DGV_Responsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Responsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Responsables.Location = new System.Drawing.Point(0, 68);
            this.DGV_Responsables.Name = "DGV_Responsables";
            this.DGV_Responsables.Size = new System.Drawing.Size(1016, 676);
            this.DGV_Responsables.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGV_Responsables);
            this.splitContainer1.Panel1.Controls.Add(this.PAN_DgvHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Todo);
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Responsables);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 746);
            this.splitContainer1.SplitterDistance = 1018;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 8;
            // 
            // PAN_DgvHeader
            // 
            this.PAN_DgvHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_DgvHeader.Location = new System.Drawing.Point(0, 0);
            this.PAN_DgvHeader.Name = "PAN_DgvHeader";
            this.PAN_DgvHeader.Size = new System.Drawing.Size(1016, 68);
            this.PAN_DgvHeader.TabIndex = 5;
            // 
            // PAN_Responsables
            // 
            this.PAN_Responsables.AutoSize = true;
            this.PAN_Responsables.BackColor = System.Drawing.Color.White;
            this.PAN_Responsables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Responsables.Controls.Add(this.FLP_Responsables);
            this.PAN_Responsables.Controls.Add(this.label18);
            this.PAN_Responsables.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Responsables.Location = new System.Drawing.Point(0, 0);
            this.PAN_Responsables.Name = "PAN_Responsables";
            this.PAN_Responsables.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Responsables.Size = new System.Drawing.Size(79, 64);
            this.PAN_Responsables.TabIndex = 5;
            // 
            // FLP_Responsables
            // 
            this.FLP_Responsables.AutoSize = true;
            this.FLP_Responsables.Controls.Add(this.label15);
            this.FLP_Responsables.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLP_Responsables.Location = new System.Drawing.Point(10, 37);
            this.FLP_Responsables.Name = "FLP_Responsables";
            this.FLP_Responsables.Size = new System.Drawing.Size(55, 26);
            this.FLP_Responsables.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "xxxxxxxxxx";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label18.Location = new System.Drawing.Point(10, 10);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label18.Size = new System.Drawing.Size(110, 27);
            this.label18.TabIndex = 0;
            this.label18.Text = "Responsables";
            // 
            // PAN_Header
            // 
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.LB_Titre);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1107, 39);
            this.PAN_Header.TabIndex = 7;
            // 
            // F_Responsables_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 785);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Responsables_Liste";
            this.Text = "F_Responsables_Liste";
            this.Load += new System.EventHandler(this.F_Responsables_Liste_Load);
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Responsables)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PAN_Responsables.ResumeLayout(false);
            this.PAN_Responsables.PerformLayout();
            this.FLP_Responsables.ResumeLayout(false);
            this.FLP_Responsables.PerformLayout();
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Responsables;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PAN_DgvHeader;
        private System.Windows.Forms.Panel PAN_Responsables;
        private System.Windows.Forms.FlowLayoutPanel FLP_Responsables;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel PAN_Header;
    }
}