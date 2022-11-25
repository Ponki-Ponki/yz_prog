// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j],5} |");
            else Console.Write($"{arr[i, j],5}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

int[,] MultiplMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] multiplMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < multiplMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < matrixTwo.GetLength(0); l++)
            {
                sum += matrixOne[i, l] * matrixTwo[l, j];
            }
            multiplMatrix[i, j] = sum;
        }
    }
    return multiplMatrix;
}



int[,] matrix1 = CreateMatrix(5, 4, -9, 10);
int[,] matrix2 = CreateMatrix(4, 7, -9, 10);
Console.WriteLine("Двe матрицы, заполненные случайными вещественными числами:");
PrintMatrix(matrix1);
Console.WriteLine("");
PrintMatrix(matrix2);
Console.WriteLine("");
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    Console.WriteLine("Произведение 2х матриц: ");
    int[,] result = MultiplMatrix(matrix1, matrix2);
    PrintMatrix(result);
}
else System.Console.WriteLine("Нельзя найти произведение 2х матриц");