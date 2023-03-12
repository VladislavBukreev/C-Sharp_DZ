/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
using static System.Console;
{
    Clear();
    Write("Введите колличество строк первого массива -> ");
    int rows = int.Parse(ReadLine());
    Write("Введите колличество столбцов первого массива -> ");
    int columns = int.Parse(ReadLine());
    Write("Введите колличество строк второго массива -> ");
    int rows2 = int.Parse(ReadLine());
    Write("Введите колличество столбцов второго массива -> ");
    int columns2 = int.Parse(ReadLine());
    int[,] array = GetArray(rows , columns, 0, 10);
    int[,] array2 = GetArray(rows2, columns2, 0, 10);
    if(columns != rows2)
    {
        WriteLine("Невозможно");
        return;
    }
    PrintArray(array);
    WriteLine();
    PrintArray(array2);
    WriteLine();
    PrintArray(MatrixMultiplication(array, array2));





    int[,] GetArray(int n, int m, int minValue, int maxValue)
    {
        int[,] result = new int[m,m];
        for(int i = 0; i < n; i++ )
        {
            for(int j = 0; j < m; j++)
            {
                result[i,j] = new Random().Next(minValue, maxValue);
            }
        }
        return result; 
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write($"{array[i, j]} ");
            }
            WriteLine();
        }
    }

    int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB) //Метод произведения двух матриц
    {
        int[,] arrayC = new int[array.GetLength(0), array2.GetLength(1)]; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    arrayC[i, j] += array[i, k] * array2[k, j];
                }
            }
        }   
        return arrayC;
}







}
