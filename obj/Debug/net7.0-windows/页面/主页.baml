   M S B A M L   `   `   `  ����_  [hyg frp launcher wpf 精简版 5.1.3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:hyg_frp_launcher_beta.页面hyg_frp_launcher_beta.页面  5      )    #hyg_frp_launcher_beta.页面.主页   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:hyg_frp_launcher_beta.页面     5      A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  主页��5
      .��5      � .+�5   
   �� -   5         ��Name$ 线路名称��5      $y�	Collapsed=�6"   �� 5   
   -   5        $ 	供应商��5      $y�	Collapsed=�6!     Wpf.Ui.Controls.TextBox  5   
   -   5          Name$ 本地端口��5         PlaceholderText$ 本地端口(25565)��64   $	��180��6R   $��10,10,593,0q�6^   $	��Top=�6s     5   
   -   5        $ 远程端口��5      $ 远程端口��64   $	��180��6K   $��10,49,593,0q�6W   $	��Top=�6l     5   
   -   5        $ 本地IP��5      $ 本地IP:127.0.0.1��64   $	��180��6U   $��10,88,593,0q�6a   $	��Top=�6v    � Cursor$ IBeam��6�   ]� 5   
   $��
10,330,0,0q�6   .+�5      �� -   5        $ 延迟��5      $��Center=�6%   $��13(�6j   $��Microsoft YaHei)�6x   $��Normal"�6�    �� TextAlignment$ Right=�6�   ��6@   ��  �� Path$ 网络状态_信息� �� Mode$ TwoWay=�6�   �� 5      $��ms��6   $��13(�6"   $��Center=�61   $��Microsoft YaHei)�6L   $��Normal"�6i   ��6}   Z� 5        Wpf.Ui.Controls.Button  5   
   -   5          Name$ 启动_关闭��5   6   	   
Appearance$	 Primary=�6   $��启动��6)   $��	0,330,0,0q�6E   $	��Top=�6X   $��Center=�6p   $	��130��6�   
���   �6�     5   
   -   5        $	 Primary=�5      $��随机远程端口��6)   $��
10,127,0,0q�6O   $	��Top=�6c   $	��180��6{   
���   �6�     Wpf.Ui.Controls.Hyperlink  5   
   
   NavigateUri$
 https://frp.hyhbx.xyz��6   $��官网��6;   $��
10,163,0,0q�6H   $	��Top=�6\   $��72��6t     5   
   $
 https://docs.hyhbx.xyz��6   $��使用文档��6<   $��
87,163,0,0q�6K   $	��Top=�6_   $	��103��6w     5   
   -	   5           Icon$ Delete12=�5      $��
删除logs��6'   $��192,163,0,0q�68   $	��Top=�6M   $	��103��6e   6q     5   
   -
   5        $ CalendarCancel16=�5      $��强行杀死frpc��6/   $��290,163,0,0q�6B   $	��Top=�6W   $	��120��6o   6{   �� 5   
   $��精简版 v5.1.3��6   $
��Left=�6&   $��700,344,0,0q�6A   $
��Wrap=�6V   $	��Top=�6j   ���	#FF1D1D1D6�   �� 5   
   -   5        $ 	公告框��5      $
��Left=�6!   $��
200,10,0,0q�6<   $
��Wrap=�6P   $	��Top=�6d   $	��572��6|   $	��148��6�   ���	#FF80B9EE
���   �6�   �� 5   
   $
��Left=�6   $��640,170,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $	��132��6p   �� 6}   $�	小提示��6�   �� 6�    � Language$ zh-cn�6�   $	�：��6�   �� 6�   $�留空则自动填入��6�   6�   5      5       