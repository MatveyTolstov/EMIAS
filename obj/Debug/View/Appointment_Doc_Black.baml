   M S B A M L   `   `   `  ����@  <EMIAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EMIAS.ViewModelEMIAS.ViewModel  5   	   &     EMIAS.View.Appointment_Doc_Black   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   )localclr-namespace:EMIAS.ViewModel  5   	     � Title$  Appointment_Doc_White��5	   	   $	��700��6'   $
��1000��64    � DataContext 5
      2   ,EMIAS.ViewModel.AppointmentDocBlackViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� ���#2196F3$��0��6*   .+�5      � $��10q�6    5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� $��
ЕМИАС��6   
�������$��18(�6<   $��0��6J    J� RenderTransformOrigin$ 0.606,0.531&�6Z   �� 5      $��v. 1.0��6   
�������$��1��6=   $��Bottom=�6M   5      �� 5      
�������$��0,0,0,1q�6)   $��10q�6C   �� 5!      -   5        $��Главная��5!      
����������#2196F3��6O   Z� 6f   �� 5%      -   5        $��Медкарта��5%      
����������#2196F3��6P   Z� 6g   �� 5)      -   5        $��MainMenuStackPanel��5)      $y�	Collapsed=�63   .+�5*      �� .��5+      �� $,��&Записи и направления��6    
�������6<   5,      �� 5-      .��5.      �� $��Рецепты��6    
�������6/   5/      �� 50      .��51      �� $$��Диспансеризация��6    
�������67   52      53      �� 56      -   5        $��MedCardStackPanel��56      $y�	Collapsed=�62   .+�57      �� .��58      �� $��Приёмы��6    
�������6.   59      �� 5:      .��5;      �� $��Анализы��6    
�������6/   5<      �� 5=      .��5>      �� $��Исследования��6    
�������64   5?      5@      5A      ]� 5F   
   $��0��6   $��Bottom=�6$   .+�5G      �� $��10q�6   .+�5H      �� 
�������$��0,1,0,0q�6-   $��	10,0,10,0q�6G   � 5I      $��10q�6    5J      �� 5K      $��* �6+   �� 5L      $
��Auto �6+   .+�5N      �� -   5        $#��Полис ОМС: Ирина��5N      $��10(�68   
����������#2196F3$��Center=�6�   $��Center=�6�   $	��124��6�   ��6n   Z� 6�   �� 5O      -   5        $��1��5O      $��	18,5,-8,5q�6-   ���#2196F3��6U   Z� .��5P      �� $��../img/gear.png��6    $��20��69   $��20��6D   5Q      5R      �� 5S      -   5        $��OnGearStackPanel��5S      $y�	Collapsed=�65   ���#2196F3$��10q�6a   .+�5T      �� -   5        $��Темная тема��5T       
����������#2196F3$��5q�6[    � Cursor$
 Hand��6f   6t   5U      �� 5V      -	   5        $��IrinaMenuStackPanel��5V      $y�	Collapsed=�68   ���#2196F3$��10q�6d   .+�5W      �� -
   5        $��
Выход��5W       
����������#2196F3$��5q�6U   $
 Hand��6`   6n   5X      5Y      5Z      �� 5`   
   $��1��6   $��10q�6%    �� Orientation$ Vertical=�61   ��6H   �� *backgroundColor+.+�5a      �� $*��$Записаться на приём��6   $��24(�63   $��0,0,0,20q�6A   �� 5b      $��ОРВИ / COVID 19��6   $��18(�6/   $��0,0,0,10q�6=   �� 5c      $��Visible=�6   $��Disabled=�6C      MaterialDesignScrollViewer#��[  6�   ��6j   �� *ScrollViewerColor+.��5d      �� $ 
Horizontal=�6   .+�5e      ��   MaterialDesignRaisedButton#��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5f      �� $ Vertical=�6%   $��Center=�6<   .+�5g      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5h      $-��'Дежурный врач по ОРВИ��6(   $��Center=�6E   $
��Wrap=�6b   $��65��6�   ��6v   �� *
TextSize+6�   5i      5j      �� 5k      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5l      �� $ Vertical=�6%   $��Center=�6<   .+�5m      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5n      $��Center=�6(   $(��"Вакцинация от COVID-19��6C   $��Center=�6a   $
��Wrap=�6~   ��6�   �� *
TextSize+5o      5p      5q      5r      �� 5t      $ ��Специальности��6   $��18(�6-   $��0,0,0,10q�6;   �� 5u      $��Visible=�6   $��Disabled=�6C   #��[  6�   ��6j   �� *ScrollViewerColor+.��5v      �� $ 
Horizontal=�6   .+�5w      �� #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5x      �� $ Vertical=�6%   $��Center=�6<   .+�5y      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5z      $��Офтальмолог��6(   $
��Wrap=�6;   $��67��6m   ��6O   �� *
TextSize+6m   5{      5|      �� 5}      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5~      �� $ Vertical=�6%   $��Center=�6<   .+�5      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Офтальмолог��6(   $
��Wrap=�6;   $��66��6m   ��6O   �� *
TextSize+6m   5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Офтальмолог��6C   $��Center=�6V   $
��Wrap=�6s   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Офтальмолог��6C   $��Center=�6V   $
��Wrap=�6s   ��6�   �� *
TextSize+5�      5�      5�      5�      �� 5�      $��Направления��6   $��18(�6+   $��0,0,0,10q�69   �� 5�      $��Visible=�6   $��Disabled=�6C   #��[  6�   ��6k   �� *ScrollViewerColor+.��5�      �� $ 
Horizontal=�6   .+�5�      �� #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Офтальмолог��6(   $
��Wrap=�6;   $��15��6m   ��6O   �� *
TextSize+6m   5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Офтальмолог��6C   $��Center=�6V   $
��Wrap=�6s   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Офтальмолог��6C   $��Center=�6V   $
��Wrap=�6s   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Офтальмолог��6C   $��Center=�6V   $
��Wrap=�6s   ��6�   �� *
TextSize+5�      5�      5�      5�      �� 5�      $!��Цели обращения��6   $��18(�6.   $��0,0,0,10q�6<   �� 5�      $��Visible=�6   $��Disabled=�6C   #��[  6�   ��6j   �� *ScrollViewerColor+ � 	Resources 5�       �� 
TargetType �� Property	 �� Value��%e   '��       �� 5�      " ��6   .�5�      ��  � ��	 67   �� *ScrollBarColor+5�      5�      .��5�      �� $ 
Horizontal=�6   .+�5�      �� #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $,��&Вакцинация от гриппа��6C   $��Center=�6_   $
��Wrap=�6|   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $)��#Острое заболевание��6C   $��Center=�6]   $
��Wrap=�6z   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $(��"Дежурный врач ОРВИ��6C   $��Center=�6]   $
��Wrap=�6z   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $&�� Осмотр по хронике��6C   $��Center=�6\   $
��Wrap=�6y   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $)��#Оформить документы��6C   $��Center=�6]   $
��Wrap=�6z   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $-��'Женская консультация��6C   $��Center=�6_   $
��Wrap=�6|   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $��Профилактика��6C   $��Center=�6W   $
��Wrap=�6t   ��6�   �� *
TextSize+5�      5�      �� 5�      #��[ 6   $��5q�6Q   ��6\   �� *ButtonHeight+��6|   �� *ButtonWidth+��6�   �� *ButtonColor+.��5�      �� $ Vertical=�6%   $��Center=�6<   .+�5�      �� $��../img/1.png��6$   $��0,0,0,5q�6Y   ��6:   �� *ImageHeight+6Y   �� 5�      $��Center=�6(   $,��&Запись к стоматологу��6C   $��Center=�6_   $
��Wrap=�6|   ��6�   �� *
TextSize+5�      5�      5�      5�      5�      5�      5�      