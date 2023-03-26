using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace hyg_frp_launcher_beta.页面
{
    public partial class 主页 : Page
    {
        bool 启动控制 = false;
        public bool _启动控制
        {
            get { return 启动控制; }
        }
        public void 绑定信息(信息绑定类 信息绑定类) {
            frp套壳 = new frp套壳(信息绑定类);
        }
        frp套壳 frp套壳;
        public object frp
        {
            get { return frp套壳; }
        }
        public static 主页 公 = null;
        public 主页()
        {
            公 = this;
            InitializeComponent();
            new ping类(new 信息绑定类L(延迟));
            线路名称.Text = new Random().Next(1, 999999999).ToString();
        }
        public void 绑定日志信息(信息绑定类 日志信息)
        {
            frp套壳 = new frp套壳(日志信息);
        }
        public void 启动_关闭函()
        {
            if (启动控制)
            {
                启动控制 = false;
                try
                {
                    frp套壳.关闭进程();
                }
                catch { }
                启动_关闭.Content = "启动";
            }
            else
            {
                if (本地端口.Text.Trim() == "")
                {
                    本地端口.Text = "25565";
                }
                if (远程端口.Text.Trim() == "")
                {
                    远程端口.Text = new Random().Next(10000, 65535).ToString();
                }
                if (本地IP.Text.Trim() == "")
                {
                    本地IP.Text = "127.0.0.1";
                }
                string[] arry = 设置.设.服务器IP.Text.Trim().Split(':');
                string 字符串 = arry[0];
                Clipboard.SetDataObject(字符串 + ":" + 远程端口.Text);
                string[] 供应商 = this.供应商.Text.Split(';');
                try
                {
                    供应商[0] = " -s " + 供应商[0];
                }
                catch { }
                try
                {
                    供应商[0] += " -t " + 供应商[1];
                }
                catch { }
                frp套壳.启动壳子(供应商[0], 本地IP.Text, 本地端口.Text, 远程端口.Text, 线路名称.Text);
                启动控制 = true;
                启动_关闭.Content = "关闭";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            远程端口.Text = new Random().Next(10000, 65535).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            启动_关闭函();
        }
        void 限制输入数字(object s, KeyEventArgs e)
        {
            e.Handled = (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9) ? false : true;
        }
        void 限制输入IP(object s, KeyEventArgs e)
        {
            e.Handled = (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.Decimal ? false : true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(设置.设.路径日志.Text);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            日志.日.日志框.Text += DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + "已清空logs文件夹" + "\n";
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            string processName = "frpc.exe";
            Process[] myproc = Process.GetProcesses();
            foreach (Process item in myproc)
            {
                if (item.ProcessName == processName)
                {
                    item.Kill();
                }
            }
        }
    }
}