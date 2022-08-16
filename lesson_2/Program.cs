/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
// точка А
System.Console.Write("введите координаты точки А по оси oX: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите координаты точки А по оси oY: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите координаты точки А по оси oZ: ");
int zA = Convert.ToInt32(Console.ReadLine());
// точка В
System.Console.Write("введите координаты точки В по оси oX: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите координаты точки В по оси oY: ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите координаты точки B по оси oZ: ");
int zB = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(xA-xB,2) + Math.Pow(yA-yB,2) + Math.Pow(zA - zB,2));
System.Console.WriteLine($"Расстояние ={Math.Round(d,2)}");

