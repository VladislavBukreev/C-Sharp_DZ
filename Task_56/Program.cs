/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
Console.WriteLine("Введите размер строк массива -> ");
int ress = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер столбцов массива -> ");
int columns = int.Parse(Console.ReadLine()!);
int [,] array = GetArray(ress, columns , 0,10);

PrintArray(array);
System.Console.WriteLine();
Console.WriteLine($"Номер столбца(индекс) с наименьшей суммой элементов: {Method(array)} ");

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
    
    
    

int Method(int[,] array)
{
    //Находим сумму элементов первой строки
    int sumEl = 0;
    int res = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumEl = sumEl + array[0, i];
    }
    // Находим сумму элементов каждой строки начиная со 2 столбца ...
    for (int i = 1; i < array.GetLength(0); i++)
    {   
        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        
        // ... И сравниваем их с суммой элементов первой
        if (sumEl > sum)
        {
            sumEl = sum;
            res = i;
        }
    }
    return res; // возвращаем столбец с минимальной суммой 
}
