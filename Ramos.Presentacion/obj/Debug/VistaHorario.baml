   M S B A M L   `   `   `  ����M  IRamos.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Ramos.PresentacionRamos.Presentacion  5   	   %    Ramos.Presentacion.VistaHorario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Ramos.Presentacion     5   	     � Title$  Toma de Ramos - Horario��5   	   $	��400��6)   $	��600��66    � 
ResizeMode$ CanMinimize=�6B    � WindowStartupLocation$ CenterScreen=�6[   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFEEE8CD��6   $	 0.5Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgHorario��5      $	��225��6'   $��	20,60,0,0q�64   $	��Top=�6G      CanUserAddRows .  $
��Left=�6v   $	��554��6�   �� 5   
   -   5        	 ��Name$	 	lbHorario��5      $��Horario - *alumno*��6#   $
��Left=�6@   $��	20,10,0,0q�6[   $	��Top=�6n   $��45��6�   $	��450��6�   $��20(�6�   �� 5   
   -   5        
 ��Name$
 btnSalir��5      $��Salir��6#   $��	0,0,20,25q�63   $��Right=�6F   $��75��6b   $��30��6m   $��Bottom=�6y   6�   5      5      