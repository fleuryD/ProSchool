namespace ProSchool
{
    partial class UserControl_Calendar_Day
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Evenements = new System.Windows.Forms.Label();
            this.PAN_All = new System.Windows.Forms.Panel();
            this.RICHTXT_Date = new System.Windows.Forms.RichTextBox();
            this.PAN_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Evenements
            // 
            this.LB_Evenements.AutoEllipsis = true;
            this.LB_Evenements.BackColor = System.Drawing.Color.White;
            this.LB_Evenements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Evenements.Location = new System.Drawing.Point(5, 27);
            this.LB_Evenements.Name = "LB_Evenements";
            this.LB_Evenements.Padding = new System.Windows.Forms.Padding(4);
            this.LB_Evenements.Size = new System.Drawing.Size(195, 76);
            this.LB_Evenements.TabIndex = 1;
            this.LB_Evenements.Text = "LB_Evenements";
            // 
            // PAN_All
            // 
            this.PAN_All.BackColor = System.Drawing.Color.White;
            this.PAN_All.Controls.Add(this.LB_Evenements);
            this.PAN_All.Controls.Add(this.RICHTXT_Date);
            this.PAN_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_All.Location = new System.Drawing.Point(3, 3);
            this.PAN_All.Margin = new System.Windows.Forms.Padding(5);
            this.PAN_All.Name = "PAN_All";
            this.PAN_All.Padding = new System.Windows.Forms.Padding(5);
            this.PAN_All.Size = new System.Drawing.Size(205, 108);
            this.PAN_All.TabIndex = 2;
            // 
            // RICHTXT_Date
            // 
            this.RICHTXT_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RICHTXT_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.RICHTXT_Date.Location = new System.Drawing.Point(5, 5);
            this.RICHTXT_Date.Margin = new System.Windows.Forms.Padding(5);
            this.RICHTXT_Date.Name = "RICHTXT_Date";
            this.RICHTXT_Date.ReadOnly = true;
            this.RICHTXT_Date.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RICHTXT_Date.Size = new System.Drawing.Size(195, 22);
            this.RICHTXT_Date.TabIndex = 2;
            this.RICHTXT_Date.Text = "Date";
            this.RICHTXT_Date.WordWrap = false;
            // 
            // UserControl_Calendar_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.PAN_All);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_Calendar_Day";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(211, 114);
            this.PAN_All.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LB_Evenements;
        private System.Windows.Forms.Panel PAN_All;
        private System.Windows.Forms.RichTextBox RICHTXT_Date;
    }
}
