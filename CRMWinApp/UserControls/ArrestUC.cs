using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMWinApp.Models;

namespace CRMWinApp.UserControls
{
    public partial class ArrestUC :UserControl
    {
        private Arrest _arrest;

        public ArrestUC()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) //Personal Info
            {
                if (_arrest != null)
                    editCriminal1.SetCriminal(_arrest.Criminal);
            }
        }

        private void ArrestUC_Load(object sender, EventArgs e)
        {
            this.editCriminal1 = new CRMWinApp.UserControls.EditCriminal();

            if (_arrest != null)
                editCriminal1.SetCriminal(_arrest.Criminal);
            editCriminal1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add( editCriminal1 );
        }

        public void SetArrestData(Arrest a)
        {
            _arrest = a;
        }

        private void editCriminal1_Load(object sender, EventArgs e)
        {
             if (_arrest != null)
                editCriminal1.SetCriminal(_arrest.Criminal);
        }
    }
}
