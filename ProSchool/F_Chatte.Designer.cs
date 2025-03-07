namespace ProSchool
{
    partial class F_Chatte
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
            this.RTXT_Chat = new System.Windows.Forms.RichTextBox();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Envoyer = new System.Windows.Forms.Button();
            this.TXT_Send = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PAN_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTXT_Chat
            // 
            this.RTXT_Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTXT_Chat.Location = new System.Drawing.Point(0, 65);
            this.RTXT_Chat.Name = "RTXT_Chat";
            this.RTXT_Chat.Size = new System.Drawing.Size(432, 565);
            this.RTXT_Chat.TabIndex = 0;
            this.RTXT_Chat.Text = "";
            // 
            // PAN_Header
            // 
            this.PAN_Header.Controls.Add(this.label1);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(867, 65);
            this.PAN_Header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_Envoyer);
            this.panel1.Controls.Add(this.TXT_Send);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(432, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 565);
            this.panel1.TabIndex = 2;
            // 
            // BT_Envoyer
            // 
            this.BT_Envoyer.Location = new System.Drawing.Point(306, 405);
            this.BT_Envoyer.Name = "BT_Envoyer";
            this.BT_Envoyer.Size = new System.Drawing.Size(75, 23);
            this.BT_Envoyer.TabIndex = 1;
            this.BT_Envoyer.Text = "Envoyer";
            this.BT_Envoyer.UseVisualStyleBackColor = true;
            this.BT_Envoyer.Click += new System.EventHandler(this.BT_Envoyer_Click);
            // 
            // TXT_Send
            // 
            this.TXT_Send.Location = new System.Drawing.Point(20, 296);
            this.TXT_Send.Multiline = true;
            this.TXT_Send.Name = "TXT_Send";
            this.TXT_Send.Size = new System.Drawing.Size(403, 87);
            this.TXT_Send.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 65);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Racontez votre vie, signalez un bug, faites une demande pour le programme...";
            // 
            // F_Chatte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 695);
            this.Controls.Add(this.RTXT_Chat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Chatte";
            this.Text = "F_Chatte";
            this.Load += new System.EventHandler(this.F_Chatte_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXT_Chat;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_Send;
        private System.Windows.Forms.Button BT_Envoyer;
        private System.Windows.Forms.Label label1;
    }
}