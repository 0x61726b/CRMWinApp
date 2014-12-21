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
using System.IO;
using CRMWinApp.Rendering;


namespace CRMWinApp
{


    public partial class MainForm : Form
    {
        private CRMDataModel context = new CRMDataModel();

        private RenderUC renderUC;
        private bool isRenderingStarted = false;

        List<Control> lastControls = new List<Control>();
        private Cell selectedCell;
        private Box selectedBox;

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

            ClearPanel();
            renderUC = new RenderUC();
            renderUC.Width = MidPanel.Width;
            renderUC.Height = MidPanel.Height;
            renderUC.ClientWidth = MidPanel.Width;
            renderUC.ClientHeight = MidPanel.Height;
            renderUC.OnCellClicked = new RenderUC.OnCellClickedDelegate(OnCellClickedEvent);
            MidPanel.Controls.Add(renderUC);

            isRenderingStarted = true;
        }
        private void UpdateStatistics()
        {
            int criminalCount = context.Criminals.Count();

            criminalCountLbl.Text = "Criminal Count " + criminalCount;

            int arrestCount = context.Arrests.Count();

            arrestCountLbl.Text = "Arrest Count " + arrestCount;

            int chargesCount = context.Charges.Where(x => x.Date.Day == DateTime.Today.Day).Count();

            chargeCountLbl.Text = "Charges Today: " + chargesCount;
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
            ucf.SetCriminal(c);

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
            panel3.Visible = false;
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
            renderUC.OnCellClicked = new RenderUC.OnCellClickedDelegate(OnCellClickedEvent);
            MidPanel.Controls.Add(renderUC);

            isRenderingStarted = true;
            PostClearPanel();
        }
        void ClearCriminalCellInfo()
        {
            if (criminalPicture.Image != null)
                criminalPicture.Image = null;
            criminalListLB.DataSource = null;
            searchSurnameTxt.Text = "";
            searchNameTxt.Text = "";
            nameLBL.Text = "";
            surnameLBL.Text = "";
        }
        void OnCellClickedEvent(Rendering.Box b)
        {
            panel3.Visible = true;

            ClearCriminalCellInfo();

            selectedCell = b.Cell;
            selectedBox = b;


            UpdateCriminalCellInfo();

        }
        void UpdateCriminalCellInfo()
        {
            if (selectedCell != null)
            {
                cellNoLBL.Text = selectedCell.Number;
                if (selectedCell.Status)
                    statusLBL.Text = "Occupied.";
                else
                    statusLBL.Text = "Empty.";
                nameLBL.Enabled = true;
                surnameLBL.Enabled = true;

                if (selectedCell.Criminal != null)
                {
                    nameLBL.Text = selectedCell.Criminal.Name;
                    surnameLBL.Text = selectedCell.Criminal.Surname;
                    criminalPicture.Image = ByteToImage(selectedCell.Criminal.PictureFront);
                }
            }
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                criminalListLB.DataSource = null;
                var crList = context.Criminals.Where(x => x.Name.Contains(searchNameTxt.Text) || x.Surname.Contains(searchSurnameTxt.Text)).ToList();

                if (crList.Count == 1)
                {
                    if (selectedCell != null)
                    {
                        selectedCell.Criminal = crList[0];
                        UpdateCriminalCellInfo();
                        transferBtn.Enabled = true;
                    }
                }
                for (int i = 0; i < crList.Count(); ++i)
                {
                    criminalListLB.DataSource = crList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void criminalListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criminal selected = criminalListLB.SelectedItem as Criminal;

            if (selected != null && selectedCell != null)
            {
                selectedCell.Criminal = selected;
                transferBtn.Enabled = true;
                UpdateCriminalCellInfo();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCell != null)
            {
                if (MessageBox.Show("Are you sure you want to transfer " + selectedCell.Criminal.Name + " to " + selectedCell.Number + " ?", "Transferring criminal", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    var cell = context.Cells.Where(x => x.Id == selectedCell.Id).FirstOrDefault();
                    selectedCell.Status = true;

                    cell.Criminal = selectedCell.Criminal;

                    var previousCell = context.Cells.Where(x => x.Criminal.Id == selectedCell.Criminal.Id).FirstOrDefault();
                    var newCell = previousCell;


                    try
                    {
                        context.Entry(cell).CurrentValues.SetValues(selectedCell);
                        
                        if (previousCell != null)
                        {
                            newCell.Criminal = null;
                            newCell.Status = false;
                            context.Entry(previousCell).CurrentValues.SetValues(newCell);
                        }

                        context.SaveChanges();
                        renderUC.UpdatePictures();
                    }
                    catch( Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    UpdateCriminalCellInfo();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            renderUC.UpdatePictures();
        }

        private void addAttorney_Click(object sender, EventArgs e)
        {
            ClearPanel();

            AddAttorney aa = new AddAttorney();
            aa.Dock = DockStyle.Fill;
            MidPanel.Controls.Add(aa);
        }

        private void registerCrime_Click(object sender, EventArgs e)
        {
            ClearPanel();
            RegisterCrime rc = new RegisterCrime();
            rc.User = cLoggedUser;
            rc.Dock = DockStyle.Fill;
            rc.EventCrimeRegistered = new RegisterCrime.CrimeRegisteredDelegate(EventCrimeRegistered);
            MidPanel.Controls.Add(rc);
        }
        private void EventCrimeRegistered()
        {
            UpdateStatistics();
        }

    }
}
