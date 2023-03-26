using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace hyg_frp_launcher_beta.页面
{
    /// <summary>
    /// 日志.xaml 的交互逻辑
    /// </summary>
    public partial class 日志 : Page
    {
        public static 日志 日 = null;
        public 日志()
        {
            日 = this;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] arry = 设置.设.服务器IP.Text.Trim().Split(':');
            string 字符串 = arry[0];
            日志.日.日志框.Text += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + "已复制IP" + "：" + 字符串 + ":" + 主页.公.远程端口.Text + "\n";
            Clipboard.SetDataObject(字符串 + 主页.公.远程端口.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            日志.日.日志框.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            日志.日.日志框.Text += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + "已保存日志" + "\n";
            string lj = 设置.设.路径日志.Text;
            string time = lj + "/" + DateTime.Now.ToString("yyyy-MM-dd") + "-" + DateTime.Now.ToString("HH-mm-ss") + ".txt";
            if (!File.Exists(time))
            {
                FileStream fs1 = new FileStream(time, FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(this.日志框.Text.Trim());//开始写入值
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(time, FileMode.Open, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(this.日志框.Text.Trim());//开始写入值
                sr.Close();
                fs.Close();
            }
        }
    }
}
