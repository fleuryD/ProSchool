namespace ProSchool
{
    partial class UserControl_Calendar_Day_Absences
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
            this.PAN_All = new System.Windows.Forms.Panel();
            this.LB_JourLettre = new System.Windows.Forms.Label();
            this.LB_JourChiffre = new System.Windows.Forms.Label();
            this.LB_JourMois = new System.Windows.Forms.Label();
            this.LB_Presence = new System.Windows.Forms.Label();
            this.LB_MatinAprem = new System.Windows.Forms.Label();
            this.PAN_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_All
            // 
            this.PAN_All.BackColor = System.Drawing.Color.White;
            this.PAN_All.Controls.Add(this.LB_MatinAprem);
            this.PAN_All.Controls.Add(this.LB_Presence);
            this.PAN_All.Controls.Add(this.LB_JourLettre);
            this.PAN_All.Controls.Add(this.LB_JourChiffre);
            this.PAN_All.Controls.Add(this.LB_JourMois);
            this.PAN_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAN_All.Location = new System.Drawing.Point(4, 4);
            this.PAN_All.Name = "PAN_All";
            this.PAN_All.Size = new System.Drawing.Size(158, 62);
            this.PAN_All.TabIndex = 3;
            // 
            // LB_JourLettre
            // 
            this.LB_JourLettre.AutoSize = true;
            this.LB_JourLettre.Location = new System.Drawing.Point(5, 6);
            this.LB_JourLettre.Name = "LB_JourLettre";
            this.LB_JourLettre.Size = new System.Drawing.Size(24, 13);
            this.LB_JourLettre.TabIndex = 0;
            this.LB_JourLettre.Text = "Xxx";
            // 
            // LB_JourChiffre
            // 
            this.LB_JourChiffre.AutoSize = true;
            this.LB_JourChiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_JourChiffre.Location = new System.Drawing.Point(30, 1);
            this.LB_JourChiffre.Name = "LB_JourChiffre";
            this.LB_JourChiffre.Size = new System.Drawing.Size(29, 20);
            this.LB_JourChiffre.TabIndex = 0;
            this.LB_JourChiffre.Text = "00";
            // 
            // LB_JourMois
            // 
            this.LB_JourMois.AutoSize = true;
            this.LB_JourMois.Location = new System.Drawing.Point(61, 6);
            this.LB_JourMois.Name = "LB_JourMois";
            this.LB_JourMois.Size = new System.Drawing.Size(24, 13);
            this.LB_JourMois.TabIndex = 0;
            this.LB_JourMois.Text = "Xxx";
            // 
            // LB_Presence
            // 
            this.LB_Presence.AutoSize = true;
            this.LB_Presence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Presence.Location = new System.Drawing.Point(4, 42);
            this.LB_Presence.Name = "LB_Presence";
            this.LB_Presence.Size = new System.Drawing.Size(82, 13);
            this.LB_Presence.TabIndex = 2;
            this.LB_Presence.Text = "LB_Presence";
            // 
            // LB_MatinAprem
            // 
            this.LB_MatinAprem.AutoSize = true;
            this.LB_MatinAprem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MatinAprem.Location = new System.Drawing.Point(4, 22);
            this.LB_MatinAprem.Name = "LB_MatinAprem";
            this.LB_MatinAprem.Size = new System.Drawing.Size(96, 15);
            this.LB_MatinAprem.TabIndex = 3;
            this.LB_MatinAprem.Text = "LB_MatinAprem";
            // 
            // UserControl_Calendar_Day_Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PAN_All);
            this.Name = "UserControl_Calendar_Day_Absences";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(166, 70);
            this.PAN_All.ResumeLayout(false);
            this.PAN_All.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAN_All;
        private System.Windows.Forms.Label LB_JourLettre;
        private System.Windows.Forms.Label LB_JourChiffre;
        private System.Windows.Forms.Label LB_JourMois;
        private System.Windows.Forms.Label LB_MatinAprem;
        private System.Windows.Forms.Label LB_Presence;
    }
}
