   M S B A M L   `   `   `  ����  CADemoPost.App     RamboTweets.App.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$
  Post��5   	   $	��350��6   $	��525��6#    � WindowState$ 	Maximized=�6/    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius F�Name	 �� Stretch
 ��Name �� Triggers P� Property P� Value �� 
TargetName   HeaderBrush �� 
StartPoint �� EndPoint � Color � Offset  HeaderBorderBrush  HeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '��       &	  �    &	 B    &	     7   7  �� 5	   
   " ��6   .�5
      ��  � �� �#3737376+   �� 5       � ��
 �����6+   �� 5       � ��$ 15(�6)   �� 5       �@J�SnapsToDevicePixels . 64   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 4��6!   #��z��62   ._�5      � .+�5   "   F� $ PathIcon��6'   $��15��69   $��25��6D   $
	 Fill=�6P   ���#4C87B3$
��Left=�6n   $��17,0,0,0q�6�   4�������<R���=�x�O���Tn5����<R6�   �� 5   "   $
 MyContentPresenter��63   #��z��6O   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   5      5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� �#E594006?   �� 5   "    � ��
 �����6?   �� 5   "   $ PathIcon��6)    � ��
 �   �6O   5      P� 5        � �� . . �5!   "   ��  � ��
 � E��6?   �� 5"   "    � ��
 �����6?   5#      5%      5'      5(      �� 5)   
   $ 0.5,0&�62   $ 0.5,1&�6E   .��5*      � $ 	#FF6B8E95��6   $ 0Q�6-   � 5+      $ 	#FF14A7C1��6   $ 1Q�6-   � 5,      $ 	#FF1E424E��6   $ 0.509Q�6-   � 5-      $ 	#FF1D4855��6   $ 0.542Q�6-   � 5.      $ 	#FF1D4855��6   $ 0.542Q�6-   � 5/      $ 	#FF193A44��6   $ 0.526Q�6-   50      �� 52   
   $ 0.5,0&�68   $ 0.5,1&�6K   .��53      � $ 	#FF1D1D1D��6   $ 0.614Q�6-   � 54      $ 	#FF007F96��6   $ 0.853Q�6-   � 55      $ 	#FF0AEAFA��6   $ 1Q�6-   56      �� 58   
   "  6$   .�59      ��  � ��8   6+   �� 5:       � ��
 �����6+   �� 5;       � ��8  6,   �� 5<       � ��$ 1q�60   �� 5=       �@J�SnapsToDevicePixels . 64   �� 5>       � ��$ Center=�6;   �� 5?       � ��$ 0��6)   �� 5@       � ��$ 30��6*   �� 5A       �@�Cursor$
 Hand��6'   5B      5C      .��5D      �  � ColumnDefinitions 5E   
   �� 5F      $��5 �6   �� 5G      $
��509* �6   �� 5H      $��5 �6    � RowDefinitions 5J   
   �� 5K      $��5 �6   �� 5L      $��27 �6   �� 5M      $��5 �6   �� 5N      $
��310* �6   �� 5O      $��5 �6   .+�5Q   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgPosts��5Q   D      ColumnHeaderStyle# [ 6      CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .     AutoGenerateColumns .  $��1��5S   V   $��3��6f   ��6/   �� *PostViewModels+   Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 6%       Header$  Id��61   !   
IsReadOnly! . 1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 6=   �� *Id+#   ClipboardContentBinding# 6T   Z� 6w     5V      $	 10* 6%   $  UserId��61   ! . " 6A   �� *UserId+# 6\   Z� 6     5W      $	 50* 6%   $  Title��61   ! . " 6@   �� *Title+# 6Z   Z� 6}     5X      $
 100* 6%   $
  Body��62   ! . " 6@   �� *Body+# 6Y   Z� 6|   4  .System.Windows.Controls.DataGridTemplateColumn  5Y      $	 22* 6)   $  Details��65   $   CellTemplate$ 5Z      �� 5[      .R�5\      �� $��
btnGetPost��61   $	��140��6%   $��2q�6C   ��6N   �� % �� RelativeSource% �� & �� Mode$& FindAncestor=�' �� AncestorType"' �( �� Path$!( DataContext.ViewPostCommand���5]   c   �� $	( Tag�) �� ElementName$) 
btnGetPost��
* � Tag* 6�   �� .��6�   	Details6�   5^      5`      5c      �� 5d   
   $��Refresh Data��64   $��1��6K   $��Right=�6[   $��1��6w   $��Center=�6�   $	��160��6�   ��6   �� *RefreshCommand+6�   5f      5g      