   M S B A M L   `   `   `  ����F  BTestproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:UserControlFun.FunUserControlFun.Fun  5   �        UserControlFun.RangeSlider   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      \ XAvalonControlsLibrary, Version=2.0.0.0, Culture=neutral, PublicKeyToken=50c04fcafdb45ca6Hlocal<http://schemas.AvalonControls/AvalonControlsLibrary/Controls  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  6E   -local1 clr-namespace:UserControlFun.Fun  6�   -   5          >�Name$
  root��5       � 	Resources 5         WindowColor  ContentAreaColorLight  ContentAreaColorDark  BrushSliderEdge �� Color  BrushSliderActiveArea  BrushSliderThumb  BrushSliderThumbBorder  DisabledControlLightColor  DisabledControlDarkColor 	 DisabledForegroundColor 
 SelectedBackgroundColor  SelectedUnfocusedColor  ControlLightColor  ControlMediumColor  ControlDarkColor  ControlMouseOverColor  ControlPressedColor  
GlyphColor  GlyphMouseOver  BorderLightColor  BorderMediumColor  BorderDarkColor  PressedBorderLightColor  PressedBorderDarkColor  DisabledBorderLightColor  DisabledBorderDarkColor  DefaultBorderBrushDarkColor  HeaderTopColor " DatagridCurrentCellBorderColor  SliderTrackDarkColor  NavButtonFrameColor  MenuPopupBrush �� EndPoint �� 
StartPoint � Color � Offset $   ProgressBarIndicatorAnimatedFill ! SliderButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType " SliderThumbStyle A�Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value �� Triggers P� Property P� Value # HorizontalSlider $ VerticalSlider % SliderThumb & simpleSlider J� SnapsToDevicePixels �Name � RowDefinitions ��Name ]�Name ]� Thumb��%�  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 8    &	
 Y    &	 z    &	 �    &	 �    &	 �    &	 �    &	     &	 <    &	 ]    &	 �    &	 �    &	 �    &	     &	 $    &	 E    &	 f    &	 �    &	 �    &	 �    &	 �    &	     &	 $    &	  �    &	!     &	" o    7  7  7  '�� �    7 # 7 $ &	% �    7  &	& �    7 % ��5	   
   	#FFE8EDF9��6/   ��5
   
   	#FFC5CBF9��69   ��5   
   	#FF7381F9��68   �� 5   
   $ 	LightGray��62   �� 5   
   $ DeepSkyBlue��68   �� 5   
   $ LightSkyBlue��63   �� 5   
   $ DeepSkyBlue��69   ��5   
   	#FFE8EDF9��6=   ��5   
   	#FFC5CBF9��6<   ��5   
   	#FF888888��6;   ��5   
   	#FFC5CBF9��6;   ��5   
   	#FFDDDDDD��6:   ��5   
   	White��61   ��5   
   	#FF7381F9��66   ��5   
   	#FF211AA9��64   ��5   
   	#FF3843C4��69   ��5   
   	#FF211AA9��67   ��5   
   	#FF444444��6.   ��5    
   /+sc#1, 0.004391443, 0.002428215, 0.242281124��6T   ��5#   
   	#FFCCCCCC��64   ��5$   
   	#FF888888��65   ��5%   
   	#FF444444��63   ��5'   
   	#FF888888��6;   ��5(   
   	#FF444444��6:   ��5*   
   	#FFAAAAAA��6<   ��5+   
   	#FF888888��6;   ��5-   
   	Black��6;   ��50   
   	#FFC5CBF9��62   ��51   
   	Black��6>   ��52   
   	#FFC5CBF9��68   ��54   
   	#FF3843C4��67   �� 56   
   $ 0.5,1&�57      $ 0.5,0&�58      .��59      � # �  6   $ 0Q�5:      � 5;      # �  6   $	 0.5Q�5<      � 5=      # �  6   $ 1Q�5>      5?      �� 5A   
   $	 0,0&�5B      $	 1,0&�5C      ��5E      � � 5F      $ 	#000000FF��6#   $ 0Q�5G      � 5H      $ 	#600000FF��6#   $	 0.4Q�5I      � 5J      $ 	#600000FF��6#   $	 0.6Q�5K      � 5L      $ 	#000000FF��6#   $ 1Q�5M      5N      5P      �� 5S   
   " ��5T      .�5U      ��  �@J�SnapsToDevicePixels	 . 5V      �� 5W       �@�OverridesDefaultStyle	 . 5X      �� 5Y       � ��	 .  5Z      �� 5[       � |�	 .  5\      �� 5]       � ��	 5^      �� 5_      "
 ��6&   .R�5`      �� 
������ 6!   5a      5c      5d      �� 5f   
   " n�5g      .�5h      ��  �@J�SnapsToDevicePixels	 . 5i      �� 5j       �@�OverridesDefaultStyle	 . 5k      �� 5l       � ��$	 14��5m      �� 5n       � ��$	 14��5o      �� 5p       � ��	 5q      �� 5r      "
 n�6&   .R�5s      A� $ Ellipse��6"   $��1��5t      ��5u      �� 5v   "   $	 0,0&�66   $	 0,1&�5w   "   ��5y   *   � � 5z   .   # �  6;   $	 0.0Q�5{   !   � 5|   .   # �  6;   $	 1.0Q�5}   !   5~   +   5�   #   ��5�      �� 5�   "   $ 0.5,1&�66   $ 0.5,0&�5�   "   .��5�   &   � # �  63   $ 1Q�5�      � 5�   &   # �  63   5�   #    5�        5�   "   CommonStates��. 5�   &     
Normal��62     5�   &   	MouseOver��. 5�   *   �� .��5�   .   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6K   $ Ellipse��5�   1   .g�5�   2     $ 0��6F   8   5�   *   5�   /   5�   +   5�   '     5�   &   Pressed��. 5�   *   �� .��5�   .   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6K   $ Ellipse��5�   1   .g�5�   2     $ 0��6F   8  5�   *   5�   /   5�   +   5�   '     5�   &   Disabled��. 5�   *   �� .��5�   .   �� $] W(Shape.Fill).                     (GradientBrush.GradientStops)[0].(GradientStop.Color)�6K   $ Ellipse��5�   1   .g�5�   2     $ 0��6F   8  5�   *   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�   
   " ��6   .�5�      ��  �@J�SnapsToDevicePixels	 . 5�      �� 5�       �@�OverridesDefaultStyle	 . 5�       5�      P� 5�       �@��Orientation$ 
Horizontal=�5�      . �5�      ��  � ��$		 104��5�      �� 5�       � ��$	 21��5�      �� 5�       � ��8	   5�      5�      P� 5�       �@��Orientation$ Vertical=�5�      . �5�      ��  � ��$	 21��5�      �� 5�       � ��$		 104��5�      �� 5�       � ��8	  5�      5�      5�      �� 5�   
   " n�6$   .�5�      ��  �@�OverridesDefaultStyle	 . 66   �� 5�       �@J�SnapsToDevicePixels	 . 64   �� 5�       � ��	 5�      �� 5�      "
 n�6&   .R�5�      A� $��10��6"   $��10��6-   8��  69   5�      5�      5�      �� 5�   
   "
 ��6/   .R�5�      ��  . #��z��61   #��z��6]   ._�5�      � $ tempGrid��6    5�      �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   #��z��66   �� 5�      $
��Auto �6(   .+�5�      �� $ PART_SelectionRange��6    ]� 5�      $ 
PART_Track��5�      $��1��5�       5�      n� 5�      8��  6$   5�      5�      5�      5�      5     .��5     � -   5        $ 
sliderGrid��5     $	��Top=�6    � ColumnDefinitions 5  
   �� 5     $
��70px �6   6.   �� 5     $��* �6    6,   �� 5     $
��70px �6   6.   .+�5  
   �� -   5        $��0q�5     $��0��6&    �� 
IsReadOnly .  $��	10,1,10,1q�5     ��5  J   ��  �� ElementName$
 root�� �� Path$ 
LowerValue�  �� Mode$  TwoWay=�5     �� 5  
   -   5        ! ��Name$! border��5     $��1��6!   $��0,2,0,0q�62   
�������$��Center=�6a   $��5,0,5,0q�5      �� 5"  
   -   5        " ��Name$" LowerSlider��5"     # �� TickFrequency$# 1Q�6&   $��1��6:   $ �� IsSnapToTickEnabled$ . #��[& 5#  ,   % �� IsSelectionRangeEnabled% . $��0,0,10,0q�5+     & � Minimum& 5&     �� $
 root��$ Minimum�' � Maximum' 5'     �� $
 root��$ Maximum�( � Value( 5)     �� $
 root��$ 
LowerValue�$  TwoWay=�.  (System.Windows.Interactivity.Interaction)   	Behaviors) 5-     8   2UserControlFun.Fun.SliderValueChangeByDragBehavior  5.     50     �� 52  
   -   5        $" UpperSlider��52     $# 1Q�6'   $��1��6:   $ . #��[& 53  ,   $��10,0,0,0q�5:     & 55     �� $
 root��$ Minimum�' 56     �� $
 root��$ Maximum�( 58     �� $
 root��$ 
UpperValue�$  TwoWay=�) 5<       5=     5?     �� 5C  
   -   5        $��0q�5C     $��2��6&    .  $��	10,1,10,1q�5G     ��5F     �� $
 root��$ 
UpperValue�$  TwoWay=�5G     5K     5L     