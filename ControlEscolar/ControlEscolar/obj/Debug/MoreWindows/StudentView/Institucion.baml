   M S B A M L   `   `   `  ����I  EControlEscolar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ControlEscolar.ViewControlEscolar.View  5   	   C&clr-namespace:ControlEscolar.ViewModelControlEscolar.ViewModel  5   	   %    ControlEscolar.View.Institucion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ControlEscolar.View     5   	   <	ViewModel&clr-namespace:ControlEscolar.ViewModel     5   	     � Title$  Institucion��5	   	   $	��450��6   $	��800��6*    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency .  � Icon$/ )/Resources/LogoAplicacionSomosUAZmini.ico��5   	    � DataContext 5      -   'ControlEscolar.ViewModel.LoginViewModel  5   
    � 	Resources 5         BooleanToVisivility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'   	 �� 	Converter#	 [  5      .��5      �� 
 �� CornerRadius$
 12��6   ._�5   
   �� $
 10��6   $��2q�6#    J� Opacity$
 0.98Q�67   $��
0,14,0,-14q�6F   ��5      �� 5        �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5!      �  � Color$ #2e2e2e��6#    � Offset$ 0Q�63   � 5"      $ #dadada��6#   $
 0.75Q�63   � 5#      $ #2e2e2e��6#   $ 1Q�63   5$      ��5&      �� 5'      $ 0.1,0&�6&   $	 1,1&�69   .��5(      � $ #060521��6#   $ 0Q�63   � 5)      $ 	LightBlue��6#   $
 0.75Q�65   � 5*      $ #060521��6#   $ 1Q�63   5+      ._�5.      �  � RowDefinitions 5/      �� 50      $��30 �6$   �� 52      $��* �6$   .+�57      � $��0��6    � ColumnDefinitions 58      �� 59      �� 5:      $��25 �6+   �� 5;      $��25 �6+   �� 5<      $��5 �6+   .+�5?      �� -   5         ��Name$ btnMinimizar��5?      $��0q�5@      $��-��5A      
�������$��16(�5C      $��	Monserrat)�5D       � Cursor$
 Hand��5E      $��1��5F      ��5H      �� 5I       �� 
TargetType" ��6$   .�5J   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5K   "   P� 5L   &    P� Property �@J�IsMouseOver P� Value . . �5M   *   ��  � �� �#278BEF6G   5N   '   5P      ��5R      �� 5S       �� 
TargetType" ��6.   .R�5T   "   �� $��18��6)   $��18��64   $
 9��6@   #��z��5U   )   $��4,8,3,4q�6S   ._�5V   &   �� $��Center=�67   $��Center=�5W   7   5X   #   5Y      5[      �� 5]      -   5        $ 	btnCerrar��5]      $��0q�5^      $��x��5_      
�������$��16(�5a      $��	Monserrat)�5b      $
 Hand��5c      $��2��5d      $��2,0,2,0q�5e   5   ��5f      �� 5g      " ��6$   .�5h   "   ��  � ��
 �  ��6?    5i   "   P� 5j   &    �@J�IsMouseOver . . �5k   *   ��  � �� �#278BEF6G   5l   '   5n      ��5p      �� 5q      " ��6.   .R�5r   "   �� $��18��6)   $��18��64   $
 9��6@   #��z��5s   )   ._�5t   &   �� $��Center=�67   $��Center=�5u   7   5v   #   5w      5y      �� 5{      -   5        $��← Regresar��5{      $
��Left=�5|      $��631,15,0,-25q�5}      $	��110��5~      $��16(�5�      $
��Bold"�5�      
���������5�      �� 5�      " ��6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   " ��6:   .R�5�   .   �� #��z��65   $
 8��5�   5   
�������$��2q�5�   5   ._�5�   2   �� $��Center=�6C   $��Center=�5�   C   5�   /   5�   +   5�   #   �� 5�   "    � �� �#005A9C6?   �� 5�   "    � ��
 �����6?   �� 5�   "    � ��$ 16(�6=   �� 5�   "    � ��$
 Bold"�6?   �� 5�   "    � ��$	 120��6:   �� 5�   "    � ��$ 40��6;    5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   ��  � �� �#007ACC6G   �� 5�   *    �@�Cursor$
 Hand��6C   5�   '   5�      5�      5�      �� 5�       �� Orientation$ Vertical=�6   $��50,80,50,50q�5�      $��1��5�      .+�5�      �� $��NUESTRA INSTITUCIÓN��6    
�������$��32(�5�       $
��Bold"�5�       $��
Montserrat)�5�       $��0,0,0,20q�5�       �� 5�      $����La Universidad Autónoma de Zacatecas (UAZ) es una institución pública comprometida con la formación integral de profesionistas, la generación de conocimiento, y la vinculación con la sociedad.��6    $
��Wrap=�5�       
�������$��15(�5�       $��
Montserrat)�5�       $��0,0,0,10q�5�       �� 5�      $����Cuenta con una amplia oferta educativa, una sólida planta docente, y múltiples programas de investigación y extensión. Su campus principal, el Campus Siglo XXI, alberga modernas instalaciones que favorecen el desarrollo académico y cultural de la comunidad estudiantil.��6    $
��Wrap=�5�       
�������$��15(�5�       $��
Montserrat)�5�       �� 5�      $��Dirección:��6    
�������$��16(�5�       $
��Bold"�5�       $��0,20,0,5q�5�       �� 5�      $S��MCampus Siglo XXI: Villanueva - Zacatecas, La Escondida, 98160 Zacatecas, Zac.��6    
�������$��15(�5�       $��
Montserrat)�5�       $
��Wrap=�5�       5�      5�      5�      5�      5�      