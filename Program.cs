namespace home_idle
{
    internal static class Program
    {
        public interface IMySettings
        {
            string HomeHostnameIp { get; }
        }
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormSettings());
        }
    }
}