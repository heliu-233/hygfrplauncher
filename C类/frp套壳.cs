using hyg_frp_launcher_beta.页面;
using System;
using System.Diagnostics;
using System.Text;


class frp套壳
{
    string 路径;
    Process 壳套;
    信息绑定类 信息绑定类;
    public object 信息绑定的类 {
        get { return 信息绑定类; }
    }
    string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    public frp套壳(信息绑定类 信息绑定)
    {
        信息绑定类 = 信息绑定;
        路径 = Environment.CurrentDirectory + @"/frpc.exe";
        信息绑定类.信息 = time + " " + "尚未启动，没有日志信息，请先在主页进行基本设置，启动后才会显示日志内容!" + "\n";
    }
    public void 启动壳子(string 供应商, string 本地地址, string 本地端口, string 公网端口, string 代理名)
    {
        if (供应商 == " -s ") 供应商 += 设置.设.服务器IP.Text + " -t " + 设置.设.服务器Token.Text;
        壳套 = new Process();
        壳套.StartInfo.FileName = 路径;
        壳套.StartInfo.CreateNoWindow = true;
        壳套.StartInfo.UseShellExecute = false;
        壳套.StartInfo.RedirectStandardOutput = true;
        壳套.StartInfo.RedirectStandardError = true;
        壳套.StartInfo.StandardErrorEncoding = Encoding.UTF8;
        壳套.StartInfo.StandardOutputEncoding = Encoding.UTF8;
        壳套.ErrorDataReceived += (s, e) =>
        {
            if (e.Data != null) 信息绑定类.信息 += e.Data + "\n";
        };
        壳套.OutputDataReceived += (s, e) =>
        {
            if (e.Data != null) 信息绑定类.信息 += e.Data + "\n";
        };
        壳套.Exited += (s, e) =>
        {
            信息绑定类.信息 += time + " " + "已关闭隧道" + "\n";
        };
        壳套.StartInfo.Arguments = "tcp -i " + 本地地址 + " -l " + 本地端口 + 供应商 + " -r " + 公网端口 + " -n " + 代理名;
        壳套.Start();
        壳套.BeginErrorReadLine();
        壳套.BeginOutputReadLine();
        string[] arry = 设置.设.服务器IP.Text.Trim().Split(':');
        string 字符串 = arry[0];
        信息绑定类.信息 += time + " " + "已自动复制IP：" + 字符串 + ":" + 主页.公.远程端口.Text + "\n";
        信息绑定类.信息 += time + " " + "已创建隧道" + " " + "[" + 代理名 + "]" + "\n";
    }
    public void 关闭进程()
    {
        信息绑定类.信息 += time + " " + "已关闭隧道" + "\n";
        壳套.Kill();
    }
}
