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
    public partial class EditCriminal :UserControl, IUserPermissionDisable
    {
        private Models.Criminal selectedCriminal;


        CRMDataModel context = new CRMDataModel();
        public EditCriminal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditCriminal_Load(object sender, EventArgs e)
        {
            if (selectedCriminal != null)
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
        void DisableControls(bool t)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = t;
            }
        }

        public void Disable(List<Permission> permissions)
        {
            DisableControls(false);
            foreach (Permission p in permissions)
            {
                if( p.Name == "CAN_UPDATE_CRIMINAL_CRIME" )
                {
                    DisableControls(true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty(nameTB))
                return;
            selectedCriminal.Name = nameTB.Text;

            if (CheckIfEmpty(surnameTB))
                return;
            selectedCriminal.Surname = surnameTB.Text;

            if (CheckIfEmpty(heightTB))
                return;
            selectedCriminal.Height = Int32.Parse(heightTB.Text);

            if (CheckIfEmpty(weightTB))
                return;
            selectedCriminal.Weight = Int32.Parse(weightTB.Text);

            selectedCriminal.Gender = genderCB.SelectedItem.ToString();

            if (CheckIfEmpty(hairColorTB))
                return;
            selectedCriminal.HairColor = (hairColorTB.Text);

            if (CheckIfEmpty(raceTB))
                return;
            selectedCriminal.Race = (raceTB.Text);

            if (CheckIfEmpty(countryTB))
                return;
            selectedCriminal.Country = (countryTB.Text);

            if (CheckIfEmpty(stateTB))
                return;
            selectedCriminal.State = (stateTB.Text);

            selectedCriminal.CustodyStart = custodyStartDT.Value;
            selectedCriminal.CustodyEnd = custodyEndDT.Value;

            
            try
            {
                
                context.Entry( context.Criminals.Where( x => x.Id == selectedCriminal.Id ).FirstOrDefault() ).CurrentValues.SetValues( selectedCriminal );


                context.SaveChanges();
                MessageBox.Show("Criminal Updated succesfully.");

               
            }
            catch( Exception ex )
            {
                MessageBox.Show("U SCREWED UP LULZ " + ex.Message);
            }
        }
         bool CheckIfEmpty(TextBox tb)
        {
            if (tb.Text == String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
