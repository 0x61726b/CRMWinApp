﻿namespace CRMWinApp.UserControls
{
    partial class EditCriminal
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
        public void SetCriminal(Models.Criminal c)
        {
            selectedCriminal = c;
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.Identifying = new System.Windows.Forms.GroupBox();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.raceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hairColorTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photoRight = new System.Windows.Forms.PictureBox();
            this.photoLeft = new System.Windows.Forms.PictureBox();
            this.photoFront = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.topGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Identifying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoFront)).BeginInit();
            this.SuspendLayout();
            // 
            // topGroupBox
            // 
            this.topGroupBox.Controls.Add(this.button1);
            this.topGroupBox.Controls.Add(this.groupBox3);
            this.topGroupBox.Controls.Add(this.groupBox2);
            this.topGroupBox.Controls.Add(this.Identifying);
            this.topGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topGroupBox.Location = new System.Drawing.Point(0, 0);
            this.topGroupBox.Name = "topGroupBox";
            this.topGroupBox.Size = new System.Drawing.Size(702, 477);
            this.topGroupBox.TabIndex = 0;
            this.topGroupBox.TabStop = false;
            this.topGroupBox.Text = "Edit Criminal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.photoRight);
            this.groupBox3.Controls.Add(this.photoLeft);
            this.groupBox3.Controls.Add(this.photoFront);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 182);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.stateTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.countryTB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 67);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location of Record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "State";
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(406, 28);
            this.stateTB.Name = "stateTB";
            this.stateTB.Size = new System.Drawing.Size(99, 20);
            this.stateTB.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Country";
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(88, 28);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(214, 20);
            this.countryTB.TabIndex = 0;
            // 
            // Identifying
            // 
            this.Identifying.Controls.Add(this.weightTB);
            this.Identifying.Controls.Add(this.label7);
            this.Identifying.Controls.Add(this.raceTB);
            this.Identifying.Controls.Add(this.label6);
            this.Identifying.Controls.Add(this.hairColorTB);
            this.Identifying.Controls.Add(this.label5);
            this.Identifying.Controls.Add(this.surnameTB);
            this.Identifying.Controls.Add(this.genderCB);
            this.Identifying.Controls.Add(this.nameTB);
            this.Identifying.Controls.Add(this.label4);
            this.Identifying.Controls.Add(this.label1);
            this.Identifying.Controls.Add(this.heightTB);
            this.Identifying.Controls.Add(this.label2);
            this.Identifying.Controls.Add(this.label3);
            this.Identifying.Dock = System.Windows.Forms.DockStyle.Top;
            this.Identifying.Location = new System.Drawing.Point(3, 16);
            this.Identifying.Name = "Identifying";
            this.Identifying.Size = new System.Drawing.Size(696, 123);
            this.Identifying.TabIndex = 13;
            this.Identifying.TabStop = false;
            this.Identifying.Text = "Identifying Information";
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(626, 45);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(45, 20);
            this.weightTB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Weight";
            // 
            // raceTB
            // 
            this.raceTB.Location = new System.Drawing.Point(88, 97);
            this.raceTB.Name = "raceTB";
            this.raceTB.Size = new System.Drawing.Size(214, 20);
            this.raceTB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Race";
            // 
            // hairColorTB
            // 
            this.hairColorTB.Location = new System.Drawing.Point(88, 71);
            this.hairColorTB.Name = "hairColorTB";
            this.hairColorTB.Size = new System.Drawing.Size(214, 20);
            this.hairColorTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hair Color";
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(88, 45);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(214, 20);
            this.surnameTB.TabIndex = 5;
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCB.Location = new System.Drawing.Point(626, 74);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(57, 21);
            this.genderCB.TabIndex = 9;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(88, 19);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(214, 20);
            this.nameTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(626, 19);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(45, 20);
            this.heightTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // photoRight
            // 
            this.photoRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoRight.Location = new System.Drawing.Point(448, 19);
            this.photoRight.Name = "photoRight";
            this.photoRight.Size = new System.Drawing.Size(172, 139);
            this.photoRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoRight.TabIndex = 19;
            this.photoRight.TabStop = false;
            this.photoRight.Click += new System.EventHandler(this.photoRight_Click);
            // 
            // photoLeft
            // 
            this.photoLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoLeft.Location = new System.Drawing.Point(242, 19);
            this.photoLeft.Name = "photoLeft";
            this.photoLeft.Size = new System.Drawing.Size(172, 139);
            this.photoLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoLeft.TabIndex = 18;
            this.photoLeft.TabStop = false;
            this.photoLeft.Click += new System.EventHandler(this.photoLeft_Click);
            // 
            // photoFront
            // 
            this.photoFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.photoFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoFront.Location = new System.Drawing.Point(36, 19);
            this.photoFront.Name = "photoFront";
            this.photoFront.Size = new System.Drawing.Size(172, 139);
            this.photoFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoFront.TabIndex = 17;
            this.photoFront.TabStop = false;
            this.photoFront.Click += new System.EventHandler(this.photoFront_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topGroupBox);
            this.Name = "EditCriminal";
            this.Size = new System.Drawing.Size(702, 477);
            this.Load += new System.EventHandler(this.EditCriminal_Load);
            this.topGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Identifying.ResumeLayout(false);
            this.Identifying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox topGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.GroupBox Identifying;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox raceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hairColorTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox photoRight;
        private System.Windows.Forms.PictureBox photoLeft;
        private System.Windows.Forms.PictureBox photoFront;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
