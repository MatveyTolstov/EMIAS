   M S B A M L   `   `   `  ����@  <EMIAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:EMIAS.View
EMIAS.View  5   	   "    EMIAS.View.MainPatientWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:EMIAS.View     5   	   9b+http://schemas.microsoft.com/xaml/behaviors     60     � Title$6  0Главное окно пользователя��5	      $	��850��6;   $
��1500��6H   .��5
      � ���#007BFE � ColumnDefinitions 5   
   �� 5      $
��20px �6   �� 5      $��300px �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��0.07* �6   �� 5      $��* �6   �� 5      $��0.05* �6   .+�5   
   �� 
�������$��20(�6'   $
��Bold"�65   $��1��6G   $��
ЕМИАС��6W   6f   �� 5   
   
�������$��20(�6'   $
��Bold"�65   $��Right=�6G   $��1��6c   	в. 1.06{   �� 5   
   
�������$��20(�6'   $
��Bold"�65   $��Center=�6G   $��1��6b   $+��%_____________________________________��6r   $��285.1��6�   6�   R� 5   
   $	��220��6   $��1��6"   $��1��6/   .@�5      Q� $��Главная��6    Q� 
IsExpanded . ���	#E5FFFFFF$��14(�6V   .@�5      Q� $,��&Записи и направления��6   ���	#E5FFFFFF$��14(�6T   Q� 5      $��Рецепты��6   ���	#E5FFFFFF$��14(�6H   Q� 5      $$��Диспансеризация��6   ���	#E5FFFFFF$��14(�6P   5       Q� 5!      $��Медкарта��6    . ���	#E5FFFFFF$��14(�6W   .@�5"      Q� $��Приемы��6   ���	#E5FFFFFF$��14(�6G   Q� 5#      $��Анализы��6   ���	#E5FFFFFF$��14(�6H   Q� 5$      $��Исследования��6   ���	#E5FFFFFF$��14(�6M   5%      5&      �� 5(   
   
�������$��14(�6'   $��Center=�65   $��1��6P   $��2��6`   $��Полис ОМС:��6m   6�   �� 5)   
   $��3��6   $��1��6     �� DisplayMemberPath$ Surname��5+      $��Right=�5-      $��26��6/   $	��200��6;   $��Center=�6G   
���������5*      �� *
Patients+ �� SelectedItem 5,      �� *SelectedPatient+5-   b    � 5/   
   -   5          �Name$ 	PageFrame��5/        � NavigationUIVisibility$ Hidden=�6#   $��2��6C   $��3��6S   50      51      