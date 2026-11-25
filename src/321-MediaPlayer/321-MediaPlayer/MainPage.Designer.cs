using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelSidebar = null!;
        private Panel panelNavActive = null!;
        private Panel panelNavAccent = null!;
        private Label labelNavMusic = null!;
        private Button btnNavNetwork = null!;
        private Button btnNavSettings = null!;

        private Panel panelMain = null!;
        private Panel panelActionBar = null!;
        private Panel panelActionBorder = null!;
        private Panel panelSearch = null!;
        private TextBox txtSearch = null!;
        private Button btnImport = null!;

        private Panel panelLibrary = null!;
        private DataGridView dgvTracks = null!;
        private DataGridViewTextBoxColumn colTitle = null!;
        private DataGridViewTextBoxColumn colArtist = null!;
        private DataGridViewTextBoxColumn colYear = null!;
        private DataGridViewTextBoxColumn colDuration = null!;
        private DataGridViewTextBoxColumn colSize = null!;
        private Panel panelStatus = null!;
        private Label labelStatus = null!;

        private Panel panelPlayer = null!;
        private Panel panelPlayerBorder = null!;
        private Panel panelSeekRow = null!;
        private Panel panelSeekArea = null!;
        private Panel panelSeekBg = null!;
        private Panel panelSeekFill = null!;
        private Panel panelSeekKnob = null!;
        private Panel panelTimesRow = null!;
        private Label labelTimeCurrent = null!;
        private Label labelTimeTotal = null!;
        private Panel panelTransportRow = null!;
        private TableLayoutPanel tblTransport = null!;
        private Label labelNowPlaying = null!;
        private FlowLayoutPanel flowCenter = null!;
        private Button btnPrev = null!;
        private Button btnPlay = null!;
        private Button btnNext = null!;
        private FlowLayoutPanel flowRight = null!;
        private Label labelVolIcon = null!;
        private Panel panelVolume = null!;
        private Panel panelVolumeBg = null!;
        private Panel panelVolumeFill = null!;
        private Panel panelVolumeKnob = null!;
        private Button btnMute = null!;

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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ------------------------------------------------------------------
            // Form
            // ------------------------------------------------------------------
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(28, 28, 31);
            this.ClientSize = new Size(1200, 750);
            this.Font = new Font("Segoe UI", 9F);
            this.ForeColor = Color.FromArgb(232, 232, 236);
            this.MinimumSize = new Size(960, 640);
            this.Name = "MainPage";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BitRuisseau";
            this.DoubleBuffered = true;

            // ------------------------------------------------------------------
            // Barre latérale
            // ------------------------------------------------------------------
            this.panelSidebar = new Panel();
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 220;
            this.panelSidebar.BackColor = Color.FromArgb(32, 32, 35);

            // Élément actif : fond surligné + barre d'accent violette
            this.panelNavActive = new Panel();
            this.panelNavActive.Location = new Point(12, 24);
            this.panelNavActive.Size = new Size(196, 40);
            this.panelNavActive.BackColor = Color.FromArgb(47, 47, 51);

            this.labelNavMusic = new Label();
            this.labelNavMusic.Dock = DockStyle.Fill;
            this.labelNavMusic.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.labelNavMusic.ForeColor = Color.FromArgb(255, 255, 255);
            this.labelNavMusic.TextAlign = ContentAlignment.MiddleLeft;
            this.labelNavMusic.Padding = new Padding(17, 0, 0, 0);
            this.labelNavMusic.BackColor = Color.Transparent;
            this.labelNavMusic.Text = "Ma musique";

            this.panelNavAccent = new Panel();
            this.panelNavAccent.Dock = DockStyle.Left;
            this.panelNavAccent.Width = 3;
            this.panelNavAccent.BackColor = Color.FromArgb(139, 92, 246);

            this.panelNavActive.Controls.Add(this.labelNavMusic);
            this.panelNavActive.Controls.Add(this.panelNavAccent);

            this.btnNavNetwork = CreateNavButton("Réseau");
            this.btnNavNetwork.Location = new Point(12, 72);

            this.btnNavSettings = CreateNavButton("Paramètres");
            this.btnNavSettings.Location = new Point(12, 120);

            this.panelSidebar.Controls.Add(this.panelNavActive);
            this.panelSidebar.Controls.Add(this.btnNavNetwork);
            this.panelSidebar.Controls.Add(this.btnNavSettings);

            // ------------------------------------------------------------------
            // Barre d'actions (recherche + import)
            // ------------------------------------------------------------------
            this.panelActionBar = new Panel();
            this.panelActionBar.Dock = DockStyle.Top;
            this.panelActionBar.Height = 56;
            this.panelActionBar.BackColor = Color.FromArgb(31, 31, 34);

            this.panelSearch = new Panel();
            this.panelSearch.Location = new Point(580, 12);
            this.panelSearch.Size = new Size(260, 32);
            this.panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.panelSearch.BackColor = Color.FromArgb(42, 42, 46);

            this.txtSearch = new TextBox();
            this.txtSearch.Location = new Point(14, 6);
            this.txtSearch.Size = new Size(232, 20);
            this.txtSearch.BorderStyle = BorderStyle.None;
            this.txtSearch.BackColor = Color.FromArgb(42, 42, 46);
            this.txtSearch.ForeColor = Color.FromArgb(138, 138, 144);
            this.txtSearch.Font = new Font("Segoe UI", 9F);
            this.txtSearch.Text = "Rechercher…";

            this.panelSearch.Controls.Add(this.txtSearch);

            this.btnImport = new Button();
            this.btnImport.Location = new Point(848, 12);
            this.btnImport.Size = new Size(112, 32);
            this.btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnImport.BackColor = Color.FromArgb(139, 92, 246);
            this.btnImport.ForeColor = Color.White;
            this.btnImport.FlatStyle = FlatStyle.Flat;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            this.btnImport.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            this.btnImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnImport.Text = "Importer";
            this.btnImport.Cursor = Cursors.Hand;
            this.btnImport.UseVisualStyleBackColor = false;

            this.panelActionBorder = new Panel();
            this.panelActionBorder.Dock = DockStyle.Bottom;
            this.panelActionBorder.Height = 1;
            this.panelActionBorder.BackColor = Color.FromArgb(51, 51, 56);

            this.panelActionBar.Controls.Add(this.panelSearch);
            this.panelActionBar.Controls.Add(this.btnImport);
            this.panelActionBar.Controls.Add(this.panelActionBorder);

            // ------------------------------------------------------------------
            // Liste des morceaux
            // ------------------------------------------------------------------
            this.panelLibrary = new Panel();
            this.panelLibrary.Dock = DockStyle.Fill;
            this.panelLibrary.Padding = new Padding(16, 12, 16, 0);
            this.panelLibrary.BackColor = Color.FromArgb(28, 28, 31);

            this.dgvTracks = new DataGridView();
            this.dgvTracks.Dock = DockStyle.Fill;
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.AllowUserToResizeRows = false;
            this.dgvTracks.AllowUserToOrderColumns = false;
            this.dgvTracks.ReadOnly = true;
            this.dgvTracks.RowHeadersVisible = false;
            this.dgvTracks.MultiSelect = false;
            this.dgvTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.BorderStyle = BorderStyle.None;
            this.dgvTracks.BackgroundColor = Color.FromArgb(28, 28, 31);
            this.dgvTracks.GridColor = Color.FromArgb(42, 42, 46);
            this.dgvTracks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTracks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgvTracks.EnableHeadersVisualStyles = false;
            this.dgvTracks.ColumnHeadersHeight = 40;
            this.dgvTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTracks.ScrollBars = ScrollBars.Vertical;
            this.dgvTracks.RowTemplate.Height = 44;

            this.dgvTracks.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 28, 31),
                ForeColor = Color.FromArgb(138, 138, 144),
                SelectionBackColor = Color.FromArgb(28, 28, 31),
                SelectionForeColor = Color.FromArgb(138, 138, 144),
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                WrapMode = DataGridViewTriState.False
            };

            this.dgvTracks.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(33, 33, 37),
                ForeColor = Color.FromArgb(207, 207, 214),
                SelectionBackColor = Color.FromArgb(44, 45, 52),
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5F),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                WrapMode = DataGridViewTriState.False
            };

            this.dgvTracks.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 28, 31),
                ForeColor = Color.FromArgb(207, 207, 214),
                SelectionBackColor = Color.FromArgb(44, 45, 52),
                SelectionForeColor = Color.White
            };

            this.colTitle = new DataGridViewTextBoxColumn();
            this.colTitle.HeaderText = "TITRE";
            this.colTitle.Name = "colTitle";
            this.colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.FillWeight = 100F;
            this.colTitle.MinimumWidth = 240;
            this.colTitle.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colArtist = new DataGridViewTextBoxColumn();
            this.colArtist.HeaderText = "ARTISTE";
            this.colArtist.Name = "colArtist";
            this.colArtist.Width = 240;
            this.colArtist.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colYear = new DataGridViewTextBoxColumn();
            this.colYear.HeaderText = "ANNÉE";
            this.colYear.Name = "colYear";
            this.colYear.Width = 90;
            this.colYear.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colDuration = new DataGridViewTextBoxColumn();
            this.colDuration.HeaderText = "DURÉE";
            this.colDuration.Name = "colDuration";
            this.colDuration.Width = 100;
            this.colDuration.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colSize = new DataGridViewTextBoxColumn();
            this.colSize.HeaderText = "TAILLE";
            this.colSize.Name = "colSize";
            this.colSize.Width = 100;
            this.colSize.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvTracks.Columns.AddRange(new DataGridViewColumn[]
            {
                this.colTitle,
                this.colArtist,
                this.colYear,
                this.colDuration,
                this.colSize
            });

            this.panelStatus = new Panel();
            this.panelStatus.Dock = DockStyle.Bottom;
            this.panelStatus.Height = 48;
            this.panelStatus.BackColor = Color.FromArgb(28, 28, 31);

            this.labelStatus = new Label();
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new Point(20, 16);
            this.labelStatus.Font = new Font("Segoe UI", 8.5F);
            this.labelStatus.ForeColor = Color.FromArgb(138, 138, 144);

            this.panelStatus.Controls.Add(this.labelStatus);

            this.panelLibrary.Controls.Add(this.dgvTracks);
            this.panelLibrary.Controls.Add(this.panelStatus);

            // ------------------------------------------------------------------
            // Lecteur : barre de progression
            // ------------------------------------------------------------------
            this.panelSeekRow = new Panel();
            this.panelSeekRow.Dock = DockStyle.Top;
            this.panelSeekRow.Height = 44;
            this.panelSeekRow.Padding = new Padding(40, 20, 40, 0);
            this.panelSeekRow.BackColor = Color.FromArgb(38, 38, 42);

            this.panelSeekArea = new Panel();
            this.panelSeekArea.Dock = DockStyle.Fill;
            this.panelSeekArea.Margin = new Padding(0);
            this.panelSeekArea.BackColor = Color.FromArgb(38, 38, 42);

            this.panelSeekBg = new Panel();
            this.panelSeekBg.Location = new Point(0, 9);
            this.panelSeekBg.Size = new Size(1120, 6);
            this.panelSeekBg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.panelSeekBg.BackColor = Color.FromArgb(61, 61, 68);

            this.panelSeekFill = new Panel();
            this.panelSeekFill.Location = new Point(0, 9);
            this.panelSeekFill.Size = new Size(430, 6);
            this.panelSeekFill.BackColor = Color.FromArgb(139, 92, 246);

            this.panelSeekKnob = new Panel();
            this.panelSeekKnob.Location = new Point(422, 4);
            this.panelSeekKnob.Size = new Size(16, 16);
            this.panelSeekKnob.BackColor = Color.White;
            this.panelSeekKnob.Region = EllipseRegion(this.panelSeekKnob.Size);

            this.panelSeekArea.Controls.Add(this.panelSeekKnob);
            this.panelSeekArea.Controls.Add(this.panelSeekFill);
            this.panelSeekArea.Controls.Add(this.panelSeekBg);

            this.panelSeekRow.Controls.Add(this.panelSeekArea);

            // ------------------------------------------------------------------
            // Lecteur : temps
            // ------------------------------------------------------------------
            this.panelTimesRow = new Panel();
            this.panelTimesRow.Dock = DockStyle.Top;
            this.panelTimesRow.Height = 26;
            this.panelTimesRow.Padding = new Padding(40, 0, 40, 0);
            this.panelTimesRow.BackColor = Color.FromArgb(38, 38, 42);

            this.labelTimeCurrent = new Label();
            this.labelTimeCurrent.Dock = DockStyle.Left;
            this.labelTimeCurrent.Width = 100;
            this.labelTimeCurrent.Font = new Font("Segoe UI", 8F);
            this.labelTimeCurrent.ForeColor = Color.FromArgb(154, 154, 160);
            this.labelTimeCurrent.TextAlign = ContentAlignment.MiddleLeft;

            this.labelTimeTotal = new Label();
            this.labelTimeTotal.Dock = DockStyle.Right;
            this.labelTimeTotal.Width = 100;
            this.labelTimeTotal.Font = new Font("Segoe UI", 8F);
            this.labelTimeTotal.ForeColor = Color.FromArgb(154, 154, 160);
            this.labelTimeTotal.TextAlign = ContentAlignment.MiddleRight;

            this.panelTimesRow.Controls.Add(this.labelTimeCurrent);
            this.panelTimesRow.Controls.Add(this.labelTimeTotal);

            // ------------------------------------------------------------------
            // Lecteur : transport
            // ------------------------------------------------------------------
            this.btnPrev = new Button();
            this.btnPrev.Size = new Size(32, 32);
            this.btnPrev.Margin = new Padding(0, 4, 12, 0);
            this.btnPrev.BackColor = Color.FromArgb(38, 38, 42);
            this.btnPrev.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnPrev.FlatStyle = FlatStyle.Flat;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 56);
            this.btnPrev.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 62, 70);
            this.btnPrev.Font = new Font("Segoe UI", 8F);
            this.btnPrev.Text = "◀◀";
            this.btnPrev.Cursor = Cursors.Hand;
            this.btnPrev.UseVisualStyleBackColor = false;

            this.btnPlay = new Button();
            this.btnPlay.Size = new Size(40, 40);
            this.btnPlay.Margin = new Padding(0, 0, 12, 0);
            this.btnPlay.BackColor = Color.FromArgb(139, 92, 246);
            this.btnPlay.ForeColor = Color.White;
            this.btnPlay.FlatStyle = FlatStyle.Flat;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            this.btnPlay.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            this.btnPlay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnPlay.Text = "▶";
            this.btnPlay.Cursor = Cursors.Hand;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Region = EllipseRegion(this.btnPlay.Size);

            this.btnNext = new Button();
            this.btnNext.Size = new Size(32, 32);
            this.btnNext.Margin = new Padding(0, 4, 0, 0);
            this.btnNext.BackColor = Color.FromArgb(38, 38, 42);
            this.btnNext.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnNext.FlatStyle = FlatStyle.Flat;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 56);
            this.btnNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 62, 70);
            this.btnNext.Font = new Font("Segoe UI", 8F);
            this.btnNext.Text = "▶▶";
            this.btnNext.Cursor = Cursors.Hand;
            this.btnNext.UseVisualStyleBackColor = false;

            this.flowCenter = new FlowLayoutPanel();
            this.flowCenter.AutoSize = true;
            this.flowCenter.WrapContents = false;
            this.flowCenter.FlowDirection = FlowDirection.LeftToRight;
            this.flowCenter.Margin = new Padding(0, 4, 0, 0);
            this.flowCenter.BackColor = Color.FromArgb(38, 38, 42);
            this.flowCenter.Controls.Add(this.btnPrev);
            this.flowCenter.Controls.Add(this.btnPlay);
            this.flowCenter.Controls.Add(this.btnNext);

            this.labelNowPlaying = new Label();
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.Anchor = AnchorStyles.Left;
            this.labelNowPlaying.Margin = new Padding(0, 14, 0, 0);
            this.labelNowPlaying.Font = new Font("Segoe UI", 9.5F);
            this.labelNowPlaying.ForeColor = Color.FromArgb(216, 216, 222);
            this.labelNowPlaying.Text = "Stairway to Heaven — Led Zeppelin";

            this.labelVolIcon = new Label();
            this.labelVolIcon.AutoSize = true;
            this.labelVolIcon.Margin = new Padding(0, 14, 10, 0);
            this.labelVolIcon.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelVolIcon.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelVolIcon.Text = "VOL";

            this.panelVolume = new Panel();
            this.panelVolume.Size = new Size(106, 24);
            this.panelVolume.Margin = new Padding(0);
            this.panelVolume.BackColor = Color.FromArgb(38, 38, 42);

            this.panelVolumeBg = new Panel();
            this.panelVolumeBg.Location = new Point(0, 9);
            this.panelVolumeBg.Size = new Size(106, 5);
            this.panelVolumeBg.BackColor = Color.FromArgb(61, 61, 68);

            this.panelVolumeFill = new Panel();
            this.panelVolumeFill.Location = new Point(0, 9);
            this.panelVolumeFill.Size = new Size(68, 5);
            this.panelVolumeFill.BackColor = Color.FromArgb(139, 92, 246);

            this.panelVolumeKnob = new Panel();
            this.panelVolumeKnob.Location = new Point(62, 5);
            this.panelVolumeKnob.Size = new Size(13, 13);
            this.panelVolumeKnob.BackColor = Color.White;
            this.panelVolumeKnob.Region = EllipseRegion(this.panelVolumeKnob.Size);

            this.panelVolume.Controls.Add(this.panelVolumeKnob);
            this.panelVolume.Controls.Add(this.panelVolumeFill);
            this.panelVolume.Controls.Add(this.panelVolumeBg);

            this.btnMute = new Button();
            this.btnMute.Size = new Size(28, 28);
            this.btnMute.Margin = new Padding(14, 8, 0, 0);
            this.btnMute.BackColor = Color.FromArgb(50, 50, 56);
            this.btnMute.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnMute.FlatStyle = FlatStyle.Flat;
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            this.btnMute.Font = new Font("Segoe UI", 9F);
            this.btnMute.Text = "✕";
            this.btnMute.Cursor = Cursors.Hand;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Region = EllipseRegion(this.btnMute.Size);

            this.flowRight = new FlowLayoutPanel();
            this.flowRight.AutoSize = true;
            this.flowRight.WrapContents = false;
            this.flowRight.FlowDirection = FlowDirection.LeftToRight;
            this.flowRight.Anchor = AnchorStyles.Right;
            this.flowRight.Margin = new Padding(0, 4, 0, 0);
            this.flowRight.BackColor = Color.FromArgb(38, 38, 42);
            this.flowRight.Controls.Add(this.labelVolIcon);
            this.flowRight.Controls.Add(this.panelVolume);
            this.flowRight.Controls.Add(this.btnMute);

            this.tblTransport = new TableLayoutPanel();
            this.tblTransport.Dock = DockStyle.Fill;
            this.tblTransport.ColumnCount = 3;
            this.tblTransport.RowCount = 1;
            this.tblTransport.BackColor = Color.FromArgb(38, 38, 42);
            this.tblTransport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tblTransport.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tblTransport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tblTransport.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tblTransport.Controls.Add(this.labelNowPlaying, 0, 0);
            this.tblTransport.Controls.Add(this.flowCenter, 1, 0);
            this.tblTransport.Controls.Add(this.flowRight, 2, 0);

            this.panelTransportRow = new Panel();
            this.panelTransportRow.Dock = DockStyle.Fill;
            this.panelTransportRow.BackColor = Color.FromArgb(38, 38, 42);
            this.panelTransportRow.Controls.Add(this.tblTransport);

            this.panelPlayerBorder = new Panel();
            this.panelPlayerBorder.Dock = DockStyle.Top;
            this.panelPlayerBorder.Height = 1;
            this.panelPlayerBorder.BackColor = Color.FromArgb(58, 58, 65);

            this.panelPlayer = new Panel();
            this.panelPlayer.Dock = DockStyle.Bottom;
            this.panelPlayer.Height = 120;
            this.panelPlayer.BackColor = Color.FromArgb(38, 38, 42);
            this.panelPlayer.Controls.Add(this.panelTransportRow);
            this.panelPlayer.Controls.Add(this.panelTimesRow);
            this.panelPlayer.Controls.Add(this.panelSeekRow);
            this.panelPlayer.Controls.Add(this.panelPlayerBorder);

            // ------------------------------------------------------------------
            // Colonne principale
            // ------------------------------------------------------------------
            this.panelMain = new Panel();
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = Color.FromArgb(28, 28, 31);
            this.panelMain.Controls.Add(this.panelLibrary);
            this.panelMain.Controls.Add(this.panelActionBar);

            // ------------------------------------------------------------------
            // Form
            // ------------------------------------------------------------------
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelPlayer);
            this.ResumeLayout(false);
        }

        #endregion

        private static Button CreateNavButton(string text)
        {
            Button button = new Button();
            button.AutoSize = false;
            button.Size = new Size(196, 40);
            button.Margin = new Padding(0, 2, 0, 4);
            button.BackColor = Color.FromArgb(32, 32, 35);
            button.ForeColor = Color.FromArgb(154, 154, 160);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 46);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 56);
            button.Font = new Font("Segoe UI", 9.5F);
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(20, 0, 0, 0);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            return button;
        }

        private static Region EllipseRegion(Size size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size.Width, size.Height);
            return new Region(path);
        }
    }
}
