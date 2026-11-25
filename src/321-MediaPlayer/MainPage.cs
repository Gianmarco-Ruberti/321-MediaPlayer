namespace _321_MediaPlayer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            if (AppSettings.HasLibrary)
            {
                labelStatus.Text = "Dossier média : " + Path.GetFileName(AppSettings.MediaFolder);
            }
        }
    }
}
