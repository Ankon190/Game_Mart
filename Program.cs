namespace ProjectWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new SalesMan("a","b"));

Application.Run(new AddGames());
            //Application.Run(new SalesMan("ankon", "yusuf"));


            //Application.Run(new AddGames());
            //Application.Run(new Admin_Homepage());
            Application.Run(new All_Role());

            //Application.Run(new SalesMan("ankon", "yusuf"));
            //Application.Run(new Login("a"));


        }
    }
}