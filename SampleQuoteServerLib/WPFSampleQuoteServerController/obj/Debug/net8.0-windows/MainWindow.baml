   M S B A M L   `   `   `  ����Y  UWPFSampleQuoteServerController, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WPFSampleQuoteServerControllerWPFSampleQuoteServerController  5   	   /    )WPFSampleQuoteServerController.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:WPFSampleQuoteServerController     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ listBoxServices��5      $
��Auto��6+   $��6q�68   $��0��6C   $��0��6P      listTemplate#��[  5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6?   ��5   `   �� 5   ?   � 5   
   $��0��6   $��1��6    5      �� 5      $��50 �6    �� 5      $��50 �6    �� 5      $��50 �6    �� 5      $��50 �6    �� 5      $��* �6     5      �� 5      $	��100 �6#   �� 5      $��* �6#   .+�5      �� -   5        $��labelServiceDisplayName��5      $��Display Name:��63   $��6q�6K   $��0��6V   $��0��6c   $
��Auto��6s   $��Right=�6�   �� 5       -   5         ��Name$! textBlockServiceDisplayName��5       $��6q�6=   $��0��6H   $��1��6U   $
��Auto��6e   ��6r   �� */DisplayName+�� 5!      -   5        $��labelServiceStatus��5!      $��Status:��6.   $��6q�6@   $��1��6K   $��0��6X   $
��Auto��6h   $��Right=�6u   �� 5"      -   5        $ textBlockServiceStatus��5"      $��6q�68   $��1��6C   $��1��6P   $
��Auto��6`   ��6m   �� */ServiceStatusName+�� 5#      -   5        $��labelServiceType��5#      $��Type:��6,   $��6q�6<   $��2��6G   $��0��6T   $
��Auto��6d   $��Right=�6q   �� 5$      -   5        $ textBlockServiceType��5$      $��6q�66   $��2��6A   $��1��6N   $
��Auto��6^   ��6k   �� */ServiceTypeName+�� 5%      -   5        $��labelServiceName��5%      $��Service Name:��6,   $��6q�6D   $��3��6O   $��0��6\   $
��Auto��6l   $��Right=�6y   �� 5&      -	   5        $ textBlockServiceName��5&      $��6q�66   $��3��6A   $��1��6N   $
��Auto��6^   ��6k   �� */ServiceName+� 5'      $��4��6   $��0��6    $��2��60   $��Bottom=�6D    5(      �� 5)      $��50 �6$   �� 5*      $��50 �6$   �� 5+      $��50 �6$    5-      �� 5.      $��* �6'   �� 5/      $��* �6'   .+�51      �� -
   5         ��Name$ buttonStart��51      $��6q�6.   $��Start��69   $��0��6I   $��0��6V   0   *WPFSampleQuoteServerController.ButtonState   Start
 � Tag# Z 6�   {�6f   �� */EnableStart+	 �� Mode$	 OneTime=�6�   �� 52      -   5        $ 
buttonStop��52      $��6q�6-   $
��Stop��68   $��0��6G   $��1��6T   
   Stop# Z
 6�   {�6d   �� */EnableStop+$	 OneTime=�6�   �� 53      -   5        $ buttonPause��53      $��6q�6.   $��Pause��69   $��1��6I   $��0��6V      Pause# Z 6�   {�6f   �� */EnablePause+$	 OneTime=�6�   �� 54      -   5        $ buttonContinue��54      $��6q�61   $��Continue��6<   $��1��6O   $��1��6\      Continue# Z 6�   {�6l   �� */EnableContinue+$	 OneTime=�6�   �� 55      -   5        $ buttonRefresh��55      $��6q�60   $��Refresh��6;   $��2��6M   $��0��6Z   6j   �� 56      -   5        $ 
buttonExit��56      $��6q�6-   $
��Exit��68   $��2��6G   $��1��6T   6d   57      58      59      5:      