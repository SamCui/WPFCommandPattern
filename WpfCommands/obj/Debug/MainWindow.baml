   M S B A M L   `   `   `  ����F  BWpfCommands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfCommandsWpfCommands  5   	       WpfCommands.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   +localclr-namespace:WpfCommands     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5         WpfCommands.MainViewModel  5   
   -   5        myviewModel��5      .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��0��6!   $	��160��6/   $��30��6;   $��Simple Command��6G   ��6`   �� *SimpleCommand+��6�   �� *
Messages+&   System.Windows.Controls.DataGrid  5   
   -   5        $��
dgMessages��5      $��0��6%   $��1��65      AutoGenerateColumns . ��5      ��  �� Path$ Messages�5      5      5      