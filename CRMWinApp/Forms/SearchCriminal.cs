using CRMWinApp.UserControls;
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
    public partial class SearchCriminal : Form
    {
        public delegate void PassCriminalDel(Models.Criminal c);
        public PassCriminalDel PassCriminal;
        public SearchCriminal()
        {
            InitializeComponent();
        }

        private void SearchCriminal_Load(object sender, EventArgs e)
        {
            SearchPrisoner sp = new SearchPrisoner();
            sp.Dock = DockStyle.Fill;
            sp.PassCriminal = new SearchPrisoner.PassCriminalDel(SendCriminalInfo);
            this.Controls.Add(sp);


        }
        void SendCriminalInfo( Models.Criminal c)
        {
            if (c != null)
            {

                PassCriminal(c);
                this.Hide();
            }
        }
    }
}
