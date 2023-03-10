/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();
Console.WriteLine("Введите размер строк массива -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер столбцов массива -> ");
int columns = int.Parse(Console.ReadLine());
int [,] array = GetArray(rows, columns , 0,10);
PrintArray(array);
System.Console.WriteLine();
SortingArray(array);
PrintArray(array);
int[,] GetArray(int n , int m, int minValue , int maxValue)
{
    int[,] result = new int [n,m];
    for(int i = 0; i < n ; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next (minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

//метод сортировки пузырьком
void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }
        }
    }
}         
            
        
        
  