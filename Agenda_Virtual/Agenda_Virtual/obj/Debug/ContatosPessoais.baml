   M S B A M L   `   `   `  ����I  EAgenda_Virtual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Agenda_VirtualAgenda_Virtual  5   	   %    Agenda_Virtual.ContatosPessoais   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Agenda_Virtual     5   	     � Title$  ContatosPessoais��5   	   $��528.696��6"   $��881.491��63   .��5	      � $��0,-26,-8,-4q�6   $
��Left=�6    $	��881��6;    � RowDefinitions 5
   
   �� 5       � ColumnDefinitions 5   
   �� 5      ��5   
   
� 5      .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF3AFF00��6   5      .+�5   
   �� $
��Left=�6   $	��315��6/   $��279,102,0,0q�6<   
�������$	��Top=�6`   $	��273��6x   �� 5   
   $
��Left=�6   $	��411��6/   $��
13,101,0,0q�6<   
�������$	��Top=�6_   $	��261��6w   �� 5   
   $
��Left=�6   $��28��6/   $��	13,73,0,0q�6;   
�������$	��Top=�6]   $	��261��6u   �� 5   
   -   5         ��Name$ label��5      $��Nome:��6   $
��Left=�6/   $��
11,109,0,0q�6J   $	��Top=�6^   $��Arial)�6v   $��16(�6�   $��56��6�   ���	#FFFFC5006�   �� 5   
   -   5        $ 
label_Copy��5      $��
Sobrenome:��6$   $
��Left=�69   $��
11,141,0,0q�6T   $	��Top=�6h   $��Arial)�6�   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5   
   -   5        $ label_Copy1��5      $
��CPF:��6%   $
��Left=�64   $��
11,175,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5   
   -   5        $ label_Copy2��5      $��Email:��6%   $
��Left=�66   $��
11,273,0,0q�6Q   $	��Top=�6e   $��Arial)�6}   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5   
   -   5        $ label_Copy3��5      $��Telefone Residencial:��6%   $
��Left=�6E   $��
11,207,0,0q�6`   $	��Top=�6t   $��Arial)�6�   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5    
   -   5        $ label_Copy4��5       $��Celular��6%   $
��Left=�67   $��
11,241,0,0q�6R   $	��Top=�6f   $��Arial)�6~   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5!   
   -   5        $ label_Copy5��5!      $��Data Aniversario:��6%   $
��Left=�6A   $��
11,307,0,0q�6\   $	��Top=�6p   $��Arial)�6�   $��16(�6�   $	��138��6�   ���	#FFFFC5006�   �� 5"   
   -   5        $ label_Copy6��5"      $��	Facebook:��6%   $
��Left=�69   $��
11,339,0,0q�6T   $	��Top=�6h   $��Arial)�6�   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5#   
   -	   5         ��Name$ txbFacebookC��5#      $
��Left=�6(   $��24��6C   $��149,345,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��108��6�   $��Lucasgalvao��6�   �� 5$   
   -
   5        $ 	txbEmailC��5$      $
��Left=�6%   $��24��6@   $��149,279,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��108��6�   $��lucas@gmail.com��6�   �� 5%   
   -   5        $ txbCelularC��5%      $
��Left=�6'   $��22��6B   $��149,247,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��108��6�   $��(41) 4444-4444��6�   �� 5&   
   -   5        $ txbTelefoneC��5&      $
��Left=�6(   $��24��6C   $��149,213,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��108��6�   $��(41) 3333-3333��6�   �� 5'   
   -   5        $ txbCpfC��5'      $
��Left=�6#   $��22��6>   $��149,181,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��108��6�   $��999.999.999-00��6�   �� 5(   
   -   5        $ txbSobrenomeC��5(      $
��Left=�6)   $��24��6D   $��149,147,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��108��6�   $��Galvão��6�   �� 5)   
   -   5        $ txbNomeC��5)      $
��Left=�6$   $��22��6?   $��149,115,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��108��6�   $��Lucas��6�   �� 5*   
   -   5        $ label_Copy7��5*      $��
CADASTRAR:��6%   $��Right=�6:   $��0,74,1116,0q�6V   $	��Top=�6k   $��Arial)�6�   $��16(�6�   $	��114��6�   ���	#FFFFC5006�   �� 5+   
   -   5         ��Name$ btnCadastra��5+      $��	Cadastrar��6&   $
��Left=�6:   $��
86,473,0,0q�6U   $	��Top=�6i   $	��111��6�   $��24��6�   
���   ����	#FFFFF3006�   �� 5,   
   -   5        $ 	btnExclui��5,      $��Excluir��6$   $
��Left=�66   $��465,152,0,0q�6Q   $	��Top=�6f   $��70��6~   $��36��6�   $��20(�6�   ���	#FFFFF3006�   �� 5-   
   -   5        $ btnPesquisa��5-      $��	Pesquisar��6&   $
��Left=�6:   $��461,111,0,0q�6U   $	��Top=�6j   $��74��6�   $��36��6�   $��17.333(�6�   ���	#FFFFF3006�   �� 5.   
   -   5        	 ��Name$	 
lbPesquisa��5.      $
��Left=�6&   $	��187��6A   $��308,213,0,0q�6N   $	��Top=�6c   $	��224��6{   ���	#FFF3FF00��6�   Z� 6�   o� 5/   
   -   5        
 o�Name$

 menu��5/      $
��Left=�6   $��30��68   $	��Top=�6D   $
��1316��6\   $��0,27,0,0q�6i   .@�50      m� -   5        $��Voltar Menu��50      $��16(�6,   6:   52      �� 53   
   -   5        $	 
lbContatos��53      $
��Left=�6&   $	��315��6A   $��557,102,0,0q�6N   $	��Top=�6c   $	��304��6{   ���	#FFE8FF00��6�   Z� 6�   �� 54   
   $
��Left=�6   $��28��6/   $��
557,74,0,0q�6;   
�������$	��Top=�6^   $	��304��6v   �� 55   
   -   5        $ label_Copy23��55      $��CONTATOS��6&   $
��Left=�69   $��
649,74,0,0q�6T   $	��Top=�6h   $��Arial)�6�   $��16(�6�   $	��103��6�   ���	#FFF3FF00��6�   Z� 6�   (  "System.Windows.Controls.DatePicker  56   
   -   5          Name$ 
dataAniver��56      $
��Left=�6)   $��149,310,0,0q�6D   $	��Top=�6Y   $	��108��6q      DisplayDate$ 
1997-10-30��6}   �� 57   
   -   5        $ label_Copy24��57      $	��Rua��6&   $
��Left=�64   $��
11,372,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 58   
   -   5        $ txbRuaC��58      $
��Left=�6#   $��24��6>   $��149,378,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��108��6�   $��Sao Sebastiao��6�   �� 59   
   -   5        $ label_Copy25��59      $��Bairo��6&   $
��Left=�66   $��
11,405,0,0q�6Q   $	��Top=�6e   $��Arial)�6}   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5:   
   -   5        $ 	txbBairoC��5:      $
��Left=�6%   $��24��6@   $��149,411,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��108��6�   $��Roseira��6�   �� 5;   
   -   5        $ label_Copy26��5;      $��Numero��6&   $
��Left=�67   $��
11,438,0,0q�6R   $	��Top=�6f   $��Arial)�6~   $��16(�6�   $��96��6�   ���	#FFFFC5006�   �� 5<   
   -   5        $ 
txbNumeroC��5<      $
��Left=�6&   $��24��6A   $��149,444,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��108��6�   $��80��6�   �� 5=   
   -    5        $ label_Copy20��5=      $��Nome:��6&   $
��Left=�66   $��281,106,0,0q�6Q   $	��Top=�6f   $��Arial)�6~   $��16(�6�   $��63��6�   ���	#FFFFC5006�   �� 5>   
   -!   5        $ txbInformaNomeA��5>      $
��Left=�6+   $��22��6F   $��382,111,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $��74��6�   �� 5?   
   -"   5        $ txbInformaSobrenomeA��5?      $
��Left=�60   $��22��6K   $��382,139,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $��74��6�   �� 5@   
   -#   5        $ btnOK��5@      $��	Vereficar��6    $
��Left=�64   $��308,170,0,0q�6O   $	��Top=�6d   $��74��6|   $��36��6�   ���	#FFE8FF00$��17.333(�6�   �� 5A   
   -$   5        $ 	btnAltera��5A      $��Alterar��6$   $
��Left=�66   $��387,170,0,0q�6Q   $	��Top=�6f   $��72��6~   $��36��6�   ���	#FFE8FF00$��17.333(�6�   �� 5B   
   $
��Left=�6   $��28��6/   $��
279,74,0,0q�6;   
�������$	��Top=�6^   $	��273��6v   �� 5C   
   -%   5        $ label_Copy8��5C      $#��ALTERAR / EXCLUIR / PESQUISAR��6%   $
��Left=�6M   $��
281,74,0,0q�6h   $	��Top=�6|   $��Arial)�6�   $��16(�6�   $	��271��6�   ���	#FFFFC5006�   �� 5D   
   -&   5        $ label_Copy9��5D      $��
Sobrenome:��6%   $
��Left=�6:   $��281,134,0,0q�6U   $	��Top=�6j   $��Arial)�6�   $��16(�6�   $	��101��6�   ���	#FFFFC5006�   �� 5E   
   -'   5        $ label_Copy10��5E      $��CADASTRO��6&   $
��Left=�69   $��	86,74,0,0q�6T   $	��Top=�6g   $��Arial)�6   $��16(�6�   $	��103��6�   ���	#FFF3FF00��6�   Z� 6�   5G      5H      