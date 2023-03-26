using hyg_frp_launcher_beta.页面;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace hyg_frp_launcher_wpf_精简版_5._1._3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void appExit(object sender, ExitEventArgs e)
        {
            if ((bool)(设置.设.自动保存.IsChecked = true))
            {
                string lj = 设置.设.路径日志.Text;
                string time = lj + "/" + DateTime.Now.ToString("yyyy-MM-dd") + "-" + DateTime.Now.ToString("HH-mm-ss") + ".txt";
                if (!File.Exists(time))
                {
                    FileStream fs1 = new FileStream(time, FileMode.Create, FileAccess.Write);//创建写入文件 
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.WriteLine(日志.日.日志框.Text.Trim());//开始写入值
                    sw.Close();
                    fs1.Close();
                }
                else
                {
                    FileStream fs = new FileStream(time, FileMode.Open, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs);
                    sr.WriteLine(日志.日.日志框.Text.Trim());//开始写入值
                    sr.Close();
                    fs.Close();
                }
            }
            ProcessStartInfo startInfo = new ProcessStartInfo("frpc.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process ieProcess = Process.Start(startInfo);
            ieProcess.Kill(true);
            Process.GetCurrentProcess().Kill();
        }
    }
}
