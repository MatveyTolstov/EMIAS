   M S B A M L   `   `   `  ����@  <EMIAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EMIAS.CardsEMIAS.Cards  5      )clr-namespace:EMIAS.CardsEMIAS.Cards  66   +    %EMIAS.Cards.CurrentAppointmentControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:EMIAS.Cards     5      +modelclr-namespace:EMIAS.Cards     66   .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	TitleText��5      $��2��6D   ��6'   �� *Doctor.Name+6D   �� 5   
   -   5        $ 
DoctorText��5      $��1��6H   $	��Top=�6U   ��6(   �� *Doctor.Surname+6U   �� 5   
   -   5        $ AddressText��5      $��1��6M   $��1��6Z   ��6)   �� *Doctor.WorkAddress+6Z   �� 5   
   -   5        $ DateText��5      $��1��6f   $��Bottom=�6s   ��6&   �� *AppointmentDate+ �� StringFormat$ {0:dd.MM.yyyy}��6s   �� 5   
   $��Перенести��6   ���#007BFE
�������$��2��6M   $��12(�6Z   $��139.5��6h   $��25��6v   $��Center=�6�   $��Center=�6�   ���#007BFE6�   �� 5   
   $��Отменить��6   
���  ��
�������$��2��6H   $��1��6U   $��12(�6e   $��139.5��6s   $��25��6�   
���  ��6�   5      5      