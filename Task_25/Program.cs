//Напишите цикл, который принимает на вход два числа (A и B) и возводит число x в натуральную степень B.


Console.Clear();
Console.WriteLine("Введите число А: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine($" А в степени В -> {RaiseToThePower(x)}");


int RaiseToThePower(int x){
int result = 1;
for(int i = 1; i <= y; i++)
{
    result *= x;
}
return result;
}
    