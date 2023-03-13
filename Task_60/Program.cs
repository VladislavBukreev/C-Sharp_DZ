using static System.Console;
{
    Clear();
    WriteLine("Генерация массива ... ");
    int[,,] array = GetArray(2, 2, 2, 0, 10);
    PrintArray(array);
    ReadLine();

        int[,,] GetArray(int n, int m, int l, int minValue, int maxValue)
    {
        int[,,] result = new int[n, m, l];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < l; k++)
                {
                    result[i, j, k] = new Random().Next(minValue, maxValue);
                }
                
            }
        }
        return result;
    }

    void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($" {array[i, j, k]} ");
                }
                Console.WriteLine();
            }
           
        }

    }
}