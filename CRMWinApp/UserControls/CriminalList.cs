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
            dataGridView1.DataSource =iCriminalList ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Criminal selectedCriminal = iCriminalList[e.RowIndex];
         
            if( PassCriminal != null )
            {
                PassCriminal( selectedCriminal );
                PassControl( this );
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
