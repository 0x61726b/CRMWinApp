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
            this.ChargesTab = new System.Windows.Forms.TabPage();
            
            this.tabControl1.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
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
            this.ArrestInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ArrestInfoTab.Name = "ArrestInfoTab";
            this.ArrestInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArrestInfoTab.Size = new System.Drawing.Size(944, 614);
            this.ArrestInfoTab.TabIndex = 1;
            this.ArrestInfoTab.Text = "Arrest Information";
            this.ArrestInfoTab.UseVisualStyleBackColor = true;
            // 
            // ChargesTab
            // 
            this.ChargesTab.Location = new System.Drawing.Point(4, 22);
            this.ChargesTab.Name = "ChargesTab";
            this.ChargesTab.Size = new System.Drawing.Size(944, 614);
            this.ChargesTab.TabIndex = 2;
            this.ChargesTab.Text = "Charges";
            this.ChargesTab.UseVisualStyleBackColor = true;
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
            this.personalInfoTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage ArrestInfoTab;
        private System.Windows.Forms.TabPage ChargesTab;
        private EditCriminal editCriminal1;
    }
}
