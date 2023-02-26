// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.WriteLine(" Введите длину массива : ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите максимальный элемент в массиве : ");
int random = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
int max = 0;
int min = 0;
Console.WriteLine($"Генерирую новый массив ...  [    {String.Join( ", " , array)}    ]  ");
Console.WriteLine(MaxMin(max));

int[] NewArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(random);
    }
    return res;
}

int MaxMin(int[] NewArray)
{
  
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max =+ array[i]; 
        }
    }
return max;
}
