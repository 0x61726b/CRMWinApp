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
    public partial class RegisterCriminal :UserControl
    {
        public delegate void PassUser( Criminal c );
        public PassUser passControl;

        CRMDataModel context = new CRMDataModel();
        public RegisterCriminal()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Criminal newCriminal = new Criminal();

            if (CheckIfEmpty(nameTB))
                return;
            newCriminal.Name = nameTB.Text;

            if (CheckIfEmpty(surnameTB))
                return;
            newCriminal.Surname = surnameTB.Text;

            if (CheckIfEmpty(heightTB))
                return;
            newCriminal.Height = Int32.Parse(heightTB.Text);

            if (CheckIfEmpty(weightTB))
                return;
            newCriminal.Weight = Int32.Parse(weightTB.Text);

            newCriminal.Gender = genderCB.SelectedItem.ToString();

            if (CheckIfEmpty(hairColorTB))
                return;
            newCriminal.HairColor = (hairColorTB.Text);

            if (CheckIfEmpty(raceTB))
                return;
            newCriminal.Race = (raceTB.Text);

            if (CheckIfEmpty(countryTB))
                return;
            newCriminal.Country = (countryTB.Text);

            if (CheckIfEmpty(stateTB))
                return;
            newCriminal.State = (stateTB.Text);

            newCriminal.CustodyStart = custodyStartDT.Value;
            newCriminal.CustodyEnd = custodyEndDT.Value;

            context.Criminals.Add(newCriminal);

            try
            {
                context.SaveChanges();
                MessageBox.Show("Criminal Added succesfully.");

                if( passControl != null )
                    passControl( newCriminal );
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
                ShowMsg();
                return true;
            }
            return false;
        }
        void ShowMsg()
        {
            MessageBox.Show("Please FILL IN THE BLANKS.");
        }
    }
}
