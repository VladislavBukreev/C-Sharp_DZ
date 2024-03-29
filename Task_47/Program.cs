﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5  7  -2  -0,2
1  -3,3  8  -9,9
8   7,8  -7  ,1 9
*/
Console.Clear();
Console.WriteLine("Введите количство строк в массиве : ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количство столбцов в массиве : ");
int columns = int.Parse(Console.ReadLine());
double[,] array = GetArray(rows, columns, -10 , 10 );
PrintArray(array);

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m,n];
    Random random = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = random.Next(-10 , 10) + random.NextDouble() ;
            

        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}