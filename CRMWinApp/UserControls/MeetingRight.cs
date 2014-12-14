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
    public partial class MeetingRight :UserControl
    {
        private Meeting _meeting;

        public void SetMeeting( Meeting m )
        {
            _meeting = m;
        }
        public MeetingRight()
        {
            InitializeComponent();
        }

        private void MeetingRight_Load(object sender, EventArgs e)
        {
            if( _meeting != null )
            {
                outsiderNameTB.Text = _meeting.Outsider.Name;
                outsiderSurnameTB.Text = _meeting.Outsider.Surname;
                outsiderAgeTB.Text = _meeting.Outsider.Age.ToString();
                dateTimePicker1.Value  = _meeting.Date;
                relationTB.Text = _meeting.Outsider.Relation;
            }
        }
    }
}
