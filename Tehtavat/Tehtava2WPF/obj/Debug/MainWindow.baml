   M S B A M L   `   `   `  ����F  BTehtava2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tehtava2WPFTehtava2WPF  5   	       Tehtava2WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tehtava2WPF     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   $��Stretch=�5	   	   $��Stretch=�6.   .��5
      ]� ��. .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,5,0,5q�6.   $	��Top=�6?   $��Stretch=�6T   $��35��6r   .+�5      �� -   5         ��Name$ btnCountCountries��5      $��
Laske maat��60   $
��Left=�6E   $��	10,0,10,0q�6`   $	��Top=�6s   $	��100��6�   6�   �� 5      -   5        $ btnCountPopulations��5      $��Laske asukkaat��62   $
��Left=�6K   $��	10,0,10,0q�6f   $	��Top=�6y   $	��100��6�   6�   �� 5      -   5        $ 	btnTopPop��5      $��Top-10 asukasluvut��6(   $
��Left=�6E   $��	10,0,10,0q�6`   $	��Top=�6s   $	��100��6�   6�   �� 5      -   5        $ 
btnTopArea��5      $��Top-10 pinta-alat��6)   $
��Left=�6E   $��	10,0,10,0q�6`   $	��Top=�6s   $	��100��6�   6�   �� 5      -   5         ��Name$ lblFilterName��5      $��10,0,5,0q�6+   $��Suodata nimellä:��6=   �� 5      -   5         ��Name$ txtFilterName��5      $�� ��6-   $��0,0,10,0q�65   $��35��6G   $	��100��6S   �� 5      -   5        $ btnFilterName��5      $��Suodata��6,   $
��Left=�6>   $��	10,0,10,0q�6Y   $	��Top=�6l   $	��100��6�   6�   �� 5      -   5        $ lblSelectContinent��5      $��10,0,5,0q�60   $��Valitse maanosa:��6B   �� 5      -	   5         ��Name$ cbSelectContinent��5      ��62   �� �� 5      -
   5        $ btnSelectContinent��5      $��Valitse��61   $
��Left=�6C   $��	10,0,10,0q�6^   $	��Top=�6q   $	��100��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCountries��5      $��Stretch=�6@   $��0,0,0,0q�6^   $��Stretch=�6o   $��Bottom=�6�   $
��Auto=�6�   $
��Auto=�6�   ��6(   �� 6�   5      5      