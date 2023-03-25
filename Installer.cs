using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_idle
{
    internal class Installer
    {
        public const string ProductName = "home-idle";
        public const string RunOnStartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public static void RegisterRunOnStartup()
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RunOnStartupKey))
            {
                if (key != null)
                {
                    key.SetValue(ProductName, Application.ExecutablePath);
                }
            }
        }
        public static void UnRegisterRunOnStartup()
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RunOnStartupKey))
            {
                if (key != null)
                {
                    key.DeleteValue(ProductName, false);
                }
            }
        }
        public static bool WillRunOnStartup
        {
            get
            {
                using (var key = Registry.CurrentUser.CreateSubKey(RunOnStartupKey))
                {
                    return (key != null && key.GetValue(ProductName) != null);
                }
            }
        }
    }
}
