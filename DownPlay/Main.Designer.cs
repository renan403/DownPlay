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
            lblnameSize = new Label();
            lblSize = new Label();
            panel5 = new Panel();
            PirctureBoxThumb = new PictureBox();
            pictureBoxDonwload = new PictureBox();
            lblChannelName = new Label();
            lblTitle = new Label();
            lblStatusDownload = new Label();
            lblVideoName = new Label();
            lblDuration = new Label();
            lblDurationRT = new Label();
            lblChannel = new Label();
            btnDownload = new Button();
            btnLinkYT = new Button();
            lblLinkYoutube = new Label();
            lblErrorYt = new Label();
            txtLinkYT = new TextBox();
            lblDownloadFixed = new Label();
            pgMusica = new TabPage();
            panel3 = new Panel();
            panelLista = new Panel();
            tViewAllMp3 = new TreeView();
            imageList2 = new ImageList(components);
            panel6 = new Panel();
            lblLista = new Label();
            panelConfig = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            lblVol = new Label();
            slider = new PictureBox();
            lblVolume = new Label();
            trackBar1 = new TrackBar();
            lblTimer = new Label();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            lblTitleMusic = new Label();
            labelNameMusic = new Label();
            btnRefresh = new Button();
            lblInfo = new Label();
            txtDirSelected = new TextBox();
            btnSaveDir = new Button();
            lblDir = new Label();
            btnBrowserDialog = new Button();
            tabControl1 = new TabControl();
            tbFTP = new TabPage();
            panel7 = new Panel();
            btnRefreshFTP = new Button();
            btnDisconnect = new Button();
            label14 = new Label();
            label13 = new Label();
            tBoxFileRemoteSelected = new TextBox();
            label12 = new Label();
            tBoxFileLocalSelected = new TextBox();
            label11 = new Label();
            tBoxRemoteFolderSelected = new TextBox();
            lblStatus = new Label();
            btnDonwloadFtp = new Button();
            btnSendFtp = new Button();
            progressBarDirRemote = new ProgressBar();
            tViewRemoteSite = new TreeView();
            imageList1 = new ImageList(components);
            tViewFilesMp3 = new TreeView();
            btnLocalSite = new Button();
            tboxLocalSite = new TextBox();
            label10 = new Label();
            label9 = new Label();
            treeView1 = new TreeView();
            btnConnectFTP = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tBoxPort = new TextBox();
            tBoxPwd = new TextBox();
            tBoxUsername = new TextBox();
            tboxHost = new TextBox();
            folderBrowserDialogDownload = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            tbDownload.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelYT.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PirctureBoxThumb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDonwload).BeginInit();
            pgMusica.SuspendLayout();
            panel3.SuspendLayout();
            panelLista.SuspendLayout();
            panel6.SuspendLayout();
            panelConfig.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            tbFTP.SuspendLayout();
            panel7.SuspendLayout();
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
            tbDownload.Size = new Size(958, 561);
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
            panel1.Size = new Size(952, 555);
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
            PanelYT.Controls.Add(lblnameSize);
            PanelYT.Controls.Add(lblSize);
            PanelYT.Controls.Add(panel5);
            PanelYT.Controls.Add(pictureBoxDonwload);
            PanelYT.Controls.Add(lblChannelName);
            PanelYT.Controls.Add(lblTitle);
            PanelYT.Controls.Add(lblStatusDownload);
            PanelYT.Controls.Add(lblVideoName);
            PanelYT.Controls.Add(lblDuration);
            PanelYT.Controls.Add(lblDurationRT);
            PanelYT.Controls.Add(lblChannel);
            PanelYT.Controls.Add(btnDownload);
            PanelYT.Location = new Point(-3, 112);
            PanelYT.Name = "PanelYT";
            PanelYT.Size = new Size(958, 448);
            PanelYT.TabIndex = 1;
            PanelYT.Visible = false;
            // 
            // lblnameSize
            // 
            lblnameSize.AutoSize = true;
            lblnameSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblnameSize.ForeColor = Color.Lime;
            lblnameSize.Location = new Point(196, 358);
            lblnameSize.Name = "lblnameSize";
            lblnameSize.Size = new Size(33, 15);
            lblnameSize.TabIndex = 19;
            lblnameSize.Text = "Size:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.ForeColor = Color.Lime;
            lblSize.Location = new Point(230, 358);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(27, 15);
            lblSize.TabIndex = 20;
            lblSize.Text = "Size";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(PirctureBoxThumb);
            panel5.Location = new Point(196, 3);
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
            // pictureBoxDonwload
            // 
            pictureBoxDonwload.BackColor = Color.Transparent;
            pictureBoxDonwload.Image = (Image)resources.GetObject("pictureBoxDonwload.Image");
            pictureBoxDonwload.Location = new Point(285, 376);
            pictureBoxDonwload.Name = "pictureBoxDonwload";
            pictureBoxDonwload.Size = new Size(23, 24);
            pictureBoxDonwload.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDonwload.TabIndex = 18;
            pictureBoxDonwload.TabStop = false;
            pictureBoxDonwload.Visible = false;
            pictureBoxDonwload.WaitOnLoad = true;
            // 
            // lblChannelName
            // 
            lblChannelName.AutoSize = true;
            lblChannelName.ForeColor = Color.Lime;
            lblChannelName.Location = new Point(249, 328);
            lblChannelName.Name = "lblChannelName";
            lblChannelName.Size = new Size(74, 15);
            lblChannelName.TabIndex = 12;
            lblChannelName.Text = "Channel title";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(196, 313);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 15);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title:";
            // 
            // lblStatusDownload
            // 
            lblStatusDownload.AutoSize = true;
            lblStatusDownload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusDownload.ForeColor = Color.Lime;
            lblStatusDownload.Location = new Point(383, 376);
            lblStatusDownload.Name = "lblStatusDownload";
            lblStatusDownload.Size = new Size(155, 21);
            lblStatusDownload.TabIndex = 17;
            lblStatusDownload.Text = "Finished download";
            lblStatusDownload.Visible = false;
            // 
            // lblVideoName
            // 
            lblVideoName.AutoSize = true;
            lblVideoName.ForeColor = Color.Lime;
            lblVideoName.Location = new Point(230, 313);
            lblVideoName.Name = "lblVideoName";
            lblVideoName.Size = new Size(70, 15);
            lblVideoName.TabIndex = 8;
            lblVideoName.Text = "Video name";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuration.ForeColor = Color.Lime;
            lblDuration.Location = new Point(196, 343);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(59, 15);
            lblDuration.TabIndex = 13;
            lblDuration.Text = "Duration:";
            // 
            // lblDurationRT
            // 
            lblDurationRT.AutoSize = true;
            lblDurationRT.ForeColor = Color.Lime;
            lblDurationRT.Location = new Point(255, 343);
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
            lblChannel.Location = new Point(196, 328);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(54, 15);
            lblChannel.TabIndex = 11;
            lblChannel.Text = "Channel:";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.MediumSpringGreen;
            btnDownload.Cursor = Cursors.Hand;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(196, 376);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 16;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
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
            pgMusica.Size = new Size(958, 561);
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
            panel3.Size = new Size(952, 555);
            panel3.TabIndex = 1;
            // 
            // panelLista
            // 
            panelLista.BackColor = SystemColors.WindowText;
            panelLista.BackgroundImageLayout = ImageLayout.None;
            panelLista.Controls.Add(tViewAllMp3);
            panelLista.Controls.Add(panel6);
            panelLista.Location = new Point(450, 0);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(495, 552);
            panelLista.TabIndex = 0;
            // 
            // tViewAllMp3
            // 
            tViewAllMp3.BackColor = Color.Black;
            tViewAllMp3.ForeColor = Color.White;
            tViewAllMp3.Location = new Point(0, 43);
            tViewAllMp3.Name = "tViewAllMp3";
            tViewAllMp3.ShowLines = false;
            tViewAllMp3.Size = new Size(491, 501);
            tViewAllMp3.StateImageList = imageList2;
            tViewAllMp3.TabIndex = 3;
            tViewAllMp3.AfterSelect += tViewAllMp3_AfterSelect;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Apps-Player-Audio-icon.png");
            imageList2.Images.SetKeyName(1, "mp3.png");
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.BorderStyle = BorderStyle.FixedSingle;
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
            panel4.Controls.Add(lblVol);
            panel4.Controls.Add(slider);
            panel4.Controls.Add(lblVolume);
            panel4.Controls.Add(trackBar1);
            panel4.Controls.Add(lblTimer);
            panel4.Controls.Add(btnStop);
            panel4.Controls.Add(btnPause);
            panel4.Controls.Add(btnPlay);
            panel4.Controls.Add(lblTitleMusic);
            panel4.Controls.Add(labelNameMusic);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 274);
            panel4.TabIndex = 2;
            panel4.Visible = false;
            // 
            // lblVol
            // 
            lblVol.AutoSize = true;
            lblVol.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVol.ForeColor = Color.Lime;
            lblVol.Location = new Point(391, 122);
            lblVol.Name = "lblVol";
            lblVol.Size = new Size(31, 20);
            lblVol.TabIndex = 10;
            lblVol.Text = "Vol";
            // 
            // slider
            // 
            slider.BackColor = Color.Black;
            slider.Location = new Point(9, 229);
            slider.Name = "slider";
            slider.Size = new Size(421, 13);
            slider.TabIndex = 9;
            slider.TabStop = false;
            slider.Paint += slider_Paint;
            slider.MouseDown += slider_MouseDown;
            slider.MouseMove += slider_MouseMove;
            slider.MouseUp += slider_MouseUp;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolume.ForeColor = Color.Lime;
            lblVolume.Location = new Point(9, 122);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(62, 20);
            lblVolume.TabIndex = 8;
            lblVolume.Text = "Volume";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(9, 145);
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
            lblTimer.Location = new Point(9, 206);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(50, 20);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "Timer";
            lblTimer.Visible = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.White;
            btnStop.FlatAppearance.BorderColor = Color.Gold;
            btnStop.FlatAppearance.BorderSize = 2;
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnStop.Location = new Point(314, 50);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(90, 40);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.White;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPause.Location = new Point(176, 50);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(90, 40);
            btnPause.TabIndex = 3;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPlay.Location = new Point(40, 50);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(90, 40);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
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
            toolTip1.SetToolTip(btnRefresh, "Refresh");
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
            toolTip1.SetToolTip(btnSaveDir, "Save");
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
            toolTip1.SetToolTip(btnBrowserDialog, "Search folder");
            btnBrowserDialog.UseVisualStyleBackColor = false;
            btnBrowserDialog.Click += btnBrowserDialog_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pgMusica);
            tabControl1.Controls.Add(tbDownload);
            tabControl1.Controls.Add(tbFTP);
            tabControl1.Location = new Point(-4, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 589);
            tabControl1.TabIndex = 5;
            // 
            // tbFTP
            // 
            tbFTP.Controls.Add(panel7);
            tbFTP.Location = new Point(4, 24);
            tbFTP.Name = "tbFTP";
            tbFTP.Padding = new Padding(3);
            tbFTP.Size = new Size(958, 561);
            tbFTP.TabIndex = 2;
            tbFTP.Text = "FTP";
            tbFTP.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(btnRefreshFTP);
            panel7.Controls.Add(btnDisconnect);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(tBoxFileRemoteSelected);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(tBoxFileLocalSelected);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(tBoxRemoteFolderSelected);
            panel7.Controls.Add(lblStatus);
            panel7.Controls.Add(btnDonwloadFtp);
            panel7.Controls.Add(btnSendFtp);
            panel7.Controls.Add(progressBarDirRemote);
            panel7.Controls.Add(tViewRemoteSite);
            panel7.Controls.Add(tViewFilesMp3);
            panel7.Controls.Add(btnLocalSite);
            panel7.Controls.Add(tboxLocalSite);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(treeView1);
            panel7.Controls.Add(btnConnectFTP);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(tBoxPort);
            panel7.Controls.Add(tBoxPwd);
            panel7.Controls.Add(tBoxUsername);
            panel7.Controls.Add(tboxHost);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(952, 555);
            panel7.TabIndex = 0;
            // 
            // btnRefreshFTP
            // 
            btnRefreshFTP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.World, 0);
            btnRefreshFTP.Location = new Point(627, 28);
            btnRefreshFTP.Name = "btnRefreshFTP";
            btnRefreshFTP.Size = new Size(75, 23);
            btnRefreshFTP.TabIndex = 31;
            btnRefreshFTP.Text = "Refresh";
            btnRefreshFTP.UseVisualStyleBackColor = true;
            btnRefreshFTP.Visible = false;
            btnRefreshFTP.Click += btnRefreshFTP_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.World, 0);
            btnDisconnect.Location = new Point(546, 28);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 30;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Visible = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.Lime;
            label14.Location = new Point(9, 431);
            label14.Name = "label14";
            label14.Size = new Size(101, 17);
            label14.TabIndex = 29;
            label14.Text = "Folder selected";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.Lime;
            label13.Location = new Point(481, 460);
            label13.Name = "label13";
            label13.Size = new Size(84, 17);
            label13.TabIndex = 28;
            label13.Text = "File selected";
            // 
            // tBoxFileRemoteSelected
            // 
            tBoxFileRemoteSelected.Enabled = false;
            tBoxFileRemoteSelected.Location = new Point(588, 459);
            tBoxFileRemoteSelected.Name = "tBoxFileRemoteSelected";
            tBoxFileRemoteSelected.Size = new Size(352, 23);
            tBoxFileRemoteSelected.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Lime;
            label12.Location = new Point(9, 459);
            label12.Name = "label12";
            label12.Size = new Size(84, 17);
            label12.TabIndex = 26;
            label12.Text = "File selected";
            // 
            // tBoxFileLocalSelected
            // 
            tBoxFileLocalSelected.Enabled = false;
            tBoxFileLocalSelected.Location = new Point(116, 458);
            tBoxFileLocalSelected.Name = "tBoxFileLocalSelected";
            tBoxFileLocalSelected.Size = new Size(353, 23);
            tBoxFileLocalSelected.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Lime;
            label11.Location = new Point(480, 432);
            label11.Name = "label11";
            label11.Size = new Size(101, 17);
            label11.TabIndex = 24;
            label11.Text = "Folder selected";
            // 
            // tBoxRemoteFolderSelected
            // 
            tBoxRemoteFolderSelected.Enabled = false;
            tBoxRemoteFolderSelected.Location = new Point(588, 431);
            tBoxRemoteFolderSelected.Name = "tBoxRemoteFolderSelected";
            tBoxRemoteFolderSelected.Size = new Size(352, 23);
            tBoxRemoteFolderSelected.TabIndex = 23;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(9, 527);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "lblStatus";
            lblStatus.Visible = false;
            // 
            // btnDonwloadFtp
            // 
            btnDonwloadFtp.FlatStyle = FlatStyle.System;
            btnDonwloadFtp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonwloadFtp.Location = new Point(481, 489);
            btnDonwloadFtp.Name = "btnDonwloadFtp";
            btnDonwloadFtp.Size = new Size(85, 33);
            btnDonwloadFtp.TabIndex = 21;
            btnDonwloadFtp.Text = "Download ↓";
            btnDonwloadFtp.UseVisualStyleBackColor = true;
            btnDonwloadFtp.Click += btnDonwloadFtp_Click;
            // 
            // btnSendFtp
            // 
            btnSendFtp.FlatStyle = FlatStyle.System;
            btnSendFtp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendFtp.Location = new Point(9, 489);
            btnSendFtp.Name = "btnSendFtp";
            btnSendFtp.Size = new Size(85, 33);
            btnSendFtp.TabIndex = 20;
            btnSendFtp.Text = "Send ↑";
            btnSendFtp.UseVisualStyleBackColor = true;
            btnSendFtp.Click += btnSendFtp_Click;
            // 
            // progressBarDirRemote
            // 
            progressBarDirRemote.Location = new Point(481, 245);
            progressBarDirRemote.Name = "progressBarDirRemote";
            progressBarDirRemote.Size = new Size(459, 10);
            progressBarDirRemote.TabIndex = 19;
            // 
            // tViewRemoteSite
            // 
            tViewRemoteSite.Location = new Point(480, 260);
            tViewRemoteSite.Name = "tViewRemoteSite";
            tViewRemoteSite.Size = new Size(460, 163);
            tViewRemoteSite.StateImageList = imageList1;
            tViewRemoteSite.TabIndex = 18;
            tViewRemoteSite.AfterSelect += tViewRemoteSite_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "mp3.png");
            imageList1.Images.SetKeyName(1, "3767084.png");
            // 
            // tViewFilesMp3
            // 
            tViewFilesMp3.LineColor = Color.White;
            tViewFilesMp3.Location = new Point(9, 89);
            tViewFilesMp3.Name = "tViewFilesMp3";
            tViewFilesMp3.Size = new Size(460, 334);
            tViewFilesMp3.StateImageList = imageList2;
            tViewFilesMp3.TabIndex = 17;
            tViewFilesMp3.AfterSelect += tViewFilesMp3_AfterSelect;
            // 
            // btnLocalSite
            // 
            btnLocalSite.Location = new Point(444, 428);
            btnLocalSite.Name = "btnLocalSite";
            btnLocalSite.Size = new Size(25, 24);
            btnLocalSite.TabIndex = 16;
            btnLocalSite.Text = "🔍︎";
            btnLocalSite.UseVisualStyleBackColor = true;
            btnLocalSite.Click += btnLocalSite_Click;
            // 
            // tboxLocalSite
            // 
            tboxLocalSite.Enabled = false;
            tboxLocalSite.Location = new Point(116, 428);
            tboxLocalSite.Name = "tboxLocalSite";
            tboxLocalSite.Size = new Size(322, 23);
            tboxLocalSite.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Lime;
            label10.Location = new Point(9, 66);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 14;
            label10.Text = "Local site";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Lime;
            label9.Location = new Point(481, 66);
            label9.Name = "label9";
            label9.Size = new Size(81, 17);
            label9.TabIndex = 10;
            label9.Text = "Remote site";
            // 
            // treeView1
            // 
            treeView1.HideSelection = false;
            treeView1.Location = new Point(480, 89);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(460, 156);
            treeView1.StateImageList = imageList1;
            treeView1.TabIndex = 9;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.DoubleClick += treeView1_DoubleClick;
            // 
            // btnConnectFTP
            // 
            btnConnectFTP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.World, 0);
            btnConnectFTP.Location = new Point(465, 28);
            btnConnectFTP.Name = "btnConnectFTP";
            btnConnectFTP.Size = new Size(75, 23);
            btnConnectFTP.TabIndex = 8;
            btnConnectFTP.Text = "Connect";
            btnConnectFTP.UseVisualStyleBackColor = true;
            btnConnectFTP.Click += btnConnectFTP_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(387, 7);
            label8.Name = "label8";
            label8.Size = new Size(34, 17);
            label8.TabIndex = 7;
            label8.Text = "Port";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(270, 7);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(148, 7);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(9, 7);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 4;
            label5.Text = "Host";
            // 
            // tBoxPort
            // 
            tBoxPort.Location = new Point(387, 28);
            tBoxPort.Name = "tBoxPort";
            tBoxPort.Size = new Size(72, 23);
            tBoxPort.TabIndex = 3;
            tBoxPort.KeyPress += tBoxPort_KeyPress;
            // 
            // tBoxPwd
            // 
            tBoxPwd.Location = new Point(270, 28);
            tBoxPwd.Name = "tBoxPwd";
            tBoxPwd.Size = new Size(111, 23);
            tBoxPwd.TabIndex = 2;
            tBoxPwd.UseSystemPasswordChar = true;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Location = new Point(148, 28);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(116, 23);
            tBoxUsername.TabIndex = 1;
            // 
            // tboxHost
            // 
            tboxHost.Location = new Point(9, 28);
            tboxHost.Name = "tboxHost";
            tboxHost.Size = new Size(133, 23);
            tboxHost.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
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
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PirctureBoxThumb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDonwload).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            tbFTP.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Panel panelLista;
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
        private PictureBox pictureBox1;
        private Label lblLoading;
        private Label lblStatusDownload;
        private PictureBox pictureBoxDonwload;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TabPage tbFTP;
        private Panel panel7;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tBoxPort;
        private TextBox tBoxPwd;
        private TextBox tBoxUsername;
        private TextBox tboxHost;
        private Button btnConnectFTP;
        private TreeView treeView1;
        private Label label9;
        private Label label10;
        private FolderBrowserDialog folderBrowserDialog2;
        private ImageList imageList1;
        private Button btnLocalSite;
        private TextBox tboxLocalSite;
        private TreeView tViewFilesMp3;
        private ImageList imageList2;
        private TreeView tViewRemoteSite;
        private ProgressBar progressBarDirRemote;
        private Button btnDonwloadFtp;
        private Button btnSendFtp;
        private PictureBox slider;
        private System.Windows.Forms.Timer timer1;
        private TreeView tViewAllMp3;
        private Panel PanelYT;
        private Label lblnameSize;
        private Label lblSize;
        private Label lblStatus;
        private Label label12;
        private TextBox tBoxFileLocalSelected;
        private Label label11;
        private TextBox tBoxRemoteFolderSelected;
        private Label label14;
        private Label label13;
        private TextBox tBoxFileRemoteSelected;
        private Button btnDisconnect;
        private Button btnRefreshFTP;
        private ToolTip toolTip1;
        private Label lblVol;
    }
}
