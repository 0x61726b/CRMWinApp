using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMWinApp.Forms
{
    public partial class UserPermissions : Form
    {
        public UserPermissions()
        {
            InitializeComponent();
        }

        private void UserPermissions_Load(object sender, EventArgs e)
        {
            for( int i=0; i < cPermissionList.Count; ++i )
            {
                listBox1.Items.Add( cPermissionList[i].Name );
            }
        }
    }
}
