//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Как всегда - введите число");
string a = Console.ReadLine();
if(a.Length < 3)
    {Console.WriteLine("Третьей цыфры нет "); 
    return;
    }

Console.WriteLine($"Число третье по счёту это -> {a[2]}");

