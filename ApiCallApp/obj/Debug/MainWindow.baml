   M S B A M L   `   `   `  ����E  AApiCallApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ApiCallApp
ApiCallApp  5   	       ApiCallApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ApiCallApp     5   	   -   5        $��22(�5        � Title$  XKCD Comic Viewer��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   $��0,0,0,10q�6a   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ previousImageButton��5      $��15q�62   $��15q�6?   $��DemiBold"�6m   .��6�   
Previous6�   �� 5      -   5        $ sunInformationButton��5      $��15q�63   $��15q�6@   $��DemiBold"�6o   .��6�   Sun Information6�   �� 5      -   5        $ nextImageButton��5      $��15q�6.   $��15q�6;   {�.  $��DemiBold"�6w   .��6�   Next6�   5      �� 5   
   -   5         ��Name$ 
comicImage��5      $��1��6   $��10,10,10,40q�61   �� 5   
   -   5         ��Name$ 	comicInfo��5      $��1��6#   $��
10,10,10,2q�60   $��Bottom=�6D   $
��Left=�6_   $��22(�6z   $��Italic$�6�   $��Light"�6�   5      5      