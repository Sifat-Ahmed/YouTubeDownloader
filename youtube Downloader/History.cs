using System;
using System.IO;
using System.Windows.Forms;


namespace youtube_Downloader
{
    public partial class History : MaterialSkin.Controls.MaterialForm
    {
        string link, title, ext, res, size;
        public History()
        {
            InitializeComponent();
           
        }

        private void History_Load(object sender, EventArgs e)
        {
            StreamReader LR = new StreamReader(@"Link.dat");
            StreamReader TR = new StreamReader(@"title.dat");
            StreamReader ER = new StreamReader(@"Extension.dat");
            StreamReader RR = new StreamReader(@"Resolution.dat");
            StreamReader SR = new StreamReader(@"Size.dat");

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


    }
}
