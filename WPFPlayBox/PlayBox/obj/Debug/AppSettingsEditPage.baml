   M S B A M L   `   `   `  ����B  >PlayBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PlayBoxPlayBox  5      !    PlayBox.AppSettingsEditPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:PlayBox     5        N� Title$  Application Settings��5	      $
��Auto��6$   $
��Auto��61    N� 
Background �	#FF2B343A.��5
      � $��0,0,3,0q�6    � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   �� 5      $	��35* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   �� 5      $	��13* �6   .+�5   
   �� -   5         ��Name$ _header��5      $��Settings Configuration��6!   $��0q�6B   $��Center=�6M   $��16(�6o   $��5,0,1,0q�6}   
�������6�   � 5   
   -   5         �Name$ _currencyGrid��5      $��0q�6&   $��1��61   ���	#FF2D2F31 � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      .+�5      �� -   5        $ _currencyLBL��5      $��	Currency
��6*   $��0q�6B   $��0q�6M   $��Center=�6Y   $��Center=�6�   
�������$��13.333(�6�   $��Microsoft YaHei Light)�6�   �� 5      -   5         ��Name$ 	_currency��5      $��0q�6�   $��1��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��10.667(�6   �� SelectedIndex 6+   �� *
Currency+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�.@�5      �� $��$��6   �� 5      $	��€��6   �� 5      $	��Bs.��6   5      5      � 5    
   -   5        $ _consumptionGrid��5       $��0q�6)   $��2��64    5!      �� 5"      $��3* �6    �� 5#      $��7* �6    �� 5$      $��3* �6    �� 5%      $��7* �6    .+�5'      �� -   5        $ _gameConsumptionGridLBL��5'      $��Game Consumption Settings��65   $��0q�6Y   $��0q�6�   
�������$��10.667(�6�   $��Center=�6�   $��Microsoft YaHei Light)�6�   � 5(      -   5        $ _gameConsumptionGrid��5(      $��0q�61   ���	#FF121417$��1��6S    5)      �� 5*      �� 5+       5-      �� 5.      $��5* �6'   �� 5/      $
��Auto �6'   �� 50      $��5* �6'   �� 51      $��8* �6'   .+�53      �� -   5        $ _gamePriceLBL��53      $��Price��6/   $��0q�6?   $��0q�6J   $��Center=�6V   $
��Bold"�6z   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 54      -	   5        $ _gameTimeLBL��54      $
��Time��6.   $��0q�6=   $��0q�6H   $��2��6T   $��Center=�6d   $
��Bold"�6�   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 55      -
   5        $ _gameTimeMeasurementLBL��55      $��Time
Measurement��69   $��0q�6X   $��0q�6c   $��3��6o   $��Center=�6   $
��Bold"�6�   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 56      -   5        
 ��Name$
 
_gamePrice��56      $��0q�6�    �� TextWrapping$
 Wrap=�6�   $	��106��6�   $��1��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6  $��Center=�6'  $��10.667(�6I  ��6.   �� *Settings.GameSettings.Price+$ TwoWay=�$	 PropertyChanged=�6I  �� 57      -   5        $ _gamePerLBL��57      $��/��6-   $��0q�69   $��0q�6D   $��Stretch=�6P   $��1��6s   $��1��6�   $
��Bold"�6�   $��Stretch=�6�   
�������6�   �� 58      -   5        $
 	_gameTime��58      $��0q�6�   $
 Wrap=�6�   $��1��6�   $��2��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6  $��Center=�6/  $��10.667(�6Q  ��6-   �� *" Settings.GameSettings.PerDivisor+$ TwoWay=�$	 PropertyChanged=�6Q  �� 59      -   5        $ _gameTimeMeasurement��59      $��0q�6�   $��1��6�   $��3��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6   $��10.667(�6B   6:   �� *GameTimeDivisor+$ TwoWay=�$	 PropertyChanged=�.@�5:      �� $��Seconds��6#   �� 5;      $��Minutes��6#   �� 5<      $��Hours��6#   5=      5>      �� 5?      -   5        $ _videoConsumptionGridLBL��5?      $ ��Video Consumption Settings��66   $��0q�6[   $��0q�6f   
�������$��2��6�   $��10.667(�6�   $��Center=�6�   � 5@      -   5        $ _videoConsumptionGrid��5@      $��0q�62   $��3��6=   ���	#FF121417 5A      �� 5B      �� 5C       5E      �� 5F      $��5* �6'   �� 5G      $
��Auto �6'   �� 5H      $��5* �6'   �� 5I      $��8* �6'   .+�5K      �� -   5        $ _videoPriceLBL��5K      $��Price��60   $��0q�6@   $��0q�6K   $��Center=�6W   $
��Bold"�6{   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 5L      -   5        $ _videoTimeLBL��5L      $
��Time��6/   $��0q�6>   $��0q�6I   $��2��6U   $��Center=�6e   $
��Bold"�6�   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 5M      -   5        $ _videoTimeMeasurementLBL��5M      $��Time
Measurement��6:   $��0q�6Y   $��0q�6d   $��3��6p   $��Center=�6�   $
��Bold"�6�   
�������$��Bottom=�6�   $��10.667(�6�   $��Microsoft YaHei Light)�6�   �� 5N      -   5        $
 _videoPrice��5N      $��0q�6�   $
 Wrap=�6�   $	��106��6�   $��1��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6  $��Center=�6)  $��10.667(�6K  ��6/   �� *Settings.VideoSettings.Price+$ TwoWay=�$	 PropertyChanged=�6K  �� 5O      -   5        $ _videoPerLBL��5O      $��/��6.   $��0q�6:   $��0q�6E   $��Stretch=�6Q   $��1��6t   $��1��6�   $
��Bold"�6�   $��Stretch=�6�   
�������6�   �� 5P      -   5        $
 
_videoTime��5P      $��0q�6�   $
 Wrap=�6�   $��1��6�   $��2��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6  $��Center=�61  $��10.667(�6S  ��6.   �� *#!Settings.VideoSettings.PerDivisor+$ TwoWay=�$	 PropertyChanged=�6S  �� 5Q      -   5        $ _videoTimeMeasurement��5Q      $��0q�6�   $��1��6�   $��3��6�   ���	#FF1083F0$��Calibri)�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6!  $��10.667(�6C   6:   �� *VideoTimeDivisor+$ TwoWay=�$	 PropertyChanged=�.@�5R      �� $��Seconds��6#   �� 5S      $��Minutes��6#   �� 5T      $��Hours��6#   5U      5V      5W      � 5X   
   -   5        $! _gameMinimumConsumptionGrid��5X      $��0q�64   $��3��6?   ���	#FF2C323A 5Y      �� 5Z      $��2* �6    �� 5[      $��6* �6    .+�5]      �� -   5         ��Name$  _minimumConsumptionEnabled��5]      $&�� Game Minimum Consumption Enabled��6;   $��0q�6�   $��10,0,0,0q�6  $��RightToLeft=�6  
����������	#FF66B2E7$
��Bold"�6]  $��Center=�6o  $��9.333(�6�  $��Center=�6�  $��Microsoft YaHei Light)�6�   d� 	IsChecked 6f   �� *1/Settings.GameSettings.MinimumConsumptionEnabled+$ TwoWay=�$	 PropertyChanged=�6�  � 5^      $��0q�6   $��1��6   ���	#FF121417{�6B   �� *1/Settings.GameSettings.MinimumConsumptionEnabled+$	 PropertyChanged=� 5_      �� 5`      $��4* �6'   �� 5a      $��3* �6'   �� 5b      $��2* �6'    5d      �� 5e      �� 5f      .+�5h      �� -   5        $ _gameMinimumConsumtionLBL��5h      $��Minimum Consumption��6;   $��0q�6Y   
�������$��Center=�6�   $	��5,0q�6�   $��10.667(�6�   $��Right=�6�   $��Microsoft YaHei Light)�6�   �� 5i      -   5        $ _gameMinimumTimeLBL��5i      $��Minimum Time��65   $��0q�6L   
�������$��Center=�6j   $��1��6�   $	��5,0q�6�   $��10.667(�6�   $��Right=�6�   $��Microsoft YaHei Light)�6�   �� 5j      -   5        $
 _gameMinimumConsumption��5j      $��1��6�   $��0q�6�   $
 Wrap=�6�   $��Center=�6�   $��Center=�6�   ���	#FF1083F0$��Calibri)�63  $
��Bold"�6H  $��10.667(�6Z  ��6;   �� **(Settings.GameSettings.MinimumConsumption+$ TwoWay=�$	 PropertyChanged=�6Z  �� 5k      -   5        $
 _gameMinimumTime��5k      $��1��6�   $��0q�6�   $
 Wrap=�6�   $��Center=�6�   $��Center=�6�   $��1��6  ���	#FF1083F0$��Calibri)�62  $
��Bold"�6G  $��10.667(�6Y  ��64   �� *#!Settings.GameSettings.MinimumTime+$ TwoWay=�$	 PropertyChanged=�6Y  �� 5l      $��2��6�   $��0q�6�   
�������$��Center=�6�   $��Center=�6�   $��Calibri)�6  $	��2,0q�6-  $��10.667(�6;  $
��Bold"�6M  ��6   ��  �� ElementName$ 	_currency�� �� Path$ SelectedItem.Content�$	 PropertyChanged=�6M  �� 5m      $��2��6�   $��0q�6�   $��1��6�   
�������$��Center=�6�   $��Center=�6  $��Calibri)�60  $	��2,0q�6E  $��10.667(�6S  $
��Bold"�6e  ��6   �� $ _gameTimeMeasurement��$ SelectedItem.Content�$	 PropertyChanged=�6e  5n      5o      � 5p   
   -   5        $" _videoMinimumConsumptionGrid��5p      $��0q�65   $��4��6@   ���	#FF2C323A 5q      �� 5r      $��2* �6    �� 5s      $��6* �6    .+�5u      �� -   5        $% _videoMinimumConsumptionEnabled��5u      $'��!Video Minimum Consumption Enabled��6@   $��0q�6�   $��10,0,0,0q�6  $��RightToLeft=�6  
����������	#FF66B2E7$
��Bold"�6d  $��Center=�6v  $��9.333(�6�  $��Center=�6�  $��Microsoft YaHei Light)�6�   6l   �� *20Settings.VideoSettings.MinimumConsumptionEnabled+$ TwoWay=�$	 PropertyChanged=�6�  � 5v      $��0q�6   $��1��6   ���	#FF121417{�6B   �� *20Settings.VideoSettings.MinimumConsumptionEnabled+$	 PropertyChanged=� 5w      �� 5x      $��4* �6'   �� 5y      $��3* �6'   �� 5z      $��2* �6'    5|      �� 5}      �� 5~      .+�5�      �� -    5        $  _videoMinimumConsumtionLBL��5�      $��Minimum Consumption��6<   $��0q�6Z   
�������$��Center=�6�   $	��5,0q�6�   $��10.667(�6�   $��Right=�6�   $��Microsoft YaHei Light)�6�   �� 5�      -!   5        $ _videoMinimumTimeLBL��5�      $��Minimum Time��66   $��0q�6M   
�������$��Center=�6k   $��1��6�   $	��5,0q�6�   $��10.667(�6�   $��Right=�6�   $��Microsoft YaHei Light)�6�   �� 5�      -"   5        $
 _videoMinimumConsumption��5�      $��1��6�   $��0q�6�   $
 Wrap=�6�   $��Center=�6�   $��Center=�6�   ���	#FF1083F0$��Calibri)�65  $
��Bold"�6J  $��10.667(�6\  ��6<   �� *+)Settings.VideoSettings.MinimumConsumption+$ TwoWay=�$	 PropertyChanged=�6\  �� 5�      -#   5        $
 _videoMinimumTime��5�      $��1��6�   $��0q�6�   $
 Wrap=�6�   $��Center=�6�   $��Center=�6�   $��1��6  ���	#FF1083F0$��Calibri)�64  $
��Bold"�6I  $��10.667(�6[  ��65   �� *$"Settings.VideoSettings.MinimumTime+$ TwoWay=�$	 PropertyChanged=�6[  �� 5�      $��2��6�   $��0q�6�   
�������$��Center=�6�   $��Center=�6�   $��Calibri)�6  $	��2,0q�6-  $��10.667(�6;  $
��Bold"�6M  ��6   �� $ 	_currency��$ SelectedItem.Content�$	 PropertyChanged=�6M  �� 5�      $��2��6�   $��0q�6�   $��1��6�   
�������$��Center=�6�   $��Center=�6  $��Calibri)�61  $	��2,0q�6F  $��10.667(�6T  $
��Bold"�6f  ��6   �� $ _videoTimeMeasurement��$ SelectedItem.Content�$	 PropertyChanged=�6f  5�      5�      � 5�   
   -$   5        $ _buttonsGrid��5�      $��0q�6%   $��5��60    5�      �� 5�      �� 5�      �� 5�       5�      �� 5�      $��3* �6#   .+�5�      �� -%   5        $% _gameLapsConsumptionEnabledCHBX��5�      $"��Enable Game Laps Consumption��6@   $��0q�6�   $��20,0,0,0q�6  $��Center=�6  $��RightToLeft=�66  $��Center=�6R  $��Center=�6v  
�������$
��Bold"�6�  $��13.333(�6�  $��Microsoft YaHei Light)�6�   6g   �� *.,Settings.GameSettings.LapsConsumptionEnabled+$ TwoWay=�$	 PropertyChanged=�6�  �� 5�      -&   5        $&  _videoLapsConsumptionEnabledCHBX��5�      $#��Enable Video Laps Consumption��6A   $��0q�6�   $��20,0,0,0q�6�   $��Center=�6�   $��RightToLeft=�6  $��Center=�6:  $��Center=�6^  
�������$
��Bold"�6�  $��13.333(�6�  $��Microsoft YaHei Light)�6�  $��1��6�   6i   �� */-Settings.VideoSettings.LapsConsumptionEnabled+$ TwoWay=�$	 PropertyChanged=�6�  �� 5�      -'   5        $ _errorDisplayLBL��5�      $�� ��6.   ���	#FFF40808$��14.667(�6P   $��Center=�6b   $��Center=�6�   $��0q�6�   $��2��6�   ��5�      �� 5�       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5�      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5�      $ Black��6'   $ 1Q�65   5�      5�      5�      5�      5�      