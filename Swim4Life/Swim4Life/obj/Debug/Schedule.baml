   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.Schedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$  Schedule��5	   	   $��543.095��6   $��997.645��6+   .��5
      � ���	#FF4DB5FF � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ sch_tbl��5      $
��Left=�6$   $	��380��6?   $	��Top=�6L   $	��485��6d   $��	22,71,0,0q�6p   
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $
 Date��6G    6%   �� *ScheduleDate+6G     5      $ 	Team Name��6?    6%   �� *Team+6?     5      $ 	Pool Name��6>    6%   �� *Pool+6>   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��659,391,0,0q�6]   $��60��6r   $
��Bold"�6~   $��Segoe Print)�6�   ���	#FF150202
�������6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��758,391,0,0q�6`   $��60��6u   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��848,391,0,0q�6`   $��60��6u   
�������
���   �$��Segoe Print)�6�   $
��Bold"�6�   6�   �� 5   
   $��Shedule Table��6   $
��Left=�6(   $	��Top=�6C   $��
158,10,0,0q�6[   $��61��6o   $	��180��6{   ���	#FF150202$
��Bold"�6�   $��Segoe Print)�6�   $��18(�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-    �� TextWrapping$
 Wrap=�69   $��Date:��6M   $	��Top=�6Z   $��81��6r   $��
659,99,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6}   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
 Wrap=�69   $��Team :��6M   $	��Top=�6[   $��81��6s   $��659,157,0,0q�6~   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
 Wrap=�69   $��Pool :��6M   $	��Top=�6[   $��81��6s   $��659,128,0,0q�6~   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$
 SchD��5      $
��Left=�6    $��24��6;   $
 Wrap=�6G   $	��Top=�6[   $	��129��6s   $��
755,99,0,0q�6   
���   �6�   �� 5   
   -   5        	 ��Name$	 CB��5      $
��Left=�6   $��
659,71,0,0q�6:   $	��Top=�6N   $	��225��6f   6r   �� 5   
   -   5        $	 Pcombo��5      $
��Left=�6#   $	��Top=�6>   $	��129��6V   $��758,130,0,0q�6b   
���   �5!      �� 5"   
   -	   5        $	 Tcombo��5"      $
��Left=�6#   $	��Top=�6>   $	��129��6V   $��758,159,0,0q�6b   
���   �6w   5$      5%      