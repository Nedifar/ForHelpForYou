   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Test.Forms
Test.Forms  5   	       Test.Forms.ListForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Test.Forms     5   	     � Title$  ListForm��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��364* �6   �� 5      $	��55* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsers��5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
idPeople+  5      $
 Name��6%    63   �� *Name+  5      $	 Age��6%    62   �� *Age+  5      $ Birthday��6%    67   �� *
Birthday+ �� StringFormat$ {0:dd.MM.yyyy}��4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� $��1q�6%   ._�5   "   �� ��6,   �� *Gender.Name+��5   "   �� 5   &   
 �� 
TargetType"
 ��6,    �� Triggers 5   *   �� 5   .    �� Binding 6:   �� *Gender.Name+ �� Value
 Муж6Z   .a�5   2   ��  �� Property � �� �� Value
 ��  �6P   5   /   �� 5   .    6:   �� *Gender.Name+
 Жен6Z   .a�5    2   ��  � ��
 �  ��6P   5!   /   5#   '   5%      5&      5(      5*      �� 5+   
   -   5        $��Добавить��5+      $��1��62   $
��Left=�6?   $��Center=�6Z   �� 5,   
   -   5        $ ��Редактировать��5,      $��1��68   $��Right=�6E   $��Center=�6a   �� 5-   
   -   5        $��Удалить��5-      $��1��64   $��Center=�6A   $��Center=�6^   5.      5/      