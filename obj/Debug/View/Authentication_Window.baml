   M S B A M L   `   `   `  ����@  <EMIAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EMIASEMIAS  5   	   !    EMIAS.Authentication_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:EMIAS  5   	     � Title$  Authentication_Window��5	   	   $	��220��6'   $	��400��64    � WindowStartupLocation$ CenterScreen=�6@   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      GlassFrameThickness$ 0q�6      CornerRadius$ 0��6/      CaptionHeight$ 0Q�6@   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � ���#007BFE$��0��6$   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $	��Top=�6N   $��1��6f   .+�5      �� -   5         ��Name$ СollapseButton��5      $��30��61   $��30��6<   
������ 
������ 
���   �	 �� IsCancel	 . $��0q�6�   .��5      >� b ^SharpVectors.Converters.Wpf, Version=1.8.4.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  6"   $��12��6V   $��0 0 15 0q�6b   .��5      (  "SharpVectors.Converters.SvgViewbox  
   Source$
 /Icons/wrap.svg?�6*   5      5      �� 5      -   5        $ ExpandButton��5      $��30��6/   $��30��6:   
������ 
������ 
���   �	 . $��0q�6�   .��5      >� 1svgc&http://sharpvectors.codeplex.com/svgc/  6"   $��12��6V   $��0 0 15 0q�6b    � Cursor$  ��6t   .��5        $
 /Icons/full.svg?�6*   5      5      �� 5      -   5        $ ClosedButton��5      $��30��60   $��30��6;   
������ 
������ $��10(�6{   $��0q�6�   
���   �.��5      >� 1svgc&http://sharpvectors.codeplex.com/svgc/  6"   $��12��6V   $��0 0 15 0q�6b   .��5         $
 /Icons/close.svg?�6*   5!      5"      5#      � 5$      $��0��6    5%      �� 5&      �� 5'      �� 5(      $��2* �6$   .+�5*      �� $��
ЕМИАС��6   
�������$��20(�6<   $��Center=�6J   $��Center=�6e   $��1��6�   $��Medium"�6�   �� 5+      $n��hЕдиная медицинская информационно-аналитическая система��6   $
��Wrap=�6Z   $
��16px(�6n    �� TextAlignment$ Center=�6~   $��	10,0,10,8q�6�   
�������$��Center=�6�   $��Center=�6�   $��2��6�   5,      5-      � 5.   
   $��1��6    5/      �� 50      $��1* �6    �� 51       � ColumnDefinitions 53      �� 54      �� 55      .+�57      �� -   5         ��Name$ NumberPolicyButton��57      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Номер полиса��64   $��0��6b   $��2��6o   $��Center=�6�   $��1q�6�   $��	10,0,10,0q�6�   �� 58      -   5        $ 
SignButton��58      $��1��6*   $��0��67      
BlueBottom#��[  6G   $��
Войти��6k   $��	15,0,15,0q�6{   ���#007BFE$��26��6�   6�   �� 59      -   5        $ DoctorButton��59      $��1��6,   #��[  69   $��1��6]   $��Я врач��6n   $��	15,0,15,0q�6   $��26��6�   6�   5:      5;      5<      