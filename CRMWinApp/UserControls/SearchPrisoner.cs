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
    public partial class SearchPrisoner :UserControl
    {
        CRMDataModel context = new CRMDataModel();
        List<Criminal> criminalList = new List<Criminal>();

        public delegate void PassCriminalDel( Models.Criminal criminal );
        public PassCriminalDel PassCriminal;


        public SearchPrisoner()
        {
            InitializeComponent();
        }

        private void SearchPrisoner_Load(object sender, EventArgs e)
        {

        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            Criminal newCriminal = new Criminal();


            newCriminal.Name = nameTB.Text;


            newCriminal.Surname = surnameTB.Text;

            if( heightTB.Text == String.Empty )
                newCriminal.Height = 0;
            else
                newCriminal.Height = Int32.Parse(heightTB.Text);

            if( weightTB.Text == String.Empty )
                newCriminal.Weight = 0;
            else
                newCriminal.Weight = Int32.Parse(weightTB.Text);

            newCriminal.Gender = genderCB.SelectedItem.ToString();

         
            newCriminal.HairColor = (hairColorTB.Text);

       
            newCriminal.Race = (raceTB.Text);

        
            newCriminal.Country = (countryTB.Text);

   
            newCriminal.State = (stateTB.Text);

            try
            {
                var result = context.Criminals.Where(
                                        x => x.Name == newCriminal.Name ||
                                             x.Surname == newCriminal.Surname ||
                                             x.Height == newCriminal.Height ||
                                             x.Weight == newCriminal.Weight ||
                                             x.Gender == newCriminal.Gender ||
                                             x.HairColor == newCriminal.HairColor ||
                                             x.Race == newCriminal.Race ||
                                             x.Country == newCriminal.Country ||
                                             x.State == newCriminal.State
                                        );

                criminalList = result.ToList();
                dataGridView1.DataSource = criminalList;
                int lul = 5;
            }
            catch( Exception ex )
            {
                MessageBox.Show("BAE ERROR SWAG " + ex.Message );
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Criminal selectedCriminal = criminalList[e.RowIndex];

            if( selectedCriminal != null )
            {
                PassCriminal(selectedCriminal);
            }
        }
    }
}
