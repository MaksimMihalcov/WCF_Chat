   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	   -   5          � Title$  WCF Chat��5   	   $	��450��6   $��534.858��6'   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF201D1D��6    � Offset$ 0Q�6-   � 5      $	 Red��6   $ 1Q�6'   � 5      $ 	#FF482F2F��6   $ 0.169Q�6-   � 5      $ 	#FF732E2E��6   $ 0.353Q�6-   � 5      $ 	#FFA62E2E��6   $ 0.566Q�6-   � 5      $ 	#FFC22121��6   $
 0.79Q�6-   5      .��5      � $��0,0,236.8,0q�6   ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5      � $ 	#FF2F2A2A��6   $ 0.003Q�61   � 5      $	 Red��6   $ 1Q�6+   � 5      $ 	#FF482F2F��6   $ 0.214Q�61   � 5      $ 	#FF732E2E��6   $ 0.434Q�61   � 5      $ 	#FFA62E2E��6   $ 0.617Q�61   � 5      $ 	#FFC22121��6   $ 0.807Q�61   5       � ColumnDefinitions 5   
   �� 5      �� 5       $��0* �6   .+�5"   
   �� -   5         ��Name$ 
tbUserName��5"      $��47��6'   $��197,10,-228.8,0q�63    �� TextWrapping$
 Wrap=�6L   $��	User Name��6`   $	��Top=�6q    J� RenderTransformOrigin$ 0.377,0.435&�6�   $��2��6�   �� 5#   
   -   5        	 ��Name$	 Button��5#      $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $	��165��6g   $��47��6s   .��5$      �� $
��Wrap=�6   $��Connect��6,   5%      �� 5&   
   -   5        
 ��Name$
 lbChat��5&      $	��244��6"   $��10,79,-228.6,0q�6/   $	��Top=�6G   $ 
1.01,0.504&�6_   $��2��6�   $
��Left=�6�   $	��513��6�   �� 5'   
   -   5        $ 	tbMessage��5'      $��60                  ��6%   $��10,347,-229,0q�5(      $
 Wrap=�6+   $��Write message here��6?   $	��Top=�6Y   $ 0.577,0.429&�6q   $��2��6�   5*      5+      