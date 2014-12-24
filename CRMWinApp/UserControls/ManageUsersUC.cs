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
    public partial class ManageUsersUC :UserControl
    {
        CRMDataModel context = new CRMDataModel();
        private User selectedUser;
        public ManageUsersUC()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; ++i)
            {
                ListViewItem lvi = listView1.SelectedItems[i];
                string id = lvi.SubItems[0].Text;
                int iId = Int32.Parse(id);

                var user = context.Users.Where(x => x.Id == iId).SingleOrDefault();

                userNameTB.Text = user.Name;
                passTB.Text = user.Pass;
                selectedUser = user;

            }
        }

        private void ManageUsersUC_Load(object sender, EventArgs e)
        {
            var permList = context.Permissions.ToList();

            foreach (var p in permList)
            {
                permissionList.Items.Add(p.Name);
            }

            //

            var userList = context.Users.ToList();

            foreach (var u in userList)
            {
                ListViewItem lvi = new ListViewItem(new string[] 
                {
                    u.Id.ToString(),
                    u.Name,
                    u.AuthLevel.ToString(),
                }, -1);
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = context.Permissions.Where( x => x.Name == permissionList.SelectedItem.ToString() ).FirstOrDefault();

            try
            {
                AuthLevel_Permission ap = new AuthLevel_Permission();
                ap.AuthLevel = selectedUser.AuthLevel;
                ap.Permission = p;
                context.AuthLevel_Permissions.Add(ap);
                context.SaveChanges();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
