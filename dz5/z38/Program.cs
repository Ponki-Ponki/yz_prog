// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

double DiffMinMax(double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    return Math.Round(max - min, 1);
}

void PrintResult(double result)
{
    Console.WriteLine($" -> {result}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");
}

double[] arr = CreateArray(10, -100, 100);
PrintArray(arr);
double result = DiffMinMax(arr);
PrintResult(result);