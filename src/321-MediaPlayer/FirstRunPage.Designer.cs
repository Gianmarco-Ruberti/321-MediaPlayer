using System.Drawing;
using System.Windows.Forms;

namespace _321_MediaPlayer
{
    partial class FirstRunPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelAccent = null!;
        private Label labelTitle = null!;
        private Label labelIntro = null!;
        private Panel panelFolderCard = null!;
        private Label labelFolderCaption = null!;
        private Label labelFolderPath = null!;
        private Button btnBrowse = null!;
        private Label labelHint = null!;
        private Panel panelFooterBorder = null!;
        private Button btnStart = null!;
        private Button btnLater = null!;

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
            this.ClientSize = new Size(720, 484);
            this.Font = new Font("Segoe UI", 9F);
            this.ForeColor = Color.FromArgb(232, 232, 236);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstRunPage";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BitRuisseau — Configuration";
            this.DoubleBuffered = true;

            // ------------------------------------------------------------------
            // En-tête
            // ------------------------------------------------------------------
            this.panelAccent = new Panel();
            this.panelAccent.Location = new Point(40, 46);
            this.panelAccent.Size = new Size(40, 4);
            this.panelAccent.BackColor = Color.FromArgb(139, 92, 246);

            this.labelTitle = new Label();
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new Point(40, 62);
            this.labelTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            this.labelTitle.ForeColor = Color.FromArgb(244, 244, 247);
            this.labelTitle.Text = "Bienvenue dans BitRuisseau";

            this.labelIntro = new Label();
            this.labelIntro.Location = new Point(40, 112);
            this.labelIntro.Size = new Size(640, 58);
            this.labelIntro.Font = new Font("Segoe UI", 9.75F);
            this.labelIntro.ForeColor = Color.FromArgb(154, 154, 160);
            this.labelIntro.Text = "Indique le dossier où se trouvent tes médias. La bibliothèque s'ouvrira directement au prochain démarrage, sans repasser par cet écran.";

            // ------------------------------------------------------------------
            // Carte du dossier média
            // ------------------------------------------------------------------
            this.panelFolderCard = new Panel();
            this.panelFolderCard.Location = new Point(40, 196);
            this.panelFolderCard.Size = new Size(640, 108);
            this.panelFolderCard.BackColor = Color.FromArgb(32, 32, 35);

            this.labelFolderCaption = new Label();
            this.labelFolderCaption.AutoSize = true;
            this.labelFolderCaption.Location = new Point(24, 20);
            this.labelFolderCaption.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            this.labelFolderCaption.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelFolderCaption.Text = "DOSSIER MÉDIA";

            this.labelFolderPath = new Label();
            this.labelFolderPath.Location = new Point(24, 44);
            this.labelFolderPath.Size = new Size(396, 24);
            this.labelFolderPath.Font = new Font("Segoe UI", 10F);
            this.labelFolderPath.ForeColor = Color.FromArgb(138, 138, 144);
            this.labelFolderPath.TextAlign = ContentAlignment.MiddleLeft;
            this.labelFolderPath.AutoEllipsis = true;
            this.labelFolderPath.Text = "Aucun dossier sélectionné";

            this.btnBrowse = new Button();
            this.btnBrowse.Location = new Point(440, 34);
            this.btnBrowse.Size = new Size(176, 40);
            this.btnBrowse.BackColor = Color.FromArgb(42, 42, 46);
            this.btnBrowse.ForeColor = Color.FromArgb(232, 232, 236);
            this.btnBrowse.FlatStyle = FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(54, 54, 60);
            this.btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 72);
            this.btnBrowse.Font = new Font("Segoe UI", 9.5F);
            this.btnBrowse.Text = "Parcourir…";
            this.btnBrowse.Cursor = Cursors.Hand;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += this.btnBrowse_Click;

            this.panelFolderCard.Controls.Add(this.labelFolderCaption);
            this.panelFolderCard.Controls.Add(this.labelFolderPath);
            this.panelFolderCard.Controls.Add(this.btnBrowse);

            // ------------------------------------------------------------------
            // Pied de page
            // ------------------------------------------------------------------
            this.labelHint = new Label();
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new Point(40, 324);
            this.labelHint.Font = new Font("Segoe UI", 8.5F);
            this.labelHint.ForeColor = Color.FromArgb(111, 111, 119);
            this.labelHint.Text = "Analyse locale uniquement — aucun fichier n'est envoyé en ligne.";

            this.panelFooterBorder = new Panel();
            this.panelFooterBorder.Location = new Point(40, 372);
            this.panelFooterBorder.Size = new Size(640, 1);
            this.panelFooterBorder.BackColor = Color.FromArgb(51, 51, 56);

            this.btnStart = new Button();
            this.btnStart.Location = new Point(40, 404);
            this.btnStart.Size = new Size(180, 44);
            this.btnStart.BackColor = Color.FromArgb(58, 58, 65);
            this.btnStart.ForeColor = Color.FromArgb(120, 120, 128);
            this.btnStart.FlatStyle = FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 118, 255);
            this.btnStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 76, 224);
            this.btnStart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnStart.Text = "Commencer";
            this.btnStart.Enabled = false;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += this.btnStart_Click;

            this.btnLater = new Button();
            this.btnLater.Location = new Point(232, 404);
            this.btnLater.Size = new Size(120, 44);
            this.btnLater.BackColor = Color.FromArgb(28, 28, 31);
            this.btnLater.ForeColor = Color.FromArgb(138, 138, 144);
            this.btnLater.FlatStyle = FlatStyle.Flat;
            this.btnLater.FlatAppearance.BorderSize = 0;
            this.btnLater.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 46);
            this.btnLater.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 56);
            this.btnLater.Font = new Font("Segoe UI", 9.5F);
            this.btnLater.Text = "Plus tard";
            this.btnLater.Cursor = Cursors.Hand;
            this.btnLater.UseVisualStyleBackColor = false;
            this.btnLater.Click += this.btnLater_Click;

            // ------------------------------------------------------------------
            // Assemblage
            // ------------------------------------------------------------------
            this.Controls.Add(this.panelAccent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelIntro);
            this.Controls.Add(this.panelFolderCard);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.panelFooterBorder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLater);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
