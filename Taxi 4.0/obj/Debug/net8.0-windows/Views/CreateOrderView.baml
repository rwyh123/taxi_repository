   M S B A M L   `   `   `  ����C  ?Taxi 4.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Taxi_4._0.ViewsTaxi_4._0.Views  5      %    Taxi_4._0.Views.CreateOrderView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Taxi_4._0.Views     5      .��5      � 
�������  � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��* �6   .+�5   
   �� $��0��6      Headder text#��[  5      $��Order��5      $��Center=�5      $��Center=�5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#    z� SharedSizeGroup$ firstColumn��60   �� 5      $
��auto �6#   $ SecondColumn��60   .+�5!      �� $��1��6   $��0��5"        	Main text#��[ 5#      $��
where from��5$      $��Center=�5%      �� 5&      $��1��6   $��1��5'      $��20 0 0 0q�5(      $��Center=�5)      $	��180��5*      $��35��6#   5+      � 5-   
   $��2��6    5.      �� 5/      $
��auto �6#   $ firstColumn��60   �� 50      $
��auto �6#   $ SecondColumn��60   .+�52      �� $��2��6   #��[ 53      $��0��54      $��where��55      $��Center=�56      �� 57      $��2��6   $��1��58      $��20 0 0 0q�59      $��Center=�5:      $	��180��5;      $��35��6!   5=      �� 5?   
   $��3��6   #��[ 5@      $��	Pre price��5A      $��Center=�5B      �� 5D   
   $��4��6    	 Field#��[ 5E      $
��Left=�5F      $��Center=�5G      $	��180��5H      $��40��6   ${�False��5I      �� 5K   
   $��5��6    �� Orientation$ 
Horizontal=�6"   .+�5L      �� $��5��6     Navigation button#��[ 5M      $
��Back��5O      ��5N      �� *BackToMainMenu+5O      �� 5P      -   5         ��Name$ CreateOrderButton��5S      $��5��5P      #��[ 5Q      $��20 0 0 0q�5R      $��Create order��5T      5V      5W      5X      