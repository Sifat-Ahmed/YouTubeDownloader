using System;
using System.IO;
using System.Windows.Forms;


namespace youtube_Downloader
{
    public partial class History : MaterialSkin.Controls.MaterialForm
    {
        string link, title, ext, res, size;

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public History()
        {
            InitializeComponent();
           
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader LR = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Link.dat");
                StreamReader TR = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\title.dat");
                StreamReader ER = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Extension.dat");
                StreamReader RR = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Resolution.dat");
                StreamReader SR = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Size.dat");
            
                while ( (link = LR.ReadLine() ) != null && ( title = TR.ReadLine() ) != null && (ext = ER.ReadLine() ) != null
                   && (res = RR.ReadLine() ) != null && (size = SR.ReadLine() ) != null)
                {
                    ListViewItem list = new ListViewItem(link);
                    list.SubItems.Add(title);
                    list.SubItems.Add(ext);
                    list.SubItems.Add(res);
                    list.SubItems.Add(size);
                    listView.Items.Add(list);
                }

                LR.Close();
                TR.Close();
                ER.Close();
                RR.Close();
                SR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("History not found or Corrupted");
            }
        }


    }
}
