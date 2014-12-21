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
    public partial class FindAtt : Form
    {
        private CRMDataModel context = new CRMDataModel();

        public delegate void SendAttorneyBackDel(Models.Attorney a);
        public SendAttorneyBackDel PassAttorney;

        private Models.Attorney selectedAttorney;
        public FindAtt()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var r = context.Attorneys.Where(x => x.Name.Contains(nameTB.Text) || x.Surname.Contains(surnameTB.Text)).ToList();

            for( int i=0; i < r.Count;++i)
            {
                attL.DataSource = r;
            }
        }

        private void attL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Attorney selected = attL.SelectedItem as Models.Attorney;

            if( selected != null )
            {

                selectedAttorney = selected;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedAttorney != null)
            {
                PassAttorney(selectedAttorney);
                this.Hide();
            }
        }
    }
}
