   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.WorkShop   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$  WorkShop��5   	   $��472.4��6   $	��899��6)   .��5	      � ���	#FF9BB5FF � ColumnDefinitions 5
   
   �� 5      $
��247* �6   �� 5      $
��199* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ work_tbl��5      $
��Left=�6%   $	��369��6@   $	��Top=�6M   $	��485��6e   $��	10,52,0,0q�6q   $��2��6�   
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $
 Name��6G    6%   �� *WorkShopName+6G     5      $
 Date��6G    6%   �� *WorkShopDate+6G     5      $ Employee Name��6O    6%   �� *WorkShopEmployeeName+6O   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��124.6,361,0,0q�6]   $��60��6t   $��1��6�   
�������$
��Bold"�6�   $��Segoe Print)�6�   
���   �6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��210.6,361,0,0q�6`   $��60��6w   $��1��6�   
���   �
�������$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $��Bottom=�6=   $��60��6X   $��289.6,0,0,10.4q�6c   $��60��6{   $��1��6�   $
��Bold"�6�   $��Segoe Print)�6�   
�������
���   �6�   �� 5   
   $��WorkShop Table��6   $
��Left=�6)   $	��Top=�6D   $��	149,0,0,0q�6\   $��55��6o   $	��190��6{   $
��Bold"�6�   $��Segoe Print)�6�   $��18(�6�   
���   �6�   �� 5   
   -   5         ��Name$ CB��5      $
��Left=�6   $	��Top=�6:   $	��225��6R   $��1��6^   $��124.6,52,0,0q�6n   $��23��6�   6�   �� 5   
   $
��Left=�6   $��24��6-    �� TextWrapping$
 Wrap=�69   $��Name:��6M   $	��Top=�6Z   $��81��6r   $��1��6}   $��124.6,80,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
 Wrap=�69   $��Date:��6M   $	��Top=�6Z   $��81��6r   $��1��6}   $��124.6,109,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
 Wrap=�69   $��	Employee:��6M   $	��Top=�6^   $��91��6v   $��1��6�   $��124.6,138,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5    
   -   5        	 ��Name$	 WorkN��5       $
��Left=�6!   $��24��6<   $
 Wrap=�6H   $	��Top=�6]   $	��139��6u   $��210.6,80,0,0q�6�   $��1��6�   
���   �6�   �� 5!   
   -   5        $	 WorkD��5!      $
��Left=�6!   $��24��6<   $
 Wrap=�6H   $	��Top=�6]   $	��139��6u   $��210.6,109,0,0q�6�   $��1��6�   
���   �6�   �� 5"   
   -	   5        $ Ecombo��5"      $
��Left=�6#   $	��Top=�6>   $	��129��6V   $��1��6b   $��220.6,140,0,0q�6r   5$      5%      