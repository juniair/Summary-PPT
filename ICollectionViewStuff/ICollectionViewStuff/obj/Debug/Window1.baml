   M S B A M L   `   `   `  ����O  KICollectionViewStuff, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ICollectionViewStuffICollectionViewStuff  5      "    ICollectionViewStuff.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      2local"clr-namespace:ICollectionViewStuff    5        � Title$  CollectionView Stuff :)��5      $	��600��6%   $	��400��62   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   9� $��	Filtering��6   $��0��6&   .��5      ]� $��0,5,0,5q�6   .+�5      �� $��Search by Name��6   $��0,0,20,0q�62   �� 5      $	��150��6   ��6&   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�5      5      9� 5   
   $��Sorting��6   $��1��6$   .��5      ]� $��1��6   $��0,5,0,5q�6%   .+�5      �� $��
Sort By Id��6   $��5q�60    d� 	IsChecked 6;   �� *
SortById+�� 5      $��Sort By Name��6   $��5q�62    6=   �� *
SortByName+�� 5      $��	Ascending��6   $��15,5,5,5q�6/    6A   �� *SortAscending+5      5      9� 5"   
   $��Grouping��6   $��2��6%   .��5#      ]� $��1��6   $��0,5,0,5q�6%   .+�5$      �� $��Group By Location��6   $��5q�67    6B   �� *GroupByLocation+5%      5&      �� 5(   
   $��3��62   $��0,5,0,0q�6?   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6P   ��6   �� *MyData+ �� 
GroupStyle 5)      (  "System.Windows.Controls.GroupStyle  5*         HeaderTemplate 5+      �� 5,      .R�5-      �� $
��Bold"�6>   ��6(   �� *Name+6>   5.      50       �� View 52      �� 53      .P�54      �� $��ID��6%    �� Width$ 50��6U   	 �� DisplayMemberBinding	 61   �� *ID+6U   �� 55      $
��Name��6%   $	 250��6Y   	 63   �� *Name+6Y   56      58      �� 5:   
   $��4��6   $��5q�6"   .+�5<      �� 
 �� Orientation$
 
Horizontal=�6   $
��Bold"�62   $��2��6P   $��Center=�6d   .+�5=      �� $��<|��6   $ ��local:Commands.SelectFirst��6)   �� 5>      $��<��6   $#��local:Commands.SelectPrevious��6(   �� 5?      $��>��6   $��local:Commands.SelectNext��6(   �� 5@      $��|>��6   $��local:Commands.SelectLast��6)   5A      �� 5C      $��0,5,0,0q�6    �� CornerRadius$ 5��6&   
�������$��1q�6L    �� Padding$ 5q�6`   ._�5E      �  5F      �� 5G      �� 5H      �� 5I      �� 5J       � ColumnDefinitions 5L      �� 5M      $	��100 �6+   �� 5N      .+�5Q      �� $��Currently selected��6    $
��Bold"�6:   $��2��6L   �� 5S      $��ID��6    $��1��6*   �� 5T      $��1��6J   $��1��6W   ��6    �� *CurrentSelectedPerson.ID+6W   �� 5V      $
��Name��6    $��2��6,   �� 5W      $��2��6L   $��2��6\   ��6    �� *CurrentSelectedPerson.Name+6\   �� 5Y      $��Location��6    $��3��60   �� 5Z      $��3��6P   $��3��6`   ��6    �� * CurrentSelectedPerson.Location+6`   5\      5]      5^      5`      5a      