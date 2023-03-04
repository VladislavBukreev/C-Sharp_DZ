//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Сколько элементов будет в нашем новом массиве ? -> ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Какое зададим максимальное рандомное число в массиве ? -> ");
int random = int.Parse(Console.ReadLine());
int[] arr = NewArray(size);
Console.WriteLine($"Создаю случайный массив ... [    {String.Join(" , ", arr)}    ]");
Console.WriteLine(ElementSearch(arr));

int[] NewArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)

        mas[i] = new Random().Next(random);
    return mas;
}

int ElementSearch(int[] NewArray)    //Метод поиска элемента
{
    int res = 0 ;
    for (int i = 0; i <NewArray.Length; i++)
    {
        if(arr[i] > 0)
        {
            res += 1;
        }
    }
    return res;
}