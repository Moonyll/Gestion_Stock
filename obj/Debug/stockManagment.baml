   M S B A M L   `   `   `  ����B  >Gestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GestionGestion  5          Gestion.stockManagment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Gestion     5      -   5          N� Title$  stockManagment��5	      .��5
      �� -   5        $��Center=�5
      $��Center=�6.    �� Orientation$ 
Horizontal=�6I   $��10q�6b   .+�5   
   � $��Center=�6   $��Center=�6,   $	��273��6G   $
��auto��6T   ���	#FF1167AE J� InputBindings 5      d� 5       d� Gesture$ LeftDoubleClicka�6    �� Command 69   �� *Car_Details+.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ stock_product��5   3      AutoGenerateColumns .  $��10q�6i   ���	#FF1138BB$��Center=�6�   $��Center=�6�   $
��auto��6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Nom��6)   
   FontSize$
 10Q�6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *nom+6N     5      $	 Référence��6)   $
 10Q�6Z    6<   �� *	reference+6Z     5      $	 Descritpion��6)   $
 10Q�6^    6>   �� *description+6^     5      $
	 Prix��6)   $
 10Q�6P    67   �� *prix+6P     5      $	 	Quantité��6)   $
 10Q�6X    6;   �� *
quantite+6X     5      $	 Image��6)   $
 10Q�6R      
Visibility$ Hidden=�6`    68   �� *image+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Image��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 6<      
IsReadOnly .    CellTemplate 5      �� 5      .R�5   "   �� $	��130��6(   $��95��67   ��6F   �� *image+5      5         5"      $	 	Categorie��6)   $
 10Q�6e    6<   �� *categorie.categorie1+6e   5$      5%      � 5'   
   $��Center=�6   $��Center=�6,   $	��325��6G   $	��351��6T   $��10q�6`   ���	#FF1167AE � ColumnDefinitions 5)      �� 5*      $
��Auto �6#   �� 5+      $
��Auto �6#   �� 5,      $
��Auto �6#   �� 5-      $
��Auto �6#   �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#   �� 50      $
��Auto �6#    � RowDefinitions 53      �� 54      $
��auto �6    �� 55      $
��auto �6    �� 56      $
��auto �6    �� 57      $
��auto �6    �� 58      $
��auto �6    �� 59      $
��auto �6    �� 5:      $
��auto �6    .+�5<      �� $��0��6   $��0��6$   $��2,25,0,2q�61   $
��Bold"�6C   $��Center=�6U   $��Center=�6r   
�������.��6�   Nom6�   �� 5=      -   5        $
��name��5=      $��1��6"   $��0��62   $��2,25,2,2q�6?    �� TextAlignment$ Center=�6Q   ���	#FF73BECF
�������$
��Bold"�6�   �� 5>      $��0��6   $��1��6$   $��2q�61   $
��Bold"�6<   $��Center=�6N   $��Center=�6k   
�������.��6�   Référence6�   �� 5?      -   5        $��	reference��5?      $��1��6'   $��1��67   $��2q�6D   $ Center=�6O   ���	#FF73BECF
�������$
��Bold"�6�   �� 5@      $��0��6   $��2��6$   $��2q�61   $
��Bold"�6<   $��Center=�6N   $��Center=�6k   
�������.��6�   Description6�   �� 5A      -   5        $��description��5A      $��1��6*   $��2��6:   $��2q�6G   $ Center=�6R   ���	#FF73BECF
�������$
��Bold"�6�   �� 5B      $��0��6   $��3��6$   $��2q�61   $
��Bold"�6<   $��Center=�6N   $��Center=�6k   
�������.��6�   Prix6�   �� 5C      -   5        $��price��5C      $��1��6#   $��3��63   $��2q�6@   $ Center=�6K   ���	#FF73BECF
�������6y   �� 5D      $��0��6   $��4��6$   $��2q�61   $
��Bold"�6<   $��Center=�6N   $��Center=�6k   
�������.��6�   	Quantité6�   �� 5E      -   5        $��quantity��5E      $��1��6&   $��4��66   $��2q�6C   $ Center=�6N   ���	#FF73BECF
�������$
��Bold"�6�   �� 5F      $��0��6   $��6��6$   $��14,49,11,-24q�61   $
��Bold"�6G   $��25��6Y   $��Center=�6e   $��Center=�6�   
�������.��6�   
Catégorie6�   �� 5H      $��0��6   $��5��6$   $��2q�61   $
��Bold"�6<   $��Center=�6N   $��Center=�6k   
�������.��6�   Image6�   �� 5I      -	   5        $��image��5I      $��1��6#   $��5��63   $��2q�6@   ���	#FF73BECF6K   �� 5J      -
   5         ��Name$ BrowseButton��5J      $��	Parcourir��6+   $
��Left=�6?   $	��Top=�5K      $��81��6*    J� RenderTransformOrigin$ 1.047,0.821&�5L      $��24��65   $��1��6A   $��2,3,0,0q�6Q   $��6��6b   �� 5N      -   5         ��Name$ categorie_choice��5N      $��6��61    �� DisplayMemberPath$ 
categorie1��6>    �� SelectedValuePath$ id��6]   ���	#FF73BECF$��25��6�   $��
0,48,0,-25q�6�   $��Center=�6�   $��5��6�   $��1��6�   �� 5O      -   5        $��0��5O      $��6��6%   $��	Supprimer��62   $��12,87,13,-55q�6F   $ 0.601,1.029&�6k   ���	#FFEA2929$
��Bold"�6�   $��10(�6�   $��Center=�6�   $��Center=�6�   $��66��6�   
�������6	  �� 5P      -   5        $��1��5P      $��6��6%   $��Modifier��62   $��
8,87,9,-55q�6E   $ 0.307,0.493&�6g   $��Center=�6�   $��88��6�   $
��Bold"�6�   $��10(�6�   $��Center=�6�   ���	#FF7EE46E
�������6  5R      5X      5Y      