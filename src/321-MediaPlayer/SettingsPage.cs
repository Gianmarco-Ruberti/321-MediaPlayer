using System.Drawing;

namespace _321_MediaPlayer
{
    /// <summary>
    /// Page « Paramètres » — maquette figée : valeurs d'exemple, aucun enregistrement.
    /// </summary>
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();

            // Valeurs d'exemple, purement décoratives.
            txtMediaFolder.Text = @"D:\Musique";
            txtMediaFolder.ForeColor = Color.FromArgb(232, 232, 236);
            txtNodeName.Text = "poste-salon";
        }
    }
}
