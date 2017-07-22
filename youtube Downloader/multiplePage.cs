using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace youtube_Downloader
{
    public partial class multiplePage : MaterialSkin.Controls.MaterialForm
    {

        public bool multiple = false;

        //List<String> linkList = new List<string>();
        Queue<String> queue = new Queue<string>();

        public multiplePage()
        {
            InitializeComponent();
        }

        private void multiplePage_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(check(link.Text))
            {
                //linkList.Add(link.Text);
                queue.Enqueue(link.Text);
                ListViewItem list = new ListViewItem(link.Text);
                multiple = true;
            }
        }

        public Queue<string> getQ()
        {
            return queue;
        }

        private bool check(string link)
        {
            try
            {
                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(link);
                VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4);
            }
            catch (Exception)
            {
                MessageBox.Show("Link Not Available" , "Alert" , MessageBoxButtons.OK);
                return false;
            }

            return true;
            
        }
    }
}
