// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[] arr)
{
    int indx;
    for (int i = 0; i < arr.Length; i++)
    {
        indx = i;
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] > arr[indx]) indx = j;
        }
        if (arr[indx] != arr[i])
            (arr[i], arr[indx]) = (arr[indx], arr[i]);
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] temp = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[i, j];
        }
        SortArray(temp);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp[j];
        }
    }
}

int[,] arr = CreateMatrix(4, 4, -9, 10);
Console.WriteLine("Двумерный массив размером 4*4, заполненный случайными вещественными числами:");
PrintMatrix(arr);
SortMatrix(arr);
System.Console.WriteLine("Отсортированный двухмерный массив по убыванию: ");
PrintMatrix(arr);