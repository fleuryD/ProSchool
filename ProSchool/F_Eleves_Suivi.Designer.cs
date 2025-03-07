namespace ProSchool
{
    partial class F_Eleves_Suivi
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
            this.PAN_Todo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(12, 9);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(103, 20);
            this.LB_Titre.TabIndex = 2;
            this.LB_Titre.Text = "Suivi élèves";
            // 
            // PAN_Todo
            // 
            this.PAN_Todo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.PAN_Todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Todo.Controls.Add(this.label2);
            this.PAN_Todo.Controls.Add(this.label1);
            this.PAN_Todo.Location = new System.Drawing.Point(39, 105);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Todo.Size = new System.Drawing.Size(537, 107);
            this.PAN_Todo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Afficher / Ajouter des entretiens, commentaires, signalement, ( ... ) pour les " +
    "élèves";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label1.Size = new System.Drawing.Size(56, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "TODO";
            // 
            // F_Eleves_Suivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PAN_Todo);
            this.Controls.Add(this.LB_Titre);
            this.Name = "F_Eleves_Suivi";
            this.Text = "F_Eleves_Suivi";
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}