   M S B A M L   `   `   `  ���� I  EwpfExample01_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:wpfExample01_1.ViewswpfExample01_1.Views  &     wpfExample01_1.Views.DetailsView   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:wpfExample01_1.Views     .��� y��� *SelectedContact+   SelectedContactConverter  �� 	Converter#  [   � RowDefinitions �� �� �� �� �� .+�� $��0�� � ColumnDefinitions �� �� $	��100 �.+��� $��0��$
��Left=�$��5q�.+���  �� Orientation$ 
Horizontal=�.+��� $��Center=�.+��� $��Center=�$��24(����� *SelectedContact.FirstName+ �� FallbackValue$
 NULL����   favoriteCheckbox#��[  d� 	IsChecked �� *SelectedContact.IsFavorite+���� *UpdateCommand+� $	��125��$	��125��.+��� $	��125��$	��125������ *SelectedContact.ImagePath+  DefaultContactImage# [  �� TargetNullValue# [ ��   MenuIconButton#��[   GloomyPurple#��[ $��Bottom=�$��Right=�
���   �$��DemiBold"�.��Browse�� $��1��$��Bottom=�$ 
Horizontal=�.+��� #��[   MaximumBlueGreen#��[ $��90��$��40��$��5q����� *SaveCommand+���� $ 
Horizontal=�.+��� $��/Resources/saveIcon.png���� $
��Bold"�.��Save�� $��1��$��5q�.+��� .+���   DetailBorder#��[ ._��� $
��Bold"����	#fff5f7f9$��Phone���� .+���   DetailLabel#��[ $
��Home����   ContentLabel#��[ ���� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� #��[ $
��Cell���� #��[ ���� *!SelectedContact.PhoneNumbers[1]+$
 NULL���� $��2��$��5q�.+��� .+��� #��[ ._��� $
��Bold"����	#fff5f7f9$��Phone���� .+��� #��[ $
��Home���� #��[ ���� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� #��[ $
��Cell���� #��[ ���� *!SelectedContact.PhoneNumbers[1]+$
 NULL���� $��3��$��5q�.+��� .+��� #��[ ._��� $
��Bold"����	#fff5f7f9$��	Locations���� .+��� #��[ $
��Home���� #��[ ���� *!SelectedContact.PhoneNumbers[0]+$
 NULL���� #��[ $
��Cell���� #��[ ���� *!SelectedContact.PhoneNumbers[1]+$
 NULL��