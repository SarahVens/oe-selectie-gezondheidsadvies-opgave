   M S B A M L   `   `   `  ����O  KPersoonlijkeInfo.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PersoonlijkeInfo.WpfPersoonlijkeInfo.Wpf  5   	   %    PersoonlijkeInfo.Wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PersoonlijkeInfo.Wpf     5   	   -   5          � Title$  
MainWindow��5   	   $	��351��6   $��558.192��6)   .��5	      � .+�5
   
   �� $��Persoonlijke info��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   $	��163��6r   $
��Bold"�6~   $��14(�6�   �� 5   
   -   5         ��Name$ txtFamilienaam��5      $
��Left=�6*   $��23��6E   $��
102,39,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��229��6�   6�   �� 5   
   $��Familienaam:��6   $
��Left=�6'   $��	11,35,0,0q�6B   $	��Top=�6U   $��87��6m   �� 5   
   $��	Voornaam:��6   $
��Left=�6$   $��	11,70,0,0q�6?   $	��Top=�6R   $��87��6j    J� RenderTransformOrigin$ 0.519,0.257&�6u   �� 5   
   -   5        $ txtVoornaam��5      $
��Left=�6'   $��23��6B   $��
102,74,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��229��6�   6�   �� 5   
   $��Lengte:��6   $
��Left=�6"   $��
11,102,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ 	cmbLengte��5      $
��Left=�6&   $��102,106,0,0q�6A   $	��Top=�6V   $��55��6n   �� 5   
   $��cm��6   $
��Left=�6   $��158,102,0,0q�68   $	��Top=�6M   �� 5   
   $��Gewicht:��6   $
��Left=�6#   $��195,102,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $ 
cmbGewicht��5      $
��Left=�6'   $��248,106,0,0q�6B   $	��Top=�6W   $��55��6o   �� 5   
   $��kg��6   $
��Left=�6   $��306,102,0,0q�68   $	��Top=�6M   �� 5   
   $��Rijksregister��6   $
��Left=�6(   $��
11,138,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $ txtRijksregister��5      $
��Left=�6,   $��23��6G   $��102,141,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��229��6�    � ToolTip$/ )Vul dit in zonder spaties of koppeltekens��6�    �� 	MaxLength$ 11��6�    �� MaxLines$ 1��6�   6�   �� 5   
   -   5         ��Name$ lblSamenvatting��5      $��Samenvatting��6)   $
��Left=�6@   $��
11,212,0,0q�6[   $	��Top=�6o   $��98��6�   $	��320��6�   $��10(�6�   ���	#FFAAF7056�   �� 5   
   -   5        	 ��Name$	 btnVatSamen��5      $��	Vat samen��6&   $
��Left=�6:   $��
11,187,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -	   5        
 ��Name$
 brdFeedBack��5      
���   �$��3q�6:   $
��Left=�6N   $	��300��6i   $��
346,10,0,0q�6v   $	��Top=�6�   $	��191��6�   ._�5      �� -
   5         ��Name$ tbkFeedBack��5      $
��Wrap=�6-    �� Padding$ 5q�6A   5      5      5      