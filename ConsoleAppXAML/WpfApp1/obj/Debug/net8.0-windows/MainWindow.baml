   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   P LConsoleAppXAMLDataLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:ConsoleAppXAMLDataLib;assembly=ConsoleAppXAMLDataLibConsoleAppXAMLDataLib 5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   VdatalibBclr-namespace:ConsoleAppXAMLDataLib;assembly=ConsoleAppXAMLDataLib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      �� 5   
    �� Type"  ConsoleAppXAMLDataLib.Person"  6      KeypersonArray  .s�5           	FirstName$ 	Stephanie��6      LastName$ Nagel��63     5      $ Matthias��6   $ Nagel��62   5         WpfApp1.MyDependencyObject  5   
      WpfApp1.MyDependencyObject   ValueChanged$ OnValueChanged��6T   dep1     Minimum$ 0��60      Maximum$ 50��6<      Value$ 30��6I   6T   .��5      � -   5        	 � ColumnDefinitions	 5   
   �� 5      $	��100 �6   �� 5      $��* �6   
 � RowDefinitions
 5   
   �� 5      $
��auto �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��button1��5      $��	Click Me!��6    $��0��6I   $��0��6Y   �� 5   
   $��1��6   $��0��6"   .@�5        $ 	Stephanie��6   $ Nagel��63     5      $ Matthias��6   $ Nagel��62   5       �� 5!   
   $��1��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $��2��6K   .+�5"      �� -   5         ��Name$ CheckStopPreview��5"      $��20q�61   .��6=   Stop Preview5$      �� 5%      -   5        $ CheckStopBubbling��5%      $��20q�62   .��6>   Stop Bubbling5'      �� 5(      -   5        $ CheckIgnoreGridMove��5(      $��20q�64   .��6@   Ignore Grid Move5*      �� 5+      -   5         ��Name$ buttonCleanStatus��5+   !   $��20q�6   .��6\   Clean Status6j   �� 5,      .+�5-      �� -   5         ��Name$ slider1��5-       � Minimum$ 0Q�6*    � Maximum$ 70Q�66   $	��257��6�   $��27��6�    � Value 6C   ��   dep1 �� Source# [  �� Path$ Value� �� Mode$ TwoWay=�6�   �� 5.      
����� �$��80��6u   
���������6   �� # [ $ Value�$ TwoWay=�6�   5/      50      �� 51   
   -   5         ��Name$ stackPanelButton��51      $��2��6/   $��0��6<   $��2��6L   $ 
Horizontal=�6`   .+�52      �� -	   5        $ buttonMouseMove��52      $��20q�6.   $	��200��6:   .��6�   Move6�   �� 53      -
   5        $ buttonAttachedProperty��53      $��20q�65   $	��200��6A   (  "WpfApp1.MyAttachedPropertyProvider   
MyProperty$ 42��6M   .��6   Attached Property6�   �� 54      -   5         ��Name$ list1��54      $��2��6%   
���Gc��
�������$	��300��6Y   $��70��6e   55      �� 56   
   $��3��6   $��0��6$   $��2��64   
�������.��57      �� -   5         ��Name$ 
textStatus��57   $   $��20q�6   6$   58      59      5:      