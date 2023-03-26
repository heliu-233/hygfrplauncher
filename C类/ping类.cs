using hyg_frp_launcher_beta.页面;
using System.Net;
using System.Net.NetworkInformation;

class ping类
{
    public static ping类 类 = null;
    Ping 网络状态 = new Ping();
    public ping类(信息绑定类L 信息绑定)
    {
        类 = this;
        信息绑定.信息 = "-";
        new 时间轴类().添加_1秒事件 = (s, e) =>
        {
            try
            {
                PingReply a = 网络状态.Send("cn.2.sh.hyhbx.xyz");
                信息绑定.信息 = a.RoundtripTime.ToString();
            }
            catch
            {
                信息绑定.信息 = "-";
            }

        };
        new 时间轴类().添加_1秒事件 = (s, e) =>
        {
            try
            {
                主页.公.公告框.Text = new WebClient().DownloadString("https://frp.hyhbx.xyz/hygfrplauncherstreamline/5.1.3/bulletin.txt");
            }
            catch
            {
                主页.公.公告框.Text = "网站无法访问";
            }
        };
    }
}
