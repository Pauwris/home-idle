using System.Runtime.InteropServices;

namespace home_idle
{
    public partial class FormSettings : Form
    {
        private BreakIdle breakIdle = new BreakIdle();
        private bool allowVisible;     // ContextMenu's Show command used
        private string pingResult = "";

        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();
            SetControlsState();
            UpdateLocation();

            if (Properties.Settings.Default.AutoStartMonitoring)
            {
                StartMonitoring();
            }            
        }
        private void SetControlsState()
        {
            int idleSeconds = breakIdle.secondsIdle();

            if (timer1.Enabled)
            {
                btnStartStop.Text = "Stop";
                lblIdleSeconds.Text = String.Format("{0} seconds idle", idleSeconds.ToString());
            }
            else
            {
                btnStartStop.Text = "Start";
                lblIdleSeconds.Text = "Off";
            }

            if (pingResult == "OK")
            {
                lblPingResult.Text = "OK";
                lblPingResult.ForeColor = System.Drawing.Color.Green;
            }
            else if (pingResult == "Failed")
            {
                lblPingResult.Text = "Failed";
                lblPingResult.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPingResult.Text = "";
            };
        }

        private void LoadSettings()
        {
            tbHostnameIp.Text = Properties.Settings.Default.HomeHostnameIP;
            nudBreakIdleAfter.Value = Properties.Settings.Default.ResetIdleIntervalSeconds;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.HomeHostnameIP = tbHostnameIp.Text;
            Properties.Settings.Default.ResetIdleIntervalSeconds = Decimal.ToInt32(nudBreakIdleAfter.Value);
            Properties.Settings.Default.AutoStartMonitoring = timer1.Enabled;
            Properties.Settings.Default.Save();
        }

        private void UpdateLocation()
        {
            pingResult = "";
            SetControlsState();

            Task.Run(() => {
                pingResult = LocationInfo.PingHost(tbHostnameIp.Text) ? "OK" : "Failed";
            });            
        }

        public void StartMonitoring()
        {
            timer1.Enabled = true;
            SetControlsState();
        }
        public void StopMonitoring()
        {
            timer1.Enabled = false;
            SetControlsState();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {            
            timer1.Enabled = !timer1.Enabled;
            SetControlsState();
        }
        private void btnPing_Click(object sender, EventArgs e)
        {
            UpdateLocation();            
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
        private void MinizeToTray()
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
            SaveSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            int idleSeconds = breakIdle.secondsIdle();

            // 5 Seconds before the reset, check location
            if (idleSeconds == Properties.Settings.Default.ResetIdleIntervalSeconds - 6)
            {
                UpdateLocation();
            }

            if (pingResult == "OK" && idleSeconds > Properties.Settings.Default.ResetIdleIntervalSeconds - 1)
            {
                breakIdle.resetIdle();
            }

            SetControlsState();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinizeToTray();
        }

        private void notifyIconSysTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MinizeToTray();
        }
    }
}
