//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Сколько элементов будет в нашем новом массиве ? -> ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Какое зададим максимальное рандомное число в массиве ? -> ");
int random = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
Console.WriteLine($"Создаю случайный массив ... [    {String.Join(" , ", array)}    ]");

Console.WriteLine($"Сумма элементов на нечетной позиции равна -> {Summ(array)}");


int[] NewArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)

        mas[i] = new Random().Next(random);
    return mas;

}

int Summ(int[] NewArray)
{
    int sum = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        
        if (i % 2 != 0)
        {
            sum += NewArray[i];
        }
    }
    return sum;
}