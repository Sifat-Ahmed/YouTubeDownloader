using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace youtube_Downloader
{
    public partial class Settings : MaterialSkin.Controls.MaterialForm
    {
        string path;
        StreamReader read;
        string savedPath;
        String FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Youtube Downloader";
        
        public Settings()
        {
            InitializeComponent();


            try
            {
                read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Location.dat");
                if ((savedPath = read.ReadLine()) != null && Directory.Exists(savedPath) )
                {
                    save.Text = savedPath;
                    path = savedPath;
                }
                else
                {
                    path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
                }


                read.Close();
            }
            catch (Exception)
            {
                path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            }


        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog saveFile = new FolderBrowserDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.SelectedPath;
                save.Text = path;
                StreamWriter File = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Location.dat");
                File.WriteLine(path);
                File.Close();
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string getPath()
        {
            return path;
        }

    }
}
