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
using CRMWinApp.Globals;

namespace CRMWinApp.UserControls
{
    
    public partial class SearchPrisoner : UserControl,IUserPermissionDisable
    {
        CRMDataModel context = new CRMDataModel();
        List<Criminal> criminalList = new List<Criminal>();

        public delegate void PassCriminalDel(Models.Criminal criminal);
        public PassCriminalDel PassCriminal;

        public delegate void ControlUpdateDel( UserControl uc);
        public ControlUpdateDel PassControl;


        public SearchPrisoner()
        {
            InitializeComponent();
        }

        private void SearchPrisoner_Load(object sender, EventArgs e)
        {
            //Search by Crime Type
            var r = context.CrimeTypes.Select(x => x.Name);

            List<string> crimeTypeList = new List<string>();
            crimeTypeList = r.ToList();

            crimeTypeCB.DataSource = crimeTypeList;
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            Criminal newCriminal = new Criminal();
            List<int> indexOfSearch = new List<int>();

            newCriminal.Name = nameTB.Text;


            newCriminal.Surname = surnameTB.Text;

            if (heightTB.Text == String.Empty)
                newCriminal.Height = 0;
            else
                newCriminal.Height = Int32.Parse(heightTB.Text);

            if (weightTB.Text == String.Empty)
                newCriminal.Weight = 0;
            else
                newCriminal.Weight = Int32.Parse(weightTB.Text);

            if( genderCB.SelectedItem == null )
                newCriminal.Gender = String.Empty;
            else
                newCriminal.Gender = genderCB.SelectedItem.ToString();


            newCriminal.HairColor = (hairColorTB.Text);


            newCriminal.Race = (raceTB.Text);


            newCriminal.Country = (countryTB.Text);


            newCriminal.State = (stateTB.Text);

            indexOfSearch.Add(1);
            indexOfSearch.Add(1);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            indexOfSearch.Add(0);
            int total = indexOfSearch.Count;

            try
            {
                if (!oneononeCB.Checked)
                {
                    var result = context.Criminals.Where(
                        x => x.Name.Contains(newCriminal.Name) ||
                                                 x.Surname.Contains(newCriminal.Surname) ||
                                                 x.Height == newCriminal.Height ||
                                                 x.Weight == newCriminal.Weight ||
                                                 x.Gender.Contains(newCriminal.Gender) ||
                                                 x.HairColor.Contains(newCriminal.HairColor) ||
                                                 x.Race.Contains(newCriminal.Race) ||
                                                 x.Country.Contains(newCriminal.Country) ||
                                                 x.State.Contains(newCriminal.State)
                                            );

                    criminalList = result.ToList();
                    List<CriminalViewModel> cvmList = new List<CriminalViewModel>();
                    for (int i = 0; i < criminalList.Count; ++i  )
                    {
                        CriminalViewModel cvm = new CriminalViewModel();
                        Criminal c = criminalList[i];
                        cvm.Name = c.Name;
                        cvm.Surname = c.Surname;
                        cvm.Height = c.Height;
                        cvm.Weight = c.Weight;
                        cvm.Gender = c.Gender;
                        cvm.HairColor = c.HairColor;
                        cvm.EyeColor = c.EyeColor;
                        cvm.Race = c.Race;
                        cvm.Country = c.Country;
                        cvm.State = c.State;
                        cvmList.Add(cvm);
                    }
                        dataGridView1.DataSource = cvmList;

                }
                else
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
                    List<CriminalViewModel> cvmList = new List<CriminalViewModel>();
                    for (int i = 0; i < criminalList.Count; ++i)
                    {
                        CriminalViewModel cvm = new CriminalViewModel();
                        Criminal c = criminalList[i];
                        cvm.Name = c.Name;
                        cvm.Surname = c.Surname;
                        cvm.Height = c.Height;
                        cvm.Weight = c.Weight;
                        cvm.Gender = c.Gender;
                        cvm.HairColor = c.HairColor;
                        cvm.EyeColor = c.EyeColor;
                        cvm.Race = c.Race;
                        cvm.Country = c.Country;
                        cvm.State = c.State;
                        cvmList.Add(cvm);
                    }
                    dataGridView1.DataSource = cvmList;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("BAE ERROR SWAG " + ex.Message);
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

            if (selectedCriminal != null)
            {
                PassCriminal(selectedCriminal);
                if( PassControl != null )PassControl( this );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var type = context.CrimeTypes.Where( x => x.Name == crimeTypeCB.SelectedItem.ToString() ).FirstOrDefault();
                var r = context.Arrests.Where(x => x.Type.Id == type.Id ).ToList();





                if (r == null)
                {
                    MessageBox.Show("No criminal found.");
                }
                else
                {
                    criminalList.Clear();
                    for(int i=0; i < r.Count; ++i )
                        criminalList.Add(r[i].Criminal);
                    List<CriminalViewModel> cvmList = new List<CriminalViewModel>();
                    for (int i = 0; i < criminalList.Count; ++i)
                    {
                        CriminalViewModel cvm = new CriminalViewModel();
                        Criminal c = criminalList[i];
                        cvm.Name = c.Name;
                        cvm.Surname = c.Surname;
                        cvm.Height = c.Height;
                        cvm.Weight = c.Weight;
                        cvm.Gender = c.Gender;
                        cvm.HairColor = c.HairColor;
                        cvm.EyeColor = c.EyeColor;
                        cvm.Race = c.Race;
                        cvm.Country = c.Country;
                        cvm.State = c.State;
                        cvmList.Add(cvm);
                    }
                    dataGridView1.DataSource = cvmList;
                    
                    DataView dv = new DataView();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("u suk" + ex.Message);
            }
        }

        public void Disable(List<Permission> permissions)
        {
            bool t = false;
            foreach( Permission p in permissions )
            {
                if( p.Name == "CAN_SEARCH_CRIMINAL_CRIME" )
                {
                    t = true;
                }
            }
            groupBox1.Enabled = t;
        }
    }
}
