   M S B A M L   `   `   `  ����E  AInicio_1_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Inicio_1_1
Inicio_1_1  5   	       Inicio_1_1.ListBusiness   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Inicio_1_1     5   	     � Title$  ListBusiness��5   	   $	��611��6   $	��765��6+   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$	 Red��6    � Offset$ 4Q�6+   � 5      $ 	#FFA23333��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $	��93* �6   �� 5      $	��23* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGEmpresas��5      $��0��6'   $��15q�64      AutoGenerateColumns .     
IsReadOnly . 	 � DataContext	 5      �� ��6+   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
DGName��,  &System.Windows.Controls.DataGridColumn   Header$"              Name           ��5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   ��  �� Path$
 Name�  5      -   5        DGPhone��$!             Phone          ��5   6    6[   �� $ 	Telephone�  5      -   5        	DGAddress��$6 0                    Adress                      ��5   8    6r   �� $ Address�  5      -   5        	DGNit��$!              Nit           ��5   4    6Y   �� $ NumNit�  5      -   5        	DGWebsite��$&               Web Site           ��5   8    6b   �� $	 Web�4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5       �� -   5        $��Eliminar��5    %   68   5!      5#      5&      �� 5(   
   -   5         ��Name$ BtnBack��5(      $
��Back��6"   $
��Left=�61   $��
535,74,0,0q�6L   $��1��6`   $	��Top=�6m   $��75��6�   $��20��6�   �� 5)   
   -	   5        $ 	BtnSearch��5)      $��Search��6$   $
��Left=�65   $��
535,32,0,0q�6P   $��1��6d   $	��Top=�6q   $��75��6�   $��20��6�   �� 5*   
   -
   5         ��Name$ TbSearch��5*      $
��Left=�6$   $��23��6?   $��
125,32,0,0q�6K   $��1��6_    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��288��6�   �� 5+   
   -   5        $ BtnNew��5+      $	��New��6!   $
��Left=�6/   $��
125,74,0,0q�6J   $��1��6^   $	��Top=�6k   $��75��6�   $��20��6�   5-      5.      