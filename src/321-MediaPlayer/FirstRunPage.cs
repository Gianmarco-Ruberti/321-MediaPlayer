using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    /// <summary>
    /// Écran affiché au tout premier lancement : choix du dossier média.
    /// </summary>
    public partial class FirstRunPage : Form
    {
        private static readonly Color AccentColor = Color.FromArgb(139, 92, 246);
        private static readonly Color AccentHoverColor = Color.FromArgb(158, 118, 255);
        private static readonly Color DisabledColor = Color.FromArgb(58, 58, 65);
        private static readonly Color TextColor = Color.FromArgb(232, 232, 236);
        private static readonly Color MutedColor = Color.FromArgb(138, 138, 144);

        private string? _mediaFolder;

        public FirstRunPage()
        {
            InitializeComponent();
            UpdateFolderState();
        }

        /// <summary>
        /// Vrai lorsque l'utilisateur a terminé (dossier choisi ou « Plus tard »).
        /// </summary>
        public bool Completed { get; private set; }

        private void UpdateFolderState()
        {
            bool hasFolder = !string.IsNullOrWhiteSpace(_mediaFolder);

            labelFolderPath.Text = hasFolder ? _mediaFolder! : "Aucun dossier sélectionné";
            labelFolderPath.ForeColor = hasFolder ? TextColor : MutedColor;

            btnStart.Enabled = hasFolder;
            btnStart.BackColor = hasFolder ? AccentColor : DisabledColor;
            btnStart.ForeColor = hasFolder ? Color.White : Color.FromArgb(120, 120, 128);
            btnStart.Cursor = hasFolder ? Cursors.Hand : Cursors.Default;
        }

        private void btnBrowse_Click(object? sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "Choisis le dossier qui contient tes médias",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = false
            };

            if (Directory.Exists(_mediaFolder))
            {
                dialog.InitialDirectory = _mediaFolder!;
            }

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _mediaFolder = dialog.SelectedPath;
                UpdateFolderState();
            }
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_mediaFolder))
            {
                return;
            }

            AppSettings.SaveMediaFolder(_mediaFolder!);
            Completed = true;
            Close();
        }

        private void btnLater_Click(object? sender, EventArgs e)
        {
            // Le guide n'est pas bloquant : la bibliothèque s'ouvre, le choix sera reproposé au prochain démarrage.
            Completed = true;
            Close();
        }
    }
}
