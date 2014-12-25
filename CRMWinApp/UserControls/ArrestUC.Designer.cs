namespace CRMWinApp.UserControls
{
    partial class ArrestUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.ArrestInfoTab = new System.Windows.Forms.TabPage();
            this.arrestInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.arrestRightPanel = new System.Windows.Forms.Panel();
            this.punishmentButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.surnameLBL = new System.Windows.Forms.Label();
            this.nameLBL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.informationTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crimeTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agencyCB = new System.Windows.Forms.ComboBox();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arrestDateDT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.arrestLeftPanel = new System.Windows.Forms.Panel();
            this.arrestListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChargesTab = new System.Windows.Forms.TabPage();
            this.chargesGroupBox = new System.Windows.Forms.GroupBox();
            this.chargesPanel = new System.Windows.Forms.Panel();
            this.rightChargePanel = new System.Windows.Forms.Panel();
            this.findAtt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.citeTypeCB = new System.Windows.Forms.ComboBox();
            this.attorneyCB = new System.Windows.Forms.ComboBox();
            this.chargeDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chargeLV = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.meetingPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.meetingItem1 = new CRMWinApp.UserControls.MeetingItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addNewChargeBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ArrestInfoTab.SuspendLayout();
            this.arrestInfoGroupBox.SuspendLayout();
            this.arrestRightPanel.SuspendLayout();
            this.arrestLeftPanel.SuspendLayout();
            this.ChargesTab.SuspendLayout();
            this.chargesGroupBox.SuspendLayout();
            this.chargesPanel.SuspendLayout();
            this.rightChargePanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalInfoTab);
            this.tabControl1.Controls.Add(this.ArrestInfoTab);
            this.tabControl1.Controls.Add(this.ChargesTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 640);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Location = new System.Drawing.Point(4, 22);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(944, 614);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Personal Information";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // ArrestInfoTab
            // 
            this.ArrestInfoTab.Controls.Add(this.arrestInfoGroupBox);
            this.ArrestInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ArrestInfoTab.Name = "ArrestInfoTab";
            this.ArrestInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArrestInfoTab.Size = new System.Drawing.Size(944, 614);
            this.ArrestInfoTab.TabIndex = 1;
            this.ArrestInfoTab.Text = "Arrest Information";
            this.ArrestInfoTab.UseVisualStyleBackColor = true;
            // 
            // arrestInfoGroupBox
            // 
            this.arrestInfoGroupBox.Controls.Add(this.arrestRightPanel);
            this.arrestInfoGroupBox.Controls.Add(this.arrestLeftPanel);
            this.arrestInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrestInfoGroupBox.Enabled = false;
            this.arrestInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.arrestInfoGroupBox.Name = "arrestInfoGroupBox";
            this.arrestInfoGroupBox.Size = new System.Drawing.Size(938, 608);
            this.arrestInfoGroupBox.TabIndex = 0;
            this.arrestInfoGroupBox.TabStop = false;
            this.arrestInfoGroupBox.Text = "Arrest Info";
            this.arrestInfoGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // arrestRightPanel
            // 
            this.arrestRightPanel.Controls.Add(this.punishmentButton);
            this.arrestRightPanel.Controls.Add(this.updateButton);
            this.arrestRightPanel.Controls.Add(this.surnameLBL);
            this.arrestRightPanel.Controls.Add(this.nameLBL);
            this.arrestRightPanel.Controls.Add(this.label9);
            this.arrestRightPanel.Controls.Add(this.label8);
            this.arrestRightPanel.Controls.Add(this.informationTB);
            this.arrestRightPanel.Controls.Add(this.label1);
            this.arrestRightPanel.Controls.Add(this.label5);
            this.arrestRightPanel.Controls.Add(this.crimeTypeCB);
            this.arrestRightPanel.Controls.Add(this.label2);
            this.arrestRightPanel.Controls.Add(this.agencyCB);
            this.arrestRightPanel.Controls.Add(this.locationTB);
            this.arrestRightPanel.Controls.Add(this.label4);
            this.arrestRightPanel.Controls.Add(this.arrestDateDT);
            this.arrestRightPanel.Controls.Add(this.label3);
            this.arrestRightPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.arrestRightPanel.Location = new System.Drawing.Point(361, 16);
            this.arrestRightPanel.Name = "arrestRightPanel";
            this.arrestRightPanel.Size = new System.Drawing.Size(574, 589);
            this.arrestRightPanel.TabIndex = 11;
            // 
            // punishmentButton
            // 
            this.punishmentButton.Location = new System.Drawing.Point(35, 3);
            this.punishmentButton.Name = "punishmentButton";
            this.punishmentButton.Size = new System.Drawing.Size(180, 23);
            this.punishmentButton.TabIndex = 15;
            this.punishmentButton.Text = "Show Punishment Data";
            this.punishmentButton.UseVisualStyleBackColor = true;
            this.punishmentButton.Click += new System.EventHandler(this.punishmentButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(168, 390);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // surnameLBL
            // 
            this.surnameLBL.AutoSize = true;
            this.surnameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLBL.Location = new System.Drawing.Point(182, 72);
            this.surnameLBL.Name = "surnameLBL";
            this.surnameLBL.Size = new System.Drawing.Size(87, 24);
            this.surnameLBL.TabIndex = 13;
            this.surnameLBL.Text = "Surname";
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLBL.Location = new System.Drawing.Point(182, 31);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(61, 24);
            this.nameLBL.TabIndex = 12;
            this.nameLBL.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Name";
            // 
            // informationTB
            // 
            this.informationTB.Location = new System.Drawing.Point(142, 198);
            this.informationTB.Name = "informationTB";
            this.informationTB.Size = new System.Drawing.Size(255, 159);
            this.informationTB.TabIndex = 8;
            this.informationTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crime Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Information";
            // 
            // crimeTypeCB
            // 
            this.crimeTypeCB.FormattingEnabled = true;
            this.crimeTypeCB.Location = new System.Drawing.Point(142, 104);
            this.crimeTypeCB.Name = "crimeTypeCB";
            this.crimeTypeCB.Size = new System.Drawing.Size(255, 21);
            this.crimeTypeCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // agencyCB
            // 
            this.agencyCB.FormattingEnabled = true;
            this.agencyCB.Location = new System.Drawing.Point(142, 363);
            this.agencyCB.Name = "agencyCB";
            this.agencyCB.Size = new System.Drawing.Size(274, 21);
            this.agencyCB.TabIndex = 7;
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(142, 134);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(255, 20);
            this.locationTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Agency";
            // 
            // arrestDateDT
            // 
            this.arrestDateDT.Location = new System.Drawing.Point(142, 169);
            this.arrestDateDT.Name = "arrestDateDT";
            this.arrestDateDT.Size = new System.Drawing.Size(255, 20);
            this.arrestDateDT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arrest Date";
            // 
            // arrestLeftPanel
            // 
            this.arrestLeftPanel.Controls.Add(this.arrestListView);
            this.arrestLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.arrestLeftPanel.Location = new System.Drawing.Point(3, 16);
            this.arrestLeftPanel.Name = "arrestLeftPanel";
            this.arrestLeftPanel.Size = new System.Drawing.Size(358, 589);
            this.arrestLeftPanel.TabIndex = 10;
            // 
            // arrestListView
            // 
            this.arrestListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.arrestListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrestListView.Location = new System.Drawing.Point(0, 0);
            this.arrestListView.Name = "arrestListView";
            this.arrestListView.Size = new System.Drawing.Size(358, 589);
            this.arrestListView.TabIndex = 0;
            this.arrestListView.UseCompatibleStateImageBehavior = false;
            this.arrestListView.View = System.Windows.Forms.View.Details;
            this.arrestListView.SelectedIndexChanged += new System.EventHandler(this.arrestListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 82;
            // 
            // ChargesTab
            // 
            this.ChargesTab.Controls.Add(this.chargesGroupBox);
            this.ChargesTab.Location = new System.Drawing.Point(4, 22);
            this.ChargesTab.Name = "ChargesTab";
            this.ChargesTab.Size = new System.Drawing.Size(944, 614);
            this.ChargesTab.TabIndex = 2;
            this.ChargesTab.Text = "Charges";
            this.ChargesTab.UseVisualStyleBackColor = true;
            // 
            // chargesGroupBox
            // 
            this.chargesGroupBox.AutoSize = true;
            this.chargesGroupBox.Controls.Add(this.chargesPanel);
            this.chargesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chargesGroupBox.Enabled = false;
            this.chargesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.chargesGroupBox.Name = "chargesGroupBox";
            this.chargesGroupBox.Size = new System.Drawing.Size(944, 614);
            this.chargesGroupBox.TabIndex = 0;
            this.chargesGroupBox.TabStop = false;
            this.chargesGroupBox.Text = "Charges";
            // 
            // chargesPanel
            // 
            this.chargesPanel.Controls.Add(this.rightChargePanel);
            this.chargesPanel.Controls.Add(this.chargeLV);
            this.chargesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chargesPanel.Location = new System.Drawing.Point(3, 16);
            this.chargesPanel.Name = "chargesPanel";
            this.chargesPanel.Size = new System.Drawing.Size(938, 595);
            this.chargesPanel.TabIndex = 0;
            // 
            // rightChargePanel
            // 
            this.rightChargePanel.Controls.Add(this.addNewChargeBtn);
            this.rightChargePanel.Controls.Add(this.findAtt);
            this.rightChargePanel.Controls.Add(this.button2);
            this.rightChargePanel.Controls.Add(this.citeTypeCB);
            this.rightChargePanel.Controls.Add(this.attorneyCB);
            this.rightChargePanel.Controls.Add(this.chargeDate);
            this.rightChargePanel.Controls.Add(this.richTextBox1);
            this.rightChargePanel.Controls.Add(this.label13);
            this.rightChargePanel.Controls.Add(this.label12);
            this.rightChargePanel.Controls.Add(this.label11);
            this.rightChargePanel.Controls.Add(this.label10);
            this.rightChargePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightChargePanel.Location = new System.Drawing.Point(501, 0);
            this.rightChargePanel.Name = "rightChargePanel";
            this.rightChargePanel.Size = new System.Drawing.Size(437, 595);
            this.rightChargePanel.TabIndex = 1;
            // 
            // findAtt
            // 
            this.findAtt.Location = new System.Drawing.Point(339, 90);
            this.findAtt.Name = "findAtt";
            this.findAtt.Size = new System.Drawing.Size(51, 23);
            this.findAtt.TabIndex = 11;
            this.findAtt.Text = "Find";
            this.findAtt.UseVisualStyleBackColor = true;
            this.findAtt.Click += new System.EventHandler(this.findAtt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // citeTypeCB
            // 
            this.citeTypeCB.FormattingEnabled = true;
            this.citeTypeCB.Location = new System.Drawing.Point(132, 54);
            this.citeTypeCB.Name = "citeTypeCB";
            this.citeTypeCB.Size = new System.Drawing.Size(200, 21);
            this.citeTypeCB.TabIndex = 7;
            // 
            // attorneyCB
            // 
            this.attorneyCB.FormattingEnabled = true;
            this.attorneyCB.Location = new System.Drawing.Point(133, 92);
            this.attorneyCB.Name = "attorneyCB";
            this.attorneyCB.Size = new System.Drawing.Size(200, 21);
            this.attorneyCB.TabIndex = 6;
            // 
            // chargeDate
            // 
            this.chargeDate.Location = new System.Drawing.Point(133, 133);
            this.chargeDate.Name = "chargeDate";
            this.chargeDate.Size = new System.Drawing.Size(200, 20);
            this.chargeDate.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(132, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 184);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Attorney";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type";
            // 
            // chargeLV
            // 
            this.chargeLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.chargeLV.Dock = System.Windows.Forms.DockStyle.Left;
            this.chargeLV.Location = new System.Drawing.Point(0, 0);
            this.chargeLV.Name = "chargeLV";
            this.chargeLV.Size = new System.Drawing.Size(495, 595);
            this.chargeLV.TabIndex = 0;
            this.chargeLV.UseCompatibleStateImageBehavior = false;
            this.chargeLV.View = System.Windows.Forms.View.Details;
            this.chargeLV.SelectedIndexChanged += new System.EventHandler(this.chargeLV_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Note";
            this.columnHeader6.Width = 242;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 614);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Meetings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 608);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meetings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.meetingPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(386, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 589);
            this.panel2.TabIndex = 1;
            // 
            // meetingPanel
            // 
            this.meetingPanel.Location = new System.Drawing.Point(6, 105);
            this.meetingPanel.Name = "meetingPanel";
            this.meetingPanel.Size = new System.Drawing.Size(540, 481);
            this.meetingPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.meetingItem1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 589);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "between";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meetingItem1
            // 
            this.meetingItem1.Location = new System.Drawing.Point(3, 105);
            this.meetingItem1.Name = "meetingItem1";
            this.meetingItem1.Size = new System.Drawing.Size(374, 466);
            this.meetingItem1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select Date";
            // 
            // addNewChargeBtn
            // 
            this.addNewChargeBtn.Location = new System.Drawing.Point(339, 26);
            this.addNewChargeBtn.Name = "addNewChargeBtn";
            this.addNewChargeBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewChargeBtn.TabIndex = 12;
            this.addNewChargeBtn.Text = "Add";
            this.addNewChargeBtn.UseVisualStyleBackColor = true;
            this.addNewChargeBtn.Click += new System.EventHandler(this.addNewChargeBtn_Click);
            // 
            // ArrestUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ArrestUC";
            this.Size = new System.Drawing.Size(952, 640);
            this.Load += new System.EventHandler(this.ArrestUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.ArrestInfoTab.ResumeLayout(false);
            this.arrestInfoGroupBox.ResumeLayout(false);
            this.arrestRightPanel.ResumeLayout(false);
            this.arrestRightPanel.PerformLayout();
            this.arrestLeftPanel.ResumeLayout(false);
            this.ChargesTab.ResumeLayout(false);
            this.ChargesTab.PerformLayout();
            this.chargesGroupBox.ResumeLayout(false);
            this.chargesPanel.ResumeLayout(false);
            this.rightChargePanel.ResumeLayout(false);
            this.rightChargePanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage ArrestInfoTab;
        private System.Windows.Forms.TabPage ChargesTab;
        private EditCriminal editCriminal1;
        private System.Windows.Forms.GroupBox arrestInfoGroupBox;
        private System.Windows.Forms.ComboBox crimeTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker arrestDateDT;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox agencyCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox informationTB;
        private System.Windows.Forms.GroupBox chargesGroupBox;
        private System.Windows.Forms.Panel chargesPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private MeetingItem meetingItem1;
        private System.Windows.Forms.Panel meetingPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel arrestRightPanel;
        private System.Windows.Forms.Label surnameLBL;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel arrestLeftPanel;
        private System.Windows.Forms.ListView arrestListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListView chargeLV;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel rightChargePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox citeTypeCB;
        private System.Windows.Forms.ComboBox attorneyCB;
        private System.Windows.Forms.DateTimePicker chargeDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button findAtt;
        private System.Windows.Forms.Button punishmentButton;
        private System.Windows.Forms.Button addNewChargeBtn;
    }
}
