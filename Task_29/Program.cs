// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NewArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(1,999);
    }
    return result;
}

int[] array = NewArray(8);

Console.Clear();

Console.WriteLine($"Генерация нового массива из 8 элментов ... [    {String.Join(", ", array)}     ]");