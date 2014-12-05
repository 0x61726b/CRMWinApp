using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMWinApp.UserControls
{
    public partial class EditCriminal : UserControl
    {
        private Models.Criminal selectedCriminal;
        public EditCriminal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditCriminal_Load(object sender, EventArgs e)
        {
            if( selectedCriminal != null )
            {
                nameTB.Text = selectedCriminal.Name;
                surnameTB.Text = selectedCriminal.Surname;
                hairColorTB.Text = selectedCriminal.HairColor;
                raceTB.Text = selectedCriminal.Race;
                heightTB.Text = selectedCriminal.Height.ToString();
                weightTB.Text = selectedCriminal.Weight.ToString();
                genderCB.SelectedItem = selectedCriminal.Gender;

                countryTB.Text = selectedCriminal.Country;
                stateTB.Text = selectedCriminal.State;
                custodyStartDT.Value = selectedCriminal.CustodyStart;
                custodyEndDT.Value = selectedCriminal.CustodyEnd;
            }
            else
            {
                MessageBox.Show("Invalid Criminal.");
            }
        }
    }
}
