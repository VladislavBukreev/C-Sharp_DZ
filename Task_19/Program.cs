//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();                  
    int number = Convert.ToInt32(value); 
    return number;
}
bool Numbers(int number)
{   if(number > 9999 && number < 99999)
    {
        return true; 
        Console.WriteLine("Это пятичзначное число, ");
    }
        Console.WriteLine("Это не пятичзначное число, ");
        return false;
}
int number = Prompt("Введите пятизначное число >");

Numbers(number);

string SUKPZDZ = Convert.ToString(number);

char Firstchar = SUKPZDZ[0];
char Secondchar = SUKPZDZ[1];
char Thirdchar = SUKPZDZ[3];
char Fourthchar = SUKPZDZ[4];

if(Firstchar == Fourthchar && Secondchar == Thirdchar )
{
    Console.Write("Ваше число является полиндромом");
}
else
{
    Console.Write("Это НЕ Полиндром");
}


