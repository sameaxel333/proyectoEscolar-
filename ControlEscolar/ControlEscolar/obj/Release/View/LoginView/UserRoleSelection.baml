   M S B A M L   `   `   `  ����   ControlEscolar1    +ProyectoEscolarizado.View.UserRoleSelection   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Bienvenido��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Icon$/ )/Resources/LogoAplicacionSomosUAZmini.ico��.����  �� CornerRadius$ 12��._��� $ 10��$��2q� J� Opacity$
 0.95Q�$��
0,14,0,-14q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 #2e2e2e��
 � Offset$
 0Q�� $	 #dadada��$

 0.75Q�� $	 #2e2e2e��$
 1Q����� $ 0.1,0&�$	 1,1&�.��� $	 #060521��$
 0Q�� $	 	LightBlue��$

 0.75Q�� $	 #060521��$
 1Q�._��  � ColumnDefinitions �� ��  � RowDefinitions �� $��30 �.+��� $��-27,72,-59,-864q�$��/images/logoUAZblanco.png��$
��Fill=�$��2���� -    ��Name$ btnMinimizar�� � ToolTip$ 	Minimizar�� � Cursor$
 Hand��$��28��$��28��
������ $��0q�$��
332,1,38,1q�$��1������  �� 
TargetType" ��.R���  ��Name$ border��#��z��$��28��$��28��._��� $	��―��$��14(�
���   �$
��Bold"�$��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ border�� �� Property � �� �� Value �#DDDDDD�� -   $ 	btnCerrar��$ Cerrar��$
 Hand��$��28��$��28��
������ $��0q�$��
360,1,10,1q�$��1������ " ��.R��� $ border��#��z��$��28��$��28��._��� $��×��$��14(�
���   �$
��Bold"�$��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ border�� � �� �#FFCDD2� $��0��$��2��$��
0,0,0,-349q� �� �� $��25 ��� $��25 ��� $��5 �.+��� $	��Top=�$
��Left=�$	��208�� J� RenderTransformOrigin$ 0.5,0.5&�$��134,163,0,0q�$	��554��z�V� .~��� �� ��  �� Angle$ -0.06Q�T� .+��� $D��>Bienvenido al Sistema de la Universidad Autónoma de Zacatecas�� �� TextAlignment$ Center=�$��18(�$
��Bold"�$
��Wrap=����#ffffff$��62��$	��561���� $R��L¿Qué eres?, Por favor selecciona tu Rol en la Escuela para Iniciar Sesión��$��16(�$ Center=�$��SemiBold"����#e8f6fe��  �� Orientation$ 
Horizontal=�$	��304��$	��120��.+��� -   $	��100��$	��100�����#434343
�������
�������.���� $��/Images/IconoMaestro.png��$��90��$��90���� -   $	��100��$	��100�����#434343
�������
�������.���� $$��/Images/IconoAdministrador.png��$��90��$��90���� -   $	��100��$	��100�����#434343
�������
�������.���� $!��/Images/IconoEstudiante.png��$��90��$��90���� $��358,54,326,-136q�$%��/LogoAplicacionSomosUAZmini.png��$
��Fill=�$��2�� J� Clip ��  �� RadiusX$ 20Q� �� RadiusY$ 20Q� �� Rect$ 0,0,100,100�