/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
System.Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start<=N; start++)
{
    Console.Write(Math.Pow(start,3) + " ");
}