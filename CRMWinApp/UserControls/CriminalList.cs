using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMWinApp.Globals;
using CRMWinApp.Models;

namespace CRMWinApp.UserControls
{
    public partial class CriminalList : UserControl
    {
        public delegate void PassCriminalDel( Models.Criminal criminal );
        public PassCriminalDel PassCriminal;

        public delegate void ControlUpdateDel( UserControl uc);
        public ControlUpdateDel PassControl;

        CRMDataModel context = new CRMDataModel();
        List<Models.Criminal> iCriminalList = new List<Models.Criminal>();
        public CriminalList()
        {
            InitializeComponent();
        }

        private void CriminalList_Load(object sender, EventArgs e)
        {
            var criminalList = context.Criminals.OrderBy( x => x.Name );

            iCriminalList = criminalList.ToList();

            List<CriminalViewModel> cvmList = new List<CriminalViewModel>();
            for (int i = 0; i < iCriminalList.Count; ++i)
            {
                CriminalViewModel cvm = new CriminalViewModel();
                Criminal c = iCriminalList[i];
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Models.Criminal selectedCriminal = iCriminalList[e.RowIndex];

                if (PassCriminal != null)
                {
                    PassCriminal(selectedCriminal);
                    PassControl(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
