   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.Pool   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$
  Pool��5   	   $��472.4��6   $	��899��6%   .��5	      � ���	#FFA5DDE1.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ pool_tbl��5
      $
��Left=�6%   $	��380��6@   $	��Top=�6M   $	��485��6e   $��	10,52,0,0q�6q   
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $
 Name��6C    6%   �� *
PoolName+6C     5      $
 City��6B    6%   �� *
PoolCity+6B   5      �� 5   
   $��
Pool Table��6   $
��Left=�6%   $	��Top=�6@    J� RenderTransformOrigin$ 4.842,3.006&�6X   $��
167,10,0,0q�6|   $��56��6�   $	��190��6�   ���	#FF140101$
��Bold"�6�   $��Segoe Print)�6�   $��18(�6  ��6�   Z� 6  �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��619,372,0,0q�6]   $��60��6r   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��705,372,0,0q�6`   $��60��6u   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��784,372,0,0q�6`   $��60��6u   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $��City:��6M   $	��Top=�6Z   $��81��6r   $��619,109,0,0q�6}   $
��Bold"�6�   $��Segoe Print)�6�   ���	#FF140101��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
 Wrap=�69   $��
Pool Name:��6M   $	��Top=�6_   $��81��6w   $��
619,80,0,0q�6�   ���	#FF140101$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ CB��5      $
��Left=�6   $	��Top=�6:   $	��225��6R   $��
619,52,0,0q�6^   $��23��6r   6~   �� 5   
   -   5        	 ��Name$	 PoolC��5      $
��Left=�6!   $��23��6<   $
 Wrap=�6H   $	��Top=�6\   $	��139��6t   $��705,109,0,0q�6�   ���	#FF1401016�   �� 5   
   -   5        $	 PoolN��5      $
��Left=�6!   $��23��6<   $
 Wrap=�6H   $	��Top=�6\   $	��139��6t   $��
705,80,0,0q�6�   ���	#FF1401016�   5      5      