using System.Runtime.InteropServices;

namespace home_idle
{
    public partial class FormSettings : Form
    {
        private bool allowVisible;     // ContextMenu's Show command used

        public FormSettings()
        {
            InitializeComponent();
            setControlsState();
            start();
        }
        public void start()
        {
            timer1.Enabled = true;
            setControlsState();
        }
        public void stop()
        {
            timer1.Enabled = false;
            setControlsState();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {            
            timer1.Enabled = !timer1.Enabled;
            setControlsState();
        }
        private void btnPing_Click(object sender, EventArgs e)
        {
            if (MyLocation.PingHost(tbHostnameIp.Text))
            {
                lblPingResult.Text = "OK";
            } else
            {
                lblPingResult.Text = "Not reachable";
            };
        }

        private void FormSettings_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }
        private void minizeToTray()
        {
            allowVisible = true;
            Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void FormConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason != CloseReason.ApplicationExitCall);
            if (e.Cancel == true)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BreakIdle breakIdle = new BreakIdle();
            int idleSeconds = breakIdle.secondsIdle();

            if (idleSeconds > 59)
            {
                breakIdle.resetIdle();
            }

            lblIdleSeconds.Text = idleSeconds.ToString();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minizeToTray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIconSysTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            minizeToTray();
        }

        private void setControlsState()
        {
            if (timer1.Enabled)
            {
                btnStartStop.Text = "Stop";
                lblIdleSeconds.Text = "0";
            }
            else
            {
                btnStartStop.Text = "Start";
                lblIdleSeconds.Text = "Off"; 
            }
        }


    }
}
