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
    public partial class ArrestUC :UserControl, IUserPermissionDisable
    {
        private List<Arrest> _arrests;
        private Criminal criminal;
        private Arrest selectedArrest;

        public delegate void ControlUpdateDel(UserControl uc);
        public ControlUpdateDel PassControl;

        CRMDataModel context = new CRMDataModel();
        public ArrestUC()
        {
            InitializeComponent();
        }
        public void SetCriminal(Criminal c)
        {
            criminal = c;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) //Personal Info
            {
                editCriminal1.SetCriminal(criminal);
            }
            else if (tabControl1.SelectedIndex == 1) //Arrest Info
            {
                arrestListView.Items.Clear(); //Not working
                if (_arrests == null)
                {
                    MessageBox.Show("No arrest found for this criminale.");
                    MakeEverythingDisabled(1);
                }
                else
                {


                    for (int i = 0; i < _arrests.Count; ++i)
                    {
                        ListViewItem lvi = new ListViewItem(new string[]
                        {
                            _arrests[i].Type.Name,
                            _arrests[i].Location,
                            _arrests[i].Date.ToShortDateString(),
                            _arrests[i].Id.ToString()
                        }, -1);
                        arrestListView.Items.Add(lvi);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                var charges = context.Charges.Where(x => x.Against.Id == criminal.Id);

                if (charges != null)
                {
                    if (charges.Count() > 0)
                    {
                        List<Charge> chargeList = new List<Charge>();
                        chargeList = charges.ToList();
                        for (int i = 0; i < charges.Count(); ++i)
                        {
                            ChargeUC cuc = new ChargeUC();
                            cuc.SetCharge(chargeList[i]);
                            cuc.Dock = DockStyle.Top;
                            chargesPanel.Controls.Add(cuc);


                        }



                    }
                    else
                    {
                        MessageBox.Show("This criminale has not been charged.");
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                this.meetingItem1.PassMeeting = new MeetingItem.SelectionIndexChanged(MeetingLeftChanged);
            }
        }
        private void MeetingLeftChanged(Meeting m)
        {
            meetingPanel.Controls.Clear();
            MeetingRight mr = new MeetingRight();


            mr.SetMeeting(m);

            meetingPanel.Controls.Add(mr);
        }
        private void MakeEverythingDisabled(int tabIndex)
        {
            foreach (Control c in tabControl1.TabPages[tabIndex].Controls)
            {
                c.Enabled = false;
            }
        }
        private void ArrestUC_Load(object sender, EventArgs e)
        {
            this.editCriminal1 = new CRMWinApp.UserControls.EditCriminal();

            nameLBL.Text = criminal.Name;
            surnameLBL.Text = criminal.Surname;

            editCriminal1.SetCriminal(criminal);
            editCriminal1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add(editCriminal1);

            meetingItem1.SetMeeting(criminal);
        }

        public void SetArrestData(List<Arrest> a)
        {
            _arrests = a;
        }

        private void editCriminal1_Load(object sender, EventArgs e)
        {
            editCriminal1.SetCriminal(criminal);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meetingItem1.SearchByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        public void Disable(List<Permission> permissions)
        {
            editCriminal1.Disable(permissions);

            foreach (Permission p in permissions)
            {
                if (p.Name == "CAN_UPDATE_CRIMINAL_CRIME")
                {
                    arrestInfoGroupBox.Enabled = true;
                    chargesGroupBox.Enabled = true;
                }
                if (p.Name == "CAN_CRUD_RECORDS_WORKS")
                {
                    groupBox2.Enabled = true;
                }

            }

        }

        private void arrestListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            crimeTypeCB.Items.Clear();
            var typeList = context.CrimeTypes.ToList();
            for( int i=0; i < typeList.Count; ++i )
            {
                crimeTypeCB.Items.Add( typeList[i].Name );
            }

            agencyCB.Items.Clear();
            var agencyList = context.Agencies.ToList();
            for( int i = 0; i < agencyList.Count; ++i )
            {
                agencyCB.Items.Add( agencyList[i].Name );
            }

            for (int i = 0; i < arrestListView.SelectedItems.Count; ++i)
            {
                string id = arrestListView.SelectedItems[0].SubItems[3].Text;
                int iId = Int32.Parse(id);
                Arrest arrest = context.Arrests.Where(a => a.Id == iId).FirstOrDefault();

                if (arrest != null)
                {
                    selectedArrest = arrest;

                    crimeTypeCB.SelectedItem = arrest.Type.Name;
                    locationTB.Text = arrest.Location;
                    arrestDateDT.Value = arrest.Date;
                    informationTB.Text = arrest.Description;

                    

                    agencyCB.SelectedItem = arrest.Agency.Name;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Arrest newArrest = selectedArrest;
            newArrest.Location = locationTB.Text;
            newArrest.Date = arrestDateDT.Value;
            newArrest.Description = informationTB.Text;
            newArrest.Agency.Name = agencyCB.SelectedItem.ToString();

            var newType = context.CrimeTypes.Where( x => x.Name == crimeTypeCB.SelectedItem.ToString() ).FirstOrDefault();
            newArrest.Type = newType;

            try
            {
                context.Entry(selectedArrest).CurrentValues.SetValues(newArrest);
                context.SaveChanges();
                MessageBox.Show("Information updated.");
                tabControl1_SelectedIndexChanged(this,null);
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }
    }
}
