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
    public partial class VolumeInput : UserControl
    {
        public string text = "";
        public decimal volume { get => ((tbPressure.Value * tbVolume.Value * (decimal)293.15) / (101325 * tbTemp.Value)); }

        public VolumeInput()
        {
            InitializeComponent();
        }

        private void VolumeInput_Load(object sender, EventArgs e)
        {
            lText.Text = text;
        }
    }
}
