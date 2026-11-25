namespace _321_MediaPlayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Maquette figée : on ouvre directement l'écran principal.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());
        }
    }
}
