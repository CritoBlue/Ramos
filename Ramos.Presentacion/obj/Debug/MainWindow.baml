   M S B A M L   `   `   `  ����M  IRamos.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Ramos.PresentacionRamos.Presentacion  5   	   #    Ramos.Presentacion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Ramos.Presentacion     5   	     � Title$  Toma de Ramos��5   	   $	��500��6   $	��800��6,    � 
ResizeMode$ CanMinimize=�68   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFEEE8CD��6   $	 0.5Q�61   5      .+�5   
   �� -   5         ��Name$ 	txtNombre��5      $��*Nombre Alumno*��6#   $
��Left=�6=   $��
240,20,0,0q�6X   $	��Top=�6l   $	��420��6�   $
��Bold"�6�   �� 5   
   -   5        $ txtRut��5      $��*RUT Alumno*��6    $
��Left=�67   $��	20,20,0,0q�6R   $	��Top=�6e   $
��Bold"�6}   $	��200��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgRamo��5      $
��Left=�6$   $	��300��6?   $��	20,80,0,0q�6L   $	��Top=�6_   $	��225��6w      CanUserAddRows .  	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� $��btnGrid��6%   -   5        $	��Ver��5   4   6Z   5      5      5      �� 5   
   -   5         ��Name$ btnFin��5      $��Ver Horario��6!   $��Right=�67   $��	0,0,20,20q�6S   $	��100��6f   $��40��6�   $��Bottom=�6�     5   
   -   5        $ 
dtgSeccion��5      $��Right=�6'   $	��300��6C   $��	0,80,20,0q�6P   $	��Top=�6c   $	��500��6{    .  	 5        5       
 5!      �� 5"      .R�5#      �� $��btnSeleccionar��6%   -   5        $	��Ver��5#   ;   6h   5$      5&      5(      �� 5)   
   -   5        $ txtSede��5)      $��*Sede Alumno*��6!   $
��Left=�69   $��	20,40,0,0q�6T   $	��Top=�6g   $	��200��6   $
��Bold"�6�   �� 5*   
   -	   5        $ 
txtCarrera��5*      $��*Carrera Alumno*��6$   $
��Left=�6?   $��
240,40,0,0q�6Z   $	��Top=�6n   $
��Bold"�6�   $	��420��6�   �� 5+   
   -
   5        $ txtSemestre��5+      $��*Semestre X*��6%   $
��Left=�6<   $��
680,20,0,0q�6W   $	��Top=�6k   $	��100��6�   $
��Bold"�6�   5,      5-      