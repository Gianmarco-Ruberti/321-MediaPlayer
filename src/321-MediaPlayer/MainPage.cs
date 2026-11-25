using System.Drawing;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    /// <summary>
    /// Écran principal — maquette figée : aucun comportement, uniquement l'habillage.
    /// </summary>
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            ApplyRoundRegions();

            // « Segoe UI » ne contient pas le glyphe pause : on emprunte la police symboles.
            btnPlay.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold);

            LoadSampleRows();

            labelStatus.Text = "8 médias · Dossier média : Musique";
        }

        /// <summary>
        /// Contenu d'exemple, purement décoratif : rien n'est lu sur le disque.
        /// </summary>
        private void LoadSampleRows()
        {
            dgvTracks.Rows.Add("Around the World", "Daft Punk", 1997, "7:09", "16,3 Mo");
            dgvTracks.Rows.Add("Bohemian Rhapsody", "Queen", 1975, "5:55", "13,4 Mo");
            dgvTracks.Rows.Add("Clair de lune", "Claude Debussy", 1905, "5:03", "11,5 Mo");
            dgvTracks.Rows.Add("Été indien", "Joe Dassin", 1975, "4:32", "10,1 Mo");
            dgvTracks.Rows.Add("Get Lucky", "Daft Punk", 2013, "6:09", "14,0 Mo");
            dgvTracks.Rows.Add("La Bohème", "Charles Aznavour", 1965, "4:05", "9,6 Mo");
            dgvTracks.Rows.Add("Redemption Song", "Bob Marley", 1980, "3:47", "8,7 Mo");
            dgvTracks.Rows.Add("Stairway to Heaven", "Led Zeppelin", 1971, "8:02", "18,2 Mo");

            // Aucune ligne surlignée : l'écran reste une image fixe.
            dgvTracks.ClearSelection();
        }

        private void ApplyRoundRegions()
        {
            btnPlay.Region = EllipseRegion(btnPlay.Size);
            btnMute.Region = EllipseRegion(btnMute.Size);
            panelSeekKnob.Region = EllipseRegion(panelSeekKnob.Size);
            panelVolumeKnob.Region = EllipseRegion(panelVolumeKnob.Size);
        }
    }
}
