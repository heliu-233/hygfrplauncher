   M S B A M L   `   `   `  ����_  [hyg frp launcher wpf 精简版 5.1.3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:hyg_frp_launcher_beta.页面hyg_frp_launcher_beta.页面  5      )    #hyg_frp_launcher_beta.页面.设置   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:hyg_frp_launcher_beta.页面     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  设置��5
      .��5      � .+�5   
     Wpf.Ui.Controls.TextBox  -   5          Name$ 服务器IP��5      $��cn.2.sh.hyhbx.xyz:7000��6$      PlaceholderText$ 输入服务器IP��6B   $��10,10,537,0q�6\   $	��Top=�6q     5   
   -   5        $ 服务器Token��5      $��hyhbxhyg233��6'   $ 输入服务器Token��6:   $��10,49,537,0q�6W   $	��Top=�6l     5   
   $ 输入数据保存位置��6   $��10,88,537,0q�62   $	��Top=�6G   ${�False��6_   �� 5   
   $��自动保存数据��6   $��
10,244,0,0q�6%   $	��Top=�69   $	��160��6Q   4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6]   ${�False��6�     5   
   -   5        $ 路径日志��5   0   $ 输入日志保存位置��6   $��C:/logs��6>   $��10,127,537,0q�6M   $	��Top=�6c   �� 5   
   -   5         ��Name$ 自动保存��5   ^   $��自动保存日志��6   $��132,244,0,0q�6%   $	��Top=�6:   $	��160��6R    d� 	IsChecked$
 TrueY�6l   !  Wpf.Ui.Controls.PasswordBox  5   
   $ 用户密钥��6   $��10,166,537,0q�60   $	��Top=�6F   ${�False��6^     Wpf.Ui.Controls.Button  5   
      
Appearance$ Primary=�6   $��确定��6)   $��
10,205,0,0q�66   $	��Top=�6J   $��34��6b   $	��237��6n   
���   �${�False��6�   �� 5   
   $
��Left=�6   $��
34,281,0,0q�6/   $
��Wrap=�6C   $.��(启用/关闭自动保存重启后生效��6W   $	��Top=�6m   $��16��6�   $	��190��6�   ���	#FFEDCF04$��14(�6�   ��6�   Z� 6�   5      5      