   M S B A M L   `   `   `  ����   DatabaseClient    DatabaseClient.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -   $��myMainWindow��  � Title$  
MainWindow��$	��450��$	��800��
���iii� � 	Resources    FadeUIMessage �� 
TargetName �� TargetProperty W� From	 W� To g� Duration��%]   &	        �� .��W� $ 	UIMessage��$ (TextBlock.Opacity)�$ 1X�$ 0X�$ 0:0:6D�.���  � RowDefinitions �� $
��Auto ��� $��* � � ColumnDefinitions .+��� $
��Left=�.@��� $��Navigate��$��10(�.���� 
������ $��12(�$
��Bold"���.  ���� *Views+���� .R��� 	 �� Orientation$	 
Horizontal=����� .R��� $��0q�$��32��$	��100��  LightBrightGradientBrush#��[   DarkDullBrush#��[ ���� *
Navigate+.���� 
 �� TextAlignment$
 Center=����� *ViewDisplay+�� $
��Edit��$��10(�.���� 
������ $��12(�$
��Bold"���.  ���� *
Commands+���� .R��� $	 
Horizontal=����� .R��� $��0q�$��0q�$��0q����� *Send+.��F�  �� Stretch$ Uniform=�  MidDullBrush#��[ $��32��$��32������ *IconGeometry+ � ToolTip �� ���� *CommandDisplay+�� -    ��Name$ 	UIMessage��$�� ��$��Right=�$	��Top=�$��0,0,8,0q�  DarkBrightBrush#��[  � -     �Name$ 	EditFrame��$��1��$��1��$��2��  � NavigationUIVisibility$ Hidden=�