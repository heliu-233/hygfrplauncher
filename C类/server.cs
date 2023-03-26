using System.Net.NetworkInformation;
using System;
using hyg_frp_launcher_beta.页面;
using System.Net;
using System.Windows.Media.Animation;
using System.IO;
using System.Collections.Generic;
using System.Windows.Controls;

class server
{
    public server(信息绑定类L 信息绑定)
    {
        new 时间轴类().添加_1秒事件 = (s, e) =>
        {
            string 服务器个数 = "0";
            string 列表 = new WebClient().DownloadString("https://frp.hyhbx.xyz/server.txt");
            string[] l = File.ReadAllLines(列表);
            
        };
    }
}