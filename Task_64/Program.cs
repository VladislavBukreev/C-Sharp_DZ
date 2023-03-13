
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Clear();
/*
Write("Введите N: ");
int n = int.Parse(ReadLine());
 
for (int i = n; i > 0; i--)    
{
    Write($"{i} ");
}
WriteLine();
ReadLine();
 */

int x = 1;
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Method(x, n));



string Method(int Nachalo, int Konec)
{
    if (Konec == Nachalo) return Konec.ToString();
    return (Konec + " " + Method(Nachalo, Konec - 1));
}