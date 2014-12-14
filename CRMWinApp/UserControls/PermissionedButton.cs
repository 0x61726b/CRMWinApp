using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMWinApp.UserControls
{
    public partial class PermissionedButton :UserControl
    {
        private string buttonName;

        public string ButtonName
        {
            get { return buttonName; }
            set { buttonName = value; button1.Text = buttonName;}
        }
        
        public PermissionedButton()
        {
            InitializeComponent();
        }
    }
}
