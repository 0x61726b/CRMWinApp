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
    public partial class MeetingItem :UserControl
    {
        private Criminal _cr;

        public delegate void SelectionIndexChanged(Meeting m);
        public SelectionIndexChanged PassMeeting;
        public void SetMeeting(Criminal m)
        {
            _cr = m;
        }
        public MeetingItem()
        {
            InitializeComponent();
        }

        private void MeetingItem_Load(object sender, EventArgs e)
        {
            if (_cr != null)
            {
                var meetings = _cr.Meetings.ToList();
                if (meetings == null || meetings.Count == 0)
                {
                    MessageBox.Show("No records found.");
                }
                else
                {
                    for (int i = 0; i < meetings.Count; ++i)
                    {
                        Meeting m = meetings[i];

                        System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            _cr.Name,
            m.Outsider.Name,
            m.Date.ToShortDateString(),
            m.Location,m.Id.ToString()}, -1);
                        listView1.Items.Add(listViewItem1);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; ++i)
            {
                ListViewItem lvi = listView1.SelectedItems[i];
                string id = lvi.SubItems[4].Text;


                Meeting m = _cr.Meetings.Where(x => x.Id == Int32.Parse(id)).SingleOrDefault();
                PassMeeting(m);


            }


        }

        public void SearchByDate(DateTime date, DateTime date2)
        {

            var results = _cr.Meetings.Where(x => x.Date >= date && x.Date < date2).ToList();
            listView1.Items.Clear();

            for (int i = 0; i < results.Count(); ++i)
            {
                Meeting m = results[i];

                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            _cr.Name,
            m.Outsider.Name,
            m.Date.ToShortDateString(),
            m.Location,m.Id.ToString()}, -1);
                listView1.Items.Add(listViewItem1);
            }


        }
    }
}
