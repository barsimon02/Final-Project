   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.Product   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$  Product��5   	   $��472.4��6   $	��899��6(   .��5	      � $��0,0,-0.2,-51.6q�6   ���	#FFA5DDFF � ColumnDefinitions 5
   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ prod_tbl��5      $
��Left=�6%   $	��380��6@   $	��Top=�6M   $	��485��6e   $��	10,55,0,0q�6q   
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $
 Name��6C    6%   �� *
ProdName+6C     5      $ price��6C    6%   �� *	ProdPrice+6C   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��617,375,0,0q�6]   $��60��6r   
�������$
��Bold"�6�   $��Segoe Print)�6�   ���	#FF1201016�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��703,375,0,0q�6`   $��60��6u   
�������$
��Bold"�6�   $��Segoe Print)�6�   ���	#FF120101 J� RenderTransformOrigin$ 	0.197,0.3&�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��782,375,0,0q�6`   $��60��6u   
����������	#FF120101$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   $��Product Table��6   $
��Left=�6(   $	��Top=�6C   $��
161,12,0,0q�6[   $��38��6o   $	��199��6{   ���	#FF140101$
��Bold"�6�   $��Segoe Print)�6�   $��18(�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ ProdP��5      $
��Left=�6!   $��24��6<   	 �� TextWrapping$
	 Wrap=�6H   $	��Top=�6]   $	��139��6u   $��703,112,0,0q�6�   ���	#FF1201016�   �� 5   
   -   5        $ ProdN��5      $
��Left=�6!   $��24��6<   $
	 Wrap=�6H   $	��Top=�6]   $	��139��6u   $��
703,83,0,0q�6�   ���	#FF1201016�   �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��Name:��6M   $	��Top=�6Z   $��81��6r   $��
617,83,0,0q�6}   $ 4.249,2.575&�6�   ���	#FF120101$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��Price:��6M   $	��Top=�6[   $��81��6s   $��617,112,0,0q�6~   ���	#FF120101$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   -   5        
 ��Name$
 CB��5      $
��Left=�6   $	��Top=�6:   $	��225��6R   $��
617,55,0,0q�6^   6r   5      5      