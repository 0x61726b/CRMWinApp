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
    public partial class ChargeUC :UserControl
    {
        private Charge _charge;
        public ChargeUC()
        {
            InitializeComponent();
        }

        public void SetCharge( Charge c )
        {
            _charge = c;
        }

        private void ChargeUC_Load(object sender, EventArgs e)
        {
            titleGroupBox.Text = "Charge by + " +_charge.Cite.Officer.Name;
            citeTypeCB.SelectedText = _charge.Cite.Type.Name;
            attorneyCB.SelectedText = _charge.Attorney.Name + " " + _charge.Attorney.Surname;
            citeNoteTB.Text = _charge.Cite.Note;

        }
    }
}
