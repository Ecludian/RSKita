   M S B A M L   `   `   `  ����\  XRSKita(ALPHA PROTOTYPE) ver.0.0.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RSKita.ViewRSKita.View  5          RSKita.View.HospitalPage2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RSKita.View     5        N� Title$  HospitalPage2��5	      .��5      � $��1��6   $��1��6   ���	#FF129A7F.+�5   
   �� .��5      � $
��1205��6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��5 �6$   .+�5      �� ���	#FF000000 �� CornerRadius$ 	30,30,0,0��61   $��3��6J   $��
0,60,0.4,0q�6^   ���#F1F1FA$��3��5   &   5      �� 5      -   5         ��Name$ textBox��5      $��Daftar Rumah Sakit��6)   $��3��6F   $
��Left=�6Z   $��28��6u   $��
10,101,0,0q�6�   $	��Top=�6�   $	��328��6�   ���	#FFF1F1F1$��16(�6�   ���	#FF1A1A1A��6�   Z� 6�   �� 5      ���#FFFFFF$��0��62   $��0��6?   $��10,134,10.4,246q�6O   $��3��6h   .+�5      �� -   5         ��Name$ HospitalImage1��5      $*��$/RSKita;component/Image/Hospital.jpg��64   $��Center=�6b   $	��140��6}    J� RenderTransformOrigin$ 0.502,0.187&�6�   $
��Fill=�6�   $��10,0,10.4,0q�6�   �� 5      -   5        $ lblHospitalName1��5      $
��Left=�66   $��Hospital Name��6Q   $��15(�6i   $
��Bold"�6w   �� 5       -   5        $ lblHospitalAddres1��5       $
��Left=�68   $��Hospital Addrss��6S   $��12(�6m   �� 5!      -   5         ��Name$ btngo1��5!      $��Pilih Dokter��6-   $��24��6D   $��
0,0,-0.4,0q�6P   6d   5"      �� 5%      ���#FFFFFF$��0��62   $��10,359,10.4,21q�6?   $��3��6W   .+�5&      �� -   5        $ HospitalImage2��5&      $*��$/RSKita;component/Image/Hospital.jpg��64   $	��140��6b   $��Center=�6o   $ 0.502,0.187&�6�   $
��Fill=�6�   $��10,0,10.6,0q�6�   �� 5'      -   5        $ lblHospitalName2��5'      $
��Left=�66   $��Hospital Name��6Q   $��15(�6i   $
��Bold"�6w   �� 5(      -   5        $ lblHospitalAddres2��5(      $
��Left=�68   $��Hospital Addrss��6S   $��12(�6m   �� 5)      -	   5        $ btngo2��5)      $��Pilih Dokter��6-   $��24��6D   $��
0,0,-0.4,0q�6P   6d   5*      �� 5.      ���#FFFFFF$��0��62   $��10,584,12.4,351q�6?   $��3��6X   $��2��6l   .+�5/      �� -
   5        $ HospitalImage3��5/      $*��$/RSKita;component/Image/Hospital.jpg��64   $	��185��6b   $��Center=�6o   $ 0.502,0.187&�6�   $
��Fill=�6�   $
��10,0q�6�   �� 50      -   5        $ lblHospitalName3��50      $
��Left=�66   $��Hospital Name��6Q   $��15(�6i   $
��Bold"�6w   �� 51      -   5        $ lblHospitalAddres3��51      $
��Left=�68   $��Hospital Addrss��6S   $��12(�6m   �� 52      -   5        $ btngo3��52      $��Pilih Dokter��6-   $��24��6D   $��
0,0,-0.4,0q�6P   6d   53      �� 57      ���#FFFFFF$��1��62   $��10,254,12.4,5q�6?   $��3��6V   .+�58      �� -   5        $ HospitalImage4��58      $*��$/RSKita;component/Image/Hospital.jpg��64   $	��140��6b   $��Center=�6o   $ 0.502,0.187&�6�   $
��Fill=�6�   $��10,0,10.4,0q�6�   �� 59      -   5        $ lblHospitalName4��59      $
��Left=�66   $��Hospital Name��6Q   $��15(�6i   $
��Bold"�6w   �� 5:      -   5        $ lblHospitalAddres4��5:      $
��Left=�68   $��Hospital Addrss��6S   $��12(�6m   �� 5;      -   5        $ btngo4��5;      $��Pilih Dokter��6-   $��24��6D   $��
0,0,-0.4,0q�6P   6d   5<      5=      5>       � 5?   
   -   5          �Name$ frame��5?      $��Frame��6   $��Center=�6/   $	��667��6L   $	��Top=�6Y   $	��367��6q   	  � NavigationUIVisibility$	 Hidden=�6}   $��	0,0,0.2,0q�6�   5@      5C      