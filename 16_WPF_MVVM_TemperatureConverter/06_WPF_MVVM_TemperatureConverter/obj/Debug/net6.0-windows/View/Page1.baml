   M S B A M L   `   `   `  ����[  W06_WPF_MVVM_TemperatureConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:_06_WPF_MVVM_TemperatureConverter.View&_06_WPF_MVVM_TemperatureConverter.View  5      2    ,_06_WPF_MVVM_TemperatureConverter.View.Page1   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:_06_WPF_MVVM_TemperatureConverter.View     5        N� Title$  Page1��5	      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��20 �6    �� 5      $	��50* �6    �� 5      $	��20* �6    �� 5      $��10 �6    .+�5      � $��0��6   .+�5      �� 
�����_�6   �� 5"      -   5        $��
txt_header��5"      $-��'Temperature Converting Program: Bazinga��6.   $
��Bold"�6]   5$      � 5'      $��1��6   .+�5)      �� 
����İ�6   �� 5+      $&�� Enter Any value for Celsius  !!!��6   $��14(�6D   $
��Left=�6R   $��257,22,0,199q�6m   �� 5-      $��Celsius��6   $��light)�6*   $��16(�6=   $
��Left=�6K   $	��Top=�5.      $��28��6,   $��97��68   $��
132,92,0,0q�6C   �� 50      -   5        $��txt_celsius��50      $��light)�6-   $��16(�6@   $��Right=�6N   $	��Top=�51   
   $	��250��6"   $��
0,95,311,0q�6.   ��52   
   �� *	Celsius+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 55      $��	Farenheit��6   $��light)�6,   $��16(�6?   $
��Left=�6M   $	��Top=�56      $��28��6,   $��97��68   $��132,137,0,0q�6C   �� 57      -   5        $��txt_farenheit��57      $��light)�6/   $��16(�6B   $��Right=�6P   $	��Top=�58      $	��250��6.   $��0,144,311,0q�59   V   ��6   �� *
fahrenheit+$ PropertyChanged=�6V   �� 5;      $��Kelvin��6   $��light)�6)   $��16(�6<   $
��Left=�6J   $	��Top=�5<      $��28��6,   $��97��68   $��132,195,0,0q�6C   �� 5=      -   5        $��
txt_kelvin��5=      $��light)�6,   $��16(�6?   $��Right=�6M   $	��Top=�5>      $	��250��6.   $��0,198,311,0q�5?   R   ��6   �� *kelvin+$ PropertyChanged=�6R   �� 5C      $��16(�6O   $��Right=�6]   $	��Top=�6y   $	��250��6�   $��0,144,311,0q�6�   ��6   �� *
Fahrenheit+ �� StringFormat$ {0:F2}��6�   �� 5D      $��16(�6K   $��Right=�6Y   $	��Top=�6u   $	��250��6�   $��0,198,311,0q�6�   ��6   �� *Kelvin+$ {0:F2}��6�   5F      � 5I      $��2��6   .+�5K      �� 
����·�6   �� 5N      -   5        $��btn_Convert��5N      $��188,43,504,35q�6,   $��Convert��6C   $��18(�5O      $
��Bold"�6#   ��65   �� *ConvertCommand+�� 5Q      -   5        $��	btn_Clear��5Q      $��Clear��6+   $��18(�5R      $
��Bold"�6#   $��482,43,210,35q�65   ��5S      �� *ClearCommand+5V      � 5Y      $��3��6   .+�5[      �� 
�����_�6   �� 5]      -   5        $��
txt_footer��5]      $��Developed By MojithaR��6/   $��Light"�6L   $��6(�6_   $��Center=�6l   5`      5c      5e      5f      