   M S B A M L   `   `   `  ����   WpfApp1    ExpenseTracker.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Expense Tracker��$	��600��$	��500�����#F0F0F0 � 	Resources  �� 
TargetType �� Property �� Value��%�  '��       '�� [     '�� �     �� " ��.���  � ��$ 0,10,0,5q���  � ��$ 14(���  � �� �#333333�� " ��.���  � ��$ 5q���  � ��$ 14(���  � �� �#CCCCCC��  � ��$ 1q��� " ��.���  � ��$ 0,15,0,0q���  � ��$
 10,5q���  � �� �#0078D4��  � ��
 �������  � ��$ 14(���  � ��$ 0q�.���� 
������� �� CornerRadius$ 10��$��20q� �� Padding$ 30q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q�	   ShadowDepth$	 1Q�
   Opacity$	
 0.2Q�._��� $
��Auto=�.���� .+��� $��Expense Tracker��$��32(�$��Light"����#0078D4 �� TextAlignment$ Center=�$��0,0,0,30q��  � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��$��0,0,10,0q�.+��� $
��Name���� -    ��Name$ ExpenseNameTextBox���� $
��Type���� -   $ ExpenseTypeTextBox���� $��1��$��10,0,0,0q�.+��� $��Price���� -   $ ExpensePriceTextBox���� -   $��Add Expense��$��0,41,0,0q��� $
��0,30q����#CCCCCC�� -   $��Remove Expense by Name���� -   $��Display All Expenses���� -   $��Display Total Price���� ���#F9F9F9���#CCCCCC$��1q�$ 5��$��0,20,0,0q�$ 10q�._��� -    ��Name$ OutputTextBlock��$
��Wrap=�$��14(����#333333$	��100��