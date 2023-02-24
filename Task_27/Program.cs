//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//85 -> 13


int Summ(int n){
int result = 0;
while (n > 0)
{
    result = result + (n % 10);
    n = n / 10;
}
return result;
}


Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма всех введеных чисел равна -> {Summ(n)}");