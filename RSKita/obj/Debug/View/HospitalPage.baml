   M S B A M L   `   `   `  ����\  XRSKita(ALPHA PROTOTYPE) ver.0.0.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RSKita.ViewRSKita.View  5          RSKita.View.HospitalPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RSKita.View     5        N� Title$  HospitalPage��5	      $	��667��6   $	��375��6)   .��5
      � $��	0,0,0,-21q�6   ���	#FF129A7F � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��184* �6   �� 5      $
��183* �6   �� 5      $��0* �6   .+�5   
   �� $��3��6   ���	#FFF1F1F1$
��Left=�69   $	��570��6T   ���#F1F1FA$	��Top=�6r   $	��375��6�   $��0,90,0,0q�6�   �� 5   
   -   5         ��Name$ scroller��5      $��1��6)   ���#F1F1FA$��2��6N   $��10,90,10.2,80.2q�6b   $
��Auto=�6{   .��5      �� .+�5      �� $��Hospital List��6   $��10q�61   $��22(�6=   $��Medium"�6K   �� 5      $
��10 0q�6   .+�5      �� -   5         ��Name$ ListHospital��5   #   ��69   �� *hospitalist+��5      �� 5      Hospitalist��.R�5   "   �� $��25q�6)   $	��300��65   $	��175��6A   ._�5   &   � -   5         � ForceCursor .  � Cursor$
 Hand��5   >   .+�5   *   �� ���#FFFFFF.+�5   .   �� $	��300��65   $	��100��6A    �� CornerRadius$ 0��6N   $��0q�6_    J� Effect 5   2   3  -System.Windows.Media.Effects.DropShadowEffect  5   6      ShadowDepth$ 1Q�6G   ��5!   2   �� 5"   6   	 �� ImageSource$*	 $/RSKita;component/Image/Hospital.jpg��6A   
 j� 
AlignmentX$
 Center=�6t    j� 
AlignmentY$ Center=�6�    j� Stretch$
 Fill=�6�   5$   /   �� 5%   .    ��Name$ 	lblHsName��64   $��5q�6G   $��17(�6l   $��Franklin Gothic Medium)�6z   ���#FFFFFF��6R   �� *Name+6�   �� 5&   .   $ lblHsAddress��64   $��5q�6J   $��15(�6q   ���#FFFFFF��6U   �� *	Address+6   5'   +   5(   '   5)   #   5*      ��5,      �� 5-      .R�5.   "   � 5/      51      52      53      54       � 55   
   -   5          �Name$ frame��55      $��Frame��6   $��Center=�6/   $	��608��6L   $	��Top=�6Y   $	��375��6q   $��2��6}     � NavigationUIVisibility$ Hidden=�6�   $��1��6�   $��	0,0,0.2,0q�6�   56      58      