   M S B A M L   `   `   `  ����C  ?OP.Notes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OP.Notes.ControlsOP.Notes.Controls  5   	   /clr-namespace:OP.Notes.ModelOP.Notes.Model  5   	       OP.Notes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .myclr-namespace:OP.Notes.Controls     5   	   .modelclr-namespace:OP.Notes.Model     5   	   -   5          �Name$  mySelf��5   	    � Title$ 
OP.Notes v��5   	   $	��600��6   $	��800��6)      DefaultWindowStyle#��[  6\    � Icon$ /Images/OP.Notes.ico��6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ CanResizeWithGrip=�6�    � AllowsTransparency . $	��1,2q�6,  ���	#FFACACAC.��5      ]� ��. .+�5	   
   ]� $	��Top=�6   .+�5
      �� -   5        $��borderCaption��5
   5   $	��Top=�6   $��8��6*   
������ 6J   �� 5      -   5        $��btnClose��5      $��Right=�6$   $��/Images/w_close.png��6T   $
��None=�6q    � Cursor$
 Hand��6�   $��5q�6�    � ToolTip$ Close��6�   $��Stretch=�6�   �� 5      -   5        $��btnMaximize��5      $��Right=�6'   $��/Images/w_maximize.png��6Z   $
��None=�6z   $
 Hand��6�   $��5q�6�   $ Maximize��6�   $��Stretch=�6�   �� 5      -   5        $��
btnRestore��5      $��Right=�6&   $��/Images/w_restore.png��6X   $
��None=�6w   $
 Hand��6�   $��5q�6�   $ Restore��6�   $��Stretch=�6�   �� 5      -   5        $��btnMinimize��5      $��Right=�6'   $��/Images/w_minimize.png��6Z   $
��None=�6z   $
 Hand��6�   $��5q�6�   $ Minimize��6�   $��Stretch=�6�   �� 5      -   5        $��btnNewNotebook��5      $��Right=�6*   $��/Images/16/book_add.png��6`   $
��None=�6�   $
 Hand��6�   $��32��6�   $��5q�6�   $ New notebook��6�   $��Stretch=�6�   �� 5      -   5        $��lbNotebooks��5   ,   $
��Left=�6   $��Stretch=�6?     NbTabContainerStyle#��[ 6\   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   5      5      5      �� 5   
   $��Bottom=�6   $	��Top=�6,   .@�5      d� -	   5        $��toggleAutosave��5        ToggleButtonStyle#��[ 61   	 d� 	IsChecked$
	 TrueY�6\   .��5      �� $ 
Horizontal=�6   .+�5      �� -
   5        $��imgStatusSave��5      $��/Images/16/disk.png��61   $
��None=�6N   $y�Hidden=�6]   �� 5      $��0q�6   ��6(   �� 
 �� RelativeSource
 ��  �� AncestorType" �� �� Mode$ FindAncestor=� �� Path$ 
Foreground�.��6�   
Autosave6�   5      5      d� 5      -   5        $��
toggleWrap��5      #��[ 6-   $
	 TrueY�6X   .��6�   Wrap5!      d� 5"      -   5        $��toggleOnTop��5"      #��[ 6.   $	 falseY�6Y   .��6�   On top5$      d� 5%      -   5        $��
toggleTags��5%      #��[ 6-   $
	 trueY�6X   .��6�   Tags5'      d� 5(      -   5        $��toggleTagsOnTop��5(      #��[ 62   $
	 TrueY�6]   .��6�   Tags on top5*      5+      � 5,   
   -   5        $��pnlNotebooks��5,      $	��Top=�6#   
�������5.      5/      50      