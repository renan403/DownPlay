using NAudio.Wave;
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

        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            LoadInfo();
            wave = new WaveOutEvent
            {
                Volume = (float)trackBar1.Value / 100
            };
        }
        private void btnBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != null)
            {
                txtDirSelected.Text = folderBrowserDialog1.SelectedPath;
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
            var dirApp = Directory.GetCurrentDirectory() + "\\config.txt";
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
                        listboxMusic.Items.Add(file.Split("\\")[^1]);
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
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState == PlaybackState.Stopped)
            {
                timer.Start();
                wave.Init(mp3);
                wave.Play();
                ChangeColorButton(wave.PlaybackState);
                listboxMusic.Enabled = false;
            }
            else if (wave.PlaybackState == PlaybackState.Paused)
            {
                listboxMusic.Enabled = false;
                wave.Play();
                ChangeColorButton(wave.PlaybackState);
            }

        }
        private void listboxMusic_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState == PlaybackState.Stopped)
            {
                if (listboxMusic.SelectedItem == null)
                    return;
                panel4.Visible = true;
                lblTitleMusic.Text = listboxMusic.SelectedItem.ToString();
                mp3 = new Mp3FileReader(dir + "\\" + listboxMusic.SelectedItem.ToString());
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState != PlaybackState.Stopped)
            {
                listboxMusic.Enabled = true;
                mp3.Position = 0;
                wave.Stop();
                ChangeColorButton(wave.PlaybackState);
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (wave.PlaybackState != PlaybackState.Paused)
            {
                listboxMusic.Enabled = false;
                wave.Pause();
                ChangeColorButton(wave.PlaybackState);
            }
            else if (wave.PlaybackState == PlaybackState.Paused)
            {
                listboxMusic.Enabled = false;
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
                if (wave != null)
                    wave.Volume = ((float)trackBar1.Value) / 100;
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
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"{mp3.CurrentTime.ToString(@"hh\:mm\:ss")} / {mp3.TotalTime.ToString(@"hh\:mm\:ss")}";
            lblTimer.Visible = true;
            ProgressBarMusic.Value = (int)(((double)mp3.Position / mp3.Length) * 100);
        }
        private void listboxMusic_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Color corLinhaPar = Color.Lime;
            Color corLinhaImpar = Color.White;
            Brush textoBrush = SystemBrushes.ControlText;
            Color corFundo = (e.Index % 2 == 0) ? corLinhaPar : corLinhaImpar;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                corFundo = SystemColors.Highlight;
                textoBrush = SystemBrushes.HighlightText;
            }
            using (SolidBrush fundoBrush = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(fundoBrush, e.Bounds);
            }
            if (e.Index >= 0)
            {
                string item = listboxMusic.Items[e.Index].ToString();
                e.Graphics.DrawString(item, e.Font, textoBrush, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Pag 2 Download

        string dirPathTamp;
        StreamManifest? streamManifest;
        YoutubeClient yt;

        private async void btnLinkYT_Click(object sender, EventArgs e)
        {
            try
            {
                var ok = false;
                lblLoading.Text = "Loading ...";
                lblLoading.Visible = true;
                pictureBox1.Visible = true;

                yt = new YoutubeClient();

                var videoUrl = txtLinkYT.Text;
                var video = await yt.Videos.GetAsync(videoUrl);
                ok = true;


                int MaiorQualidade = 0;
                Resolution resolution;
                var thumb = video.Thumbnails;
                foreach (var item in thumb)
                {
                    if (MaiorQualidade < item.Resolution.Width)
                    {
                        MaiorQualidade = item.Resolution.Width;
                        resolution = item.Resolution;
                    }
                }

                var url = thumb.FirstOrDefault(e => e.Resolution.Width == MaiorQualidade).Url;

                using var httpClient = new HttpClient();
                var resposta = await httpClient.GetAsync(url);

                resposta.EnsureSuccessStatusCode();
                byte[] bytesImagem = await resposta.Content.ReadAsByteArrayAsync();

                using MemoryStream ms = new MemoryStream(bytesImagem);
                try
                {
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
                }      
            }
            catch (Exception ex)
            {
                RefreshLabels(true, "Link", ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listboxMusic.Items.Clear();
            LoadInfo();
        }
        public void ConverterParaMP3(string caminhoArquivoEntrada, string caminhoArquivoSaida)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();

            convert.ConvertMedia(caminhoArquivoEntrada, caminhoArquivoSaida, "mp3");
            foreach (var i in Directory.GetFiles(dirPathTamp))
                File.Delete(i);
            Refresh();
        }
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                txtLinkYT.Text = string.Empty;
                pictureBoxDonwload.Visible = true;
                var streamInfoAudio = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                dirPathTamp = $"{Directory.GetCurrentDirectory()}\\Temp";
                if (!Directory.Exists(dirPathTamp))
                    Directory.CreateDirectory(dirPathTamp);
                await yt.Videos.Streams.DownloadAsync(streamInfoAudio, $"{dirPathTamp}\\{lblVideoName.Text}.{streamInfoAudio.Container}");
                ConverterParaMP3($"{dirPathTamp}\\{lblVideoName.Text}.{streamInfoAudio.Container}", $"{dir}\\{lblVideoName.Text}.mp3");
                streamManifest = null;
                RefreshLabels(false, "download");
                Refresh();
            }
            catch (Exception ex)
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
                        lblErrorYt.Text = ex +", please try another link.";
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

      
    }
}
