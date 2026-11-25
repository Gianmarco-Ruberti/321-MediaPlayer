using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    partial class NetworkPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader = null!;
        private Label labelTitle = null!;
        private Label labelSubtitle = null!;
        private Panel panelHeaderBorder = null!;
        private Panel panelStatusHost = null!;
        private Panel panelStatusCard = null!;
        private Panel panelStatusDot = null!;
        private Label labelStatusTitle = null!;
        private Label labelStatusDetail = null!;
        private Panel panelRefreshHost = null!;
        private Button btnRefresh = null!;
        private Panel panelList = null!;
        private Panel panelListHeader = null!;
        private Label labelListTitle = null!;
        private DataGridView dgvPeers = null!;
        private DataGridViewTextBoxColumn colPeer = null!;
        private DataGridViewTextBoxColumn colLibrary = null!;
        private DataGridViewTextBoxColumn colTracks = null!;
        private DataGridViewTextBoxColumn colLatency = null!;
        private DataGridViewTextBoxColumn colState = null!;

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
            this.Name = "NetworkPage";
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
            this.labelTitle.Text = "Réseau";

            this.labelSubtitle = new Label();
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Location = new Point(34, 50);
            this.labelSubtitle.Font = new Font("Segoe UI", 9F);
            this.labelSubtitle.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelSubtitle.BackColor = Color.Transparent;
            this.labelSubtitle.Text = "Médiathèques partagées par les autres nœuds BitRuisseau";

            this.panelHeaderBorder = new Panel();
            this.panelHeaderBorder.Dock = DockStyle.Bottom;
            this.panelHeaderBorder.Height = 1;
            this.panelHeaderBorder.BackColor = Color.FromArgb(42, 42, 46);

            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelSubtitle);
            this.panelHeader.Controls.Add(this.panelHeaderBorder);

            // ------------------------------------------------------------------
            // Bandeau d'état de la connexion
            // ------------------------------------------------------------------
            this.panelStatusHost = new Panel();
            this.panelStatusHost.Dock = DockStyle.Top;
            this.panelStatusHost.Height = 92;
            this.panelStatusHost.Padding = new Padding(32, 8, 32, 12);
            this.panelStatusHost.BackColor = Color.FromArgb(28, 28, 31);

            this.panelStatusCard = new Panel();
            this.panelStatusCard.Dock = DockStyle.Fill;
            this.panelStatusCard.BackColor = Color.FromArgb(33, 33, 37);

            this.panelStatusDot = new Panel();
            this.panelStatusDot.Location = new Point(20, 23);
            this.panelStatusDot.Size = new Size(9, 9);
            this.panelStatusDot.BackColor = Color.FromArgb(74, 222, 128);
            this.panelStatusDot.Region = EllipseRegion(this.panelStatusDot.Size);

            this.labelStatusTitle = new Label();
            this.labelStatusTitle.AutoSize = true;
            this.labelStatusTitle.Location = new Point(38, 14);
            this.labelStatusTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.labelStatusTitle.ForeColor = Color.FromArgb(232, 232, 236);
            this.labelStatusTitle.BackColor = Color.Transparent;
            this.labelStatusTitle.Text = "Recherche de pairs en cours…";

            this.labelStatusDetail = new Label();
            this.labelStatusDetail.AutoSize = true;
            this.labelStatusDetail.Location = new Point(38, 37);
            this.labelStatusDetail.Font = new Font("Segoe UI", 8.5F);
            this.labelStatusDetail.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelStatusDetail.BackColor = Color.Transparent;
            this.labelStatusDetail.Text = "2 pairs connectés · 3 médiathèques disponibles";

            this.panelRefreshHost = new Panel();
            this.panelRefreshHost.Dock = DockStyle.Right;
            this.panelRefreshHost.Width = 152;
            this.panelRefreshHost.BackColor = Color.FromArgb(33, 33, 37);

            this.btnRefresh = new Button();
            this.btnRefresh.Location = new Point(20, 20);
            this.btnRefresh.Size = new Size(112, 32);
            this.btnRefresh.BackColor = Color.FromArgb(50, 50, 56);
            this.btnRefresh.ForeColor = Color.FromArgb(207, 207, 214);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 62, 70);
            this.btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 72, 80);
            this.btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.UseVisualStyleBackColor = false;

            this.panelRefreshHost.Controls.Add(this.btnRefresh);

            this.panelStatusCard.Controls.Add(this.panelStatusDot);
            this.panelStatusCard.Controls.Add(this.labelStatusTitle);
            this.panelStatusCard.Controls.Add(this.labelStatusDetail);
            this.panelStatusCard.Controls.Add(this.panelRefreshHost);

            this.panelStatusHost.Controls.Add(this.panelStatusCard);

            // ------------------------------------------------------------------
            // Liste des médiathèques distantes
            // ------------------------------------------------------------------
            this.panelList = new Panel();
            this.panelList.Dock = DockStyle.Fill;
            this.panelList.Padding = new Padding(32, 8, 32, 24);
            this.panelList.BackColor = Color.FromArgb(28, 28, 31);

            this.panelListHeader = new Panel();
            this.panelListHeader.Dock = DockStyle.Top;
            this.panelListHeader.Height = 26;
            this.panelListHeader.BackColor = Color.FromArgb(28, 28, 31);

            this.labelListTitle = new Label();
            this.labelListTitle.AutoSize = true;
            this.labelListTitle.Location = new Point(0, 6);
            this.labelListTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelListTitle.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelListTitle.BackColor = Color.Transparent;
            this.labelListTitle.Text = "MÉDIATHÈQUES DU RÉSEAU";

            this.panelListHeader.Controls.Add(this.labelListTitle);

            this.dgvPeers = new DataGridView();
            this.dgvPeers.Dock = DockStyle.Fill;
            this.dgvPeers.AllowUserToAddRows = false;
            this.dgvPeers.AllowUserToDeleteRows = false;
            this.dgvPeers.AllowUserToResizeRows = false;
            this.dgvPeers.AllowUserToOrderColumns = false;
            this.dgvPeers.ReadOnly = true;
            this.dgvPeers.RowHeadersVisible = false;
            this.dgvPeers.MultiSelect = false;
            this.dgvPeers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeers.BorderStyle = BorderStyle.None;
            this.dgvPeers.BackgroundColor = Color.FromArgb(28, 28, 31);
            this.dgvPeers.GridColor = Color.FromArgb(42, 42, 46);
            this.dgvPeers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgvPeers.EnableHeadersVisualStyles = false;
            this.dgvPeers.ColumnHeadersHeight = 40;
            this.dgvPeers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeers.ScrollBars = ScrollBars.Vertical;
            this.dgvPeers.RowTemplate.Height = 44;

            this.dgvPeers.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
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

            this.dgvPeers.DefaultCellStyle = new DataGridViewCellStyle
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

            this.dgvPeers.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 28, 31),
                ForeColor = Color.FromArgb(207, 207, 214),
                SelectionBackColor = Color.FromArgb(44, 45, 52),
                SelectionForeColor = Color.White
            };

            this.colPeer = new DataGridViewTextBoxColumn();
            this.colPeer.HeaderText = "PAIR";
            this.colPeer.Name = "colPeer";
            this.colPeer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colPeer.FillWeight = 40F;
            this.colPeer.MinimumWidth = 160;
            this.colPeer.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colLibrary = new DataGridViewTextBoxColumn();
            this.colLibrary.HeaderText = "MÉDIATHÈQUE";
            this.colLibrary.Name = "colLibrary";
            this.colLibrary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colLibrary.FillWeight = 50F;
            this.colLibrary.MinimumWidth = 220;
            this.colLibrary.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colTracks = new DataGridViewTextBoxColumn();
            this.colTracks.HeaderText = "MORCEAUX";
            this.colTracks.Name = "colTracks";
            this.colTracks.Width = 120;
            this.colTracks.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colLatency = new DataGridViewTextBoxColumn();
            this.colLatency.HeaderText = "LATENCE";
            this.colLatency.Name = "colLatency";
            this.colLatency.Width = 100;
            this.colLatency.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.colState = new DataGridViewTextBoxColumn();
            this.colState.HeaderText = "STATUT";
            this.colState.Name = "colState";
            this.colState.Width = 120;
            this.colState.SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvPeers.Columns.AddRange(new DataGridViewColumn[]
            {
                this.colPeer,
                this.colLibrary,
                this.colTracks,
                this.colLatency,
                this.colState
            });

            this.panelList.Controls.Add(this.dgvPeers);
            this.panelList.Controls.Add(this.panelListHeader);

            // ------------------------------------------------------------------
            // Assemblage
            // ------------------------------------------------------------------
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelStatusHost);
            this.Controls.Add(this.panelHeader);
            this.ResumeLayout(false);
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
