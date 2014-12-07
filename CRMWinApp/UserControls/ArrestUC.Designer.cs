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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.informationTB = new System.Windows.Forms.RichTextBox();
            this.agencyCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arrestDateDT = new System.Windows.Forms.DateTimePicker();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crimeTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChargesTab = new System.Windows.Forms.TabPage();
            this.chargesGroupBox = new System.Windows.Forms.GroupBox();
            this.chargesPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.ArrestInfoTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ChargesTab.SuspendLayout();
            this.chargesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalInfoTab);
            this.tabControl1.Controls.Add(this.ArrestInfoTab);
            this.tabControl1.Controls.Add(this.ChargesTab);
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
            this.ArrestInfoTab.Controls.Add(this.groupBox1);
            this.ArrestInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ArrestInfoTab.Name = "ArrestInfoTab";
            this.ArrestInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArrestInfoTab.Size = new System.Drawing.Size(944, 614);
            this.ArrestInfoTab.TabIndex = 1;
            this.ArrestInfoTab.Text = "Arrest Information";
            this.ArrestInfoTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.informationTB);
            this.groupBox1.Controls.Add(this.agencyCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.arrestDateDT);
            this.groupBox1.Controls.Add(this.locationTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.crimeTypeCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 608);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrest Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Information";
            // 
            // informationTB
            // 
            this.informationTB.Location = new System.Drawing.Point(146, 150);
            this.informationTB.Name = "informationTB";
            this.informationTB.Size = new System.Drawing.Size(255, 159);
            this.informationTB.TabIndex = 8;
            this.informationTB.Text = "";
            // 
            // agencyCB
            // 
            this.agencyCB.FormattingEnabled = true;
            this.agencyCB.Location = new System.Drawing.Point(577, 24);
            this.agencyCB.Name = "agencyCB";
            this.agencyCB.Size = new System.Drawing.Size(121, 21);
            this.agencyCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Agency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arrest Date";
            // 
            // arrestDateDT
            // 
            this.arrestDateDT.Location = new System.Drawing.Point(146, 89);
            this.arrestDateDT.Name = "arrestDateDT";
            this.arrestDateDT.Size = new System.Drawing.Size(255, 20);
            this.arrestDateDT.TabIndex = 4;
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(146, 54);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(255, 20);
            this.locationTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // crimeTypeCB
            // 
            this.crimeTypeCB.FormattingEnabled = true;
            this.crimeTypeCB.Location = new System.Drawing.Point(146, 24);
            this.crimeTypeCB.Name = "crimeTypeCB";
            this.crimeTypeCB.Size = new System.Drawing.Size(255, 21);
            this.crimeTypeCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crime Type";
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
            this.chargesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.chargesGroupBox.Name = "chargesGroupBox";
            this.chargesGroupBox.Size = new System.Drawing.Size(944, 614);
            this.chargesGroupBox.TabIndex = 0;
            this.chargesGroupBox.TabStop = false;
            this.chargesGroupBox.Text = "Charges";
            // 
            // chargesPanel
            // 
            this.chargesPanel.AutoScroll = true;
            this.chargesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chargesPanel.Location = new System.Drawing.Point(3, 16);
            this.chargesPanel.Name = "chargesPanel";
            this.chargesPanel.Size = new System.Drawing.Size(938, 595);
            this.chargesPanel.TabIndex = 0;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ChargesTab.ResumeLayout(false);
            this.ChargesTab.PerformLayout();
            this.chargesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage ArrestInfoTab;
        private System.Windows.Forms.TabPage ChargesTab;
        private EditCriminal editCriminal1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}
