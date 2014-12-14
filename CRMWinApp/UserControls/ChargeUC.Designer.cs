namespace CRMWinApp.UserControls
{
    partial class ChargeUC
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
            this.titleGroupBox = new System.Windows.Forms.GroupBox();
            this.attorneyCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.citeNoteTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citeTypeCB = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.titleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleGroupBox
            // 
            this.titleGroupBox.AutoSize = true;
            this.titleGroupBox.Controls.Add(this.label4);
            this.titleGroupBox.Controls.Add(this.dateTimePicker1);
            this.titleGroupBox.Controls.Add(this.attorneyCB);
            this.titleGroupBox.Controls.Add(this.label1);
            this.titleGroupBox.Controls.Add(this.citeNoteTB);
            this.titleGroupBox.Controls.Add(this.label3);
            this.titleGroupBox.Controls.Add(this.label2);
            this.titleGroupBox.Controls.Add(this.citeTypeCB);
            this.titleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.titleGroupBox.Name = "titleGroupBox";
            this.titleGroupBox.Size = new System.Drawing.Size(496, 169);
            this.titleGroupBox.TabIndex = 0;
            this.titleGroupBox.TabStop = false;
            this.titleGroupBox.Text = "groupBox1";
            // 
            // attorneyCB
            // 
            this.attorneyCB.FormattingEnabled = true;
            this.attorneyCB.Location = new System.Drawing.Point(150, 100);
            this.attorneyCB.Name = "attorneyCB";
            this.attorneyCB.Size = new System.Drawing.Size(264, 21);
            this.attorneyCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attorney";
            // 
            // citeNoteTB
            // 
            this.citeNoteTB.Location = new System.Drawing.Point(150, 51);
            this.citeNoteTB.Name = "citeNoteTB";
            this.citeNoteTB.Size = new System.Drawing.Size(321, 43);
            this.citeNoteTB.TabIndex = 7;
            this.citeNoteTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cite Type";
            // 
            // citeTypeCB
            // 
            this.citeTypeCB.FormattingEnabled = true;
            this.citeTypeCB.Location = new System.Drawing.Point(150, 16);
            this.citeTypeCB.Name = "citeTypeCB";
            this.citeTypeCB.Size = new System.Drawing.Size(321, 21);
            this.citeTypeCB.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // ChargeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleGroupBox);
            this.Name = "ChargeUC";
            this.Size = new System.Drawing.Size(496, 169);
            this.Load += new System.EventHandler(this.ChargeUC_Load);
            this.titleGroupBox.ResumeLayout(false);
            this.titleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox titleGroupBox;
        private System.Windows.Forms.RichTextBox citeNoteTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox citeTypeCB;
        private System.Windows.Forms.ComboBox attorneyCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
