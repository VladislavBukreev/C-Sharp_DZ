//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Какой будет размер нашего массива ? ");
int size = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
int item = 0;
Console.WriteLine($"Генерирую новый массив с трехзначными числами ... [   {String.Join(", " , array )}   ]");
Console.WriteLine($"В нашем массиве {NumberElements(array)} чётных чисел");

int[] NewArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100,1000);
    }
    return res;
}

int NumberElements(int[] NewArray)

{
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        item += 1;
    }
    return item;
}

