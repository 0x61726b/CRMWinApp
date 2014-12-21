namespace CRMWinApp
{
    partial class MainForm
    {
        private Models.User cLoggedUser;
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
        public void SetUser( Models.User user )
        {
            cLoggedUser = user;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.chargeCountLbl = new System.Windows.Forms.Label();
            this.arrestCountLbl = new System.Windows.Forms.Label();
            this.criminalCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.MidFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.GroupBox();
            this.addAttorney = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerCrime = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CriminalListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterCriminal = new System.Windows.Forms.Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchSurnameTxt = new System.Windows.Forms.TextBox();
            this.criminalListLB = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cellNoLBL = new System.Windows.Forms.Label();
            this.criminalPicture = new System.Windows.Forms.PictureBox();
            this.surnameLBL = new System.Windows.Forms.Label();
            this.nameLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userTsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userTsType = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.TopFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.MidFlowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalPicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPermissionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userPermissionsToolStripMenuItem
            // 
            this.userPermissionsToolStripMenuItem.Name = "userPermissionsToolStripMenuItem";
            this.userPermissionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userPermissionsToolStripMenuItem.Text = "User Permissions";
            this.userPermissionsToolStripMenuItem.Click += new System.EventHandler(this.userPermissionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TopFlowLayoutPanel
            // 
            this.TopFlowLayoutPanel.AutoSize = true;
            this.TopFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopFlowLayoutPanel.Controls.Add(this.panel1);
            this.TopFlowLayoutPanel.Controls.Add(this.UserInfoPanel);
            this.TopFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFlowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.TopFlowLayoutPanel.Name = "TopFlowLayoutPanel";
            this.TopFlowLayoutPanel.Size = new System.Drawing.Size(1219, 97);
            this.TopFlowLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.chargeCountLbl);
            this.panel1.Controls.Add(this.arrestCountLbl);
            this.panel1.Controls.Add(this.criminalCountLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 89);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(834, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // chargeCountLbl
            // 
            this.chargeCountLbl.AutoSize = true;
            this.chargeCountLbl.Location = new System.Drawing.Point(7, 50);
            this.chargeCountLbl.Name = "chargeCountLbl";
            this.chargeCountLbl.Size = new System.Drawing.Size(110, 13);
            this.chargeCountLbl.TabIndex = 5;
            this.chargeCountLbl.Text = "Charges Count Today";
            // 
            // arrestCountLbl
            // 
            this.arrestCountLbl.AutoSize = true;
            this.arrestCountLbl.Location = new System.Drawing.Point(7, 37);
            this.arrestCountLbl.Name = "arrestCountLbl";
            this.arrestCountLbl.Size = new System.Drawing.Size(98, 13);
            this.arrestCountLbl.TabIndex = 4;
            this.arrestCountLbl.Text = "Arrest Count Today";
            // 
            // criminalCountLbl
            // 
            this.criminalCountLbl.AutoSize = true;
            this.criminalCountLbl.Location = new System.Drawing.Point(7, 24);
            this.criminalCountLbl.Name = "criminalCountLbl";
            this.criminalCountLbl.Size = new System.Drawing.Size(80, 13);
            this.criminalCountLbl.TabIndex = 3;
            this.criminalCountLbl.Text = "Criminale Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cera CRM System Version Alpha";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(925, 61);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInfoPanel.Controls.Add(this.exitButton);
            this.UserInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoPanel.Location = new System.Drawing.Point(1014, 3);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(200, 89);
            this.UserInfoPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(120, 60);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Logout";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MidFlowLayoutPanel
            // 
            this.MidFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidFlowLayoutPanel.Controls.Add(this.panel2);
            this.MidFlowLayoutPanel.Controls.Add(this.MidPanel);
            this.MidFlowLayoutPanel.Controls.Add(this.panel3);
            this.MidFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MidFlowLayoutPanel.Location = new System.Drawing.Point(0, 121);
            this.MidFlowLayoutPanel.Name = "MidFlowLayoutPanel";
            this.MidFlowLayoutPanel.Size = new System.Drawing.Size(1219, 506);
            this.MidFlowLayoutPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.adminPanel);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 502);
            this.panel2.TabIndex = 0;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.addAttorney);
            this.adminPanel.Controls.Add(this.manageUsersButton);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminPanel.Enabled = false;
            this.adminPanel.Location = new System.Drawing.Point(0, 400);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(198, 100);
            this.adminPanel.TabIndex = 5;
            this.adminPanel.TabStop = false;
            this.adminPanel.Text = "SecretPanel";
            this.adminPanel.Visible = false;
            // 
            // addAttorney
            // 
            this.addAttorney.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAttorney.Location = new System.Drawing.Point(3, 39);
            this.addAttorney.Name = "addAttorney";
            this.addAttorney.Size = new System.Drawing.Size(192, 23);
            this.addAttorney.TabIndex = 1;
            this.addAttorney.Text = "Add/Edit Attorney";
            this.addAttorney.UseVisualStyleBackColor = true;
            this.addAttorney.Click += new System.EventHandler(this.addAttorney_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageUsersButton.Location = new System.Drawing.Point(3, 16);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(192, 23);
            this.manageUsersButton.TabIndex = 0;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerCrime);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CriminalListButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RegisterCriminal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // registerCrime
            // 
            this.registerCrime.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerCrime.Location = new System.Drawing.Point(3, 120);
            this.registerCrime.Name = "registerCrime";
            this.registerCrime.Size = new System.Drawing.Size(192, 23);
            this.registerCrime.TabIndex = 7;
            this.registerCrime.Text = "Register Crime";
            this.registerCrime.UseVisualStyleBackColor = true;
            this.registerCrime.Click += new System.EventHandler(this.registerCrime_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prison ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CriminalListButton
            // 
            this.CriminalListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CriminalListButton.Location = new System.Drawing.Point(3, 74);
            this.CriminalListButton.Name = "CriminalListButton";
            this.CriminalListButton.Size = new System.Drawing.Size(192, 23);
            this.CriminalListButton.TabIndex = 5;
            this.CriminalListButton.Text = "Criminal List";
            this.CriminalListButton.UseVisualStyleBackColor = true;
            this.CriminalListButton.Click += new System.EventHandler(this.CriminalListButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Criminal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterCriminal
            // 
            this.RegisterCriminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegisterCriminal.Location = new System.Drawing.Point(3, 16);
            this.RegisterCriminal.Name = "RegisterCriminal";
            this.RegisterCriminal.Size = new System.Drawing.Size(192, 35);
            this.RegisterCriminal.TabIndex = 2;
            this.RegisterCriminal.Text = "Register Criminal";
            this.RegisterCriminal.UseVisualStyleBackColor = true;
            this.RegisterCriminal.Click += new System.EventHandler(this.RegisterCriminal_Click);
            // 
            // MidPanel
            // 
            this.MidPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MidPanel.Location = new System.Drawing.Point(209, 3);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(798, 502);
            this.MidPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.statusLBL);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cellNoLBL);
            this.panel3.Controls.Add(this.criminalPicture);
            this.panel3.Controls.Add(this.surnameLBL);
            this.panel3.Controls.Add(this.nameLBL);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1013, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 502);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transferBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.searchSurnameTxt);
            this.groupBox2.Controls.Add(this.criminalListLB);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.searchNameTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 224);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer a prisoner here";
            // 
            // transferBtn
            // 
            this.transferBtn.Enabled = false;
            this.transferBtn.Location = new System.Drawing.Point(100, 87);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(75, 23);
            this.transferBtn.TabIndex = 7;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // searchSurnameTxt
            // 
            this.searchSurnameTxt.Location = new System.Drawing.Point(82, 52);
            this.searchSurnameTxt.Name = "searchSurnameTxt";
            this.searchSurnameTxt.Size = new System.Drawing.Size(100, 20);
            this.searchSurnameTxt.TabIndex = 4;
            // 
            // criminalListLB
            // 
            this.criminalListLB.FormattingEnabled = true;
            this.criminalListLB.Location = new System.Drawing.Point(9, 116);
            this.criminalListLB.Name = "criminalListLB";
            this.criminalListLB.Size = new System.Drawing.Size(173, 108);
            this.criminalListLB.TabIndex = 3;
            this.criminalListLB.SelectedIndexChanged += new System.EventHandler(this.criminalListLB_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(27, 87);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchNameTxt
            // 
            this.searchNameTxt.Location = new System.Drawing.Point(82, 26);
            this.searchNameTxt.Name = "searchNameTxt";
            this.searchNameTxt.Size = new System.Drawing.Size(100, 20);
            this.searchNameTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search";
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusLBL.ForeColor = System.Drawing.Color.Red;
            this.statusLBL.Location = new System.Drawing.Point(81, 57);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(0, 20);
            this.statusLBL.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // cellNoLBL
            // 
            this.cellNoLBL.AutoSize = true;
            this.cellNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cellNoLBL.Location = new System.Drawing.Point(55, 25);
            this.cellNoLBL.Name = "cellNoLBL";
            this.cellNoLBL.Size = new System.Drawing.Size(70, 26);
            this.cellNoLBL.TabIndex = 6;
            this.cellNoLBL.Text = "label4";
            // 
            // criminalPicture
            // 
            this.criminalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criminalPicture.Location = new System.Drawing.Point(19, 85);
            this.criminalPicture.Name = "criminalPicture";
            this.criminalPicture.Size = new System.Drawing.Size(159, 128);
            this.criminalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.criminalPicture.TabIndex = 5;
            this.criminalPicture.TabStop = false;
            // 
            // surnameLBL
            // 
            this.surnameLBL.AutoSize = true;
            this.surnameLBL.Location = new System.Drawing.Point(125, 248);
            this.surnameLBL.Name = "surnameLBL";
            this.surnameLBL.Size = new System.Drawing.Size(0, 13);
            this.surnameLBL.TabIndex = 3;
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Location = new System.Drawing.Point(125, 225);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(0, 13);
            this.nameLBL.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.userTsLabel,
            this.userTsType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1219, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Cera CRM Ver 0.1";
            // 
            // userTsLabel
            // 
            this.userTsLabel.Name = "userTsLabel";
            this.userTsLabel.Size = new System.Drawing.Size(41, 17);
            this.userTsLabel.Text = "userTs";
            // 
            // userTsType
            // 
            this.userTsType.Name = "userTsType";
            this.userTsType.Size = new System.Drawing.Size(118, 17);
            this.userTsType.Text = "toolStripStatusLabel2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 652);
            this.Controls.Add(this.MidFlowLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TopFlowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cera CRM System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TopFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.MidFlowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalPicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel TopFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.FlowLayoutPanel MidFlowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RegisterCriminal;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel userTsLabel;
        private System.Windows.Forms.ToolStripStatusLabel userTsType;
        private System.Windows.Forms.Button CriminalListButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chargeCountLbl;
        private System.Windows.Forms.Label arrestCountLbl;
        private System.Windows.Forms.Label criminalCountLbl;
        private System.Windows.Forms.GroupBox adminPanel;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.PictureBox criminalPicture;
        private System.Windows.Forms.Label surnameLBL;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cellNoLBL;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox criminalListLB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchSurnameTxt;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addAttorney;
        private System.Windows.Forms.Button registerCrime;

    }
}

