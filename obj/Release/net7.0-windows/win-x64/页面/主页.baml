   M S B A M L   `   `   `  ���� _  [hyg frp launcher wpf 精简版 5.1.3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:hyg_frp_launcher_beta.页面hyg_frp_launcher_beta.页面  )    #hyg_frp_launcher_beta.页面.主页   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:hyg_frp_launcher_beta.页面     A =Wpf.Ui, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml    N� Title$  主页��.��� .+��� -    ��Name$ 线路名称��$y�	Collapsed=��� -   $ 	供应商��$y�	Collapsed=�  Wpf.Ui.Controls.TextBox  -     Name$ 本地端口��   PlaceholderText$ 本地端口(25565)��$	��180��$��10,10,593,0q�$	��Top=�  -   $ 远程端口��$ 远程端口��$	��180��$��10,49,593,0q�$	��Top=�  -   $ 本地IP��$ 本地IP:127.0.0.1��$	��180��$��10,88,593,0q�$	��Top=� � Cursor$ IBeam��]� $��
10,330,0,0q�.+��� -   $ 延迟��$��Center=�$��13(�$��Microsoft YaHei)�$��Normal"� �� TextAlignment$ Right=�����  �� Path$ 网络状态_信息� �� Mode$ TwoWay=��� $��ms��$��13(�$��Center=�$��Microsoft YaHei)�$��Normal"���Z�   Wpf.Ui.Controls.Button  -     Name$ 启动_关闭��	   
Appearance$	 Primary=�$��启动��$��	0,330,0,0q�$	��Top=�$��Center=�$	��130��
���   �  -   $	 Primary=�$��随机远程端口��$��
10,127,0,0q�$	��Top=�$	��180��
���   �  Wpf.Ui.Controls.Hyperlink  
   NavigateUri$
 https://frp.hyhbx.xyz��$��官网��$��
10,163,0,0q�$	��Top=�$��72��  $
 https://docs.hyhbx.xyz��$��使用文档��$��
87,163,0,0q�$	��Top=�$	��103���� $��精简版 v5.1.3��$
��Left=�$��700,344,0,0q�$
��Wrap=�$	��Top=����	#FF1D1D1D�� -	   $ 	公告框��$
��Left=�$��
200,10,0,0q�$
��Wrap=�$	��Top=�$	��572��$	��148�����	#FF80B9EE
���   �