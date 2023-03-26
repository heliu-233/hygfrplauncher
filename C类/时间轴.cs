using System;
using System.Windows.Threading;

class 时间轴类
{
    DispatcherTimer _1秒 = new DispatcherTimer();
    public EventHandler 添加_1秒事件
    {
        set { _1秒.Tick += value; }
    }
    public EventHandler 删除_1秒事件
    {
        set { _1秒.Tick -= value; }
    }
    public 时间轴类()
    {
        _1秒.Interval = TimeSpan.FromSeconds(1);
        _1秒.Start();
    }
    public void _1秒暂停()
    {
        _1秒.Stop();
    }
}