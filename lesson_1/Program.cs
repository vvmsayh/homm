/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

System.Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
int reverse = 0;
int dig =0;
while (number > 0)
{
    dig = number % 10;
    reverse = reverse * 10 + dig;
    number = number / 10;
}
if (n==reverse)
 System.Console.WriteLine("число является палиндромом");
else System.Console.WriteLine("число не является палиндромом");

