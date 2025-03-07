namespace ProSchool
{
    partial class F_Appels_Faire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Appels_Faire));
            this.DGV_Appel = new System.Windows.Forms.DataGridView();
            this.BT_AnnulerAppel = new System.Windows.Forms.Button();
            this.BT_AppelTermine = new System.Windows.Forms.Button();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.BT_PreviousWeek = new System.Windows.Forms.Button();
            this.BT_NextWeek = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBO_Semaines = new System.Windows.Forms.ComboBox();
            this.LB_DateToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PAN_Help_SelectClasse = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PAN_Help_Appel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PAN_Help_Appel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PAN_Help_Justifier = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PAN_Todo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FLP_BoutonsClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appel)).BeginInit();
            this.PAN_Header.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PAN_Help_SelectClasse.SuspendLayout();
            this.PAN_Help_Appel1.SuspendLayout();
            this.PAN_Help_Appel2.SuspendLayout();
            this.PAN_Help_Justifier.SuspendLayout();
            this.PAN_Todo.SuspendLayout();
            this.FLP_BoutonsClasses.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Appel
            // 
            this.DGV_Appel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Appel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Appel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Appel.Location = new System.Drawing.Point(0, 401);
            this.DGV_Appel.Name = "DGV_Appel";
            this.DGV_Appel.Size = new System.Drawing.Size(1224, 183);
            this.DGV_Appel.TabIndex = 4;
            this.DGV_Appel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Appel_CellDoubleClick);
            this.DGV_Appel.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Appel_ColumnHeaderMouseDoubleClick);
            // 
            // BT_AnnulerAppel
            // 
            this.BT_AnnulerAppel.ForeColor = System.Drawing.Color.Red;
            this.BT_AnnulerAppel.Location = new System.Drawing.Point(8, 8);
            this.BT_AnnulerAppel.Name = "BT_AnnulerAppel";
            this.BT_AnnulerAppel.Size = new System.Drawing.Size(162, 23);
            this.BT_AnnulerAppel.TabIndex = 11;
            this.BT_AnnulerAppel.Text = "Annuler l\'appel";
            this.BT_AnnulerAppel.UseVisualStyleBackColor = true;
            this.BT_AnnulerAppel.Click += new System.EventHandler(this.BT_AnnulerAppel_Click);
            // 
            // BT_AppelTermine
            // 
            this.BT_AppelTermine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AppelTermine.ForeColor = System.Drawing.Color.Blue;
            this.BT_AppelTermine.Location = new System.Drawing.Point(176, 8);
            this.BT_AppelTermine.Name = "BT_AppelTermine";
            this.BT_AppelTermine.Size = new System.Drawing.Size(162, 31);
            this.BT_AppelTermine.TabIndex = 10;
            this.BT_AppelTermine.Text = "Appel Terminé";
            this.BT_AppelTermine.UseVisualStyleBackColor = true;
            this.BT_AppelTermine.Click += new System.EventHandler(this.BT_AppelTermine_Click);
            // 
            // PAN_Header
            // 
            this.PAN_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.label14);
            this.PAN_Header.Controls.Add(this.BT_PreviousWeek);
            this.PAN_Header.Controls.Add(this.BT_NextWeek);
            this.PAN_Header.Controls.Add(this.label4);
            this.PAN_Header.Controls.Add(this.COMBO_Semaines);
            this.PAN_Header.Controls.Add(this.LB_DateToday);
            this.PAN_Header.Controls.Add(this.label2);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 316);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1224, 85);
            this.PAN_Header.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(16, 46);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label14.Size = new System.Drawing.Size(884, 34);
            this.label14.TabIndex = 2;
            this.label14.Text = "C\'est l\'ancienne version de l\'appel..... Cliquez sur \"faire l\'appel\" dans le menu" +
    " ci-dessus !!!!!!!!";
            // 
            // BT_PreviousWeek
            // 
            this.BT_PreviousWeek.Location = new System.Drawing.Point(449, 4);
            this.BT_PreviousWeek.Name = "BT_PreviousWeek";
            this.BT_PreviousWeek.Size = new System.Drawing.Size(27, 23);
            this.BT_PreviousWeek.TabIndex = 19;
            this.BT_PreviousWeek.Text = "<<";
            this.BT_PreviousWeek.UseVisualStyleBackColor = true;
            this.BT_PreviousWeek.Click += new System.EventHandler(this.BT_PreviousWeek_Click);
            // 
            // BT_NextWeek
            // 
            this.BT_NextWeek.Location = new System.Drawing.Point(684, 4);
            this.BT_NextWeek.Name = "BT_NextWeek";
            this.BT_NextWeek.Size = new System.Drawing.Size(27, 23);
            this.BT_NextWeek.TabIndex = 18;
            this.BT_NextWeek.Text = ">>";
            this.BT_NextWeek.UseVisualStyleBackColor = true;
            this.BT_NextWeek.Click += new System.EventHandler(this.BT_NextWeek_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semaine du";
            // 
            // COMBO_Semaines
            // 
            this.COMBO_Semaines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Semaines.FormattingEnabled = true;
            this.COMBO_Semaines.Location = new System.Drawing.Point(482, 5);
            this.COMBO_Semaines.Name = "COMBO_Semaines";
            this.COMBO_Semaines.Size = new System.Drawing.Size(196, 21);
            this.COMBO_Semaines.TabIndex = 5;
            this.COMBO_Semaines.SelectedIndexChanged += new System.EventHandler(this.COMBO_Semaines_SelectedIndexChanged);
            // 
            // LB_DateToday
            // 
            this.LB_DateToday.AutoSize = true;
            this.LB_DateToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.LB_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateToday.Location = new System.Drawing.Point(92, 0);
            this.LB_DateToday.Name = "LB_DateToday";
            this.LB_DateToday.Size = new System.Drawing.Size(128, 20);
            this.LB_DateToday.TabIndex = 4;
            this.LB_DateToday.Text = "LB_DateToday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aujourd\'hui:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_SelectClasse);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Appel1);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Appel2);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Help_Justifier);
            this.flowLayoutPanel1.Controls.Add(this.PAN_Todo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1224, 284);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // PAN_Help_SelectClasse
            // 
            this.PAN_Help_SelectClasse.AutoSize = true;
            this.PAN_Help_SelectClasse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_SelectClasse.BackColor = System.Drawing.Color.White;
            this.PAN_Help_SelectClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_SelectClasse.Controls.Add(this.label7);
            this.PAN_Help_SelectClasse.Location = new System.Drawing.Point(3, 3);
            this.PAN_Help_SelectClasse.Name = "PAN_Help_SelectClasse";
            this.PAN_Help_SelectClasse.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_SelectClasse.Size = new System.Drawing.Size(340, 108);
            this.PAN_Help_SelectClasse.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(30);
            this.label7.Size = new System.Drawing.Size(310, 84);
            this.label7.TabIndex = 2;
            this.label7.Text = "Séléctionnez une classe !";
            // 
            // PAN_Help_Appel1
            // 
            this.PAN_Help_Appel1.AutoSize = true;
            this.PAN_Help_Appel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Appel1.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Appel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Appel1.Controls.Add(this.label10);
            this.PAN_Help_Appel1.Controls.Add(this.label9);
            this.PAN_Help_Appel1.Location = new System.Drawing.Point(349, 3);
            this.PAN_Help_Appel1.Name = "PAN_Help_Appel1";
            this.PAN_Help_Appel1.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Appel1.Size = new System.Drawing.Size(611, 58);
            this.PAN_Help_Appel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label10.Size = new System.Drawing.Size(104, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Faire l\'appel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(474, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "- Double-cliquez sur la date du jour (Matin ou Aprem) pour déverrouiller l\'appel." +
    " \r\n   (Les cases de la demi-journée deviennent jaunes.)\r\n";
            // 
            // PAN_Help_Appel2
            // 
            this.PAN_Help_Appel2.AutoSize = true;
            this.PAN_Help_Appel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Appel2.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Appel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Appel2.Controls.Add(this.label6);
            this.PAN_Help_Appel2.Controls.Add(this.label5);
            this.PAN_Help_Appel2.Location = new System.Drawing.Point(3, 117);
            this.PAN_Help_Appel2.Name = "PAN_Help_Appel2";
            this.PAN_Help_Appel2.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Appel2.Size = new System.Drawing.Size(538, 66);
            this.PAN_Help_Appel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "- Quand vous avez fini, cliquez sur \"Appel terminé\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(508, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "- Double-cliquez sur une case jaune pour modifier \"Absent/Retard/Present\" et just" +
    "ifier";
            // 
            // PAN_Help_Justifier
            // 
            this.PAN_Help_Justifier.AutoSize = true;
            this.PAN_Help_Justifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Help_Justifier.BackColor = System.Drawing.Color.Honeydew;
            this.PAN_Help_Justifier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Help_Justifier.Controls.Add(this.label13);
            this.PAN_Help_Justifier.Controls.Add(this.label11);
            this.PAN_Help_Justifier.Controls.Add(this.label12);
            this.PAN_Help_Justifier.Location = new System.Drawing.Point(547, 117);
            this.PAN_Help_Justifier.Name = "PAN_Help_Justifier";
            this.PAN_Help_Justifier.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Help_Justifier.Size = new System.Drawing.Size(386, 84);
            this.PAN_Help_Justifier.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(144, 10);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label13.Size = new System.Drawing.Size(225, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "voir les absences d\'un élève:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(7, 10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label11.Size = new System.Drawing.Size(131, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = " Ajouter/Justifier";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "- Double-cliquez sur le nom ou prénom d\'un élève \r\n(si vous n\'etes pas déjà en tr" +
    "ain de faire l\'appel)";
            // 
            // PAN_Todo
            // 
            this.PAN_Todo.AutoSize = true;
            this.PAN_Todo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PAN_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PAN_Todo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Todo.Controls.Add(this.label1);
            this.PAN_Todo.Controls.Add(this.label8);
            this.PAN_Todo.Location = new System.Drawing.Point(3, 207);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Todo.Size = new System.Drawing.Size(657, 74);
            this.PAN_Todo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TODO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(559, 48);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.Visible = false;
            // 
            // FLP_BoutonsClasses
            // 
            this.FLP_BoutonsClasses.AutoSize = true;
            this.FLP_BoutonsClasses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_BoutonsClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLP_BoutonsClasses.Controls.Add(this.label3);
            this.FLP_BoutonsClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLP_BoutonsClasses.Location = new System.Drawing.Point(0, 284);
            this.FLP_BoutonsClasses.Name = "FLP_BoutonsClasses";
            this.FLP_BoutonsClasses.Padding = new System.Windows.Forms.Padding(5);
            this.FLP_BoutonsClasses.Size = new System.Drawing.Size(1224, 32);
            this.FLP_BoutonsClasses.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classes:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.BT_AnnulerAppel);
            this.flowLayoutPanel2.Controls.Add(this.BT_AppelTermine);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 584);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1224, 49);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // F_Appels_Faire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 633);
            this.Controls.Add(this.DGV_Appel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.PAN_Header);
            this.Controls.Add(this.FLP_BoutonsClasses);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "F_Appels_Faire";
            this.Text = "F_Appels_faire";
            this.Load += new System.EventHandler(this.F_Appels_Faire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appel)).EndInit();
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PAN_Help_SelectClasse.ResumeLayout(false);
            this.PAN_Help_SelectClasse.PerformLayout();
            this.PAN_Help_Appel1.ResumeLayout(false);
            this.PAN_Help_Appel1.PerformLayout();
            this.PAN_Help_Appel2.ResumeLayout(false);
            this.PAN_Help_Appel2.PerformLayout();
            this.PAN_Help_Justifier.ResumeLayout(false);
            this.PAN_Help_Justifier.PerformLayout();
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            this.FLP_BoutonsClasses.ResumeLayout(false);
            this.FLP_BoutonsClasses.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Appel;
        private System.Windows.Forms.Button BT_AppelTermine;
        private System.Windows.Forms.Button BT_AnnulerAppel;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_DateToday;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PAN_Help_SelectClasse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PAN_Help_Appel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PAN_Help_Appel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel FLP_BoutonsClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox COMBO_Semaines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_PreviousWeek;
        private System.Windows.Forms.Button BT_NextWeek;
        private System.Windows.Forms.Panel PAN_Help_Justifier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label14;
    }
}