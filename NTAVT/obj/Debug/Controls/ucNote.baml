   M S B A M L   `   `   `  ����L  HOP.Notes.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:OP.Notes.Controls;assembly=OP.Notes.ControlsOP.Notes.Controls  5       OP.Notes   OP.Notes.Controls.ucNote   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Imy:clr-namespace:OP.Notes.Controls;assembly=OP.Notes.Controls     5      .��5	      ]� .+�5
   
   ]� $	��Top=�6   $��0,4,0,4q�6)   .+�5      �� $��/Images/16/note.png��6   $
��Left=�61   $
��None=�6G   $��Center=�6V   $��0,0,4,0q�6q     � ToolTip$  
Note title��6�   �� 5      -   5        $ ��/Images/16/cross-small.png��5      $��Right=�68   $
��None=�6P   $��Center=�6_    � Cursor$
 Hand��6z   $  Delete note��6�   6�   �� 5      -   5        $��imgTodoUnhecked��5   A   $)��#/Images/16/ui-check-box-uncheck.png��6   $��Right=�6X   $
��None=�6p   $��Center=�6   $
 Hand��6�   $!  There are uncompleted items��6�   �� 5      -   5        $��imgTodoChecked��5   9   $!��/Images/16/ui-check-box.png��6   $��Right=�6O   $
��None=�6g   $��Center=�6v   $
 Hand��6�   $  All items are completed��6�   �� 5      -   5        $��txtTitle��5         NoteTitleInputStyle#��[  6&   $��[Title]��6S   6b   5      �� 5   
   $	��Top=�6   
���   �$	��0.6��63   $��1��6I   	 �� X1$ 0��6T   	 �� Y1$ 0��6�   	 �� Y2$ 0��6�    �� StrokeDashArray$	 1 5R�6�   	 �� X2 6[   ��  �� Self �� RelativeSource# Z 	 �� Path$	 ActualWidth�6�   ]� 5   
   $	��Top=�6   $��0,4,0,4q�6)   .+�5      �� $��/Images/16/tag_blue.png��6   $
��None=�65   $��Center=�6D   $��0,0,4,0q�6_   $  List of tags��6p   �� 5      -   5        $��txtTags��5      #��[  6%   6R   5      �� 5   
   $	��Top=�6   
���   �$	��0.6��63   $��1��6I   $ 0��6T   $ 0��6�   $ 0��6�   $	 1 5R�6�    6[   �� # Z $	 ActualWidth�6�   �� 5   
   $��Bottom=�6   
���   �$��1��66   $��1��6J   $ 0��6U   $ 0��6�   $ 0��6�   $	 2 2R�6�    6\   �� # Z $	 ActualWidth�6�   #   OP.Notes.Controls.NotesEditor  5   
   -   5        $��
txtContent��5        NoteCheckbox
   CheckboxStyle#
 [ 6+   
������ $��5q�6r   ` \ICSharpCode.AvalonEdit, Version=4.3.1.9429, Culture=neutral, PublicKeyToken=9cc39be672370310'  !ICSharpCode.AvalonEdit.TextEditor"   VerticalScrollBarVisibility$
 Auto=�6~      WordWrap . $   HorizontalScrollBarVisibility$
 Auto=�6�   $	��150��6�   6�   5      5      