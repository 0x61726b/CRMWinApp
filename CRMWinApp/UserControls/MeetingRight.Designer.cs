namespace CRMWinApp.UserControls
{
    partial class MeetingRight
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outsiderNameTB = new System.Windows.Forms.TextBox();
            this.outsiderSurnameTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.relationTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outsiderAgeTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outsider Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Outsider Surname";
            // 
            // outsiderNameTB
            // 
            this.outsiderNameTB.Enabled = false;
            this.outsiderNameTB.Location = new System.Drawing.Point(160, 56);
            this.outsiderNameTB.Name = "outsiderNameTB";
            this.outsiderNameTB.Size = new System.Drawing.Size(200, 20);
            this.outsiderNameTB.TabIndex = 2;
            // 
            // outsiderSurnameTB
            // 
            this.outsiderSurnameTB.Enabled = false;
            this.outsiderSurnameTB.Location = new System.Drawing.Point(160, 87);
            this.outsiderSurnameTB.Name = "outsiderSurnameTB";
            this.outsiderSurnameTB.Size = new System.Drawing.Size(200, 20);
            this.outsiderSurnameTB.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Meeting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Relation";
            // 
            // relationTB
            // 
            this.relationTB.Enabled = false;
            this.relationTB.Location = new System.Drawing.Point(160, 165);
            this.relationTB.Name = "relationTB";
            this.relationTB.Size = new System.Drawing.Size(200, 20);
            this.relationTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Outsider Age";
            // 
            // outsiderAgeTB
            // 
            this.outsiderAgeTB.Enabled = false;
            this.outsiderAgeTB.Location = new System.Drawing.Point(160, 113);
            this.outsiderAgeTB.Name = "outsiderAgeTB";
            this.outsiderAgeTB.Size = new System.Drawing.Size(200, 20);
            this.outsiderAgeTB.TabIndex = 9;
            // 
            // MeetingRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outsiderAgeTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.relationTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.outsiderSurnameTB);
            this.Controls.Add(this.outsiderNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MeetingRight";
            this.Size = new System.Drawing.Size(460, 284);
            this.Load += new System.EventHandler(this.MeetingRight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outsiderNameTB;
        private System.Windows.Forms.TextBox outsiderSurnameTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox relationTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outsiderAgeTB;
    }
}
