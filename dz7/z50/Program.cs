// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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

void PrintArray(int[,] arr)
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

void FindNumbers(int row, int column, int[,] matrix)
{
    if ((row >= 0 && row < matrix.GetLength(0)) &&
        (column >= 0 && column < matrix.GetLength(1))) Console.WriteLine($"Значение этого элемента: {matrix[row, column]}");
    else Console.WriteLine($"Такого элемента в массиве нет");
}

Console.WriteLine("Введите позицию элемента в матрице");
Console.Write("Строка: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateMatrix(3, 4, -10, 10);
Console.WriteLine("Двумерный массив размером 3*4, заполненный случайными вещественными числами:");
PrintArray(arr);

FindNumbers(row - 1, column - 1, arr);