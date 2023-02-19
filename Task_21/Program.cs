// Задача 21 : Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.Write($" Расстояние между точками = {result:f3}");