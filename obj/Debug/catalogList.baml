   M S B A M L   `   `   `  ����B  >Gestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GestionGestion  5          Gestion.catalogList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Gestion     5      -   5          N� Title$  catalogList��5	       N� 
Background �	#FF1167AE.��5
      � -   5        $��Center=�5
      $��Center=�6(   $	��316��6C   $
��Auto��6P   ���	#FF1167AE$��30,84,30,50q�6�    J� InputBindings 5   
   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ listing_product��5   /      AutoGenerateColumns .  $	��750��6H   ���	#FF1138BB$��Center=�6k   $��Center=�6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *nom+6J     5      $ Référence��6%   $ * 6V   	 68   �� *	reference+6V     5      $ Descritpion��6%   $ * 6Z   	 6:   �� *description+6Z     5      $
 Prix��6%   $ * 6L   	 63   �� *prix+6L     5      $ 	Quantité��6%   $ * 6T   	 67   �� *
quantite+6T     5      $ Image��6%   
   FontSize$
 10Q�6N      
Visibility$ Hidden=�6\   $ * 6p   	 64   �� *image+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Image��6)   $ SizeToCells 68      
IsReadOnly .    CellTemplate 5      �� 5      .R�5      �� $	��130��6$   $��95��63   ��6B   �� *image+5      5        5       $ 	Categorie��6%   	 68   �� *categorie.categorie1+5"      �� 5&   
   
�������$
��Bold"�6#   $��153,-45,0,286q�65   $
��Left=�6L   $	��577��6g   .��6s   Filtrer par :6�   �� 5'   
   -   5         ��Name$ categoryDropDown��5'       �� 
IsReadOnly .  �� 
IsEditable .  �� Text$ -- Catégorie --��6Q    �� DisplayMemberPath$ 
categorie1��6h    �� SelectedValuePath$ id��6�   $	��120��6�   $	��Top=�6�   $��40,-43,181,0q�6�   �� 5)   
   -   5        $��Filtrer��5)      $	��Top=�6#   $��50��6;   
�������$
��Bold"�6Y   $��160,-43,131,0q�6~   ��5*      �� 5+       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5,      �  � Color$ 	#FFB0C5DE��6#    � Offset$ 0Q�65   � 5-      $ 	#FF1B559B��6#   $ 1Q�65   5.      50      �� 52   
   -   5        $��Tout Afficher��52      $	��Top=�6)   $��90��6A   
�������$
��Bold"�6_   $��215,-43,36,0q�6�   ��53      �� 54      $ 0.5,1&�6&   $ 0.5,0&�67   .��55      � $ 	#FFB0C5DE��6#   $ 0Q�65   � 56      $ 	#FF1B559B��6#   $ 1Q�65   57      59      5:      5;      