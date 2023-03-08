/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет
*/
Console.Clear();
Console.WriteLine("Введите количество строк в массиве -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве -> ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте максимально возможное число -> ");
int rand = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс искомого числа в строке -> ");
int SearchRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс искомого числа в столбце -> ");
int SearchСolumns = int.Parse(Console.ReadLine());
int [,] array = GetArray(rows, columns , 0, rand);
PrintArray(array);
Method(array);

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

void Method(int[,] array)
{
 if (SearchRows < 0 | SearchRows > array.GetLength(0) - 1 | SearchСolumns < 0 | SearchСolumns > array.GetLength(1) - 1)
            {
                Console.WriteLine("Такого нет!!");
            }
            else
            {
                Console.WriteLine("Запрвашиваемый элемент = {0}", array[SearchRows, SearchСolumns]);
            }
}