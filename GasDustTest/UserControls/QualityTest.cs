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
    public partial class QualityTest : UserControl
    {
        public bool check = false;

        public QualityTest()
        {
            InitializeComponent();
        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            check = cbFilter.Checked;
        }

        private void QualityTest_Resize(object sender, EventArgs e)
        {
            label1.MaximumSize = this.Size;
        }
    }
}
