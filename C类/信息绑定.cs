using System.ComponentModel;
using System.Windows.Controls;

public class 信息绑定类 : INotifyPropertyChanged
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
    public 信息绑定类(){}
    public 信息绑定类(TextBlock 信息框)
    {
        信息框.SetBinding(TextBox.TextProperty, "信息");
        信息框.DataContext = this;
    }
    public void 初始化(TextBlock 信息框)
    {
        信息框.SetBinding(TextBox.TextProperty, "信息");
        信息框.DataContext = this;
    }
}