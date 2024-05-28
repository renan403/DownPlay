using FluentFTP;
using NAudio.Wave;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using WinSCP;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace DownPlay
{
    public partial class Main : Form
    {
        readonly WaveOutEvent wave;
        Mp3FileReader? mp3;
        string? dir, lastMusic;
        float default_value = 0.1f, min = 0.0f, max = 1.0f;

        public Main()
        {
            InitializeComponent();
            slider.Height = 30;
            this.MaximizeBox = false;
            LoadInfo();
            wave = new WaveOutEvent
            {
                Volume = (float)trackBar1.Value / 100
            };
            default_value = 0;
        }



        private void btnBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != null)
            {
                txtDirSelected.Text = folderBrowserDialog1.SelectedPath;
                LoadInfo();
            }
        }
        private void btnSaveDir_Click(object sender, EventArgs e)
        {
            dir = txtDirSelected.Text;
            var dirApp = Directory.GetCurrentDirectory();
            try
            {
                using (StreamWriter stream = new StreamWriter(dirApp + "\\config.txt"))
                {
                    stream.NewLine = "\n";
                    stream.Write(dir);
                    stream.Flush();
                }

                lblInfo.Text = "Success to save.";
                lblInfo.ForeColor = Color.LightGreen;
                Task.Run(() =>
                {
                    if (lblInfo.InvokeRequired)
                    {
                        lblInfo.Invoke(() => { lblInfo.Visible = true; });
                        Thread.Sleep(2000);
                        lblInfo.Invoke(() => { lblInfo.Visible = false; });
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        Thread.Sleep(2000);
                        lblInfo.Visible = false;
                    }
                });
            }
            catch (Exception)
            {
                lblInfo.Text = "Was there an error!";
                lblInfo.ForeColor = Color.Red;
            }
        }
        private void LoadInfo()
        {
            string dirApp = string.IsNullOrEmpty(txtDirSelected.Text) ? Directory.GetCurrentDirectory() + "\\config.txt" : txtDirSelected.Text;
            // var dirApp = Directory.GetCurrentDirectory() + "\\config.txt";
            var dirconfVol = Directory.GetCurrentDirectory() + "\\configVol.txt";
            if (File.Exists(dirApp))
            {
                var line = (File.ReadLines(dirApp)).FirstOrDefault();
                if (line != null)
                {
                    txtDirSelected.Text = line;
                    dir = line;
                    var allFiles = Directory.GetFiles(line).Where(b => b.EndsWith(".mp3") || b.EndsWith(".webm"));
                    foreach (var file in allFiles)
                    {
                        TreeNode node = tViewAllMp3.Nodes.Add(file.Split("\\")[^1]);
                        node.StateImageIndex = 0;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtDirSelected.Text))
                {
                    var allFiles = Directory.GetFiles(txtDirSelected.Text).Where(b => b.EndsWith(".mp3") || b.EndsWith(".webm"));
                    foreach (var file in allFiles)
                    {
                        TreeNode node = tViewAllMp3.Nodes.Add(file.Split("\\")[^1]);
                        node.StateImageIndex = 0;
                    }
                }
            }
            if (File.Exists(dirconfVol))
            {
                var line = (File.ReadLines(dirconfVol)).FirstOrDefault();
                if (line != null)
                {
                    trackBar1.Value = int.Parse(line);
                }
            }
        }
        private void tViewAllMp3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (wave.PlaybackState == PlaybackState.Stopped)
                {
                    if (tViewAllMp3.SelectedNode == null)
                        return;
                    panel4.Visible = true;
                    mp3 = string.IsNullOrWhiteSpace(dir) ? new Mp3FileReader(txtDirSelected.Text + "\\" + tViewAllMp3.SelectedNode.Text) : new Mp3FileReader(dir + "\\" + tViewAllMp3.SelectedNode.Text);
                    lblTitleMusic.Text = tViewAllMp3.SelectedNode.Text;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error in your file mp3, try download again on tab 2");
            }

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState == PlaybackState.Stopped)
            {
                timer.Start();
                wave.Init(mp3);
                wave.Play();
                ChangeColorButton(wave.PlaybackState);
                tViewAllMp3.Enabled = false;


            }
            else if (wave.PlaybackState == PlaybackState.Paused)
            {
                tViewAllMp3.Enabled = false;
                wave.Play();
                ChangeColorButton(wave.PlaybackState);
            }

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState != PlaybackState.Stopped)
            {
                if (mp3 is not null)
                {
                    tViewAllMp3.Enabled = true;
                    mp3.Position = 0;
                    wave.Stop();
                    ChangeColorButton(wave.PlaybackState);
                }

            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState != PlaybackState.Paused)
            {
                tViewAllMp3.Enabled = false;
                wave.Pause();
                ChangeColorButton(wave.PlaybackState);
            }
            else if (wave.PlaybackState == PlaybackState.Paused)
            {
                tViewAllMp3.Enabled = false;
                wave.Play();
                ChangeColorButton(wave.PlaybackState);
            }
        }
        private void ChangeColorButton(PlaybackState status)
        {
            switch (status)
            {
                case PlaybackState.Stopped:
                    btnPause.BackColor = Color.White;
                    btnPause.Text = "Pause";
                    btnPlay.BackColor = Color.White;
                    btnPlay.Text = "Play";
                    btnStop.BackColor = Color.Red;
                    btnStop.Text = "Stopped";
                    break;
                case PlaybackState.Playing:
                    btnPause.BackColor = Color.White;
                    btnPause.Text = "Pause";
                    btnPlay.BackColor = Color.GreenYellow;
                    btnPlay.Text = "Playing";
                    btnStop.BackColor = Color.White;
                    btnStop.Text = "Stop";
                    break;
                case PlaybackState.Paused:
                    btnPause.BackColor = Color.GreenYellow;
                    btnPause.Text = "Paused";
                    btnPlay.BackColor = Color.White;
                    btnPlay.Text = "Play";
                    btnStop.BackColor = Color.White;
                    btnStop.Text = "Stop";
                    break;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (wave != null)
                        wave.Volume = ((float)trackBar1.Value) / 100;
                        lblVol.Text = ((float)trackBar1.Value).ToString();
                }
                catch (Exception)
                {
                    return;
                }
                var dirApp = Directory.GetCurrentDirectory() + "\\configVol.txt";

                using (StreamWriter write = new StreamWriter(dirApp))
                {
                    write.Write(trackBar1.Value);
                    write.Flush();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (mp3 is not null)
            {
                lblTimer.Text = $"{mp3.CurrentTime.ToString(@"hh\:mm\:ss")} / {mp3.TotalTime.ToString(@"hh\:mm\:ss")}";
                lblTimer.Visible = true;
                if (mp3.CurrentTime.ToString(@"hh\:mm\:ss") == mp3.TotalTime.ToString(@"hh\:mm\:ss"))
                {
                    tViewAllMp3.Enabled = true;
                    mp3.Position = 0;
                    wave.Stop();
                    ChangeColorButton(wave.PlaybackState);
                }
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wave.PlaybackState == PlaybackState.Playing)
            {
                max = (int)mp3.Length;
                default_value = (int)mp3.Position;
                slider.Invalidate();
            }

        }

        public float Bar(float value)
        {
            return (slider.Width - 24) * (value - min) / (float)(max - min);
        }

        public void thumb(float value)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            default_value = value;
            slider.Refresh();
        }
        public float slider_width(int x)
        {
            return min + (max - min) * x / (float)(slider.Width);
        }
        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(default_value);
            int y = (int)(slider.Height * bar_size);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.White, 0, y, x, slider.Height - y * 2);

            using (Pen pen = new(Color.Lime, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.Lime, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            }
            using (Pen pen = new(Color.Black, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            }
        }

        bool mouse = false;
        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            if (mp3 is not null)
            {
                mouse = true;
                thumb(slider_width(e.X));
                mp3.CurrentTime = TimeSpan.FromSeconds(e.X / (double)slider.Width * mp3.TotalTime.TotalSeconds);
            }

        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mp3 is not null)
            {
                if (!mouse) return;
                thumb(slider_width(e.X));
                mp3.CurrentTime = TimeSpan.FromSeconds(e.X / (double)slider.Width * mp3.TotalTime.TotalSeconds);
            }

        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Pag 2 Download

        string dirPathTemp = string.Empty;
        StreamManifest? streamManifest;
        YoutubeClient yt;

        private async void btnLinkYT_Click(object sender, EventArgs e)
        {
            try
            {
                lblLoading.Text = "Loading ...";
                lblLoading.Visible = true;
                pictureBox1.Visible = true;
                lblStatusDownload.Visible = false;

                yt = new YoutubeClient();

                var videoUrl = txtLinkYT.Text;
                var video = await yt.Videos.GetAsync(videoUrl);



                int MaiorQualidade = 0;
                Resolution resolution;
                var thumb = video.Thumbnails;
                foreach (var item in thumb)
                {
                    if (item.Url.EndsWith(".jpg") || item.Url.EndsWith(".png"))
                    {
                        if (MaiorQualidade < item.Resolution.Width)
                        {
                            MaiorQualidade = item.Resolution.Width;
                            resolution = item.Resolution;
                        }
                    }
                }
                try
                {
                    var url = thumb.FirstOrDefault(e => e.Resolution.Width == MaiorQualidade).Url;

                    using var httpClient = new HttpClient();
                    var resposta = await httpClient.GetAsync(url);

                    resposta.EnsureSuccessStatusCode();
                    byte[] bytesImagem = await resposta.Content.ReadAsByteArrayAsync();

                    using MemoryStream ms = new(bytesImagem);
                    Bitmap bitmap = new(ms);
                    PirctureBoxThumb.Image = bitmap;
                }
                catch
                {
                    // For images errors in BITMAP 
                }
                finally
                {
                    lblVideoName.Text = video.Title;
                    lblChannelName.Text = video.Author.ChannelTitle;
                    lblDurationRT.Text = video.Duration.ToString();
                    streamManifest = await yt.Videos.Streams.GetManifestAsync(videoUrl);
                    RefreshLabels(false, "Link");
                    lblSize.Text = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate().Size.ToString();
                    btnDownload.Visible = true;
                }
            }
            catch (Exception ex)
            {

                RefreshLabels(true, "Link", ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tViewAllMp3.Nodes.Clear();
            LoadInfo();
        }
        public void ConverterParaMP3(string caminhoArquivoEntrada, string caminhoArquivoSaida)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();

            convert.ConvertMedia(caminhoArquivoEntrada, caminhoArquivoSaida, "mp3");
            foreach (var i in Directory.GetFiles(dirPathTemp))
                File.Delete(i);
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (streamManifest is not null)
                {
                    txtLinkYT.Text = string.Empty;
                    pictureBoxDonwload.Visible = true;
                    var streamInfoAudio = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    dirPathTemp = $"{Directory.GetCurrentDirectory()}\\Temp";
                    if (!Directory.Exists(dirPathTemp))
                        Directory.CreateDirectory(dirPathTemp);
                    var worker = new BackgroundWorker();
                    worker.DoWork += async (sender, e) =>
                    {
                        var videoName = lblVideoName.Text.Replace('/', ' ').Replace('|', ' ').Replace('"', ' ');
                        try
                        {
                            await yt.Videos.Streams.DownloadAsync(streamInfoAudio, $"{dirPathTemp}\\{videoName}.{streamInfoAudio.Container}");
                            ConverterParaMP3($"{dirPathTemp}\\{videoName}.{streamInfoAudio.Container}", $"{dir}\\{videoName}.mp3");
                        }
                        catch (Exception)
                        {

                            
                            int con = 1;

                            for (int i = 0; i < 1000; i++)
                            {
                                if (!File.Exists($"{dirPathTemp}\\Music{con}"))
                                { 
                                    await yt.Videos.Streams.DownloadAsync(streamInfoAudio, $"{dirPathTemp}\\Music{con}.{streamInfoAudio.Container}");
                                    MessageBox.Show($"Problem in name music, new name Music{con}.{streamInfoAudio.Container}");
                                    ConverterParaMP3($"{dirPathTemp}\\Music{con}.{streamInfoAudio.Container}", $"{dir}\\Music{con}.mp3");
                                    break;
                                }
                                con++;
                            }
                            
                        }
                        
                       
                        streamManifest = null;
                        Invoke(() =>
                        {
                            btnDownload.Visible = false;
                            RefreshLabels(false, "download");
                            tViewAllMp3.Nodes.Clear();
                            LoadInfo();
                        });

                    };
                    worker.RunWorkerAsync();

                }

            }
            catch (Exception)
            {
                RefreshLabels(true, "download");
            }

        }
        private void RefreshLabels(bool erro, string method, string ex = "")
        {
            switch (method)
            {
                case "download":
                    if (erro)
                    {
                        lblStatusDownload.Text = "Error download, check directory permissions";
                        lblStatusDownload.ForeColor = Color.Red;
                        lblStatusDownload.Visible = true;
                        pictureBoxDonwload.Visible = false;
                        lblErrorYt.Text = "Erro";
                        lblErrorYt.ForeColor = Color.Red;
                        lblErrorYt.Visible = true;
                    }
                    else
                    {
                        pictureBoxDonwload.Visible = false;
                        lblStatusDownload.Text = "Finished download";
                        lblStatusDownload.ForeColor = Color.Lime;
                        lblStatusDownload.Visible = true;
                    }
                    break;
                case "Link":
                    if (erro)
                    {
                        lblErrorYt.Text = ex + ", please try another link.";
                        lblErrorYt.ForeColor = Color.Red;
                        lblErrorYt.Visible = true;
                        pictureBox1.Visible = false;
                        lblLoading.Visible = false;
                    }
                    else
                    {
                        lblErrorYt.Text = "";
                        PanelYT.Visible = true;
                        lblLoading.Text = "";
                        lblLoading.Visible = false;
                        pictureBox1.Visible = false;
                    }
                    break;
            }


        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Ftp

        private void btnConnectFTP_Click(object sender, EventArgs e)
        {
            if (TboxIsNullOrEmpty(tboxHost, "Host empty")) return;
            if (TboxIsNullOrEmpty(tBoxUsername, "Username empty")) return;
            if (TboxIsNullOrEmpty(tBoxPwd, "Passworld empty")) return;
            if (TboxIsNullOrEmpty(tBoxPort, "Port empty")) return;

            SessionOptions sessionOptions = new()
            {
                Protocol = Protocol.Ftp,
                HostName = tboxHost.Text,
                UserName = tBoxUsername.Text,
                Password = tBoxPwd.Text,
                PortNumber = int.Parse(tBoxPort.Text)

            };


            session = new Session();

            try
            {
                session.Open(sessionOptions);
                btnDisconnect.Visible = true;
                btnRefreshFTP.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ListarDiretorios();



        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                session.Close();
                btnDisconnect.Visible = false;
                btnRefreshFTP.Visible = false;
                treeView1.Nodes.Clear();
                tViewRemoteSite.Nodes.Clear();
                progressBarDirRemote.Value = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btnRefreshFTP_Click(object sender, EventArgs e)
        {

            ListarDiretorios();
        }
        Session session;

        private bool TboxIsNullOrEmpty(TextBox text, string erroMessage)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show(erroMessage);
                return true;
            }
            return false;
        }

        private void ListarDiretorios()
        {


            RemoteDirectoryInfo directoryInfo = session.ListDirectory("/");
            var filteredItems = directoryInfo.Files.Where(item => item.Name != "..");

            treeView1.Nodes.Clear();
            progressBarDirRemote.Maximum = filteredItems.Count();
            foreach (RemoteFileInfo fileInfo in filteredItems)
            {
                progressBarDirRemote.Value++;
                if (fileInfo.IsDirectory)
                {
                    try
                    {
                        TreeNode node = treeView1.Nodes.Add(fileInfo.Name);
                        node.StateImageIndex = 1;
                        AdicionarSubdiretorios(node, fileInfo.FullName, session);
                    }
                    catch (Exception)
                    {

                        continue;
                    }

                }

            }

        }

        private void AdicionarSubdiretorios(TreeNode parentNode, string directory, Session session)
        {

            RemoteDirectoryInfo directoryInfo = session.ListDirectory(directory);
            var filteredItems = directoryInfo.Files.Where(item => item.Name != "..");
            foreach (RemoteFileInfo fileInfo in directoryInfo.Files)
            {
                if (!fileInfo.Name.Contains(".."))
                    if (fileInfo.IsDirectory)
                    {
                        TreeNode node = parentNode.Nodes.Add(fileInfo.Name);
                        node.StateImageIndex = 1;
                        AdicionarSubdiretorios(node, fileInfo.FullName, session);
                    }
            }
        }



        private void btnLocalSite_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            tboxLocalSite.Text = folderBrowserDialog2.SelectedPath;
            listFileDir();
        }

        public void listFileDir()
        {
            var files = Directory.EnumerateFiles(tboxLocalSite.Text).Where(rt => rt.Contains(".mp3"));
            foreach (var file in files)
            {
                var FilesMp3 = (file.Split('\\'))[^1];
                TreeNode node = tViewFilesMp3.Nodes.Add(FilesMp3);
                node.StateImageIndex = 0;
            }
        }

        private void btnSendFtp_Click(object sender, EventArgs e)
        {
            try
            {
                if (tViewFilesMp3.Nodes.Count != 0)
                {
                    if (!string.IsNullOrEmpty(tBoxFileLocalSelected.Text))
                    {
                        if (tViewRemoteSite.Nodes.Count != 0)
                        {
                            if (string.IsNullOrEmpty(treeView1.SelectedNode.Text))
                            {
                                MessageBox.Show("Please, select a folder to send you file mp3.");
                                return;
                            }
                            if (!string.IsNullOrEmpty(tBoxFileLocalSelected.Text))
                            {
                                var rmNode = $"/{treeView1.SelectedNode.Text}/"; //  remote node
                                var localNode = $"{tboxLocalSite.Text}\\{tViewFilesMp3.SelectedNode.Text}";

                                var p = new TransferOptions();
                                p.TransferMode = TransferMode.Automatic;
                                var transfer = session.DoPutFiles(localNode, rmNode, false, p);
                                transfer.Check();
                                MessageBox.Show("File upload successfully");
                            }
                            else
                                MessageBox.Show("Please, select file in local site to transfer");

                        }
                        else
                            MessageBox.Show("Please, connect in remote site and select a folder");
                    }
                    else
                        MessageBox.Show("Please, select a file to transfer to remote site");
                }
                else
                    MessageBox.Show("Please, select a folder local site");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnDonwloadFtp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tBoxRemoteFolderSelected.Text))
                {
                    if (!string.IsNullOrEmpty(tBoxFileRemoteSelected.Text))
                    {
                        if (!string.IsNullOrEmpty(tboxLocalSite.Text))
                        {


                            var rmNode = $"/{treeView1.SelectedNode.Text}/{tViewRemoteSite.SelectedNode.Text}"; //  remote nod

                            var localNode = $"{tboxLocalSite.Text}\\{tViewRemoteSite.SelectedNode.Text}";
                            var answer = MessageBox.Show($"you wish make transfer from {tViewRemoteSite.SelectedNode.Text} to {localNode} ", "Download", MessageBoxButtons.OKCancel);
                            if (answer == DialogResult.OK)
                            {
                                var p = new TransferOptions();
                                p.TransferMode = TransferMode.Automatic;
                                var transfer = session.GetFile(rmNode, p);
                                using (FileStream ste = File.Create(localNode))
                                {
                                    transfer.CopyTo(ste);
                                }
                                MessageBox.Show("Download success.");
                            }
                        }
                        else
                            MessageBox.Show("Select a folder local site");
                    }
                    else
                        MessageBox.Show("Select a file in remote site");

                }
                else
                    MessageBox.Show("Make the connection Ftp and select a folder");

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                tViewRemoteSite.Nodes.Clear();
                var node = treeView1.SelectedNode.FullPath;
                tBoxRemoteFolderSelected.Text = node;
                var rt = session.ListDirectory(node);
                foreach (var i in rt.Files)
                {
                    if (!i.IsDirectory)
                    {
                        if (i.Name.Contains(".mp3"))
                        {
                            TreeNode mp = tViewRemoteSite.Nodes.Add(i.Name);
                            mp.StateImageIndex = 0;
                        }


                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void tBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void tViewRemoteSite_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var node = tViewRemoteSite.SelectedNode.FullPath;
                tBoxFileRemoteSelected.Text = node;
            }
            catch (Exception)
            {

                MessageBox.Show("Error to select the file");
            }

        }
        private void tViewFilesMp3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                tBoxFileLocalSelected.Text = tViewFilesMp3.SelectedNode.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                tViewRemoteSite.Nodes.Clear();
                tViewRemoteSite.Enabled = true;
                var node = treeView1.SelectedNode.FullPath;
                tBoxRemoteFolderSelected.Text = node;
                var rt = session.ListDirectory(node);
                bool empty = true;
                foreach (var i in rt.Files)
                {
                    if (!i.IsDirectory)
                    {
                        if (i.Name.Contains(".mp3"))
                        {
                            TreeNode mp = tViewRemoteSite.Nodes.Add(i.Name);
                            mp.StateImageIndex = 0;
                            empty = false;
                        }


                    }

                }
                if (empty)
                {
                    tViewRemoteSite.Nodes.Add("Nothing here");
                    tViewRemoteSite.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}

