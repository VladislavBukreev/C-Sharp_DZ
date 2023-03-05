//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[]  vvod()
{
    double [] arr= new double[4];
    Console.WriteLine("Введите kl");
    arr[0]= double.Parse(Console.ReadLine());
    Console.WriteLine("Введите bl");
    arr[1] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2");
    arr[2] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2");
    arr[3] = double.Parse(Console.ReadLine()); 
    return (arr);
}
double[] funk(double [] mass)
{
    double [] arr1= new double[2];
    arr1[0]= (mass[3]-mass[1])/(mass[0]-mass[2]);
    arr1[1]= mass[0]*arr1[0]+mass[1];
return (arr1);
}

Console.Clear();
Console.WriteLine($"({string.Join("; ", funk(vvod()))})");
