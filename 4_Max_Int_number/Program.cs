// Максимальное целое из трёх чисел
Console.WriteLine("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int numberC = int.Parse(Console.ReadLine());
int max = 0;
if (numberA>numberB)
{
    max = numberA;
    if (numberA>numberC)
    {
        max = numberA;
    }
    else 
    {
        max = numberC;
    }
}
       
 else 
 {
    max = numberB;
        if (numberB>numberC)
        {
            max = numberB;
        }
        else 
        {
            max = numberC;
        }
        
 }

Console.WriteLine("Максимальное число это: ");
Console.WriteLine(max);