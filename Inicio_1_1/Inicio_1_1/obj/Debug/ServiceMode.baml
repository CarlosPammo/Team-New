   M S B A M L   `   `   `  ����  
Inicio_1_1    Inicio_1_1.ServiceMode   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ServiceMode��5   	   $	��500��6   $	��500��6*   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$	 Red��6    � Offset$ 4Q�6+   � 5	      $ 	#FFA23333��6   $ 1Q�61   5
       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGEmergency��5      $��0��6(   $��15q�65      AutoGenerateColumns .     
IsReadOnly . 	 � DataContext	 5      �� ��6+   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
DGName��,  &System.Windows.Controls.DataGridColumn   Header$"              Name           ��5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   ��  �� Path$
 Name�  5      -   5        DGPhone��$!             Phone          ��5   6    6[   �� $ 	Telephone�  5      -   5        	DGAddress��$7 1                    Address                      ��5   8    6s   �� $ Address�4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� -   5        $��Eliminar��5   %   68   5      5      5       �� 5"   
   -   5         ��Name$ BtnAtras��5"      $
��Back��6#   $
��Left=�62   $��
379,69,0,0q�6M   $��1��6a   $	��Top=�6n   $��75��6�   6�   �� 5#   
   -   5        $ 	BtnBuscar��5#      $��Search��6$   $
��Left=�65   $��
379,29,0,0q�6P   $��1��6d   $	��Top=�6q   $��75��6�   6�   �� 5$   
   -   5         ��Name$ TbBuscar��5$      $
��Left=�6$   $��23��6?   $��	42,29,0,0q�6K   $��1��6^    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��288��6�   �� 5%   
   -	   5        $ BtnNuevo��5%      $	��New��6#   $
��Left=�61   $��	42,74,0,0q�6L   $��1��6_   $	��Top=�6l   $��75��6�   6�   5'      5(      