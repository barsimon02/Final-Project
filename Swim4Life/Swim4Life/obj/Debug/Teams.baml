   M S B A M L   `   `   `  ����D  @Swim4Life, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Swim4Life	Swim4Life  5   	       Swim4Life.Teams   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Swim4Life     5   	   -   5          � Title$  Teams��5   	   $��472.4��6   $	��899��6&   .��5	      � ���	#FFA5DDFF.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ team_tbl��5
      $
��Left=�6%   $	��360��6@   $	��Top=�6M   $	��485��6e   $��	10,52,0,0q�6q   
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 6;     5      $ Level��6C    6%   �� *
TeamName+6C     5      $
 Date��6H    6%   �� *TeamStartDate+6H     5      $ 	Team Name��6C    6%   �� *
TeamName+6C     5      $ Employee Name��6K    6%   �� *TeamEmployeeName+6K   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $	��Top=�6:   $��60��6R   $��622,352,0,0q�6]   $��60��6r   
�������$
��Bold"�6�   $��Segoe Print)�6�   
���   �6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��709,352,0,0q�6`   $��60��6u   
�������
���   �$��Segoe Print)�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $	��Top=�6=   $��60��6U   $��787,352,0,0q�6`   $��60��6u   
�������
���   �$
��Bold"�6�   $��Segoe Print)�6�   6�   �� 5   
   $��Teams Table��6   $
��Left=�6&   $	��Top=�6A    J� RenderTransformOrigin$ 2.934,1.757&�6Y   $��
150,10,0,0q�6}   $��43��6�   $	��176��6�   $��Segoe Print)�6�   $
��Bold"�6�   $��18(�6�   �� 5   
   -   5         ��Name$ CB��5      $
��Left=�6   $	��Top=�6:   $	��225��6R   $��
622,52,0,0q�6^   6r   �� 5   
   -   5         ��Name$ TeamN��5      $
��Left=�6!   $��24��6<   	 �� TextWrapping$
	 Wrap=�6H   $	��Top=�6]   $	��138��6u   $��709,137,0,0q�6�   �� 5   
   -   5        $ TeamL��5      $
��Left=�6!   $��24��6<   $
	 Wrap=�6H   $	��Top=�6]   $	��138��6u   $��
709,79,0,0q�6�   �� 5   
   -	   5        $ TeamS��5      $
��Left=�6!   $��24��6<   $
	 Wrap=�6H   $	��Top=�6]   $	��138��6u   $��709,108,0,0q�6�   �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��	Employee:��6M   $	��Top=�6^   $��81��6v   $��623,166,0,0q�6�   
���   �$
��Bold"�6�   $��Segoe Print)�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��Name:��6M   $	��Top=�6Z   $��81��6r   $��622,137,0,0q�6}   $
��Bold"�6�   $��Segoe Print)�6�   
���   ���6�   Z� �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��Start Date:��6M   $	��Top=�6`   $��81��6x   $��622,108,0,0q�6�   
���   �$��Segoe Print)�6�   $
��Bold"�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $��24��6-   $
	 Wrap=�69   $��Level:��6M   $	��Top=�6[   $��81��6s   $��
622,79,0,0q�6~   $��Segoe Print)�6�   $
��Bold"�6�   
���   ���6�   Z� �� 5    
   -
   5        $ Ecombo��5       $
��Left=�6#   $	��Top=�6>   $	��138��6V   $��709,168,0,0q�6b   5"      5#      