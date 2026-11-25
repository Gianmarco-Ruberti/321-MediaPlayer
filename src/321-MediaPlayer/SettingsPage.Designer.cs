using System.Drawing;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    partial class SettingsPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader = null!;
        private Label labelTitle = null!;
        private Label labelSubtitle = null!;
        private Panel panelHeaderBorder = null!;
        private Panel panelBody = null!;

        private Panel cardLibrary = null!;
        private Label labelSectionLibrary = null!;
        private Label labelFolderText = null!;
        private Panel panelFolderRow = null!;
        private Panel panelFolderBox = null!;
        private TextBox txtMediaFolder = null!;
        private Button btnBrowse = null!;
        private Panel spacerLibrary = null!;
        private CheckBox checkSubfolders = null!;

        private Panel spacerAfterLibrary = null!;

        private Panel cardPlayback = null!;
        private Label labelSectionPlayback = null!;
        private Panel spacerPlayback = null!;
        private CheckBox checkResume = null!;
        private CheckBox checkAutoplay = null!;
        private CheckBox checkNotifications = null!;

        private Panel spacerAfterPlayback = null!;

        private Panel cardNetwork = null!;
        private Label labelSectionNetwork = null!;
        private Panel panelNodeRow = null!;
        private Label labelNodeName = null!;
        private TextBox txtNodeName = null!;
        private Label labelPort = null!;
        private NumericUpDown numPort = null!;
        private CheckBox checkShare = null!;
        private CheckBox checkIncoming = null!;

        private Panel panelFooter = null!;
        private Panel panelFooterBorder = null!;
        private Label labelFooterHint = null!;
        private FlowLayoutPanel flowFooter = null!;
        private Button btnCancel = null!;
        private Button btnSave = null!;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // ------------------------------------------------------------------
            // Page
            // ------------------------------------------------------------------
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(28, 28, 31);
            this.Font = new Font("Segoe UI", 9F);
            this.ForeColor = Color.FromArgb(232, 232, 236);
            this.Name = "SettingsPage";
            this.Size = new Size(980, 530);
            this.DoubleBuffered = true;

            // ------------------------------------------------------------------
            // En-tête
            // ------------------------------------------------------------------
            this.panelHeader = new Panel();
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 88;
            this.panelHeader.BackColor = Color.FromArgb(28, 28, 31);

            this.labelTitle = new Label();
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new Point(32, 16);
            this.labelTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            this.labelTitle.ForeColor = Color.FromArgb(240, 240, 244);
            this.labelTitle.BackColor = Color.Transparent;
            this.labelTitle.Text = "Paramètres";

            this.labelSubtitle = new Label();
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Location = new Point(34, 50);
            this.labelSubtitle.Font = new Font("Segoe UI", 9F);
            this.labelSubtitle.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelSubtitle.BackColor = Color.Transparent;
            this.labelSubtitle.Text = "Bibliothèque, lecture et partage sur le réseau";

            this.panelHeaderBorder = new Panel();
            this.panelHeaderBorder.Dock = DockStyle.Bottom;
            this.panelHeaderBorder.Height = 1;
            this.panelHeaderBorder.BackColor = Color.FromArgb(42, 42, 46);

            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);

            // ------------------------------------------------------------------
            // Corps (défilement si la fenêtre est petite)
            // ------------------------------------------------------------------
            this.panelBody = new Panel();
            this.panelBody.Dock = DockStyle.Fill;
            this.panelBody.AutoScroll = true;
            this.panelBody.Padding = new Padding(32, 4, 32, 8);
            this.panelBody.BackColor = Color.FromArgb(28, 28, 31);

            // ------------------------------------------------------------------
            // Carte « Bibliothèque »
            // ------------------------------------------------------------------
            this.cardLibrary = new Panel();
            this.cardLibrary.Dock = DockStyle.Top;
            this.cardLibrary.Height = 138;
            this.cardLibrary.Padding = new Padding(20, 16, 20, 16);
            this.cardLibrary.BackColor = Color.FromArgb(33, 33, 37);

            this.labelSectionLibrary = new Label();
            this.labelSectionLibrary.Dock = DockStyle.Top;
            this.labelSectionLibrary.Height = 20;
            this.labelSectionLibrary.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelSectionLibrary.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelSectionLibrary.BackColor = Color.Transparent;
            this.labelSectionLibrary.TextAlign = ContentAlignment.MiddleLeft;
            this.labelSectionLibrary.Text = "BIBLIOTHÈQUE";

            this.labelFolderText = new Label();
            this.labelFolderText.Dock = DockStyle.Top;
            this.labelFolderText.Height = 22;
            this.labelFolderText.Font = new Font("Segoe UI", 9F);
            this.labelFolderText.ForeColor = Color.FromArgb(207, 207, 214);
            this.labelFolderText.BackColor = Color.Transparent;
            this.labelFolderText.TextAlign = ContentAlignment.MiddleLeft;
            this.labelFolderText.Text = "Dossier média";

            this.panelFolderRow = new Panel();
            this.panelFolderRow.Dock = DockStyle.Top;
            this.panelFolderRow.Height = 32;
            this.panelFolderRow.BackColor = Color.FromArgb(33, 33, 37);

            this.panelFolderBox = new Panel();
            this.panelFolderBox.Dock = DockStyle.Fill;
            this.panelFolderBox.Padding = new Padding(12, 7, 12, 0);
            this.panelFolderBox.BackColor = Color.FromArgb(42, 42, 46);

            this.txtMediaFolder = new TextBox();
            this.txtMediaFolder.Dock = DockStyle.Fill;
            this.txtMediaFolder.BorderStyle = BorderStyle.None;
            this.txtMediaFolder.ReadOnly = true;
            this.txtMediaFolder.BackColor = Color.FromArgb(42, 42, 46);
            this.txtMediaFolder.ForeColor = Color.FromArgb(138, 138, 144);
            this.txtMediaFolder.Font = new Font("Segoe UI", 9F);
            this.txtMediaFolder.Text = "Aucun dossier sélectionné";

            this.panelFolderBox.Controls.Add(this.txtMediaFolder);

            this.btnBrowse = new Button();
            this.btnBrowse.Dock = DockStyle.Right;
            this.btnBrowse.Width = 112;
            this.btnBrowse.BackColor = Color.FromArgb(50, 50, 56);
            this.btnBrowse.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnBrowse.FlatStyle = FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            this.btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 72, 80);
            this.btnBrowse.Font = new Font("Segoe UI", 9F);
            this.btnBrowse.Text = "Parcourir…";
            this.btnBrowse.Cursor = Cursors.Hand;
            this.btnBrowse.UseVisualStyleBackColor = false;

            this.panelFolderRow.Controls.Add(this.panelFolderBox);
            this.panelFolderRow.Controls.Add(this.btnBrowse);

            this.spacerLibrary = new Panel();
            this.spacerLibrary.Dock = DockStyle.Top;
            this.spacerLibrary.Height = 4;
            this.spacerLibrary.BackColor = Color.FromArgb(33, 33, 37);

            this.checkSubfolders = new CheckBox();
            this.checkSubfolders.Dock = DockStyle.Top;
            this.checkSubfolders.Height = 28;
            this.checkSubfolders.FlatStyle = FlatStyle.Flat;
            this.checkSubfolders.Font = new Font("Segoe UI", 9F);
            this.checkSubfolders.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkSubfolders.BackColor = Color.Transparent;
            this.checkSubfolders.Text = "Analyser les sous-dossiers au démarrage";
            this.checkSubfolders.Checked = true;
            this.checkSubfolders.Cursor = Cursors.Hand;

            this.cardLibrary.Controls.Add(this.checkSubfolders);
            this.cardLibrary.Controls.Add(this.spacerLibrary);
            this.cardLibrary.Controls.Add(this.panelFolderRow);
            this.cardLibrary.Controls.Add(this.labelFolderText);
            this.cardLibrary.Controls.Add(this.labelSectionLibrary);

            this.spacerAfterLibrary = new Panel();
            this.spacerAfterLibrary.Dock = DockStyle.Top;
            this.spacerAfterLibrary.Height = 12;
            this.spacerAfterLibrary.BackColor = Color.FromArgb(28, 28, 31);

            // ------------------------------------------------------------------
            // Carte « Lecture »
            // ------------------------------------------------------------------
            this.cardPlayback = new Panel();
            this.cardPlayback.Dock = DockStyle.Top;
            this.cardPlayback.Height = 144;
            this.cardPlayback.Padding = new Padding(20, 16, 20, 16);
            this.cardPlayback.BackColor = Color.FromArgb(33, 33, 37);

            this.labelSectionPlayback = new Label();
            this.labelSectionPlayback.Dock = DockStyle.Top;
            this.labelSectionPlayback.Height = 20;
            this.labelSectionPlayback.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelSectionPlayback.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelSectionPlayback.BackColor = Color.Transparent;
            this.labelSectionPlayback.TextAlign = ContentAlignment.MiddleLeft;
            this.labelSectionPlayback.Text = "LECTURE";

            this.spacerPlayback = new Panel();
            this.spacerPlayback.Dock = DockStyle.Top;
            this.spacerPlayback.Height = 2;
            this.spacerPlayback.BackColor = Color.FromArgb(33, 33, 37);

            this.checkResume = new CheckBox();
            this.checkResume.Dock = DockStyle.Top;
            this.checkResume.Height = 30;
            this.checkResume.FlatStyle = FlatStyle.Flat;
            this.checkResume.Font = new Font("Segoe UI", 9F);
            this.checkResume.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkResume.BackColor = Color.Transparent;
            this.checkResume.Text = "Reprendre la lecture à la dernière position";
            this.checkResume.Checked = true;
            this.checkResume.Cursor = Cursors.Hand;

            this.checkAutoplay = new CheckBox();
            this.checkAutoplay.Dock = DockStyle.Top;
            this.checkAutoplay.Height = 30;
            this.checkAutoplay.FlatStyle = FlatStyle.Flat;
            this.checkAutoplay.Font = new Font("Segoe UI", 9F);
            this.checkAutoplay.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkAutoplay.BackColor = Color.Transparent;
            this.checkAutoplay.Text = "Enchaîner automatiquement la piste suivante";
            this.checkAutoplay.Checked = true;
            this.checkAutoplay.Cursor = Cursors.Hand;

            this.checkNotifications = new CheckBox();
            this.checkNotifications.Dock = DockStyle.Top;
            this.checkNotifications.Height = 30;
            this.checkNotifications.FlatStyle = FlatStyle.Flat;
            this.checkNotifications.Font = new Font("Segoe UI", 9F);
            this.checkNotifications.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkNotifications.BackColor = Color.Transparent;
            this.checkNotifications.Text = "Afficher une notification au changement de piste";
            this.checkNotifications.Cursor = Cursors.Hand;

            this.cardPlayback.Controls.Add(this.checkNotifications);
            this.cardPlayback.Controls.Add(this.checkAutoplay);
            this.cardPlayback.Controls.Add(this.checkResume);
            this.cardPlayback.Controls.Add(this.spacerPlayback);
            this.cardPlayback.Controls.Add(this.labelSectionPlayback);

            this.spacerAfterPlayback = new Panel();
            this.spacerAfterPlayback.Dock = DockStyle.Top;
            this.spacerAfterPlayback.Height = 12;
            this.spacerAfterPlayback.BackColor = Color.FromArgb(28, 28, 31);

            // ------------------------------------------------------------------
            // Carte « Réseau »
            // ------------------------------------------------------------------
            this.cardNetwork = new Panel();
            this.cardNetwork.Dock = DockStyle.Top;
            this.cardNetwork.Height = 156;
            this.cardNetwork.Padding = new Padding(20, 16, 20, 16);
            this.cardNetwork.BackColor = Color.FromArgb(33, 33, 37);

            this.labelSectionNetwork = new Label();
            this.labelSectionNetwork.Dock = DockStyle.Top;
            this.labelSectionNetwork.Height = 20;
            this.labelSectionNetwork.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelSectionNetwork.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelSectionNetwork.BackColor = Color.Transparent;
            this.labelSectionNetwork.TextAlign = ContentAlignment.MiddleLeft;
            this.labelSectionNetwork.Text = "RÉSEAU";

            this.panelNodeRow = new Panel();
            this.panelNodeRow.Dock = DockStyle.Top;
            this.panelNodeRow.Height = 52;
            this.panelNodeRow.BackColor = Color.FromArgb(33, 33, 37);

            this.labelNodeName = new Label();
            this.labelNodeName.AutoSize = true;
            this.labelNodeName.Location = new Point(0, 2);
            this.labelNodeName.Font = new Font("Segoe UI", 8F);
            this.labelNodeName.ForeColor = Color.FromArgb(154, 154, 160);
            this.labelNodeName.BackColor = Color.Transparent;
            this.labelNodeName.Text = "NOM DU NŒUD";

            this.txtNodeName = new TextBox();
            this.txtNodeName.Location = new Point(0, 18);
            this.txtNodeName.Size = new Size(240, 24);
            this.txtNodeName.BorderStyle = BorderStyle.FixedSingle;
            this.txtNodeName.BackColor = Color.FromArgb(42, 42, 46);
            this.txtNodeName.ForeColor = Color.FromArgb(232, 232, 236);
            this.txtNodeName.Font = new Font("Segoe UI", 9F);

            this.labelPort = new Label();
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new Point(264, 2);
            this.labelPort.Font = new Font("Segoe UI", 8F);
            this.labelPort.ForeColor = Color.FromArgb(154, 154, 160);
            this.labelPort.BackColor = Color.Transparent;
            this.labelPort.Text = "PORT D'ÉCOUTE";

            this.numPort = new NumericUpDown();
            this.numPort.Location = new Point(264, 18);
            this.numPort.Size = new Size(100, 24);
            this.numPort.BorderStyle = BorderStyle.FixedSingle;
            this.numPort.BackColor = Color.FromArgb(42, 42, 46);
            this.numPort.ForeColor = Color.FromArgb(232, 232, 236);
            this.numPort.Font = new Font("Segoe UI", 9F);
            this.numPort.Minimum = 1024;
            this.numPort.Maximum = 65535;
            this.numPort.Value = 6881;

            this.panelNodeRow.Controls.Add(this.labelNodeName);
            this.panelNodeRow.Controls.Add(this.txtNodeName);
            this.panelNodeRow.Controls.Add(this.labelPort);
            this.panelNodeRow.Controls.Add(this.numPort);

            this.checkShare = new CheckBox();
            this.checkShare.Dock = DockStyle.Top;
            this.checkShare.Height = 26;
            this.checkShare.FlatStyle = FlatStyle.Flat;
            this.checkShare.Font = new Font("Segoe UI", 9F);
            this.checkShare.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkShare.BackColor = Color.Transparent;
            this.checkShare.Text = "Partager ma médiathèque sur le réseau";
            this.checkShare.Checked = true;
            this.checkShare.Cursor = Cursors.Hand;

            this.checkIncoming = new CheckBox();
            this.checkIncoming.Dock = DockStyle.Top;
            this.checkIncoming.Height = 26;
            this.checkIncoming.FlatStyle = FlatStyle.Flat;
            this.checkIncoming.Font = new Font("Segoe UI", 9F);
            this.checkIncoming.ForeColor = Color.FromArgb(207, 207, 214);
            this.checkIncoming.BackColor = Color.Transparent;
            this.checkIncoming.Text = "Accepter les connexions entrantes";
            this.checkIncoming.Checked = true;
            this.checkIncoming.Cursor = Cursors.Hand;

            this.cardNetwork.Controls.Add(this.checkIncoming);
            this.cardNetwork.Controls.Add(this.checkShare);
            this.cardNetwork.Controls.Add(this.panelNodeRow);
            this.cardNetwork.Controls.Add(this.labelSectionNetwork);

            this.panelBody.Controls.Add(this.cardNetwork);
            this.panelBody.Controls.Add(this.spacerAfterPlayback);
            this.panelBody.Controls.Add(this.cardPlayback);
            this.panelBody.Controls.Add(this.spacerAfterLibrary);
            this.panelBody.Controls.Add(this.cardLibrary);

            // ------------------------------------------------------------------
            // Pied de page (actions)
            // ------------------------------------------------------------------
            this.panelFooter = new Panel();
            this.panelFooter.Dock = DockStyle.Bottom;
            this.panelFooter.Height = 64;
            this.panelFooter.BackColor = Color.FromArgb(31, 31, 34);

            this.labelFooterHint = new Label();
            this.labelFooterHint.AutoSize = true;
            this.labelFooterHint.Location = new Point(32, 24);
            this.labelFooterHint.Font = new Font("Segoe UI", 8.5F);
            this.labelFooterHint.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelFooterHint.BackColor = Color.Transparent;
            this.labelFooterHint.Text = "Le dossier et le port sont vérifiés à l'enregistrement, puis appliqués sans redémarrage.";

            this.btnCancel = new Button();
            this.btnCancel.Size = new Size(120, 36);
            this.btnCancel.Margin = new Padding(0, 0, 12, 0);
            this.btnCancel.BackColor = Color.FromArgb(50, 50, 56);
            this.btnCancel.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            this.btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 72, 80);
            this.btnCancel.Font = new Font("Segoe UI", 9F);
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.UseVisualStyleBackColor = false;

            this.btnSave = new Button();
            this.btnSave.Size = new Size(120, 36);
            this.btnSave.BackColor = Color.FromArgb(139, 92, 246);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            this.btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            this.btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.UseVisualStyleBackColor = false;

            this.flowFooter = new FlowLayoutPanel();
            this.flowFooter.Dock = DockStyle.Right;
            this.flowFooter.Width = 288;
            this.flowFooter.Padding = new Padding(0, 14, 24, 0);
            this.flowFooter.WrapContents = false;
            this.flowFooter.FlowDirection = FlowDirection.LeftToRight;
            this.flowFooter.BackColor = Color.FromArgb(31, 31, 34);
            this.flowFooter.Controls.Add(this.btnCancel);
            this.flowFooter.Controls.Add(this.btnSave);

            this.panelFooterBorder = new Panel();
            this.panelFooterBorder.Dock = DockStyle.Top;
            this.panelFooterBorder.Height = 1;
            this.panelFooterBorder.BackColor = Color.FromArgb(42, 42, 46);

            this.panelFooter.Controls.Add(this.labelFooterHint);
            this.panelFooter.Controls.Add(this.flowFooter);
            this.panelFooter.Controls.Add(this.panelFooterBorder);

            // ------------------------------------------------------------------
            // Assemblage
            // ------------------------------------------------------------------
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
