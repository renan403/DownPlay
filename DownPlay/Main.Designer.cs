namespace DownPlay
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            timer = new System.Windows.Forms.Timer(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            tbDownload = new TabPage();
            panel1 = new Panel();
            lblLoading = new Label();
            pictureBox1 = new PictureBox();
            PanelYT = new Panel();
            pictureBoxDonwload = new PictureBox();
            lblStatusDownload = new Label();
            panel5 = new Panel();
            PirctureBoxThumb = new PictureBox();
            btnDownload = new Button();
            lblVideoName = new Label();
            lblTitle = new Label();
            lblDurationRT = new Label();
            lblChannel = new Label();
            lblDuration = new Label();
            lblChannelName = new Label();
            btnLinkYT = new Button();
            lblLinkYoutube = new Label();
            lblErrorYt = new Label();
            txtLinkYT = new TextBox();
            lblDownloadFixed = new Label();
            pgMusica = new TabPage();
            panel3 = new Panel();
            panelLista = new Panel();
            panel6 = new Panel();
            lblLista = new Label();
            listboxMusic = new ListBox();
            panelConfig = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            lblVolume = new Label();
            trackBar1 = new TrackBar();
            lblTimer = new Label();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            lblTitleMusic = new Label();
            labelNameMusic = new Label();
            ProgressBarMusic = new ProgressBar();
            btnRefresh = new Button();
            lblInfo = new Label();
            txtDirSelected = new TextBox();
            btnSaveDir = new Button();
            lblDir = new Label();
            btnBrowserDialog = new Button();
            tabControl1 = new TabControl();
            folderBrowserDialogDownload = new FolderBrowserDialog();
            tbDownload.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelYT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDonwload).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PirctureBoxThumb).BeginInit();
            pgMusica.SuspendLayout();
            panel3.SuspendLayout();
            panelLista.SuspendLayout();
            panel6.SuspendLayout();
            panelConfig.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // tbDownload
            // 
            tbDownload.BackColor = SystemColors.ActiveCaption;
            tbDownload.Controls.Add(panel1);
            tbDownload.Location = new Point(4, 24);
            tbDownload.Name = "tbDownload";
            tbDownload.Padding = new Padding(3);
            tbDownload.Size = new Size(958, 563);
            tbDownload.TabIndex = 1;
            tbDownload.Text = "Download";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblLoading);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PanelYT);
            panel1.Controls.Add(btnLinkYT);
            panel1.Controls.Add(lblLinkYoutube);
            panel1.Controls.Add(lblErrorYt);
            panel1.Controls.Add(txtLinkYT);
            panel1.Controls.Add(lblDownloadFixed);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 557);
            panel1.TabIndex = 0;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.ForeColor = Color.Lime;
            lblLoading.Location = new Point(569, 31);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(38, 15);
            lblLoading.TabIndex = 12;
            lblLoading.Text = "label1";
            lblLoading.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(540, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // PanelYT
            // 
            PanelYT.BackColor = Color.Transparent;
            PanelYT.Controls.Add(pictureBoxDonwload);
            PanelYT.Controls.Add(lblStatusDownload);
            PanelYT.Controls.Add(panel5);
            PanelYT.Controls.Add(btnDownload);
            PanelYT.Controls.Add(lblVideoName);
            PanelYT.Controls.Add(lblTitle);
            PanelYT.Controls.Add(lblDurationRT);
            PanelYT.Controls.Add(lblChannel);
            PanelYT.Controls.Add(lblDuration);
            PanelYT.Controls.Add(lblChannelName);
            PanelYT.Location = new Point(-3, 112);
            PanelYT.Name = "PanelYT";
            PanelYT.Size = new Size(958, 448);
            PanelYT.TabIndex = 1;
            PanelYT.Visible = false;
            // 
            // pictureBoxDonwload
            // 
            pictureBoxDonwload.BackColor = Color.Transparent;
            pictureBoxDonwload.Image = (Image)resources.GetObject("pictureBoxDonwload.Image");
            pictureBoxDonwload.Location = new Point(282, 380);
            pictureBoxDonwload.Name = "pictureBoxDonwload";
            pictureBoxDonwload.Size = new Size(23, 24);
            pictureBoxDonwload.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDonwload.TabIndex = 18;
            pictureBoxDonwload.TabStop = false;
            pictureBoxDonwload.Visible = false;
            pictureBoxDonwload.WaitOnLoad = true;
            // 
            // lblStatusDownload
            // 
            lblStatusDownload.AutoSize = true;
            lblStatusDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusDownload.ForeColor = Color.Lime;
            lblStatusDownload.Location = new Point(286, 384);
            lblStatusDownload.Name = "lblStatusDownload";
            lblStatusDownload.Size = new Size(40, 15);
            lblStatusDownload.TabIndex = 17;
            lblStatusDownload.Text = "label1";
            lblStatusDownload.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(PirctureBoxThumb);
            panel5.Location = new Point(193, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(556, 307);
            panel5.TabIndex = 9;
            // 
            // PirctureBoxThumb
            // 
            PirctureBoxThumb.BorderStyle = BorderStyle.FixedSingle;
            PirctureBoxThumb.Dock = DockStyle.Fill;
            PirctureBoxThumb.Image = (Image)resources.GetObject("PirctureBoxThumb.Image");
            PirctureBoxThumb.Location = new Point(0, 0);
            PirctureBoxThumb.Name = "PirctureBoxThumb";
            PirctureBoxThumb.Size = new Size(556, 307);
            PirctureBoxThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            PirctureBoxThumb.TabIndex = 0;
            PirctureBoxThumb.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.MediumSpringGreen;
            btnDownload.Cursor = Cursors.Hand;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(193, 380);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 16;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // lblVideoName
            // 
            lblVideoName.AutoSize = true;
            lblVideoName.ForeColor = Color.Lime;
            lblVideoName.Location = new Point(227, 329);
            lblVideoName.Name = "lblVideoName";
            lblVideoName.Size = new Size(70, 15);
            lblVideoName.TabIndex = 8;
            lblVideoName.Text = "Video name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(193, 329);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 15);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title:";
            // 
            // lblDurationRT
            // 
            lblDurationRT.AutoSize = true;
            lblDurationRT.ForeColor = Color.Lime;
            lblDurationRT.Location = new Point(252, 359);
            lblDurationRT.Name = "lblDurationRT";
            lblDurationRT.Size = new Size(53, 15);
            lblDurationRT.TabIndex = 14;
            lblDurationRT.Text = "Duration";
            // 
            // lblChannel
            // 
            lblChannel.AutoSize = true;
            lblChannel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChannel.ForeColor = Color.Lime;
            lblChannel.Location = new Point(193, 344);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(54, 15);
            lblChannel.TabIndex = 11;
            lblChannel.Text = "Channel:";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuration.ForeColor = Color.Lime;
            lblDuration.Location = new Point(193, 359);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(59, 15);
            lblDuration.TabIndex = 13;
            lblDuration.Text = "Duration:";
            // 
            // lblChannelName
            // 
            lblChannelName.AutoSize = true;
            lblChannelName.ForeColor = Color.Lime;
            lblChannelName.Location = new Point(246, 344);
            lblChannelName.Name = "lblChannelName";
            lblChannelName.Size = new Size(74, 15);
            lblChannelName.TabIndex = 12;
            lblChannelName.Text = "Channel title";
            // 
            // btnLinkYT
            // 
            btnLinkYT.Location = new Point(510, 26);
            btnLinkYT.Name = "btnLinkYT";
            btnLinkYT.Size = new Size(25, 24);
            btnLinkYT.TabIndex = 7;
            btnLinkYT.Text = "🔍︎";
            btnLinkYT.UseVisualStyleBackColor = true;
            btnLinkYT.Click += btnLinkYT_Click;
            // 
            // lblLinkYoutube
            // 
            lblLinkYoutube.AutoSize = true;
            lblLinkYoutube.BackColor = Color.Transparent;
            lblLinkYoutube.ForeColor = Color.Lime;
            lblLinkYoutube.Location = new Point(9, 31);
            lblLinkYoutube.Name = "lblLinkYoutube";
            lblLinkYoutube.Size = new Size(32, 15);
            lblLinkYoutube.TabIndex = 6;
            lblLinkYoutube.Text = "Link:";
            // 
            // lblErrorYt
            // 
            lblErrorYt.AutoSize = true;
            lblErrorYt.Location = new Point(47, 54);
            lblErrorYt.Name = "lblErrorYt";
            lblErrorYt.Size = new Size(38, 15);
            lblErrorYt.TabIndex = 15;
            lblErrorYt.Text = "label1";
            lblErrorYt.Visible = false;
            // 
            // txtLinkYT
            // 
            txtLinkYT.Location = new Point(47, 28);
            txtLinkYT.Name = "txtLinkYT";
            txtLinkYT.PlaceholderText = "Link video...";
            txtLinkYT.Size = new Size(457, 23);
            txtLinkYT.TabIndex = 5;
            // 
            // lblDownloadFixed
            // 
            lblDownloadFixed.AutoSize = true;
            lblDownloadFixed.BackColor = Color.Transparent;
            lblDownloadFixed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDownloadFixed.ForeColor = Color.Lime;
            lblDownloadFixed.Location = new Point(7, 7);
            lblDownloadFixed.Name = "lblDownloadFixed";
            lblDownloadFixed.Size = new Size(108, 17);
            lblDownloadFixed.TabIndex = 4;
            lblDownloadFixed.Text = "YoutubeExplode";
            // 
            // pgMusica
            // 
            pgMusica.BackColor = SystemColors.ActiveCaptionText;
            pgMusica.Controls.Add(panel3);
            pgMusica.ForeColor = Color.Black;
            pgMusica.Location = new Point(4, 24);
            pgMusica.Name = "pgMusica";
            pgMusica.Padding = new Padding(3);
            pgMusica.Size = new Size(958, 563);
            pgMusica.TabIndex = 0;
            pgMusica.Text = "Musics";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(panelLista);
            panel3.Controls.Add(panelConfig);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 557);
            panel3.TabIndex = 1;
            // 
            // panelLista
            // 
            panelLista.BackColor = SystemColors.WindowText;
            panelLista.BackgroundImageLayout = ImageLayout.None;
            panelLista.Controls.Add(panel6);
            panelLista.Controls.Add(listboxMusic);
            panelLista.Location = new Point(450, 0);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(495, 552);
            panelLista.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(lblLista);
            panel6.ForeColor = SystemColors.ButtonFace;
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(491, 44);
            panel6.TabIndex = 2;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(212, 9);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(69, 21);
            lblLista.TabIndex = 0;
            lblLista.Text = "All mp3";
            // 
            // listboxMusic
            // 
            listboxMusic.BackColor = SystemColors.WindowText;
            listboxMusic.BorderStyle = BorderStyle.FixedSingle;
            listboxMusic.DrawMode = DrawMode.OwnerDrawFixed;
            listboxMusic.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listboxMusic.ForeColor = Color.Yellow;
            listboxMusic.FormattingEnabled = true;
            listboxMusic.ItemHeight = 20;
            listboxMusic.Location = new Point(0, 45);
            listboxMusic.Name = "listboxMusic";
            listboxMusic.Size = new Size(492, 502);
            listboxMusic.Sorted = true;
            listboxMusic.TabIndex = 1;
            listboxMusic.Click += listboxMusic_Click;
            listboxMusic.DrawItem += listboxMusic_DrawItem;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = SystemColors.ActiveCaptionText;
            panelConfig.BorderStyle = BorderStyle.FixedSingle;
            panelConfig.Controls.Add(label4);
            panelConfig.Controls.Add(label3);
            panelConfig.Controls.Add(label2);
            panelConfig.Controls.Add(label1);
            panelConfig.Controls.Add(panel2);
            panelConfig.Controls.Add(btnRefresh);
            panelConfig.Controls.Add(lblInfo);
            panelConfig.Controls.Add(txtDirSelected);
            panelConfig.Controls.Add(btnSaveDir);
            panelConfig.Controls.Add(lblDir);
            panelConfig.Controls.Add(btnBrowserDialog);
            panelConfig.Location = new Point(0, 0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(444, 552);
            panelConfig.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(4, 223);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 10;
            label4.Text = " button above.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(3, 202);
            label3.Name = "label3";
            label3.Size = new Size(421, 17);
            label3.TabIndex = 9;
            label3.Text = "• If you download and the song doesn't appear here, click the refresh  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(3, 175);
            label2.Name = "label2";
            label2.Size = new Size(243, 17);
            label2.TabIndex = 8;
            label2.Text = "• Music needs to be stopped to change.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(3, 149);
            label1.Name = "label1";
            label1.Size = new Size(362, 17);
            label1.TabIndex = 7;
            label1.Text = "• The directory is the same for downloading in the other tab.";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(1, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 274);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblVolume);
            panel4.Controls.Add(trackBar1);
            panel4.Controls.Add(lblTimer);
            panel4.Controls.Add(btnStop);
            panel4.Controls.Add(btnPause);
            panel4.Controls.Add(btnPlay);
            panel4.Controls.Add(lblTitleMusic);
            panel4.Controls.Add(labelNameMusic);
            panel4.Controls.Add(ProgressBarMusic);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 274);
            panel4.TabIndex = 2;
            panel4.Visible = false;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolume.ForeColor = Color.Lime;
            lblVolume.Location = new Point(9, 119);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(62, 20);
            lblVolume.TabIndex = 8;
            lblVolume.Text = "Volume";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(9, 142);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(421, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 30;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.Lime;
            lblTimer.Location = new Point(9, 204);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(50, 20);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "Timer";
            lblTimer.Visible = false;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnStop.Location = new Point(314, 50);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(90, 40);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPause.Location = new Point(176, 50);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(90, 40);
            btnPause.TabIndex = 3;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPlay.Location = new Point(40, 50);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(90, 40);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblTitleMusic
            // 
            lblTitleMusic.AutoEllipsis = true;
            lblTitleMusic.AutoSize = true;
            lblTitleMusic.BackColor = SystemColors.ActiveCaptionText;
            lblTitleMusic.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleMusic.ForeColor = Color.Lime;
            lblTitleMusic.Location = new Point(52, 12);
            lblTitleMusic.Name = "lblTitleMusic";
            lblTitleMusic.Size = new Size(47, 20);
            lblTitleMusic.TabIndex = 1;
            lblTitleMusic.Text = "Music";
            // 
            // labelNameMusic
            // 
            labelNameMusic.AutoSize = true;
            labelNameMusic.BackColor = SystemColors.ActiveCaptionText;
            labelNameMusic.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameMusic.ForeColor = Color.Lime;
            labelNameMusic.Location = new Point(9, 12);
            labelNameMusic.Name = "labelNameMusic";
            labelNameMusic.Size = new Size(48, 20);
            labelNameMusic.TabIndex = 1;
            labelNameMusic.Text = "Song:";
            // 
            // ProgressBarMusic
            // 
            ProgressBarMusic.BackColor = SystemColors.ActiveCaption;
            ProgressBarMusic.Location = new Point(9, 227);
            ProgressBarMusic.Name = "ProgressBarMusic";
            ProgressBarMusic.Size = new Size(421, 10);
            ProgressBarMusic.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gold;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(356, 63);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(35, 35);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "⟳";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Black;
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            lblInfo.ForeColor = Color.LawnGreen;
            lblInfo.Location = new Point(3, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(48, 19);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "lblInfo";
            lblInfo.Visible = false;
            // 
            // txtDirSelected
            // 
            txtDirSelected.Enabled = false;
            txtDirSelected.Location = new Point(3, 34);
            txtDirSelected.Name = "txtDirSelected";
            txtDirSelected.Size = new Size(429, 23);
            txtDirSelected.TabIndex = 3;
            // 
            // btnSaveDir
            // 
            btnSaveDir.BackColor = Color.Cyan;
            btnSaveDir.Cursor = Cursors.Hand;
            btnSaveDir.FlatStyle = FlatStyle.Flat;
            btnSaveDir.Image = Properties.Resources.icons8_salvar_16;
            btnSaveDir.Location = new Point(397, 64);
            btnSaveDir.Name = "btnSaveDir";
            btnSaveDir.Size = new Size(35, 35);
            btnSaveDir.TabIndex = 2;
            btnSaveDir.UseVisualStyleBackColor = false;
            btnSaveDir.Click += btnSaveDir_Click;
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDir.ForeColor = Color.Lime;
            lblDir.Location = new Point(3, 11);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(75, 20);
            lblDir.TabIndex = 1;
            lblDir.Text = "Directory";
            // 
            // btnBrowserDialog
            // 
            btnBrowserDialog.BackColor = Color.Chartreuse;
            btnBrowserDialog.Cursor = Cursors.Hand;
            btnBrowserDialog.FlatStyle = FlatStyle.Flat;
            btnBrowserDialog.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowserDialog.Location = new Point(316, 63);
            btnBrowserDialog.Name = "btnBrowserDialog";
            btnBrowserDialog.Size = new Size(35, 35);
            btnBrowserDialog.TabIndex = 0;
            btnBrowserDialog.Text = "🔍︎";
            btnBrowserDialog.UseVisualStyleBackColor = false;
            btnBrowserDialog.Click += btnBrowserDialog_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pgMusica);
            tabControl1.Controls.Add(tbDownload);
            tabControl1.Location = new Point(-4, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 591);
            tabControl1.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(956, 580);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            tbDownload.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelYT.ResumeLayout(false);
            PanelYT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDonwload).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PirctureBoxThumb).EndInit();
            pgMusica.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelLista.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelConfig.ResumeLayout(false);
            panelConfig.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabPage tbDownload;
        private Panel panel1;
        private TabPage pgMusica;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label lblVolume;
        private TrackBar trackBar1;
        private Label lblTimer;
        private Button btnStop;
        private Button btnPause;
        private Button btnPlay;
        private Label lblTitleMusic;
        private Label labelNameMusic;
        private ProgressBar ProgressBarMusic;
        private Panel panelLista;
        private ListBox listboxMusic;
        private Label lblLista;
        private Panel panelConfig;
        private Label lblInfo;
        private TextBox txtDirSelected;
        private Button btnSaveDir;
        private Label lblDir;
        private Button btnBrowserDialog;
        private TabControl tabControl1;
        private FolderBrowserDialog folderBrowserDialogDownload;
        private Label lblLinkYoutube;
        private TextBox txtLinkYT;
        private Label lblDownloadFixed;
        private Button btnLinkYT;
        private Button btnRefresh;
        private Panel panel5;
        private PictureBox PirctureBoxThumb;
        private Label lblVideoName;
        private Label lblChannelName;
        private Label lblChannel;
        private Label lblTitle;
        private Label lblDurationRT;
        private Label lblDuration;
        private Label lblErrorYt;
        private Button btnDownload;
        private Panel PanelYT;
        private PictureBox pictureBox1;
        private Label lblLoading;
        private Label lblStatusDownload;
        private PictureBox pictureBoxDonwload;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}
