namespace ProSchool
{
    partial class F_Personnels_Liste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Personnels_Liste));
            this.LB_Titre = new System.Windows.Forms.Label();
            this.PAN_Header = new System.Windows.Forms.Panel();
            this.BT_PersonnelAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGV_Personnels = new System.Windows.Forms.DataGridView();
            this.PAN_DgvHeader = new System.Windows.Forms.Panel();
            this.CB_ShowAutres = new System.Windows.Forms.CheckBox();
            this.CB_ShowRepPlus = new System.Windows.Forms.CheckBox();
            this.CB_ShowAvs = new System.Windows.Forms.CheckBox();
            this.CB_ShowProfs = new System.Windows.Forms.CheckBox();
            this.BT_DgvOption = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_DgvSearch = new System.Windows.Forms.TextBox();
            this.PAN_Todo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PAN_Eleves = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BT_AddEleves = new System.Windows.Forms.Button();
            this.PAN_ItemsEleves = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PAN_Classes = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BT_AddClasses = new System.Windows.Forms.Button();
            this.PAN_ItemsClasses = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PAN_Personnel = new System.Windows.Forms.Panel();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.BT_Edit = new System.Windows.Forms.Button();
            this.TXT_Nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Prenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CtxtMENU_Personnel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMenuItem_Nom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMenuItem__Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuItem_EditClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenuItem_EditEleves = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.PAN_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personnels)).BeginInit();
            this.PAN_DgvHeader.SuspendLayout();
            this.PAN_Todo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PAN_Eleves.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PAN_Classes.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PAN_Personnel.SuspendLayout();
            this.CtxtMENU_Personnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titre.Location = new System.Drawing.Point(10, 7);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(157, 20);
            this.LB_Titre.TabIndex = 3;
            this.LB_Titre.Text = "Liste du personnel";
            // 
            // PAN_Header
            // 
            this.PAN_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Header.Controls.Add(this.BT_PersonnelAdd);
            this.PAN_Header.Controls.Add(this.LB_Titre);
            this.PAN_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Header.Location = new System.Drawing.Point(0, 0);
            this.PAN_Header.Name = "PAN_Header";
            this.PAN_Header.Size = new System.Drawing.Size(1153, 39);
            this.PAN_Header.TabIndex = 6;
            // 
            // BT_PersonnelAdd
            // 
            this.BT_PersonnelAdd.Location = new System.Drawing.Point(506, 7);
            this.BT_PersonnelAdd.Name = "BT_PersonnelAdd";
            this.BT_PersonnelAdd.Size = new System.Drawing.Size(120, 23);
            this.BT_PersonnelAdd.TabIndex = 4;
            this.BT_PersonnelAdd.Text = "Ajouter un personnel";
            this.BT_PersonnelAdd.UseVisualStyleBackColor = true;
            this.BT_PersonnelAdd.Click += new System.EventHandler(this.BT_PersonnelAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGV_Personnels);
            this.splitContainer1.Panel1.Controls.Add(this.PAN_DgvHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Todo);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Eleves);
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Classes);
            this.splitContainer1.Panel2.Controls.Add(this.PAN_Personnel);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 831);
            this.splitContainer1.SplitterDistance = 863;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 7;
            // 
            // DGV_Personnels
            // 
            this.DGV_Personnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Personnels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Personnels.Location = new System.Drawing.Point(0, 63);
            this.DGV_Personnels.Name = "DGV_Personnels";
            this.DGV_Personnels.Size = new System.Drawing.Size(863, 768);
            this.DGV_Personnels.TabIndex = 0;
            this.DGV_Personnels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Personnels_CellDoubleClick);
            this.DGV_Personnels.SelectionChanged += new System.EventHandler(this.DGV_Personnels_SelectionChanged);
            this.DGV_Personnels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Personnels_MouseClick);
            // 
            // PAN_DgvHeader
            // 
            this.PAN_DgvHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_DgvHeader.Controls.Add(this.CB_ShowAutres);
            this.PAN_DgvHeader.Controls.Add(this.CB_ShowRepPlus);
            this.PAN_DgvHeader.Controls.Add(this.CB_ShowAvs);
            this.PAN_DgvHeader.Controls.Add(this.CB_ShowProfs);
            this.PAN_DgvHeader.Controls.Add(this.BT_DgvOption);
            this.PAN_DgvHeader.Controls.Add(this.label16);
            this.PAN_DgvHeader.Controls.Add(this.TXT_DgvSearch);
            this.PAN_DgvHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_DgvHeader.Location = new System.Drawing.Point(0, 0);
            this.PAN_DgvHeader.Name = "PAN_DgvHeader";
            this.PAN_DgvHeader.Size = new System.Drawing.Size(863, 63);
            this.PAN_DgvHeader.TabIndex = 7;
            // 
            // CB_ShowAutres
            // 
            this.CB_ShowAutres.AutoSize = true;
            this.CB_ShowAutres.Checked = true;
            this.CB_ShowAutres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ShowAutres.Location = new System.Drawing.Point(195, 37);
            this.CB_ShowAutres.Name = "CB_ShowAutres";
            this.CB_ShowAutres.Size = new System.Drawing.Size(56, 17);
            this.CB_ShowAutres.TabIndex = 6;
            this.CB_ShowAutres.Text = "Autres";
            this.CB_ShowAutres.UseVisualStyleBackColor = true;
            this.CB_ShowAutres.CheckedChanged += new System.EventHandler(this.CB_Filtres_CheckedChanged);
            // 
            // CB_ShowRepPlus
            // 
            this.CB_ShowRepPlus.AutoSize = true;
            this.CB_ShowRepPlus.Checked = true;
            this.CB_ShowRepPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ShowRepPlus.Location = new System.Drawing.Point(72, 37);
            this.CB_ShowRepPlus.Name = "CB_ShowRepPlus";
            this.CB_ShowRepPlus.Size = new System.Drawing.Size(52, 17);
            this.CB_ShowRepPlus.TabIndex = 5;
            this.CB_ShowRepPlus.Text = "Rep+";
            this.CB_ShowRepPlus.UseVisualStyleBackColor = true;
            this.CB_ShowRepPlus.CheckedChanged += new System.EventHandler(this.CB_Filtres_CheckedChanged);
            // 
            // CB_ShowAvs
            // 
            this.CB_ShowAvs.AutoSize = true;
            this.CB_ShowAvs.Checked = true;
            this.CB_ShowAvs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ShowAvs.Location = new System.Drawing.Point(130, 37);
            this.CB_ShowAvs.Name = "CB_ShowAvs";
            this.CB_ShowAvs.Size = new System.Drawing.Size(47, 17);
            this.CB_ShowAvs.TabIndex = 3;
            this.CB_ShowAvs.Text = "AVS";
            this.CB_ShowAvs.UseVisualStyleBackColor = true;
            this.CB_ShowAvs.CheckedChanged += new System.EventHandler(this.CB_Filtres_CheckedChanged);
            // 
            // CB_ShowProfs
            // 
            this.CB_ShowProfs.AutoSize = true;
            this.CB_ShowProfs.Checked = true;
            this.CB_ShowProfs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ShowProfs.Location = new System.Drawing.Point(16, 37);
            this.CB_ShowProfs.Name = "CB_ShowProfs";
            this.CB_ShowProfs.Size = new System.Drawing.Size(50, 17);
            this.CB_ShowProfs.TabIndex = 3;
            this.CB_ShowProfs.Text = "Profs";
            this.CB_ShowProfs.UseVisualStyleBackColor = true;
            this.CB_ShowProfs.CheckedChanged += new System.EventHandler(this.CB_Filtres_CheckedChanged);
            // 
            // BT_DgvOption
            // 
            this.BT_DgvOption.Enabled = false;
            this.BT_DgvOption.Location = new System.Drawing.Point(424, 21);
            this.BT_DgvOption.Name = "BT_DgvOption";
            this.BT_DgvOption.Size = new System.Drawing.Size(52, 23);
            this.BT_DgvOption.TabIndex = 2;
            this.BT_DgvOption.Text = "Options";
            this.BT_DgvOption.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Rechercher par nom ou prénom: ";
            // 
            // TXT_DgvSearch
            // 
            this.TXT_DgvSearch.Enabled = false;
            this.TXT_DgvSearch.Location = new System.Drawing.Point(177, 7);
            this.TXT_DgvSearch.Name = "TXT_DgvSearch";
            this.TXT_DgvSearch.Size = new System.Drawing.Size(228, 20);
            this.TXT_DgvSearch.TabIndex = 0;
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
            this.PAN_Todo.Location = new System.Drawing.Point(0, 465);
            this.PAN_Todo.Name = "PAN_Todo";
            this.PAN_Todo.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Todo.Size = new System.Drawing.Size(284, 91);
            this.PAN_Todo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Filtrer les profs / AVS / RASED...\r\n- Ajouter Genre \"REP+\"\r\n- RASED :Maitresse " +
    "E/G";
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(284, 143);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 91);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Astuces";
            // 
            // PAN_Eleves
            // 
            this.PAN_Eleves.AutoSize = true;
            this.PAN_Eleves.BackColor = System.Drawing.Color.White;
            this.PAN_Eleves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Eleves.Controls.Add(this.panel4);
            this.PAN_Eleves.Controls.Add(this.PAN_ItemsEleves);
            this.PAN_Eleves.Controls.Add(this.label8);
            this.PAN_Eleves.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Eleves.Location = new System.Drawing.Point(0, 224);
            this.PAN_Eleves.Name = "PAN_Eleves";
            this.PAN_Eleves.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Eleves.Size = new System.Drawing.Size(284, 98);
            this.PAN_Eleves.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.BT_AddEleves);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 52);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel4.Size = new System.Drawing.Size(260, 32);
            this.panel4.TabIndex = 11;
            // 
            // BT_AddEleves
            // 
            this.BT_AddEleves.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_AddEleves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddEleves.Location = new System.Drawing.Point(0, 10);
            this.BT_AddEleves.Name = "BT_AddEleves";
            this.BT_AddEleves.Size = new System.Drawing.Size(260, 22);
            this.BT_AddEleves.TabIndex = 0;
            this.BT_AddEleves.Text = "Ajouter des élèves";
            this.BT_AddEleves.UseVisualStyleBackColor = true;
            this.BT_AddEleves.Click += new System.EventHandler(this.BT_AddEleves_Click);
            // 
            // PAN_ItemsEleves
            // 
            this.PAN_ItemsEleves.AutoSize = true;
            this.PAN_ItemsEleves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_ItemsEleves.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_ItemsEleves.Location = new System.Drawing.Point(10, 38);
            this.PAN_ItemsEleves.Name = "PAN_ItemsEleves";
            this.PAN_ItemsEleves.Padding = new System.Windows.Forms.Padding(5);
            this.PAN_ItemsEleves.Size = new System.Drawing.Size(260, 14);
            this.PAN_ItemsEleves.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Elèves:";
            // 
            // PAN_Classes
            // 
            this.PAN_Classes.AutoSize = true;
            this.PAN_Classes.BackColor = System.Drawing.Color.White;
            this.PAN_Classes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Classes.Controls.Add(this.panel5);
            this.PAN_Classes.Controls.Add(this.PAN_ItemsClasses);
            this.PAN_Classes.Controls.Add(this.label7);
            this.PAN_Classes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Classes.Location = new System.Drawing.Point(0, 126);
            this.PAN_Classes.Name = "PAN_Classes";
            this.PAN_Classes.Padding = new System.Windows.Forms.Padding(10);
            this.PAN_Classes.Size = new System.Drawing.Size(284, 98);
            this.PAN_Classes.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.BT_AddClasses);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 52);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Size = new System.Drawing.Size(260, 32);
            this.panel5.TabIndex = 11;
            // 
            // BT_AddClasses
            // 
            this.BT_AddClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_AddClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddClasses.Location = new System.Drawing.Point(0, 10);
            this.BT_AddClasses.Name = "BT_AddClasses";
            this.BT_AddClasses.Size = new System.Drawing.Size(260, 22);
            this.BT_AddClasses.TabIndex = 0;
            this.BT_AddClasses.Text = "Ajouter des classes";
            this.BT_AddClasses.UseVisualStyleBackColor = true;
            this.BT_AddClasses.Click += new System.EventHandler(this.BT_AddClasses_Click);
            // 
            // PAN_ItemsClasses
            // 
            this.PAN_ItemsClasses.AutoSize = true;
            this.PAN_ItemsClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_ItemsClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_ItemsClasses.Location = new System.Drawing.Point(10, 38);
            this.PAN_ItemsClasses.Name = "PAN_ItemsClasses";
            this.PAN_ItemsClasses.Padding = new System.Windows.Forms.Padding(5);
            this.PAN_ItemsClasses.Size = new System.Drawing.Size(260, 14);
            this.PAN_ItemsClasses.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label7.Size = new System.Drawing.Size(66, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Classes:";
            // 
            // PAN_Personnel
            // 
            this.PAN_Personnel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAN_Personnel.Controls.Add(this.LB_Nom);
            this.PAN_Personnel.Controls.Add(this.BT_Edit);
            this.PAN_Personnel.Controls.Add(this.TXT_Nom);
            this.PAN_Personnel.Controls.Add(this.label5);
            this.PAN_Personnel.Controls.Add(this.TXT_Prenom);
            this.PAN_Personnel.Controls.Add(this.label6);
            this.PAN_Personnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Personnel.Location = new System.Drawing.Point(0, 0);
            this.PAN_Personnel.Name = "PAN_Personnel";
            this.PAN_Personnel.Size = new System.Drawing.Size(284, 126);
            this.PAN_Personnel.TabIndex = 12;
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(18, 7);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(48, 13);
            this.LB_Nom.TabIndex = 5;
            this.LB_Nom.Text = "LB_Nom";
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(56, 88);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 6;
            this.BT_Edit.Text = "Modifier";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // TXT_Nom
            // 
            this.TXT_Nom.Location = new System.Drawing.Point(56, 27);
            this.TXT_Nom.Name = "TXT_Nom";
            this.TXT_Nom.ReadOnly = true;
            this.TXT_Nom.Size = new System.Drawing.Size(134, 20);
            this.TXT_Nom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prénom";
            // 
            // TXT_Prenom
            // 
            this.TXT_Prenom.Location = new System.Drawing.Point(56, 53);
            this.TXT_Prenom.Name = "TXT_Prenom";
            this.TXT_Prenom.ReadOnly = true;
            this.TXT_Prenom.Size = new System.Drawing.Size(134, 20);
            this.TXT_Prenom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nom";
            // 
            // CtxtMENU_Personnel
            // 
            this.CtxtMENU_Personnel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMenuItem_Nom,
            this.toolStripSeparator1,
            this.CMenuItem__Edit,
            this.CMenuItem_EditClasses,
            this.CMenuItem_EditEleves,
            this.toolStripSeparator2,
            this.CMenuItem_Delete});
            this.CtxtMENU_Personnel.Name = "CtxtMenuSt_Personnel";
            this.CtxtMENU_Personnel.Size = new System.Drawing.Size(206, 126);
            // 
            // CMenuItem_Nom
            // 
            this.CMenuItem_Nom.Enabled = false;
            this.CMenuItem_Nom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMenuItem_Nom.Name = "CMenuItem_Nom";
            this.CMenuItem_Nom.Size = new System.Drawing.Size(205, 22);
            this.CMenuItem_Nom.Text = "ITEM_Nom";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // CMenuItem__Edit
            // 
            this.CMenuItem__Edit.Name = "CMenuItem__Edit";
            this.CMenuItem__Edit.Size = new System.Drawing.Size(205, 22);
            this.CMenuItem__Edit.Text = "Modifier";
            this.CMenuItem__Edit.Click += new System.EventHandler(this.CMenuItem__Edit_Click);
            // 
            // CMenuItem_EditClasses
            // 
            this.CMenuItem_EditClasses.Enabled = false;
            this.CMenuItem_EditClasses.Name = "CMenuItem_EditClasses";
            this.CMenuItem_EditClasses.Size = new System.Drawing.Size(205, 22);
            this.CMenuItem_EditClasses.Text = "Attribuer/Enlever Classes";
            // 
            // CMenuItem_EditEleves
            // 
            this.CMenuItem_EditEleves.Enabled = false;
            this.CMenuItem_EditEleves.Name = "CMenuItem_EditEleves";
            this.CMenuItem_EditEleves.Size = new System.Drawing.Size(205, 22);
            this.CMenuItem_EditEleves.Text = "Attribuer/Enlever Elèves";
            this.CMenuItem_EditEleves.Click += new System.EventHandler(this.CMenuItem_EditEleves_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // CMenuItem_Delete
            // 
            this.CMenuItem_Delete.ForeColor = System.Drawing.Color.Red;
            this.CMenuItem_Delete.Name = "CMenuItem_Delete";
            this.CMenuItem_Delete.Size = new System.Drawing.Size(205, 22);
            this.CMenuItem_Delete.Text = "Supprimer";
            this.CMenuItem_Delete.Click += new System.EventHandler(this.CMenuItem_Delete_Click);
            // 
            // F_Personnels_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 870);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PAN_Header);
            this.Name = "F_Personnels_Liste";
            this.Text = "F_Personnel_Liste";
            this.Load += new System.EventHandler(this.F_Personnels_Liste_Load);
            this.PAN_Header.ResumeLayout(false);
            this.PAN_Header.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personnels)).EndInit();
            this.PAN_DgvHeader.ResumeLayout(false);
            this.PAN_DgvHeader.PerformLayout();
            this.PAN_Todo.ResumeLayout(false);
            this.PAN_Todo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PAN_Eleves.ResumeLayout(false);
            this.PAN_Eleves.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.PAN_Classes.ResumeLayout(false);
            this.PAN_Classes.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.PAN_Personnel.ResumeLayout(false);
            this.PAN_Personnel.PerformLayout();
            this.CtxtMENU_Personnel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Panel PAN_Header;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGV_Personnels;
        private System.Windows.Forms.Button BT_PersonnelAdd;
        private System.Windows.Forms.Panel PAN_Todo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Button BT_Edit;
        private System.Windows.Forms.Panel PAN_DgvHeader;
        private System.Windows.Forms.CheckBox CB_ShowAutres;
        private System.Windows.Forms.CheckBox CB_ShowRepPlus;
        private System.Windows.Forms.CheckBox CB_ShowAvs;
        private System.Windows.Forms.CheckBox CB_ShowProfs;
        private System.Windows.Forms.Button BT_DgvOption;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_DgvSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip CtxtMENU_Personnel;
        private System.Windows.Forms.ToolStripMenuItem CMenuItem_Nom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CMenuItem__Edit;
        private System.Windows.Forms.ToolStripMenuItem CMenuItem_EditClasses;
        private System.Windows.Forms.ToolStripMenuItem CMenuItem_EditEleves;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CMenuItem_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Prenom;
        private System.Windows.Forms.TextBox TXT_Nom;
        private System.Windows.Forms.Panel PAN_Personnel;
        private System.Windows.Forms.Panel PAN_Eleves;
        private System.Windows.Forms.Panel PAN_ItemsEleves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BT_AddEleves;
        private System.Windows.Forms.Panel PAN_Classes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BT_AddClasses;
        private System.Windows.Forms.Panel PAN_ItemsClasses;
        private System.Windows.Forms.Label label7;
    }
}