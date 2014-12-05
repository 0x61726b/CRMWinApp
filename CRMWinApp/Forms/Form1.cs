using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMWinApp.Forms;
using CRMWinApp.UserControls;


namespace CRMWinApp
{
    enum UserType
    {
        JailSuperIntendent = 1,
        PoliceOfficer = 2,
        CBIOfficer = 3,
        Administrator = 4,
        Judge = 5
    }
    public partial class MainForm :Form
    {
        CRMDataModel context = new CRMDataModel();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userTsLabel.Text = "Welcum frend," + cLoggedUser.Name;

            if (cLoggedUser.AuthLevel == (int)UserType.JailSuperIntendent)
            {
                userTsType.Text = "User Type: Jail Superintendent";
            }
            //int s = context.Users.Count();
            //MessageBox.Show(s.ToString());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPermissions upf = new UserPermissions();

            var permList = context.AuthLevel_Permissions.Where(x => x.AuthLevel == cLoggedUser.AuthLevel);

            if (permList != null)
            {
                List<Models.AuthLevel_Permission> permissionList;
                permissionList = (List<Models.AuthLevel_Permission>)permList.ToList();

                List<Models.Permission> permisList = new List<Models.Permission>();

                for (int i = 0; i < permissionList.Count; ++i)
                {
                    permisList.Add(permissionList[i].Permission);
                }
                upf.SetPermissions(permisList);
                upf.Show();
            }

        }
        private void OnNewCriminalRegistered(Models.Criminal c)
        {
            ClearPanel();
            EditCriminal edc = new EditCriminal();
            edc.Dock = DockStyle.Fill;
            edc.SetCriminal(c);
            MidPanel.Controls.Add(edc);
        }
        private void OnCriminalListClicked(Models.Criminal c)
        {
            ClearPanel();
            ArrestUC ucf = new ArrestUC();
            ucf.Dock = DockStyle.Fill;

            //TO FUCKING DO -> MAKE IT SO THAT THIS RETURNS ONLY THE LAST ARREST
            var arrestData = context.Arrests.Where(x => x.Criminal.Id == c.Id);

            if (arrestData.Count() == 0 || arrestData == null)
            {
                Models.Arrest a = new Models.Arrest();
                a.Criminal = c;
                ucf.SetArrestData(a);
            }
            else
            {
                if (arrestData.Count() != 0)
                {
                    Models.Arrest a = arrestData.SingleOrDefault();
                    ucf.SetArrestData(a);
                }
            }
            MidPanel.Controls.Add(ucf);
        }
        private void UserGreetingLbl_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterCriminal_Click(object sender, EventArgs e)
        {
            ClearPanel();

            RegisterCriminal rc = new RegisterCriminal();
            rc.Dock = DockStyle.Fill;
            rc.passControl = new UserControls.RegisterCriminal.PassUser(OnNewCriminalRegistered);
            MidPanel.Controls.Add(rc);
        }
        void ClearPanel()
        {
            MidPanel.Controls.Clear();
        }

        private void RegisterNewCrime_Click(object sender, EventArgs e)
        {
            ClearPanel();
        }

        private void EditCriminalButton_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CriminalList edc = new CriminalList();
            edc.Dock = DockStyle.Fill;
            edc.PassCriminal = new CriminalList.PassCriminalDel(OnCriminalListClicked);
            MidPanel.Controls.Add(edc);
        }

        private void CriminalListButton_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CriminalList edc = new CriminalList();
            edc.PassCriminal = new CriminalList.PassCriminalDel(OnCriminalListClicked);
            edc.Dock = DockStyle.Fill;

            MidPanel.Controls.Add(edc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearPanel();
            SearchPrisoner sc = new SearchPrisoner();
            sc.PassCriminal = new SearchPrisoner.PassCriminalDel(OnCriminalListClicked);
            sc.Dock = DockStyle.Fill;

            MidPanel.Controls.Add( sc );
        }
    }
}
