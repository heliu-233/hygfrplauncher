using hyg_frp_launcher_beta.页面;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using log4net;
using log4net.Config;

namespace hyg_frp_launcher_wpf_精简版_5._1._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            文件夹创建();
            InitializeComponent();
            检测frpc();
            翻页框.Content = new Frame()
            {
                Content = 主页
            };
            主页.绑定信息(new 信息绑定类(日志.日志框));
            if((bool)(设置.设.自动保存.IsChecked = true))
            {
                日志.日.日志框.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + "自动保存开启(退出时自动保存日志)";
            }
        }
        hyg_frp_launcher_beta.页面.主页 主页 = new hyg_frp_launcher_beta.页面.主页();
        hyg_frp_launcher_beta.页面.日志 日志 = new hyg_frp_launcher_beta.页面.日志();
        hyg_frp_launcher_beta.页面.设置 设置 = new hyg_frp_launcher_beta.页面.设置();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            翻页框.Content = new Frame()
            {
                Content = 主页
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            翻页框.Content = new Frame()
            {
                Content = 日志
            };
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            翻页框.Content = new Frame()
            {
                Content = 设置
            };
        }

        public void 检测frpc()
        {
            string time = DateTime.Now.ToString();
            if (File.Exists(@"\frpc.exe"))
            {
                日志.日志框.Text = time + " " + "frpc存在" + "\n";
                主页.启动_关闭.IsEnabled = true;
            }
            else
            {
                主页.启动_关闭.IsEnabled = false;
                日志.日志框.Text = time + " " + "frpc丢失" + "\n";
                日志.日志框.Text = time + " " + "正在下载" + "\n";
                主页.启动_关闭.IsEnabled = true;
            }
        }

        public void 文件夹创建()
        {
            string activeDir = @设置.路径日志.Text;
            string newPath = System.IO.Path.Combine(activeDir);
            System.IO.Directory.CreateDirectory(newPath);
        }
    }
}
