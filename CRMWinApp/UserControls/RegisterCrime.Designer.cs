namespace CRMWinApp.UserControls
{
    partial class RegisterCrime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sentenceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noteTB = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.attorneyCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.agencyCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crimeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crimeTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.criminalPictureBox = new System.Windows.Forms.PictureBox();
            this.findPrisoner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.sentenceTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.noteTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.attorneyCB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.addTypeButton);
            this.groupBox1.Controls.Add(this.agencyCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.crimeDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.locationTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.crimeTypeCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.surnameTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.criminalPictureBox);
            this.groupBox1.Controls.Add(this.findPrisoner);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 603);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Crime";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(424, 450);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 23);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "years";
            // 
            // sentenceTB
            // 
            this.sentenceTB.Location = new System.Drawing.Point(398, 394);
            this.sentenceTB.Name = "sentenceTB";
            this.sentenceTB.Size = new System.Drawing.Size(101, 20);
            this.sentenceTB.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sentence";
            // 
            // noteTB
            // 
            this.noteTB.Location = new System.Drawing.Point(398, 248);
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(200, 113);
            this.noteTB.TabIndex = 19;
            this.noteTB.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Note";
            // 
            // attorneyCB
            // 
            this.attorneyCB.FormattingEnabled = true;
            this.attorneyCB.Location = new System.Drawing.Point(398, 195);
            this.attorneyCB.Name = "attorneyCB";
            this.attorneyCB.Size = new System.Drawing.Size(200, 21);
            this.attorneyCB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Attorney";
            // 
            // addTypeButton
            // 
            this.addTypeButton.Location = new System.Drawing.Point(621, 72);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(116, 23);
            this.addTypeButton.TabIndex = 15;
            this.addTypeButton.Text = "Add New Crime Type";
            this.addTypeButton.UseVisualStyleBackColor = true;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // agencyCB
            // 
            this.agencyCB.FormattingEnabled = true;
            this.agencyCB.Location = new System.Drawing.Point(398, 156);
            this.agencyCB.Name = "agencyCB";
            this.agencyCB.Size = new System.Drawing.Size(200, 21);
            this.agencyCB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agency";
            // 
            // crimeDate
            // 
            this.crimeDate.Location = new System.Drawing.Point(398, 124);
            this.crimeDate.Name = "crimeDate";
            this.crimeDate.Size = new System.Drawing.Size(200, 20);
            this.crimeDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(398, 98);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(200, 20);
            this.locationTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // crimeTypeCB
            // 
            this.crimeTypeCB.FormattingEnabled = true;
            this.crimeTypeCB.Location = new System.Drawing.Point(398, 71);
            this.crimeTypeCB.Name = "crimeTypeCB";
            this.crimeTypeCB.Size = new System.Drawing.Size(200, 21);
            this.crimeTypeCB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crime Type";
            // 
            // surnameTB
            // 
            this.surnameTB.Enabled = false;
            this.surnameTB.Location = new System.Drawing.Point(398, 45);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(200, 20);
            this.surnameTB.TabIndex = 5;
            // 
            // nameTB
            // 
            this.nameTB.Enabled = false;
            this.nameTB.Location = new System.Drawing.Point(398, 19);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 20);
            this.nameTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(290, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // criminalPictureBox
            // 
            this.criminalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criminalPictureBox.Location = new System.Drawing.Point(24, 19);
            this.criminalPictureBox.Name = "criminalPictureBox";
            this.criminalPictureBox.Size = new System.Drawing.Size(213, 229);
            this.criminalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.criminalPictureBox.TabIndex = 1;
            this.criminalPictureBox.TabStop = false;
            // 
            // findPrisoner
            // 
            this.findPrisoner.Location = new System.Drawing.Point(24, 264);
            this.findPrisoner.Name = "findPrisoner";
            this.findPrisoner.Size = new System.Drawing.Size(126, 23);
            this.findPrisoner.TabIndex = 0;
            this.findPrisoner.Text = "Find Prisoner";
            this.findPrisoner.UseVisualStyleBackColor = true;
            this.findPrisoner.Click += new System.EventHandler(this.findPrisoner_Click);
            // 
            // RegisterCrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterCrime";
            this.Size = new System.Drawing.Size(910, 603);
            this.Load += new System.EventHandler(this.RegisterCrime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findPrisoner;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox criminalPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crimeTypeCB;
        private System.Windows.Forms.ComboBox agencyCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker crimeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox attorneyCB;
        private System.Windows.Forms.RichTextBox noteTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sentenceTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submitButton;
    }
}
