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
using CRMWinApp.Models;


namespace CRMWinApp
{


    public partial class MainForm :Form
    {
        private CRMDataModel context = new CRMDataModel();

        private RenderUC renderUC;
        private bool isRenderingStarted = false;

        List<Control> lastControls = new List<Control>();

        private List<Permission> userPermissionList = new List<Permission>();
        public MainForm()
        {
            InitializeComponent();
        }

        void UpdateLatestControls(Control control)
        {
            if (control != null)
                lastControls.Add(control);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            userTsLabel.Text = "Welcum frend," + cLoggedUser.Name;

            if (cLoggedUser.AuthLevel == (int)UserType.JailSuperIntendent)
            {
                userTsType.Text = "User Type: Jail Superintendent";
            }
            if (cLoggedUser.AuthLevel == (int)UserType.PoliceOfficer)
            {
                userTsType.Text = "User Type: Police Officer";
            }
            if (cLoggedUser.AuthLevel == (int)UserType.CBIOfficer)
            {
                userTsType.Text = "User Type: CBIOfficer";
            }
            if (cLoggedUser.AuthLevel == (int)UserType.Judge)
            {
                userTsType.Text = "User Type: Judge";
            }
            if (cLoggedUser.AuthLevel == (int)UserType.Administrator)
            {
                userTsType.Text = "User Type: Administrator";

                adminPanel.Visible = true;
                adminPanel.Enabled = true;
            }

            int criminalCount = context.Criminals.Count();

            criminalCountLbl.Text = "Criminal Count " + criminalCount;

            int arrestCount = context.Arrests.Count();

            arrestCountLbl.Text = "Arrest Count " + arrestCount;

            int chargesCount = context.Charges.Where(x => x.Date.Day == DateTime.Today.Day).Count();

            chargeCountLbl.Text = "Charges Today: " + chargesCount;

            var permList = context.AuthLevel_Permissions.Where(x => x.AuthLevel == cLoggedUser.AuthLevel).ToList();
            foreach (var p in permList)
            {
                userPermissionList.Add(p.Permission);
            }

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
            edc.Disable(userPermissionList);
            edc.Dock = DockStyle.Fill;
            edc.SetCriminal(c);
            MidPanel.Controls.Add(edc);
        }
        private void OnCriminalListClicked(Models.Criminal c)
        {
            ClearPanel();
            ArrestUC ucf = new ArrestUC();
            ucf.Dock = DockStyle.Fill;
            ucf.SetCriminal( c );

            //TO FUCKING DO -> MAKE IT SO THAT THIS RETURNS ONLY THE LAST ARREST
            var arrestData = context.Arrests.Where(x => x.Criminal.Id == c.Id);



            if (arrestData.Count() != 0)
            {
                List<Models.Arrest> a = arrestData.ToList();
                ucf.SetArrestData(a);
            }

            MidPanel.Controls.Add(ucf);

            PostClearPanel();
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
            if (MidPanel.Controls.Count > 0)
                UpdateLatestControls(MidPanel.Controls[MidPanel.Controls.Count - 1]);

            ClearPanel();



            RegisterCriminal rc = new RegisterCriminal();
            rc.Dock = DockStyle.Fill;
            rc.passControl = new UserControls.RegisterCriminal.PassUser(OnNewCriminalRegistered);
            rc.PassControl = new UserControls.RegisterCriminal.ControlUpdateDel(UpdateLatestControls);
            MidPanel.Controls.Add(rc);

            PostClearPanel();
        }
        void ClearPanel()
        {
            MidPanel.Controls.Clear();
        }
        void PostClearPanel()
        {
            foreach (Control c in this.MidPanel.Controls)
            {
                if (c is IUserPermissionDisable)
                {
                    IUserPermissionDisable x = c as IUserPermissionDisable;
                    x.Disable(userPermissionList);
                }
            }
        }
        private void RegisterNewCrime_Click(object sender, EventArgs e)
        {
            ClearPanel();
            PostClearPanel();
        }

        private void EditCriminalButton_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CriminalList edc = new CriminalList();
            edc.Dock = DockStyle.Fill;
            edc.PassCriminal = new CriminalList.PassCriminalDel(OnCriminalListClicked);
            MidPanel.Controls.Add(edc);
            PostClearPanel();
        }

        private void CriminalListButton_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CriminalList edc = new CriminalList();
            edc.PassCriminal = new CriminalList.PassCriminalDel(OnCriminalListClicked);
            edc.PassControl = new CriminalList.ControlUpdateDel(UpdateLatestControls);
            edc.Dock = DockStyle.Fill;

            MidPanel.Controls.Add(edc);
            PostClearPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MidPanel.Controls.Count > 0)
                UpdateLatestControls(MidPanel.Controls[MidPanel.Controls.Count - 1]);
            ClearPanel();
            SearchPrisoner sc = new SearchPrisoner();
            sc.PassCriminal = new SearchPrisoner.PassCriminalDel(OnCriminalListClicked);
            sc.PassControl = new SearchPrisoner.ControlUpdateDel(UpdateLatestControls);
            sc.Dock = DockStyle.Fill;

            MidPanel.Controls.Add(sc);
            PostClearPanel();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (lastControls.Count > 0)
            {
                ClearPanel();
                MidPanel.Controls.Add(lastControls.Last());
                PostClearPanel();
            }
        }

        public void Render()
        {
            if (isRenderingStarted)
                renderUC.Render();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            ClearPanel();


            renderUC = new RenderUC();
            renderUC.Width = MidPanel.Width;
            renderUC.Height = MidPanel.Height;
            renderUC.ClientWidth = MidPanel.Width;
            renderUC.ClientHeight = MidPanel.Height;
            MidPanel.Controls.Add(renderUC);

            isRenderingStarted = true;
            PostClearPanel();
        }
        void AddToLatestControlList(Control c)
        {
            if (MidPanel.Controls.Count > 0)
                UpdateLatestControls(MidPanel.Controls[MidPanel.Controls.Count - 1]);
            else
                UpdateLatestControls(c);
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            if (MidPanel.Controls.Count > 0)
                UpdateLatestControls(MidPanel.Controls[MidPanel.Controls.Count - 1]);

            ClearPanel();

            ManageUsersUC muc = new ManageUsersUC();
            muc.Dock = DockStyle.Fill;
            MidPanel.Controls.Add(muc);
        }

    }
}
