   M S B A M L   `   `   `  ����E  AExercise05, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Exercise05
Exercise05  5   	       Exercise05.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Exercise05     5   	   -   5          � Title$  Exercise 05��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $��Choose min depth:��6   $
��Left=�6,   $��	21,19,0,0q�6G   $	��Top=�6Z   $��18(�6r   �� 5   
   $��Choose max depth:��6   $
��Left=�6,   $��
21,114,0,0q�6G   $	��Top=�6[   $��18(�6s   �� 5   
   -   5         ��Name$ minDepthSlider��5      $
��Left=�6)   $��
207,27,0,0q�6D   $	��Top=�6X   $	��500��6p   6|   �� 5   
   -   5        $ maxDepthSlider��5      $
��Left=�6)   $��207,123,0,0q�6D   $	��Top=�6Y   $	��500��6q   6}   �� 5   
   -   5         ��Name$ shallowMinLabel��5      $�� ��6)   $
��Left=�64   $��
201,57,0,0q�6O   $	��Top=�6c   $��14(�6{   $��50��6�   �� 5   
   -   5        $ shallowMaxLabel��5      $�� ��6)   $
��Left=�64   $��
676,57,0,0q�6O   $	��Top=�6c   $��14(�6{   $��50��6�   �� 5   
   -   5        $ deepMinLabel��5      $�� ��6&   $
��Left=�61   $��201,156,0,0q�6L   $	��Top=�6a   $��14(�6y   $��50��6�   �� 5   
   -   5        $ deepMaxLabel��5      $�� ��6&   $
��Left=�61   $��676,156,0,0q�6L   $	��Top=�6a   $��14(�6y   $��50��6�   �� 5   
   -   5        $ chosenMinDepth��5      $�� ��6(   $
��Left=�63   $��	21,57,0,0q�6N   $	��Top=�6a   $��14(�6y   $��50��6�   �� 5   
   -	   5        $ chosenMaxDepth��5      $�� ��6(   $
��Left=�63   $��
21,156,0,0q�6N   $	��Top=�6b   $��14(�6z   $��50��6�   �� 5   
   -
   5         ��Name$ paperCanvas��5      $
��Left=�6&   $	��250��6A   $��
21,156,0,0q�6N   $	��Top=�6b   $	��250��6z   ���	#FFEAEAEA6�   5      5      