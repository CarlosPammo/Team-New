   M S B A M L   `   `   `  ����  
Inicio_1_1    Inicio_1_1.RegisterPerson   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  RegisterPerson��5   	   $	��478��6    $	��802��6-   .��5      � $��0,0,0,-5q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5	      $ 	#FFA23333��6   $ 1Q�61   5
       � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGListPerson��5      $��0��6)   $��20,10,10,20q�66      AutoGenerateColumns .     
IsReadOnly . 	 � DataContext	 5      �� ��6+   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
DGName��,  &System.Windows.Controls.DataGridColumn   Header$        Name   ��5   5      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   ��  �� Path$
 Name�6l     5      -   5        DGLastnameDad��$   Last Name��5   <   $	 120 6v    6Q   �� $ LastnameDad�6v     5      -   5        DGLastnameMom��$   Mother's Last Name��5   <   $	 120 6    6Z   �� $ LastnameMom�6     5      -   5        DGTelephone��$       Phone��5   :   $	 100 6r    6O   �� $ 	Telephone�6r     5      -   5        	DGCelular��$        Cell Phone��5   8   $	 100 6t    6S   �� $ Celular�6t     5      -   5        	DGAddress��$      Address��5   8   $	 100 6o    6N   �� $ Address�6o     5      -   5        DGRed_Social��$       Social��5   ;   $	 100 6u    6Q   �� $ 
Red_Social�6u   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5       �� -	   5        $��Editar��5    %   66   5!      5#        5%       5&      �� 5'      .R�5(      �� -
   5        $��Eliminar��5(   %   68   5)      5+      5.      �� 5/   
   -   5         ��Name$ 
Btn_Search��5/      $��Search��6%   $
��Left=�66   $��
552,30,0,0q�6Q   $��1��6e   $	��Top=�6r   $��80��6�   $��Rockwell Extra Bold)�6�   6�   �� 50   
   -   5        $ Btn_New��50      $��New Contact��6"   $
��Left=�68   $��
210,25,0,0q�6S   $��2��6g   $	��Top=�6t   $	��120��6�   $��Rockwell Extra Bold)�6�   6�   �� 51   
   -   5        $ 	Btn_Close��51      $��Close��6$   $
��Left=�64   $��
552,25,0,0q�6O   $��2��6c   $	��Top=�6p   $��80��6�   $��Rockwell Extra Bold)�6�   6�   �� 53   
   -   5         ��Name$ TbSearch��53      $
��Left=�6$   $��23��6?   $��	40,27,0,0q�6K   $��1��6^    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��491��6�   54      55      