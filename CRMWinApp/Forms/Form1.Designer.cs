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
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CriminalListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterCriminal = new System.Windows.Forms.Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CriminalListButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RegisterCriminal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 85);
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
            this.CriminalListButton.Location = new System.Drawing.Point(3, 62);
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
            this.button1.Location = new System.Drawing.Point(3, 39);
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
            this.RegisterCriminal.Size = new System.Drawing.Size(192, 23);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1013, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 502);
            this.panel3.TabIndex = 2;
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

    }
}

