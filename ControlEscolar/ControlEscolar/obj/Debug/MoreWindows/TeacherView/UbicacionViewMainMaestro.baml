   M S B A M L   `   `   `  ����I  EControlEscolar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ControlEscolar.ViewControlEscolar.View  5   	   M+clr-namespace:ControlEscolar.CustomControlsControlEscolar.CustomControls  5   	   C&clr-namespace:ControlEscolar.ViewModelControlEscolar.ViewModel  5   	   2    ,ControlEscolar.View.UbicacionViewMainMaestro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ControlEscolar.View     5   	   Fcustomcontrols+clr-namespace:ControlEscolar.CustomControls     5   	   <	ViewModel&clr-namespace:ControlEscolar.ViewModel     5   	     � Title$  UbicacionViewMainMaestro��5
   	   $	��450��6*   $	��800��67    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency .  � Icon$/ )/Resources/LogoAplicacionSomosUAZmini.ico��5   	    � DataContext 5      -   'ControlEscolar.ViewModel.LoginViewModel  5   
    � 	Resources 5         BooleanToVisivility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'   	 �� 	Converter#	 [  5      .��5      �� 
 �� CornerRadius$
 12��6   ._�5    
   �� $
 10��6   $��2q�6#    J� Opacity$
 0.98Q�67   $��
0,14,0,-14q�6F   ��5!      �� 5"       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5#      �  � Color$ #2e2e2e��6#    � Offset$ 0Q�63   � 5$      $ #dadada��6#   $
 0.75Q�63   � 5%      $ #2e2e2e��6#   $ 1Q�63   5&      ��5(      �� 5)      $ 0.1,0&�6&   $	 1,1&�69   .��5*      � $ #060521��6#   $ 0Q�63   � 5+      $ 	LightBlue��6#   $
 0.75Q�65   � 5,      $ #060521��6#   $ 1Q�63   5-      ._�50      �  � RowDefinitions 51      �� 52      $��30 �6$   53      .+�55      � $��0��6    � ColumnDefinitions 57      �� 58      �� 59      $��25 �6+   �� 5:      $��25 �6+   �� 5;      $��5 �6+   .+�5>      �� -   5         ��Name$ btnMinimizar��5>       � ToolTip$ 	Minimizar��5@   	    � Cursor$
 Hand��5A   	   $��28��5B   	   $��28��6   
������ $��0q�5D   	   $��	738,0,0,2q�5E   	   $��2��6   ��5F      �� 5G       �� 
TargetType" ��6.   .R�5H   "   ��  ��Name$ border��5J      #��z��5H   )   $��28��5I      $��28��6    ._�5K   &   �� $	��―��60   $��14(�5L      
���   �$
��Bold"�5N      $��Center=�5O      $��Center=�5P      5Q   #    �� Triggers 5R   "   P� 5S   &    P� Property �@J�IsMouseOver P� Value . . �5T   *   ��  �� 
TargetName$ border��61    �� Property � �� �� Value �#DDDDDD6[   5U   '   5W      5Y      �� 5\      -   5        $ 	btnCerrar��5\      $ Cerrar��5^   	   $
 Hand��5_   	   $��28��5`   	   $��28��6   
������ $��0q�5b   	   $��0,0,2,2q�5c   	   $��2��6   $��2��6*   ��5d      �� 5e      " ��6.   .R�5f   "   �� $ border��5h      #��z��5f   )   $��28��5g      $��28��6    ._�5i   &   �� $��×��60   $��14(�5j      
���   �$
��Bold"�5l      $��Center=�5m      $��Center=�5n      5o   #    5p   "   P� 5q   &    �@J�IsMouseOver . . �5r   *   �� $ border��61    � �� �#FFCDD26[   5s   '   5u      5w      �� 5x       �� Orientation$ Vertical=�5y      $��14,40,0,-376q�5z      .+�5{      �� 
�������$��14(�5}      $��Medium"�5~      $��
Montserrat)�5      $	��200��65   �� 6C   $$�Ciudad Universitaria Siglo XXI��6G   �� 6o   �� 6{   $G�AEdificio de Ingeniería de Software e Ingeniería en Computación��6   �� 6�   �� 6�   $M�GCarr. Zacatecas-Guadalajara Km. 6, Ejido “La Escondida”, C.P. 98160��6�   �� 6$  �� 60  $�Zacatecas, Zac., México.��64  6W  5�      �� 5�      -   5        $��← Regresar��5�      $
��Left=�5�   	   $��656,35,0,-32q�5�   	   $	��110��5�   	   $	��NaN��5�   	   $��16(�5�   	   $
��Bold"�5�   	   
�������$��2��5�      ��5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   " ��6:   .R�5�   .   �� #��z��65   $
 8��5�   !   
�������$��2q�5�   !   ._�5�   2   �� $��Center=�6C   $��Center=�5�   /   5�   /   5�   +   5�   #   �� 5�   "    � �� �#005A9C6?   �� 5�   "    � ��
 �����6?   �� 5�   "    � ��$ 16(�6=   �� 5�   "    � ��$
 Bold"�6?   �� 5�   "    � ��$	 120��6:   �� 5�   "    � ��$ 40��6;    �� Triggers 5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   ��  � �� �#007ACC6G   �� 5�   *    �@�Cursor$
 Hand��6C   5�   '   5�      5�      5�      �� 5�      $ Vertical=�5�      $��484,40,98,-324q�5�      �� 5�      $1��+/Images/UbicacionIngenieriaSoftwareMaps.png��6   $��136,138,136,-379q�5�      5�      5�      5�      5�      