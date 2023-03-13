using static System.Console;
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Clear();
Write("Ведите первое число ->");
int n = int.Parse(ReadLine());
Write("Ведите второе число ->");
int m = int.Parse(ReadLine());

WriteLine(Method(n,m));

int Method(int n , int m)
    {
        if(n == m)
    {
        return n;
    }
             
return  (n + Method(n+1, m));
}



