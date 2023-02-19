//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
    

}
int[] result = new int[m];
for (int j = 0; i <= N; i++)
{
    result[j] = i * i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.WriteLine($"Таблица кубов -> {result[j]} ");
}
