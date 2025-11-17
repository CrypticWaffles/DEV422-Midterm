namespace VibeHive.Client
{
    internal static class Program
    {

        // Session storage: Contain the user JWT token when logged in:
        public static string userToken = "";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new MainForm());
            Application.Run(new NavigationForm());
            Application.Run(new MainForm());
        }
    }
}