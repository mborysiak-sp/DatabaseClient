   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  5   	    DatabaseClient   DatabaseClient.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz  5   	     � Title$  DatabaseClient��5   	   $	��800��6    $
��1200��6-      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 	Resources 5        FadeUIMessage �� 
TargetName �� TargetProperty W� From	 W� To g� Duration��%�   &	       �� 5   
   .��5      W� $ 	UIMessage��6   $ (TextBlock.Opacity)�6@   $ 1X�6p   $ 0X�6y   $ 0:0:6D�6�   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   
 � ColumnDefinitions
 5   
   .+�5   
   ��   
LoginPopUp#��[ 6   5         Dragablz.TabablzControl  5   
   -   5          Name$ 
CommandTab��5   =   $
��Left=�6"      InterTabController 5      !   Dragablz.InterTabController  5      .@�5       �� $��Nawiguj��6   .��5!      �� ��.  ��6   �� *Views+��5"      �� 5#      .R�5$      ��  �� Orientation$ 
Horizontal=�6)   5%      ��5'      �� 5(      .R�5)      �� $��48��6B   $	��100��6N   ��6%   �� *
Navigate+.��5*   "   ��  �� TextAlignment$ Center=�6I   ��6,   �� *ViewDisplay+6I   5+      5,      5.      5/      �� 50      -   5         ��Name$ EditTabItem��50   &   $��Edytuj��6   .��51      �� ��6   �� *
Commands+��52      �� 53      .R�54      �� $ 
Horizontal=�6)   55      ��57      �� 58      .R�59      �� $��1q�6>   $��0q�6R   $��4q�6]   $��48��6i   $��48��6t   ��6%   �� *Send+.��5:   "   F�  �� Stretch$ Uniform=�6E     PathOpacityStyle#��[ 5;   -   
���������5:   '   �� *IconGeometry+5<   -    � ToolTip 5=   "   �� 5>   &   ��60   �� *CommandDisplay+5@      5A      5C      5D      5E      �� 5F   
   -   5         ��Name$ 	UIMessage��5F      $�� ��6'   $��Right=�6/   $	��Top=�6K   $��0,0,8,0q�6c   �� 5G   
   -   5         ��Name$ Holder��5G      $��1��6)   5H      5I      