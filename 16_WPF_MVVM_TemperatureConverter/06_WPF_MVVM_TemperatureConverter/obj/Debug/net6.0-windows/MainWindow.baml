   M S B A M L   `   `   `  ����[  W06_WPF_MVVM_TemperatureConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:_06_WPF_MVVM_TemperatureConverter!_06_WPF_MVVM_TemperatureConverter  5   	   2    ,_06_WPF_MVVM_TemperatureConverter.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:_06_WPF_MVVM_TemperatureConverter     5   	     � Title$  Temperature Converter��5   	   $	��450��6'   $	��800��64   .��5	      � ���#4b3832 � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   ���#3c2f2f.+�5      �� $��Temperature Converter��6   $
��Bold"�65   $��24(�6G   $��Center=�6U   $��Center=�6r   ���#fff4e66�   5      � 5   
   $��1��6   ���#854442.+�5      �� $��20q�6   .+�5      �� $��Enter a value in Celsius:��6   $��16(�6=   $
��0 10q�6K   ���#fff4e66Y   �� 5      $��16(�6e   $	��0 5q�6s   ��6   �� *	Celsius+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6s   �� 5      $��Fahrenheit:��6   $��16(�6/   $
��0 10q�6=   ���#fff4e66K   �� 5      $��16(�6O   $	��0 5q�6]   ���#fff4e6��6   �� *
Fahrenheit+ �� StringFormat$ {0:F2}��6j   �� 5      $��Kelvin:��6   $��16(�6+   $
��0 10q�69   ���#fff4e66G   �� 5      $��16(�6K   $	��0 5q�6Y   ���#fff4e6��6   �� *Kelvin+$ {0:F2}��6f   5      5       � 5#   
   $��2��6   ���#be9b7b.+�5$      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5&      �� $��Convert��6   $��18(�6+   $
��Bold"�69   $��10q�6K   ���#3c2f2f
���������6W   �� *ConvertCommand+6�   �� 5(      $��Clear��6   $��18(�6)   $
��Bold"�67   $��10q�6I   ���#5d140e
���������6U   �� *ClearCommand+6�   5)      5*      � 5-   
   $��3��6   ���#2f0000.+�5.      �� $��Developed By MojithaR��6   $��12(�65   $��Center=�6C   $��Center=�6`   
�������6{   5/      50      51      