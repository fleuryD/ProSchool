namespace ProSchool
{
    partial class F_About
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
            this.label1 = new System.Windows.Forms.Label();
            this.RICHTXT_Todo = new System.Windows.Forms.RichTextBox();
            this.RICHTXT_Maj = new System.Windows.Forms.RichTextBox();
            this.RICHTXT_Help = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(1184, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProSchool --- visible = false";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            //
            // RICHTXT_Todo
            //
            this.RICHTXT_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.RICHTXT_Todo.Dock = System.Windows.Forms.DockStyle.Left;
            this.RICHTXT_Todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RICHTXT_Todo.Location = new System.Drawing.Point(0, 71);
            this.RICHTXT_Todo.Name = "RICHTXT_Todo";
            this.RICHTXT_Todo.ReadOnly = true;
            this.RICHTXT_Todo.Size = new System.Drawing.Size(353, 724);
            this.RICHTXT_Todo.TabIndex = 34;
            this.RICHTXT_Todo.Text = "";
            //
            // RICHTXT_Maj
            //
            this.RICHTXT_Maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.RICHTXT_Maj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RICHTXT_Maj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RICHTXT_Maj.Location = new System.Drawing.Point(353, 71);
            this.RICHTXT_Maj.Name = "RICHTXT_Maj";
            this.RICHTXT_Maj.ReadOnly = true;
            this.RICHTXT_Maj.Size = new System.Drawing.Size(380, 724);
            this.RICHTXT_Maj.TabIndex = 35;
            this.RICHTXT_Maj.Text = "";
            //
            // RICHTXT_Help
            //
            this.RICHTXT_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RICHTXT_Help.Dock = System.Windows.Forms.DockStyle.Right;
            this.RICHTXT_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RICHTXT_Help.Location = new System.Drawing.Point(733, 71);
            this.RICHTXT_Help.Name = "RICHTXT_Help";
            this.RICHTXT_Help.ReadOnly = true;
            this.RICHTXT_Help.Size = new System.Drawing.Size(451, 724);
            this.RICHTXT_Help.TabIndex = 35;
            this.RICHTXT_Help.Text = "";
            //
            // F_About
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 795);
            this.Controls.Add(this.RICHTXT_Maj);
            this.Controls.Add(this.RICHTXT_Help);
            this.Controls.Add(this.RICHTXT_Todo);
            this.Controls.Add(this.label1);
            this.Name = "F_About";
            this.Text = "F_About";
            this.Load += new System.EventHandler(this.F_About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RICHTXT_Todo;
        private System.Windows.Forms.RichTextBox RICHTXT_Maj;
        private System.Windows.Forms.RichTextBox RICHTXT_Help;
    }
}