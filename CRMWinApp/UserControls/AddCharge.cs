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
    public partial class AddCharge : UserControl
    {
        private Criminal cr;
        private CRMDataModel context = new CRMDataModel();

        public delegate void AddClickedDelegate(Criminal c);
        public AddClickedDelegate EventAddClicked;

        public AddCharge()
        {
            InitializeComponent();
        }
        public void SetCriminal( Models.Criminal c )
        {
            cr = c;
        }

        private void AddCharge_Load(object sender, EventArgs e)
        {
            var types = context.CiteTypes.ToList();

            for( int i=0; i < types.Count;++i)
            {
                comboBox1.Items.Add(types[i].Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventAddClicked(cr);

            Charge c = new Charge();
            var criminal = context.Criminals.Where(x => x.Id == cr.Id).FirstOrDefault();
            c.Against = criminal;
            Cite cite = new Cite();

            var t = context.CiteTypes.Where(x => x.Name == (string)comboBox1.SelectedItem).FirstOrDefault();
            cite.Type = t;
            cite.Note = richTextBox1.Text;
            c.Cite = cite;
            c.Date = DateTime.Now;
            
            try
            {
                context.Charges.Add(c);
                context.SaveChanges();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
