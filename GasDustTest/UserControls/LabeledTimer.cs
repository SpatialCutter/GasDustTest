using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasDustTest.UserControls
{
    public partial class LabeledTimer : UserControl
    {
        public string text = "";
        public int timersecs = 0;

        public LabeledTimer()
        {
            InitializeComponent();
        }

        private void LabeledTimer_Load(object sender, EventArgs e)
        {
            lText.Text = text;
            lTimer.Text = $"{(timersecs / 60).ToString("00")}:{(timersecs % 60).ToString("00")}";
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (timer.Enabled)
                bStart.Text = "Остановить таймер";
            else bStart.Text = "Запустить таймер";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timersecs--;
            lTimer.Text = $"{(timersecs / 60).ToString("00")}:{(timersecs % 60).ToString("00")}";
            if (timersecs <= 0)
            {
                timer.Stop();
                bStart.Enabled = false;
                SystemSounds.Beep.Play();
            }
        }
    }
}
