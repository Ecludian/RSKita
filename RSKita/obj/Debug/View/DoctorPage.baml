   M S B A M L   `   `   `  ����\  XRSKita(ALPHA PROTOTYPE) ver.0.0.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RSKita.ViewRSKita.View  5          RSKita.View.DoctorPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RSKita.View     5        N� Title$  
DoctorPage��5	      .��5
      � ���	#FF129A7F � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��184* �6   �� 5      $
��183* �6   �� 5      $��0* �6   .+�5   
   �� ���	#FF000000 �� CornerRadius$ 	30,30,0,0��6)   $��3��6B   $��0,157,0.2,0.2q�6V   ���#F1F1FA5      �� 5   
   $��3��6   
�������$
��Left=�65   $	��117��6P   ���	#FFF1F1F1$	��Top=�6p   $	��296��6�   $��	40,75,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0.169Q�6$   �� 5      T� 5       T� X$ 0.247Q�6)   5      5      �� 5   
   -   5         ��Name$ imageDr��5      $��2��6!   $
��Left=�65   $��50��6P   $��
54,100,0,0q�6\   $	��Top=�6p   $��50��6�   $ 0.5,0.5&�6�   $
��Fill=�6�   z�5      V� 5       .~�5!      �� �� 5"      $ -0.735Q�6$   �� 5#      T� 5$      $ -0.321Q�6)   5%      5'      �� 5(   
   -   5         ��Name$ 	lblDrName��5(      $��Dokter Le Mineral Sp. Kg��6#   $��1��6F   $
��Left=�6V   $��
106,98,0,0q�6q   $	��Top=�6�   ���	#FF1A1A1A$��2��6�   $	��157��6�   �� 5)   
   -   5        $ lblDrSpecialist��5)      $��Spesialis Gigi��6)   $��1��6B   $
��Left=�6R   $��106,115,0,0q�6m   $	��Top=�6�   ���	#FF1A1A1A$��2��6�   $	��157��6�   $��10(�6�   �� 5*   
   -   5        $ lblEstimatedTime��5*      $ ��Estimasi Waktu(Menit) : 30��6*   $��2��6O   $
��Left=�6_   $��
10,162,0,0q�6z   $	��Top=�6�   ���	#FF75757A$	��137��6�   $��10(�6�   $
��Bold"�6�   $ 0.573,1.414&�6�   �� 5+   
   -   5         ��Name$ 
btnKembali��5+      $��	< Kembali��6%   $��1��6<   $��Center=�6L   $��10,16,106,0q�6i   $	��Top=�6~   
�������$��72��6�   $��10(�6�   $��0q�6�   $��20��6�   ��6�   Z� 6�   �� 5,   
   $��3��6   
�������$
��Left=�65   $	��186��6P   ���	#FFF1F1F1$	��Top=�6p   $	��293��6�   $��
44,309,0,0q�6�   $ 0.5,0.5&�6�   z�5-      V� 5.      .~�5/      �� �� 50      $ 0.169Q�6$   �� 51      T� 52      $ 0.247Q�6)   53      55      �� 56   
   -   5        $ lblCurrentnQueue��56      $��Antrian saat ini : 15��6*   $��1��6J   $
��Left=�6Z   $��
52,160,0,0q�6u   $	��Top=�6�   ���	#FF75757A$
��Bold"�6�   �� 57   
   $��3��6   
�������$
��Left=�65   $��70��6P   ���	#FFF1F1F1$	��Top=�6o   $	��296��6�   $��
41,219,0,0q�6�   $ 0.5,0.5&�6�   z�58      V� 59      .~�5:      �� �� 5;      $ 0.169Q�6$   �� 5<      T� 5=      $ 0.247Q�6)   5>      5@      �� 5A   
   -   5        $ lbl_SelectDate��5A      $��Hari dan Tanggal��6(   $��1��6C   $
��Left=�6S   $��
52,223,0,0q�6n   $	��Top=�6�   ���	#FF1A1A1A$��2��6�   $	��144��6�   }�. 6�   �� 5B   
   $��3��6   $
��Left=�6(   $��23��6C   $��
52,238,0,0q�6O   $	��Top=�6c   $	��273��6{   (  "System.Windows.Controls.DatePicker  5C   
   -   5        	  Name$	 
Datepicker��5C      $
��Left=�6)   $��28��6D   $��
54,252,0,0q�6P   $	��Top=�6d   $	��272��6|   $��1��6�   $��2��6�   ��6�   Z� ��6�   Z� 6�   �� 5D   
   -	   5        $ lbl_ConsultDate��5D      $��	Pilih Jam��6)   $��1��6=   $
��Left=�6M   $��
54,313,0,0q�6h   $	��Top=�6|   ���	#FF1A1A1A$	��144��6�   $��2��6�   �� 5E   
   $��3��6   $
��Left=�6(   $��23��6C   $��
53,329,0,0q�6O   $	��Top=�6c   $	��273��6{   �� 5K   
   -
   5        $ 
btnPayment��5K      $��3��6%   $��Lanjut Proses Pembayaran��69   $
��Left=�6\   $��34��6w   $��
44,519,0,0q�6�   $	��Top=�6�   $	��295��6�   
����������	#FF129A7F���	#FF129A7F6�   � 5L   
   -   5        
 �Name$
 gridAmPm��5L      $��3��6!   $��44,339,36.2,271.2q�65   � 5N   
   -   5        $
 gridTime��5N      $��3��6!   $��44,401,36.2,153.2q�65   .+�5P      	� -   5         	�Name$	 rb8��5P      $��10,-46,177,121q�6'   ��5Q      �� 5R      -   5        $
 lbl8��5R      $��08:00��6*   $��Center=�6:   $��Center=�6X   $��24��6s   $	��108��6   
���   �$��Center=�6�    J� IsHitTestVisible .  $��
0,5,-1.6,7q�6�   5T      	� 5W      -   5        $
 rb15��5W      $��10,10,177,65q�6(   ��5X      �� 5Y      -   5        $	 lb6��5Y      $��15:00��6)   $��Center=�69   $��Center=�6W   $��24��6r   $	��108��6~   
���   �$��Center=�6�    .  $��
0,5,-1.6,7q�6�   5[      	� 5^      -   5        $ rb930��5^      $��177,-46,10,121q�6)   ��5_      �� 5`      -   5        $	 lb7��5`      $��09:30��6)   $��Center=�69   $��Center=�6W   $��24��6r   $	��108��6~   
���   �$��Center=�6�    .  $��
0,5,-1.6,7q�6�   5b      	� 5d      -   5        $
 rb13��5d      $��177,10,10,65q�6(   ��5e      �� 5f      -   5        $	 lb9��5f      $��13:00��6)   $��Center=�69   $��Center=�6W   $��24��6r   $	��108��6~   
���   �$��Center=�6�    .  $��
0,5,-1.6,7q�6�   5h      5j       � 5l   
   -   5          �Name$ frame��5l      $��Frame��6   $��Center=�6/   $	��608��6L   $	��Top=�6Y   $	��375��6q   $��2��6}     � NavigationUIVisibility$ Hidden=�6�   $��1��6�   $��	0,0,0.2,0q�6�   5m      5n      