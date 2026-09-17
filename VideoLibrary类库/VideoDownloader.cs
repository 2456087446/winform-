using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VideoLibrary类库
{
    // 视频下载委托
    public delegate void DownloadStartedHandler();


    public delegate void DownloadProHandler(int i,int currentDownload,int totalButes);

    public class VideoDownloader
    {
        // 创建委托对象
        public event DownloadStartedHandler DownloadStarted;


        public event DownloadProHandler DownloadPro;

        public void VideoStarted()
        {
            if (DownloadStarted != null) {
                DownloadStarted();

                
            }
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                if (DownloadPro != null)
                {


                    DownloadPro(i, i * 1000, i * 10000);
                }
            }

        }
    }
}
