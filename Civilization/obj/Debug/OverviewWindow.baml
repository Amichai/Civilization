   M S B A M L   `   `   `  ����V  RDataBindingZoomAndPanSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ZoomAndPanSampleZoomAndPanSample  5      E AZoomAndPan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ZoomAndPan;assembly=ZoomAndPan
ZoomAndPan 5      %    ZoomAndPanSample.OverviewWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      .localclr-namespace:ZoomAndPanSample    5      A
ZoomAndPan,clr-namespace:ZoomAndPan;assembly=ZoomAndPan    5      -   5          � Title$  Overview��5      $	��200��5      $	��200��5       � WindowStyle$ 
ToolWindow=�5	       � ShowInTaskbar .   � ShowActivated .   � 	Resources 5      ,   &ZoomAndPanSample.ColorToBrushConverter   colorToBrushConverter �� DataType"   ZoomAndPanSample.BoardObject��%�   &	        (��      5      *, +)  5   
   5      �� 5   
   "  5      .R�5      �� ��5      �� *Width+��5      �� *Height+��5       �� *Source+5"      5$      .��5+      "  ZoomAndPan.ZoomAndPanControl  -   5          Name$ overview��5,   	   
�������.��54   
   � -   5        ��55      ��     ZoomAndPanSample.DataModel   Instance �� Source# Z 	 �� Path$	 ContentWidth���56      �� # Z $	 ContentHeight�.+�5?      �� -   5        
 ��Name$
 content��5@      
���������5A      �� # Z $	 BoardObjects���5E      �� 5F      .�5G      ��  �� Property �@��Left �� Value 68   �� *X+�� 5H       �@��Top 67   �� *Y+5I      ��5L      �� 5M      .R�5N      �� 5O      5R      �� 5X      .+�5Y      n� -   5         n�Name$ overviewZoomRectThumb��5Z       J� Opacity$	 0.5Q�5`       �� Left 5[      �� # Z $	 ContentOffsetX� �� Mode$ TwoWay=�
 �� Top 5\      �� # Z $	 ContentOffsetY�$ TwoWay=���5]      �� # Z $	 ContentViewportWidth���5^      �� # Z $	 ContentViewportHeight���5b      �� 5c       �� 
TargetType" n�5d      .R�5g      �� 
���   �$��1q�5i   !   
��� ��� �� CornerRadius$ 1��5k   !   5n      5p      5q      5s      5t      5v      