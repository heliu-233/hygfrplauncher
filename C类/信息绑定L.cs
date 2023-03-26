using System.ComponentModel;
using System.Windows.Controls;

public class 信息绑定类L : INotifyPropertyChanged
{
    string a = "";
    public event PropertyChangedEventHandler PropertyChanged;
    public string 信息
    {
        get { return a; }
        set
        {
            a = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("信息"));
        }
    }
    public 信息绑定类L()
    {

    }
    public 信息绑定类L(TextBlock 信息框L)
    {
        信息框L.SetBinding(TextBlock.TextProperty, "信息");
        信息框L.DataContext = this;
    }
    public void 初始化L(TextBlock 信息框L)
    {
        信息框L.SetBinding(TextBlock.TextProperty, "信息");
        信息框L.DataContext = this;
    }
}