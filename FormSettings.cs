using System.Runtime.InteropServices;

namespace home_idle
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BreakIdle breakIdle = new BreakIdle();
            int idleSeconds = breakIdle.secondsIdle();

            if (idleSeconds > 5)
            {
                breakIdle.resetIdle();
            }

            label1.Text = idleSeconds.ToString();
        }
    }
}
