   M S B A M L   `   `   `  ����I  EwpfExample01_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:wpfExample01_1.ViewswpfExample01_1.Views  5      &     wpfExample01_1.Views.DetailsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:wpfExample01_1.Views     5      .��5	      � y�6   �� *SelectedContact+   SelectedContactConverter  �� 	Converter#  [   � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6#   .+�5      �� $��0��6   $
��Left=�6)   $��5q�6D   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Center=�6!   .+�5      �� $��Center=�5      $��24(�5      ��5       �� *SelectedContact.FirstName+ �� FallbackValue$
 NULL��5      5      �� 5        favoriteCheckbox#��[ 6    d� 	IsChecked 6I   �� *SelectedContact.IsFavorite+��6z   �� *UpdateCommand+5      � 5      $	��125��6   $	��125��6$   .+�5       �� $	��125��6   $	��125��6)   ��5!      �� *SelectedContact.ImagePath+  DefaultContactImage# [  �� TargetNullValue# [ �� 5%        MenuIconButton#��[ 6     GloomyPurple#��[ 6E   $��Bottom=�5&      $��Right=�64   
���   �$��DemiBold"�5'   ,   .��6B   Browse5)      5*      5+      �� 5,      $��1��6   $��Bottom=�6)   $ 
Horizontal=�6D   .+�5-      �� #��[ 6     MaximumBlueGreen#��[ 6A   $��90��5/      $��40��6$   $��5q�60   ��5.      �� *SaveCommand+��50      �� 51      $ 
Horizontal=�6%   .+�52      �� $��/Resources/saveIcon.png��6$   �� 53      $
��Bold"�6$   .��66   Save6<   54      56      57      58      �� 5;   
   $��1��6   $��5q�6"   .+�5<      �� .+�5=      ��   DetailBorder#��[ 6   ._�5>      �� $
��Bold"�6   ���	#fff5f7f9$��Phone��6E   5?      �� 5A      .+�5C      ��   DetailLabel#��[ 6   $
��Home��6A   �� 5D        ContentLabel#��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� 5G      #��[ 6   $
��Cell��6A   �� 5H      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[1]+$
 NULL��5I      5J      5K      �� 5N   
   $��2��6   $��5q�6"   .+�5O      �� .+�5P      �� #��[ 6   ._�5Q      �� $
��Bold"�6   ���	#fff5f7f9$��Phone��6E   5R      �� 5T      .+�5V      �� #��[ 6   $
��Home��6A   �� 5W      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� 5Z      #��[ 6   $
��Cell��6A   �� 5[      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[1]+$
 NULL��5\      5]      5^      �� 5a   
   $��3��6   $��5q�6"   .+�5b      �� .+�5c      �� #��[ 6   ._�5d      �� $
��Bold"�6   ���	#fff5f7f9$��	Locations��6E   5e      �� 5g      .+�5i      �� #��[ 6   $
��Home��6A   �� 5j      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� 5m      #��[ 6   $
��Cell��6A   �� 5n      #��[ 6   ��6B   �� *!SelectedContact.PhoneNumbers[1]+$
 NULL��5o      5p      5q      5r      5s      