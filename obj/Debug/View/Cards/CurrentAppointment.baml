   M S B A M L   `   `   `  ����	  EMIAS)    #EMIAS.View.Cards.CurrentAppointment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      �    MainColorBrush#���   6   $��0, 10, 0, 0q�69     � RowDefinitions  5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5
   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $��0��6   $��Inter)�6A     SecondaryTextBrush#���  6T   $��
5, 5, 0, 0q�6�   ��6$   �� *
FullName+6�   �� 5      $��1��6   $��Inter)�6H   #���  6[   $��Right=�6�   $��
0, 5, 5, 0q�6�   ��6$   �� *AppointmentTime+6�   5      � 5   
   $��1��6    5      �� 5      �� 5      .+�5      �� $��0��6   $��10q�6%   ���#007BFE$��Начать прием��6F   ���#FFFFFF+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 0��6r   
������ ��6�   �� *%#DataContext.StartAppointmentCommand+ �� RelativeSource ��  �� AncestorType$ ItemsControlL���6,  �� �� 5      $��1��6   $��10q�6%   ���#FE0000$#��Отменить запись��6F   ���#FFFFFF$ 0��6u   
������ ��6�   �� *&$DataContext.CancelAppointmentCommand+ �� $ ItemsControlL���60  �� 5      5      5      