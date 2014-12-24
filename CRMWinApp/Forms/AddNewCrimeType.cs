using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMWinApp.Forms
{
    public partial class AddNewCrimeType : Form
    {
        private CRMDataModel context = new CRMDataModel();

        public delegate void TypeAddedDelegate();
        public TypeAddedDelegate TypeAddedEvent;
        public AddNewCrimeType()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Models.CrimeType ct = new Models.CrimeType();
            ct.Name = nameTB.Text;

            try
            {
                context.CrimeTypes.Add(ct);
                context.SaveChanges();
                MessageBox.Show("Crime type added succesfully.");
                TypeAddedEvent();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
