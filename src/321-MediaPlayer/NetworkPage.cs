namespace _321_MediaPlayer
{
    /// <summary>
    /// Page « Réseau » : médiathèques partagées par les autres nœuds BitRuisseau.
    /// </summary>
    public partial class NetworkPage : UserControl
    {
        public NetworkPage()
        {
            InitializeComponent();
            LoadSamplePeers();
        }

        // Exemple visuel : à remplacer par la découverte réelle des pairs (US-13 et suivantes).
        private void LoadSamplePeers()
        {
            dgvPeers.Rows.Add("poste-salon", "Médiathèque de Camille", "1 248", "12 ms", "Connecté");
            dgvPeers.Rows.Add("nas-garage", "Rock & Metal", "376", "24 ms", "Connecté");
            dgvPeers.Rows.Add("portable-lycee", "Partage de Yann", "92", "68 ms", "Instable");
        }
    }
}
