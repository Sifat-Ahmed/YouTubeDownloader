using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Threading;
using System.Windows.Shell;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace youtube_Downloader
{
    public partial class mainPage : MaterialSkin.Controls.MaterialForm
    {
        Thread ins;
        VideoDownloader VDcopy;
        Stopwatch watch = new Stopwatch();
        string title, ext , link , resolution , size , path ;
        Settings setting;
        String FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Youtube Downloader\\";
        double videoSize;
        double downloaded ;
        double downloadSpeed ;

        Queue<String> downloadQ = new Queue<string>();


        public mainPage()
        {
            InitializeComponent();
            setting = new Settings();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            resBox.SelectedIndex = 2;
            CheckForIllegalCrossThreadCalls = false;

            //path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();

        }


        private void downloadBtn_Click(object sender, EventArgs e)
        {
            path = setting.getPath();
            downloadBtn.Enabled = false;
            string url = urlText.Text;
            

            if (url.Contains("channel"))
            {
                int start = url.IndexOf("channel/") + 8;
                int end = url.Length;

                string listAdress = url.Substring(start);
                Channel(listAdress);

               


            }
            else if(url.Contains("list="))
            {
                int start = url.IndexOf("list=") + 5;
                int end = url.Length;

                string listAdress = url.Substring(start);
                PlayList(listAdress);

            }
            else
            {
                VideoDownload(url);
            }
            
            
        }

        private void VideoDownload(string linkAdress)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            VideoInfo video;
            videoSize = 0;
            downloaded = 0;
            downloadSpeed = 0;


            try
            {
                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(linkAdress);
                video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(resBox.Text));


                if (video.RequiresDecryption)
                    DownloadUrlResolver.DecryptDownloadUrl(video);


                title = checkIllegal(video.Title);
                ext = video.VideoExtension;
                link = urlText.Text;
                resolution = resBox.Text;
                titleLbl.Text = title;
                extText.Text = ext;

                VideoDownloader downloader =
                    new VideoDownloader(video, Path.Combine(path, title + video.VideoExtension));

                VDcopy = downloader;
                downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;


                Thread thread = new Thread(() => { try { downloader.Execute(); } catch (IOException ex) { } }) { IsBackground = true };
                thread.Start();
                watch.Start();
                ins = thread;



            }
            catch (FileLoadException ex)
            {
                error er = new error();
                er.Show();
                resBox.SelectedIndex = 2;
            }
        }


        private void historyBtn_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            setting.Show();
        }


        private void Downloader_DownloadProgressChanged(object sender , ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                
                videoSize = VDcopy.ContentLength / 1000000;
                downloaded = videoSize - ( (videoSize / 100) * e.ProgressPercentage );
                downloadSpeed = VDcopy.copiedBytes / 1024d / watch.Elapsed.TotalSeconds;

                progressBar.Value = (int)e.ProgressPercentage;
                lblPercentage.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";
                progressBar.Update();


                sizeLbl.Text = "Size: " + videoSize + "." + VDcopy.ContentLength % 100 + " MB";
                size = (videoSize + "." + VDcopy.ContentLength % 100);

                string speedText = $"{string.Format("{0:0.##}", downloadSpeed)} Kb / s";

                speed.Text = "Speed: " + speedText;
                timelbl.Text = "Est. Time: " + $"{string.Format("{0:0.##}", downloaded/(downloadSpeed/1000) )} s";
            }));
            
            if ((float)e.ProgressPercentage == 100.0f)
            {
                
                
                SaveFile();


                if(downloadQ.Count != 0)
                {
                    MultipleReset();
                    VideoDownload(downloadQ.Dequeue());
                }

                if (downloadQ.Count == 0 )
                {
                    DialogResult result = MessageBox.Show("Saved to " + path, "Download Complete!", MessageBoxButtons.OK);
                    System.Media.SystemSounds.Beep.Play();
                    if (result == DialogResult.OK)
                    {
                        reset();
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ins.Abort();
            }
            catch (Exception) { }
            reset();
            downloadQ.Clear();
            System.Media.SystemSounds.Beep.Play();
            
        }

        private void MultipleReset()
        {
            progressBar.Value = 0;
            progressBar.Update();
            timelbl.Text = "";
            speed.Text = "";
            sizeLbl.Text = "";
            titleLbl.Text = "";
            progressBar.Value = 0;
            progressBar.Update();
            lblPercentage.Text = "0%";
            progressBar.Value = 0;
            extText.Text = "";
            progressBar.Update();
        }


        private void reset()
        {
            downloadBtn.Enabled = true;
            progressBar.Value = 0;
            progressBar.Update();
            timelbl.Text = "";
            speed.Text = "";
            sizeLbl.Text = "";
            urlText.Clear();
            titleLbl.Text = "";
            progressBar.Value = 0;
            progressBar.Update();
            lblPercentage.Text = "0%";
            progressBar.Value = 0;
            resBox.SelectedIndex = 2;
            extText.Text = "";
            status.Text = "";
            progressBar.Update();
        }


        private void SaveFile()
        {
            StreamWriter LW = new StreamWriter(@"Link.dat" , true);
            LW.WriteLine(link);
            LW.Close();

            StreamWriter TW = new StreamWriter(@"title.dat" , true);
            TW.WriteLine(title);
            TW.Close();

            StreamWriter EW = new StreamWriter(@"Extension.dat" , true);
            EW.WriteLine(ext);
            EW.Close();

            StreamWriter RW = new StreamWriter(@"Resolution.dat" , true);
            RW.WriteLine(resolution);
            RW.Close();

            StreamWriter SW = new StreamWriter(@"Size.dat" , true);
            SW.WriteLine(size);
            SW.Close();
            
        }

        private string checkIllegal(string illegal)
        {
            Regex illName = new Regex(@"[\\/:*?""<>|{}=+%!]");
            return illName.Replace(illegal, "");
        }


        private void Channel(String ID)
        {
            try
            {
                var yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "AIzaSyCT8kXaxJ2l29vYg4HBdYy36H-PhAH-Teg" });
                var channelsListRequest = yt.Channels.List("contentDetails");
                channelsListRequest.Id = ID;
                var channelsListResponse = channelsListRequest.Execute();
                int VideoCount = 1;
                foreach (var channel in channelsListResponse.Items)
                {
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = yt.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        // Retrieve the list of videos uploaded to the authenticated user's channel.  
                        var playlistItemsListResponse = playlistItemsListRequest.Execute();
                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                           
                            string URL = "https://www.youtube.com/embed/" + playlistItem.Snippet.ResourceId.VideoId;
                            downloadQ.Enqueue(URL);
                            VideoCount++;
                            status.Text = "Status : "+" Fetching Vidoes " + VideoCount;
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                    
                }

                status.Text = "Status : " + "Channel - Total Videos Fetched " + VideoCount;
                VideoDownload(downloadQ.Dequeue());
            }
                catch (Exception e)
            {
                status.Text = "Error in Channel URL!";
            }


        }


        private void PlayList(String List)
        {
            try
            {

                var youtube = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "AIzaSyDWniOzJFAw8rbXGSgUCGEzwi3Sn-UPQ3g" });
                var videoListRequest = youtube.PlaylistItems.List("snippet");
                videoListRequest.PlaylistId = List;
                videoListRequest.MaxResults = 50;



                int videoCount = 1;

                var nextPageToken = "";

                while (nextPageToken != null)
                {
                    videoListRequest.PageToken = nextPageToken;

                    var videoListResponse = videoListRequest.Execute();

                    foreach (var video in videoListResponse.Items)
                    {
                        
                        string URL = "https://www.youtube.com/embed/" + video.Snippet.ResourceId.VideoId;
                        downloadQ.Enqueue(URL);
                       
                        videoCount++;
                        status.Text = "Status : " + " Fetching Videos.... ";
                    }

                    nextPageToken = videoListResponse.NextPageToken;
                }

                status.Text = "Status: " + "PlayList - Total Videos Fetched " + videoCount;
                VideoDownload(downloadQ.Dequeue());
            }
            catch (Exception ex)
            {
                status.Text = "Error in PlayList URL!";
            }
        }

    }

}
