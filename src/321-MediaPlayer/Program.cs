namespace _321_MediaPlayer
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

            // Premier lancement (aucun dossier média connu) : petit guide de configuration.
            if (!AppSettings.HasLibrary)
            {
                using FirstRunPage configuration = new FirstRunPage();
                Application.Run(configuration);

                if (!configuration.Completed)
                {
                    return;
                }
            }

            // Ouvertures suivantes : acces direct a la bibliotheque.
            Application.Run(new MainPage());
        }
    }
}
