using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary类库;

namespace 控件的委托事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VideoDownloader videoDownloader = new VideoDownloader();
            videoDownloader.DownloadStarted += ShowVideoStartedInfo;
            videoDownloader.DownloadPro += ShowVideoproInfo;

            videoDownloader.VideoStarted();

            

        }
        public void ShowVideoStartedInfo()
        {
            MessageBox.Show("视频开始下载了");

            label1.Text = "正在下载";

        }

        public void ShowVideoproInfo(int a ,int b ,int c)
        {

            label2.Text = $"当前的下载进度是{a}--{b}--{c}";

        }
    }
}
