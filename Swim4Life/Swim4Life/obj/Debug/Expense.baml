   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.Expense   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$  Expense��5   	   $��472.4��6   $	��899��6(   .��5	      � $��0,0,-6.2,-20q�6   ���	#FF9EE1FF � RowDefinitions 5
   
   �� 5      $
��457* �6   �� 5      $	��12* �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ exp_tbl��5      $
��Left=�6$   $	��360��6?   $	��Top=�6L   $	��485��6d   $��	10,67,0,0q�6p      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $
 Date��6F    6%   �� *ExpenseDate+6F     5      $ Product Name��6L    6%   �� *ExpenseProductName+6L     5      $ Amount��6G    6%   �� *ExpenseAmount+6G     5      $	 Sum��6D    6%   �� *
ExpenseSum+6D   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��775,367,0,0q�6]   $��60��6r   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�    J� RenderTransformOrigin$ 0.562,0.395&�6�   6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��598,367,0,0q�6`   $��60��6u   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   $ 	0.22,0.65&�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��684,367,0,0q�6`   $��60��6u   
���   �
�������$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5    
   $��Expense Table��6   $
��Left=�6)   $	��Top=�6D   $��
142,10,0,0q�6\   $��55��6p   $	��190��6|   ���	#FF0E0000	 J� OpacityMask	 �	#FF110202$
��Bold"�6�   $��18(�6�   $��Segoe Print)�6�   �� 5!   
   $
��Left=�6   $��24��6-   
 �� TextWrapping$

 Wrap=�69   $��Date:��6M   $	��Top=�6Z   $��81��6r   $��
598,95,0,0q�6}   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5"   
   $
��Left=�6   $��24��6-   $

 Wrap=�69   $��Product:��6M   $	��Top=�6]   $��81��6u   $��598,124,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   $ -0.065,-1.046&�6�   ��6�   Z� 6�   �� 5#   
   $
��Left=�6   $��24��6-   $

 Wrap=�69   $��Amount:��6M   $	��Top=�6\   $��81��6t   $��598,153,0,0q�6   
���   �$
��Bold"�6�   $��Segoe Print)�6�   $ 0.865,0.095&�6�   ��6�   Z� 6�   �� 5$   
   -   5         ��Name$ CB��5$      $
��Left=�6   $	��Top=�6:   $	��237��6R   $��
598,67,0,0q�6^   6r   �� 5%   
   -   5         ��Name$
 ExpA��5%      $
��Left=�6    $��23��6;   $

 Wrap=�6G   $	��Top=�6[   $	��151��6s   $��684,153,0,0q�6   �� 5&   
   -   5        $
 ExpD��5&      $
��Left=�6    $��24��6;   $

 Wrap=�6G   $	��Top=�6[   $	��151��6s   $��
684,95,0,0q�6   �� 5'   
   -	   5        $ 	ProdCombo��5'      $
��Left=�6&   $	��Top=�6A   $	��151��6Y   $��684,126,0,0q�6e   $��22��6z   5)      5*      