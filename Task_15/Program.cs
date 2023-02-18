﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();                  //Метод, в котороом просят ввести день недели и конвертируют в тип int, запоминают это как result 
    int result = Convert.ToInt32(value); 
    return result;
}
bool IsWeekend(int weekDay)
{ 
        if (weekDay > 5) 
        {   
            return true;                            // Метод, в котором выявляется выходной  (6 и 7 день)
        } 
        return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
         return true;                                     // Метод, в котором проверяют что введёное число это день недели а не больше.
    }
    Console.WriteLine("Это не день недели!"); 
    return false;
}
int weekDay = Prompt("Введите день недели >");             // Начало операции, которое присваивает переменной weekDay значение result
if (ValidateWeekday(weekDay))  
{
    if (IsWeekend(weekDay))
    { 
    Console.WriteLine("Наконец-то выходной");
    }                                                       
    else 
    {
        Console.WriteLine("Придется поработать");
    }
}