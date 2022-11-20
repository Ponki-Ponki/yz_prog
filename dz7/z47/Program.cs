// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[j, i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }

    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4} | ");
            else Console.Write($"{arr[i, j],4}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }

}

double[,] arr = CreateMatrix(3, 4, -10, 10);
Console.WriteLine("Двумерный массив размером 3*4, заполненный случайными вещественными числами:");
PrintArray(arr);