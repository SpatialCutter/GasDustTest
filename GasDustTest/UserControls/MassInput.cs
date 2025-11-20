using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasDustTest.UserControls
{
    public partial class MassInput : UserControl
    {
        public string text = "";
        public decimal mass = 0;

        public MassInput()
        {
            InitializeComponent();
        }

        private void MassInput_Load(object sender, EventArgs e)
        {
            lText.Text = text;
        }

        private void tbMass_Leave(object sender, EventArgs e)
        {
            mass = tbMass.Value;
        }
    }
}
