   M S B A M L   `   `   `  ����C  ?Taxi 4.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Taxi_4._0.ViewsTaxi_4._0.Views  5      #    Taxi_4._0.Views.OrderListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Taxi_4._0.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      �� $��0��5         Headder text#��[  5      $��
Order list��5      �� 5      $��1��5        Navigation button#��[ 5      $��
Make order��5      ��5      �� *CreateOrder+5      �� 5      $��2��6   #��[ 5      $��10q�5       $
��Back��5!      ��5"      �� *BackToMainMenu+5#      �� 5%   
   $��1��6   $��10,10q�6    .@�5&      �� �� 5'      �� 5(      ��5)      �� 5*       �� 
TargetType" ��6   .�5+      ��  �� Property � �� �� Value$ Stretch=�6<   5,       �� View 5.      �� 5/      .P�51      �� $��Order Numer��6%    �� CellTemplate 52      �� 53      .R�54   "   �� $��1��6,    �� Padding$ 0 0 20 0q�65   55      57      �� 59      $
��From��6%    5:      �� 5;      .R�5<   "   �� $��Ordzenikidze��6,   $ 0 0 20 0q�6@   5=      5?      �� 5A      $��
Where from��6%    5B      �� 5C      .R�5D   "   �� $��1 maya��6,   $ 0 0 20 0q�6:   5E      5G      �� 5I      $��Price��6%    5J      �� 5K      .R�5L   "   �� $	��140��6,   $ 0 0 20 0q�67   5M      5O      �� 5Q      $��Distance��6%    5R      �� 5S      .R�5T   "   �� $	��9,4��6,   $ 0 0 20 0q�67   5U      5W      �� 5Y      $��	Ride time��6%    5Z      �� 5[      .R�5\   "   �� $��10:20��6,   $ 0 0 20 0q�69   5]      5_      5a      5c      5d      5e      