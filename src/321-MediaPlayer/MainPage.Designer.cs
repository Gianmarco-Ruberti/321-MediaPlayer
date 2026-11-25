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
        private Panel panelContent = null!;
        private NetworkPage networkPage = null!;
        private SettingsPage settingsPage = null!;

        private Panel panelActionBar = null!;
        private Panel panelActionContent = null!;
        private FlowLayoutPanel flowActions = null!;
        private Button btnRefresh = null!;
        private Button btnImport = null!;
        private Panel panelSearchHost = null!;
        private Panel panelSearchBorder = null!;
        private Panel panelSearch = null!;
        private Label labelSearchIcon = null!;
        private TextBox txtSearch = null!;

        private Panel panelLibrary = null!;
        private Panel panelGridHost = null!;
        private DataGridView dgvTracks = null!;
        private DataGridViewTextBoxColumn colTitle = null!;
        private DataGridViewTextBoxColumn colArtist = null!;
        private DataGridViewTextBoxColumn colYear = null!;
        private DataGridViewTextBoxColumn colDuration = null!;
        private DataGridViewTextBoxColumn colSize = null!;
        private Panel panelEmptyState = null!;
        private Label labelEmptyState = null!;
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
        private Label labelVolumeValue = null!;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 28, 31);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(138, 138, 144);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 28, 31);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(138, 138, 144);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 33, 37);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(207, 207, 214);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 45, 52);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 28, 31);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(207, 207, 214);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(44, 45, 52);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            panelSidebar = new Panel();
            panelNavActive = new Panel();
            labelNavMusic = new Label();
            panelNavAccent = new Panel();
            btnNavNetwork = new Button();
            btnNavSettings = new Button();
            panelMain = new Panel();
            panelContent = new Panel();
            panelLibrary = new Panel();
            panelGridHost = new Panel();
            dgvTracks = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colArtist = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            panelEmptyState = new Panel();
            labelEmptyState = new Label();
            panelStatus = new Panel();
            labelStatus = new Label();
            networkPage = new NetworkPage();
            settingsPage = new SettingsPage();
            panelActionBar = new Panel();
            panelActionContent = new Panel();
            flowActions = new FlowLayoutPanel();
            btnRefresh = new Button();
            btnImport = new Button();
            panelSearchHost = new Panel();
            panelSearchBorder = new Panel();
            panelSearch = new Panel();
            labelSearchIcon = new Label();
            txtSearch = new TextBox();
            panelPlayer = new Panel();
            panelTransportRow = new Panel();
            tblTransport = new TableLayoutPanel();
            labelNowPlaying = new Label();
            flowCenter = new FlowLayoutPanel();
            btnPrev = new Button();
            btnPlay = new Button();
            btnNext = new Button();
            flowRight = new FlowLayoutPanel();
            labelVolIcon = new Label();
            panelVolume = new Panel();
            panelVolumeKnob = new Panel();
            panelVolumeFill = new Panel();
            panelVolumeBg = new Panel();
            labelVolumeValue = new Label();
            btnMute = new Button();
            panelTimesRow = new Panel();
            labelTimeCurrent = new Label();
            labelTimeTotal = new Label();
            panelSeekRow = new Panel();
            panelSeekArea = new Panel();
            panelSeekKnob = new Panel();
            panelSeekFill = new Panel();
            panelSeekBg = new Panel();
            panelPlayerBorder = new Panel();
            panelSidebar.SuspendLayout();
            panelNavActive.SuspendLayout();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            panelLibrary.SuspendLayout();
            panelGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTracks).BeginInit();
            panelEmptyState.SuspendLayout();
            panelStatus.SuspendLayout();
            panelActionBar.SuspendLayout();
            panelActionContent.SuspendLayout();
            flowActions.SuspendLayout();
            panelSearchHost.SuspendLayout();
            panelSearchBorder.SuspendLayout();
            panelSearch.SuspendLayout();
            panelPlayer.SuspendLayout();
            panelTransportRow.SuspendLayout();
            tblTransport.SuspendLayout();
            flowCenter.SuspendLayout();
            flowRight.SuspendLayout();
            panelVolume.SuspendLayout();
            panelTimesRow.SuspendLayout();
            panelSeekRow.SuspendLayout();
            panelSeekArea.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(32, 32, 35);
            panelSidebar.Controls.Add(panelNavActive);
            panelSidebar.Controls.Add(btnNavNetwork);
            panelSidebar.Controls.Add(btnNavSettings);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 630);
            panelSidebar.TabIndex = 1;
            // 
            // panelNavActive
            // 
            panelNavActive.BackColor = Color.FromArgb(47, 47, 51);
            panelNavActive.Controls.Add(labelNavMusic);
            panelNavActive.Controls.Add(panelNavAccent);
            panelNavActive.Location = new Point(12, 24);
            panelNavActive.Name = "panelNavActive";
            panelNavActive.Size = new Size(196, 40);
            panelNavActive.TabIndex = 0;
            // 
            // labelNavMusic
            // 
            labelNavMusic.BackColor = Color.Transparent;
            labelNavMusic.Cursor = Cursors.Hand;
            labelNavMusic.Dock = DockStyle.Fill;
            labelNavMusic.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            labelNavMusic.ForeColor = Color.White;
            labelNavMusic.Location = new Point(3, 0);
            labelNavMusic.Name = "labelNavMusic";
            labelNavMusic.Padding = new Padding(17, 0, 0, 0);
            labelNavMusic.Size = new Size(193, 40);
            labelNavMusic.TabIndex = 0;
            labelNavMusic.Text = "Ma musique";
            labelNavMusic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelNavAccent
            // 
            panelNavAccent.BackColor = Color.FromArgb(139, 92, 246);
            panelNavAccent.Dock = DockStyle.Left;
            panelNavAccent.Location = new Point(0, 0);
            panelNavAccent.Name = "panelNavAccent";
            panelNavAccent.Size = new Size(3, 40);
            panelNavAccent.TabIndex = 1;
            // 
            // btnNavNetwork
            // 
            btnNavNetwork.BackColor = Color.FromArgb(32, 32, 35);
            btnNavNetwork.Cursor = Cursors.Hand;
            btnNavNetwork.FlatAppearance.BorderSize = 0;
            btnNavNetwork.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 56);
            btnNavNetwork.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 46);
            btnNavNetwork.FlatStyle = FlatStyle.Flat;
            btnNavNetwork.Font = new Font("Segoe UI", 9.5F);
            btnNavNetwork.ForeColor = Color.FromArgb(154, 154, 160);
            btnNavNetwork.Location = new Point(12, 72);
            btnNavNetwork.Name = "btnNavNetwork";
            btnNavNetwork.Padding = new Padding(20, 0, 0, 0);
            btnNavNetwork.Size = new Size(196, 40);
            btnNavNetwork.TabIndex = 1;
            btnNavNetwork.Text = "Réseau";
            btnNavNetwork.TextAlign = ContentAlignment.MiddleLeft;
            btnNavNetwork.UseVisualStyleBackColor = false;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.FromArgb(32, 32, 35);
            btnNavSettings.Cursor = Cursors.Hand;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 56);
            btnNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 46);
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 9.5F);
            btnNavSettings.ForeColor = Color.FromArgb(154, 154, 160);
            btnNavSettings.Location = new Point(12, 120);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Padding = new Padding(20, 0, 0, 0);
            btnNavSettings.Size = new Size(196, 40);
            btnNavSettings.TabIndex = 2;
            btnNavSettings.Text = "Paramètres";
            btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSettings.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(28, 28, 31);
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelActionBar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(980, 630);
            panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(28, 28, 31);
            panelContent.Controls.Add(panelLibrary);
            panelContent.Controls.Add(networkPage);
            panelContent.Controls.Add(settingsPage);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 56);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(980, 574);
            panelContent.TabIndex = 0;
            // 
            // panelLibrary
            // 
            panelLibrary.BackColor = Color.FromArgb(28, 28, 31);
            panelLibrary.Controls.Add(panelGridHost);
            panelLibrary.Controls.Add(panelStatus);
            panelLibrary.Dock = DockStyle.Fill;
            panelLibrary.Location = new Point(0, 0);
            panelLibrary.Name = "panelLibrary";
            panelLibrary.Padding = new Padding(16, 12, 16, 0);
            panelLibrary.Size = new Size(980, 574);
            panelLibrary.TabIndex = 0;
            // 
            // panelGridHost
            // 
            panelGridHost.BackColor = Color.FromArgb(28, 28, 31);
            panelGridHost.Controls.Add(dgvTracks);
            panelGridHost.Controls.Add(panelEmptyState);
            panelGridHost.Dock = DockStyle.Fill;
            panelGridHost.Location = new Point(16, 12);
            panelGridHost.Name = "panelGridHost";
            panelGridHost.Size = new Size(948, 514);
            panelGridHost.TabIndex = 0;
            // 
            // dgvTracks
            // 
            dgvTracks.AllowUserToAddRows = false;
            dgvTracks.AllowUserToDeleteRows = false;
            dgvTracks.AllowUserToResizeRows = false;
            dgvTracks.BackgroundColor = Color.FromArgb(28, 28, 31);
            dgvTracks.BorderStyle = BorderStyle.None;
            dgvTracks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTracks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTracks.ColumnHeadersHeight = 40;
            dgvTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTracks.Columns.AddRange(new DataGridViewColumn[] { colTitle, colArtist, colYear, colDuration, colSize });
            dgvTracks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTracks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTracks.Dock = DockStyle.Fill;
            dgvTracks.EnableHeadersVisualStyles = false;
            dgvTracks.GridColor = Color.FromArgb(42, 42, 46);
            dgvTracks.Location = new Point(0, 0);
            dgvTracks.MultiSelect = false;
            dgvTracks.Name = "dgvTracks";
            dgvTracks.ReadOnly = true;
            dgvTracks.RowHeadersVisible = false;
            dgvTracks.RowTemplate.Height = 44;
            dgvTracks.ScrollBars = ScrollBars.Vertical;
            dgvTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTracks.Size = new Size(948, 514);
            dgvTracks.TabIndex = 0;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.HeaderText = "TITRE";
            colTitle.MinimumWidth = 240;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            colTitle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colArtist
            // 
            colArtist.HeaderText = "ARTISTE";
            colArtist.Name = "colArtist";
            colArtist.ReadOnly = true;
            colArtist.SortMode = DataGridViewColumnSortMode.NotSortable;
            colArtist.Width = 240;
            // 
            // colYear
            // 
            colYear.HeaderText = "ANNÉE";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            colYear.SortMode = DataGridViewColumnSortMode.NotSortable;
            colYear.Width = 90;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "DURÉE";
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDuration.Width = 100;
            // 
            // colSize
            // 
            colSize.HeaderText = "TAILLE";
            colSize.Name = "colSize";
            colSize.ReadOnly = true;
            colSize.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSize.Width = 100;
            // 
            // panelEmptyState
            // 
            panelEmptyState.BackColor = Color.FromArgb(28, 28, 31);
            panelEmptyState.Controls.Add(labelEmptyState);
            panelEmptyState.Dock = DockStyle.Fill;
            panelEmptyState.Location = new Point(0, 0);
            panelEmptyState.Name = "panelEmptyState";
            panelEmptyState.Size = new Size(948, 514);
            panelEmptyState.TabIndex = 1;
            panelEmptyState.Visible = false;
            // 
            // labelEmptyState
            // 
            labelEmptyState.Dock = DockStyle.Fill;
            labelEmptyState.Font = new Font("Segoe UI", 10F);
            labelEmptyState.ForeColor = Color.FromArgb(154, 154, 160);
            labelEmptyState.Location = new Point(0, 0);
            labelEmptyState.Name = "labelEmptyState";
            labelEmptyState.Size = new Size(948, 514);
            labelEmptyState.TabIndex = 0;
            labelEmptyState.Text = "Aucun média dans ce dossier";
            labelEmptyState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(28, 28, 31);
            panelStatus.Controls.Add(labelStatus);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(16, 526);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(948, 48);
            panelStatus.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 8.5F);
            labelStatus.ForeColor = Color.FromArgb(138, 138, 144);
            labelStatus.Location = new Point(20, 16);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 0;
            // 
            // networkPage
            // 
            networkPage.BackColor = Color.FromArgb(28, 28, 31);
            networkPage.Dock = DockStyle.Fill;
            networkPage.Font = new Font("Segoe UI", 9F);
            networkPage.ForeColor = Color.FromArgb(232, 232, 236);
            networkPage.Location = new Point(0, 0);
            networkPage.Name = "networkPage";
            networkPage.Size = new Size(980, 574);
            networkPage.TabIndex = 1;
            networkPage.Visible = false;
            // 
            // settingsPage
            // 
            settingsPage.BackColor = Color.FromArgb(28, 28, 31);
            settingsPage.Dock = DockStyle.Fill;
            settingsPage.Font = new Font("Segoe UI", 9F);
            settingsPage.ForeColor = Color.FromArgb(232, 232, 236);
            settingsPage.Location = new Point(0, 0);
            settingsPage.Name = "settingsPage";
            settingsPage.Size = new Size(980, 574);
            settingsPage.TabIndex = 2;
            settingsPage.Visible = false;
            // 
            // panelActionBar
            // 
            panelActionBar.BackColor = Color.FromArgb(51, 51, 56);
            panelActionBar.Controls.Add(panelActionContent);
            panelActionBar.Dock = DockStyle.Top;
            panelActionBar.Location = new Point(0, 0);
            panelActionBar.Name = "panelActionBar";
            panelActionBar.Padding = new Padding(0, 0, 0, 1);
            panelActionBar.Size = new Size(980, 56);
            panelActionBar.TabIndex = 1;
            // 
            // panelActionContent
            // 
            panelActionContent.BackColor = Color.FromArgb(31, 31, 34);
            panelActionContent.Controls.Add(flowActions);
            panelActionContent.Controls.Add(panelSearchHost);
            panelActionContent.Dock = DockStyle.Fill;
            panelActionContent.Location = new Point(0, 0);
            panelActionContent.Name = "panelActionContent";
            panelActionContent.Size = new Size(980, 55);
            panelActionContent.TabIndex = 0;
            // 
            // flowActions
            // 
            flowActions.BackColor = Color.FromArgb(31, 31, 34);
            flowActions.Controls.Add(btnRefresh);
            flowActions.Controls.Add(btnImport);
            flowActions.Dock = DockStyle.Right;
            flowActions.FlowDirection = FlowDirection.LeftToRight;
            flowActions.Location = new Point(720, 0);
            flowActions.Name = "flowActions";
            flowActions.Padding = new Padding(8, 12, 20, 0);
            flowActions.Size = new Size(260, 55);
            flowActions.TabIndex = 1;
            flowActions.WrapContents = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(50, 50, 56);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 72, 80);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.FromArgb(207, 207, 214);
            btnRefresh.Location = new Point(8, 12);
            btnRefresh.Margin = new Padding(0, 0, 8, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 32);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Actualiser";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(139, 92, 246);
            btnImport.Cursor = Cursors.Hand;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            btnImport.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(128, 12);
            btnImport.Margin = new Padding(0);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(112, 32);
            btnImport.TabIndex = 1;
            btnImport.Text = "Importer";
            btnImport.UseVisualStyleBackColor = false;
            // 
            // panelSearchHost
            // 
            panelSearchHost.BackColor = Color.FromArgb(31, 31, 34);
            panelSearchHost.Controls.Add(panelSearchBorder);
            panelSearchHost.Dock = DockStyle.Right;
            panelSearchHost.Location = new Point(408, 0);
            panelSearchHost.Name = "panelSearchHost";
            panelSearchHost.Padding = new Padding(0, 10, 12, 10);
            panelSearchHost.Size = new Size(312, 55);
            panelSearchHost.TabIndex = 0;
            // 
            // panelSearchBorder
            // 
            panelSearchBorder.BackColor = Color.FromArgb(58, 58, 65);
            panelSearchBorder.Controls.Add(panelSearch);
            panelSearchBorder.Dock = DockStyle.Fill;
            panelSearchBorder.Location = new Point(0, 10);
            panelSearchBorder.Name = "panelSearchBorder";
            panelSearchBorder.Padding = new Padding(1);
            panelSearchBorder.Size = new Size(300, 35);
            panelSearchBorder.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(42, 42, 46);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(labelSearchIcon);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(1, 1);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(298, 33);
            panelSearch.TabIndex = 0;
            // 
            // labelSearchIcon
            // 
            labelSearchIcon.AutoSize = true;
            labelSearchIcon.BackColor = Color.Transparent;
            labelSearchIcon.Font = new Font("Segoe MDL2 Assets", 9F);
            labelSearchIcon.ForeColor = Color.FromArgb(138, 138, 144);
            labelSearchIcon.Location = new Point(11, 9);
            labelSearchIcon.Name = "labelSearchIcon";
            labelSearchIcon.Size = new Size(17, 12);
            labelSearchIcon.TabIndex = 0;
            labelSearchIcon.Text = "\uE721";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(42, 42, 46);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.FromArgb(138, 138, 144);
            txtSearch.Location = new Point(34, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 16);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Rechercher un titre, un artiste…";
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(38, 38, 42);
            panelPlayer.Controls.Add(panelTransportRow);
            panelPlayer.Controls.Add(panelTimesRow);
            panelPlayer.Controls.Add(panelSeekRow);
            panelPlayer.Controls.Add(panelPlayerBorder);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(0, 630);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(1200, 120);
            panelPlayer.TabIndex = 2;
            // 
            // panelTransportRow
            // 
            panelTransportRow.BackColor = Color.FromArgb(38, 38, 42);
            panelTransportRow.Controls.Add(tblTransport);
            panelTransportRow.Dock = DockStyle.Fill;
            panelTransportRow.Location = new Point(0, 71);
            panelTransportRow.Name = "panelTransportRow";
            panelTransportRow.Size = new Size(1200, 49);
            panelTransportRow.TabIndex = 0;
            // 
            // tblTransport
            // 
            tblTransport.BackColor = Color.FromArgb(38, 38, 42);
            tblTransport.ColumnCount = 3;
            tblTransport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTransport.ColumnStyles.Add(new ColumnStyle());
            tblTransport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTransport.Controls.Add(labelNowPlaying, 0, 0);
            tblTransport.Controls.Add(flowCenter, 1, 0);
            tblTransport.Controls.Add(flowRight, 2, 0);
            tblTransport.Dock = DockStyle.Fill;
            tblTransport.Location = new Point(0, 0);
            tblTransport.Name = "tblTransport";
            tblTransport.RowCount = 1;
            tblTransport.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTransport.Size = new Size(1200, 49);
            tblTransport.TabIndex = 0;
            // 
            // labelNowPlaying
            // 
            labelNowPlaying.Anchor = AnchorStyles.Left;
            labelNowPlaying.AutoSize = true;
            labelNowPlaying.Font = new Font("Segoe UI", 9.5F);
            labelNowPlaying.ForeColor = Color.FromArgb(138, 138, 144);
            labelNowPlaying.Location = new Point(40, 16);
            labelNowPlaying.Margin = new Padding(0, 14, 0, 0);
            labelNowPlaying.Name = "labelNowPlaying";
            labelNowPlaying.Size = new Size(146, 17);
            labelNowPlaying.TabIndex = 0;
            labelNowPlaying.Text = "Aucune lecture en cours";
            // 
            // flowCenter
            // 
            flowCenter.AutoSize = true;
            flowCenter.BackColor = Color.FromArgb(38, 38, 42);
            flowCenter.Controls.Add(btnPrev);
            flowCenter.Controls.Add(btnPlay);
            flowCenter.Controls.Add(btnNext);
            flowCenter.FlowDirection = FlowDirection.LeftToRight;
            flowCenter.Location = new Point(536, 4);
            flowCenter.Margin = new Padding(0, 4, 0, 0);
            flowCenter.Name = "flowCenter";
            flowCenter.Size = new Size(128, 40);
            flowCenter.TabIndex = 1;
            flowCenter.WrapContents = false;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(38, 38, 42);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 62, 70);
            btnPrev.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 56);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 8F);
            btnPrev.ForeColor = Color.FromArgb(207, 207, 214);
            btnPrev.Location = new Point(0, 4);
            btnPrev.Margin = new Padding(0, 4, 12, 0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(32, 32);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "◀◀";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(139, 92, 246);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            btnPlay.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(44, 0);
            btnPlay.Margin = new Padding(0, 0, 12, 0);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(40, 40);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "▶";
            btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(38, 38, 42);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 62, 70);
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 56);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 8F);
            btnNext.ForeColor = Color.FromArgb(207, 207, 214);
            btnNext.Location = new Point(96, 4);
            btnNext.Margin = new Padding(0, 4, 0, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 32);
            btnNext.TabIndex = 2;
            btnNext.Text = "▶▶";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // flowRight
            // 
            flowRight.Anchor = AnchorStyles.Right;
            flowRight.AutoSize = true;
            flowRight.BackColor = Color.FromArgb(38, 38, 42);
            flowRight.Controls.Add(labelVolIcon);
            flowRight.Controls.Add(panelVolume);
            flowRight.Controls.Add(labelVolumeValue);
            flowRight.Controls.Add(btnMute);
            flowRight.FlowDirection = FlowDirection.LeftToRight;
            flowRight.Location = new Point(990, 8);
            flowRight.Margin = new Padding(0, 4, 0, 0);
            flowRight.Name = "flowRight";
            flowRight.Size = new Size(210, 36);
            flowRight.TabIndex = 2;
            flowRight.WrapContents = false;
            // 
            // labelVolIcon
            // 
            labelVolIcon.AutoSize = true;
            labelVolIcon.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            labelVolIcon.ForeColor = Color.FromArgb(138, 138, 144);
            labelVolIcon.Location = new Point(0, 14);
            labelVolIcon.Margin = new Padding(0, 14, 10, 0);
            labelVolIcon.Name = "labelVolIcon";
            labelVolIcon.Size = new Size(25, 12);
            labelVolIcon.TabIndex = 0;
            labelVolIcon.Text = "VOL";
            // 
            // panelVolume
            // 
            panelVolume.BackColor = Color.FromArgb(38, 38, 42);
            panelVolume.Controls.Add(panelVolumeKnob);
            panelVolume.Controls.Add(panelVolumeFill);
            panelVolume.Controls.Add(panelVolumeBg);
            panelVolume.Location = new Point(35, 0);
            panelVolume.Margin = new Padding(0);
            panelVolume.Name = "panelVolume";
            panelVolume.Size = new Size(106, 24);
            panelVolume.TabIndex = 1;
            // 
            // panelVolumeKnob
            // 
            panelVolumeKnob.BackColor = Color.White;
            panelVolumeKnob.Location = new Point(66, 5);
            panelVolumeKnob.Name = "panelVolumeKnob";
            panelVolumeKnob.Size = new Size(13, 13);
            panelVolumeKnob.TabIndex = 0;
            // 
            // panelVolumeFill
            // 
            panelVolumeFill.BackColor = Color.FromArgb(139, 92, 246);
            panelVolumeFill.Location = new Point(0, 9);
            panelVolumeFill.Name = "panelVolumeFill";
            panelVolumeFill.Size = new Size(72, 5);
            panelVolumeFill.TabIndex = 1;
            // 
            // panelVolumeBg
            // 
            panelVolumeBg.BackColor = Color.FromArgb(61, 61, 68);
            panelVolumeBg.Location = new Point(0, 9);
            panelVolumeBg.Name = "panelVolumeBg";
            panelVolumeBg.Size = new Size(106, 5);
            panelVolumeBg.TabIndex = 2;
            // 
            // labelVolumeValue
            // 
            labelVolumeValue.AutoSize = true;
            labelVolumeValue.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            labelVolumeValue.ForeColor = Color.FromArgb(138, 138, 144);
            labelVolumeValue.Location = new Point(149, 15);
            labelVolumeValue.Margin = new Padding(8, 15, 4, 0);
            labelVolumeValue.Name = "labelVolumeValue";
            labelVolumeValue.Size = new Size(31, 12);
            labelVolumeValue.TabIndex = 2;
            labelVolumeValue.Text = "68 %";
            // 
            // btnMute
            // 
            btnMute.BackColor = Color.FromArgb(50, 50, 56);
            btnMute.Cursor = Cursors.Hand;
            btnMute.FlatAppearance.BorderSize = 0;
            btnMute.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            btnMute.FlatStyle = FlatStyle.Flat;
            btnMute.Font = new Font("Segoe UI", 9F);
            btnMute.ForeColor = Color.FromArgb(207, 207, 214);
            btnMute.Location = new Point(184, 8);
            btnMute.Margin = new Padding(14, 8, 0, 0);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(28, 28);
            btnMute.TabIndex = 3;
            btnMute.Text = "✕";
            btnMute.UseVisualStyleBackColor = false;
            // 
            // panelTimesRow
            // 
            panelTimesRow.BackColor = Color.FromArgb(38, 38, 42);
            panelTimesRow.Controls.Add(labelTimeCurrent);
            panelTimesRow.Controls.Add(labelTimeTotal);
            panelTimesRow.Dock = DockStyle.Top;
            panelTimesRow.Location = new Point(0, 45);
            panelTimesRow.Name = "panelTimesRow";
            panelTimesRow.Padding = new Padding(40, 0, 40, 0);
            panelTimesRow.Size = new Size(1200, 26);
            panelTimesRow.TabIndex = 1;
            // 
            // labelTimeCurrent
            // 
            labelTimeCurrent.Dock = DockStyle.Left;
            labelTimeCurrent.Font = new Font("Segoe UI", 8F);
            labelTimeCurrent.ForeColor = Color.FromArgb(154, 154, 160);
            labelTimeCurrent.Location = new Point(40, 0);
            labelTimeCurrent.Name = "labelTimeCurrent";
            labelTimeCurrent.Size = new Size(100, 26);
            labelTimeCurrent.TabIndex = 0;
            labelTimeCurrent.Text = "0:00";
            labelTimeCurrent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTimeTotal
            // 
            labelTimeTotal.Dock = DockStyle.Right;
            labelTimeTotal.Font = new Font("Segoe UI", 8F);
            labelTimeTotal.ForeColor = Color.FromArgb(154, 154, 160);
            labelTimeTotal.Location = new Point(1060, 0);
            labelTimeTotal.Name = "labelTimeTotal";
            labelTimeTotal.Size = new Size(100, 26);
            labelTimeTotal.TabIndex = 1;
            labelTimeTotal.Text = "0:00";
            labelTimeTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelSeekRow
            // 
            panelSeekRow.BackColor = Color.FromArgb(38, 38, 42);
            panelSeekRow.Controls.Add(panelSeekArea);
            panelSeekRow.Dock = DockStyle.Top;
            panelSeekRow.Location = new Point(0, 1);
            panelSeekRow.Name = "panelSeekRow";
            panelSeekRow.Padding = new Padding(40, 20, 40, 0);
            panelSeekRow.Size = new Size(1200, 44);
            panelSeekRow.TabIndex = 2;
            // 
            // panelSeekArea
            // 
            panelSeekArea.BackColor = Color.FromArgb(38, 38, 42);
            panelSeekArea.Controls.Add(panelSeekKnob);
            panelSeekArea.Controls.Add(panelSeekFill);
            panelSeekArea.Controls.Add(panelSeekBg);
            panelSeekArea.Dock = DockStyle.Fill;
            panelSeekArea.Location = new Point(40, 20);
            panelSeekArea.Margin = new Padding(0);
            panelSeekArea.Name = "panelSeekArea";
            panelSeekArea.Size = new Size(1120, 24);
            panelSeekArea.TabIndex = 0;
            // 
            // panelSeekKnob
            // 
            panelSeekKnob.BackColor = Color.White;
            panelSeekKnob.Location = new Point(334, 4);
            panelSeekKnob.Name = "panelSeekKnob";
            panelSeekKnob.Size = new Size(16, 16);
            panelSeekKnob.TabIndex = 0;
            // 
            // panelSeekFill
            // 
            panelSeekFill.BackColor = Color.FromArgb(139, 92, 246);
            panelSeekFill.Location = new Point(0, 9);
            panelSeekFill.Name = "panelSeekFill";
            panelSeekFill.Size = new Size(342, 6);
            panelSeekFill.TabIndex = 1;
            // 
            // panelSeekBg
            // 
            panelSeekBg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSeekBg.BackColor = Color.FromArgb(61, 61, 68);
            panelSeekBg.Location = new Point(0, 9);
            panelSeekBg.Name = "panelSeekBg";
            panelSeekBg.Size = new Size(1120, 6);
            panelSeekBg.TabIndex = 2;
            // 
            // panelPlayerBorder
            // 
            panelPlayerBorder.BackColor = Color.FromArgb(58, 58, 65);
            panelPlayerBorder.Dock = DockStyle.Top;
            panelPlayerBorder.Location = new Point(0, 0);
            panelPlayerBorder.Name = "panelPlayerBorder";
            panelPlayerBorder.Size = new Size(1200, 1);
            panelPlayerBorder.TabIndex = 3;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 31);
            ClientSize = new Size(1200, 750);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelPlayer);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(232, 232, 236);
            MinimumSize = new Size(960, 640);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BitRuisseau";
            panelSidebar.ResumeLayout(false);
            panelNavActive.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelLibrary.ResumeLayout(false);
            panelGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTracks).EndInit();
            panelEmptyState.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelActionBar.ResumeLayout(false);
            panelActionContent.ResumeLayout(false);
            flowActions.ResumeLayout(false);
            panelSearchHost.ResumeLayout(false);
            panelSearchBorder.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelPlayer.ResumeLayout(false);
            panelTransportRow.ResumeLayout(false);
            tblTransport.ResumeLayout(false);
            tblTransport.PerformLayout();
            flowCenter.ResumeLayout(false);
            flowRight.ResumeLayout(false);
            flowRight.PerformLayout();
            panelVolume.ResumeLayout(false);
            panelTimesRow.ResumeLayout(false);
            panelSeekRow.ResumeLayout(false);
            panelSeekArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private static Region EllipseRegion(Size size)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size.Width, size.Height);
            return new Region(path);
        }
    }
}
