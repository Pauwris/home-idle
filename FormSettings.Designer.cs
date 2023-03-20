namespace home_idle
{
    partial class FormSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblIdleSeconds = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.contextMenuStripSysStray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBreakIdleAfter = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPingResult = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.tbHostnameIp = new System.Windows.Forms.TextBox();
            this.contextMenuStripSysStray.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakIdleAfter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblIdleSeconds
            // 
            this.lblIdleSeconds.AutoSize = true;
            this.lblIdleSeconds.Location = new System.Drawing.Point(87, 43);
            this.lblIdleSeconds.Name = "lblIdleSeconds";
            this.lblIdleSeconds.Size = new System.Drawing.Size(24, 15);
            this.lblIdleSeconds.TabIndex = 0;
            this.lblIdleSeconds.Text = "Off";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 39);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start/Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // contextMenuStripSysStray
            // 
            this.contextMenuStripSysStray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripSysStray.Name = "contextMenuStripSysStray";
            this.contextMenuStripSysStray.Size = new System.Drawing.Size(126, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIconSysTray
            // 
            this.notifyIconSysTray.BalloonTipTitle = "Home-idle";
            this.notifyIconSysTray.ContextMenuStrip = this.contextMenuStripSysStray;
            this.notifyIconSysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSysTray.Icon")));
            this.notifyIconSysTray.Text = "Home-idle";
            this.notifyIconSysTray.Visible = true;
            this.notifyIconSysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSysTray_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudBreakIdleAfter);
            this.groupBox1.Controls.Add(this.lblIdleSeconds);
            this.groupBox1.Controls.Add(this.btnStartStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idle monitoring";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Process state";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Break idle after";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds";
            // 
            // nudBreakIdleAfter
            // 
            this.nudBreakIdleAfter.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudBreakIdleAfter.Location = new System.Drawing.Point(6, 93);
            this.nudBreakIdleAfter.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudBreakIdleAfter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBreakIdleAfter.Name = "nudBreakIdleAfter";
            this.nudBreakIdleAfter.Size = new System.Drawing.Size(59, 23);
            this.nudBreakIdleAfter.TabIndex = 2;
            this.nudBreakIdleAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBreakIdleAfter.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblPingResult);
            this.groupBox2.Controls.Add(this.btnPing);
            this.groupBox2.Controls.Add(this.tbHostnameIp);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Home ping hostname/IP";
            // 
            // lblPingResult
            // 
            this.lblPingResult.AutoSize = true;
            this.lblPingResult.Location = new System.Drawing.Point(188, 25);
            this.lblPingResult.Name = "lblPingResult";
            this.lblPingResult.Size = new System.Drawing.Size(23, 15);
            this.lblPingResult.TabIndex = 3;
            this.lblPingResult.Text = "OK";
            // 
            // btnPing
            // 
            this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPing.Location = new System.Drawing.Point(107, 22);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // tbHostnameIp
            // 
            this.tbHostnameIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostnameIp.Location = new System.Drawing.Point(6, 22);
            this.tbHostnameIp.Name = "tbHostnameIp";
            this.tbHostnameIp.Size = new System.Drawing.Size(95, 23);
            this.tbHostnameIp.TabIndex = 0;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 147);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home-idle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsole_FormClosing);
            this.Resize += new System.EventHandler(this.FormSettings_Resize);
            this.contextMenuStripSysStray.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakIdleAfter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblIdleSeconds;
        private Button btnStartStop;
        private ContextMenuStrip contextMenuStripSysStray;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIconSysTray;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnPing;
        private TextBox tbHostnameIp;
        private Label lblPingResult;
        private Label label1;
        private NumericUpDown nudBreakIdleAfter;
        private Label label3;
        private Label label2;
    }
}