// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[j, i] = rnd.Next(min, max);
        }

    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

int SumRows(int[] rows)
{
    int sum = 0;
    for (int i = 0; i < rows.Length; i++)
    {
        sum += rows[i];
    }
    return sum;
}

int[] StringComparison(int[,] matrix)
{
    int[] minNum = new int[2] { int.MaxValue, 0 };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] temp = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[i, j];
        }
        int sumRows = SumRows(temp);
        if (minNum[0] > sumRows)
        {
            minNum[0] = sumRows;
            minNum[1] = i;
        }
    }
    return minNum;
}

void PrintResult(int[] result)
{
    Console.WriteLine($"Строка с наименьшей суммой элементов: {result[1] + 1}");
    Console.WriteLine($"Сумма элементов в этой строке: {result[0]}");
}

int[,] arr = CreateMatrix(4, 4, 1, 10);
Console.WriteLine("Двумерный массив размером 4*4, заполненный случайными вещественными числами:");
PrintMatrix(arr);
int[] result = StringComparison(arr);
PrintResult(result);