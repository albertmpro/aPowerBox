   M S B A M L   `   `   `  ����D  @AlbertWin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullL4clr-namespace:Albert.Flex.Windows;assembly=AlbertWinAlbert.Flex.Windows  5      E AaPowerDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:aPowerDesk
aPowerDesk 5   	      aPowerDesk.View.MainShell   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Bc4clr-namespace:Albert.Flex.Windows;assembly=AlbertWin     5      *localclr-namespace:aPowerDesk     5   	     � Icon$  /Assets/aPowerDesk.png��5       � Title$ 
aPowerDesk��5	   	   $	��600��6   $	��960��6)   .��5
      � -   5         �Name$ 
layoutRoot��5
         AccentBrush4#��[  6    � RowDefinitions 5      �� 5      $
��auto �6   �� 5      �� 5      $��30 �6   .+�5      o� .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� Command$	 New��6   6-   m� 5      $
��Open��6   $
 Open��6   6/   m� 5      $
��Save��6   $
 Save��6   6/   m� 5      $��Save As��6   $ c:DesktopCommands.SaveAs��6    6F   �� 5      m� 5      $
��Quit��6   $ c:DesktopCommands.Quit��6   6A   5      m� 5      $
��Edit��6   .@�5      m� $	��Cut��6   $	 Cut��6   6-   m� 5      $
��Copy��6   $
 Copy��6   6/   m� 5      $��Paste��6   $ Paste��6   61   m� 5      $��
Select All��6   $ 	SelectAll��6#   6:   5      m� 5      $��Tools��6   5!      m� 5"      $
��Help��6   5$      5%       � 5'      -   5          �Name$ frame��5'      $��1��6
   6   �� 5*      -   5         ��Name$ 	statusBar��5*      $��2��6   .@�5+      �� $��Medium"�6   $��Status: ��6#   5,      5.      5/      