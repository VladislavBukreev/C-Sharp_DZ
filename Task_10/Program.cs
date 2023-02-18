 // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 Console.Clear();
 int n = new Random().Next(100,999); 
 int result1 = n / 10;
 int result2 = result1 % 10;

Console.WriteLine( $" Наш рандом  -> {n} Второе число из него - {result2}");
