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
    public partial class ArrestUC :UserControl
    {
        private Arrest _arrest;

        public delegate void ControlUpdateDel(UserControl uc);
        public ControlUpdateDel PassControl;

        CRMDataModel context = new CRMDataModel();
        public ArrestUC()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) //Personal Info
            {
                if (_arrest != null)
                    editCriminal1.SetCriminal(_arrest.Criminal);
            }
            else if (tabControl1.SelectedIndex == 1) //Arrest Info
            {
                if (_arrest.Type == null)
                {
                    MessageBox.Show("No arrest found for this criminale.");
                    MakeEverythingDisabled(1);
                }
                else
                {
                    crimeTypeCB.SelectedText = _arrest.Type.Name;
                    locationTB.Text = _arrest.Location;
                    arrestDateDT.Value = _arrest.Date;
                    informationTB.Text = _arrest.Description;
                    agencyCB.SelectedText = _arrest.Agency.Name;
                }
            }
            else if ( tabControl1.SelectedIndex == 2 )
            {
                var charges = context.Charges.Where( x => x.Against.Id == _arrest.Criminal.Id );

                if( charges != null )
                {
                    if( charges.Count() > 0 )
                    {
                        List<Charge> chargeList = new List<Charge>();
                        chargeList = charges.ToList();
                        for( int i=0; i < charges.Count(); ++i ) 
                        {
                            ChargeUC cuc = new ChargeUC();
                            cuc.SetCharge( chargeList[i] );
                            cuc.Dock = DockStyle.Top;
                            chargesPanel.Controls.Add( cuc );


                        }


                       
                    }
                    else
                    {
                        MessageBox.Show("This criminale has not been charged.");
                    }
                }
            }
        }
        private void MakeEverythingDisabled(int tabIndex)
        {
            foreach (Control c in tabControl1.TabPages[tabIndex].Controls)
            {
                c.Enabled = false;
            }
        }
        private void ArrestUC_Load(object sender, EventArgs e)
        {
            this.editCriminal1 = new CRMWinApp.UserControls.EditCriminal();

            if (_arrest != null)
                editCriminal1.SetCriminal(_arrest.Criminal);
            editCriminal1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add(editCriminal1);
        }

        public void SetArrestData(Arrest a)
        {
            _arrest = a;
        }

        private void editCriminal1_Load(object sender, EventArgs e)
        {
            if (_arrest != null)
                editCriminal1.SetCriminal(_arrest.Criminal);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
