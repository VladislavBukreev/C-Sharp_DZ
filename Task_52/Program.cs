/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
Console.WriteLine("Введите количество строк в массиве -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве -> ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте максимально возможное число -> ");
int rand = int.Parse(Console.ReadLine());

int [,] array = GetArray(rows, columns , 0, rand);
PrintArray(array);
ArithmeticMean(array);


int[,] GetArray(int n, int m, int minValue, int rand)
{
    int[,] result = new int[n,m];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next(minValue , rand);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)
{   
    double X = 0;
    double y = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            X = X + array[i,j];
            y = X / array.GetLength(0);

        }
        System.Console.WriteLine($" Среднеарифмитическое - {y}");
    }
    
}
