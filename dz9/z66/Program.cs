// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenNAndM(int m, int n)
{
    if (m < n)
    {
        m += SumBetweenNAndM(++m, n);
    }
    return m;
}

System.Console.Write("Задайте значения M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте значения N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумму натуральных элементов в промежутке от {m} до {n}: ");
Console.Write($"M = {m}; N = {n} -> ");
if (m > 0 && n > 0) Console.WriteLine(m > n ? SumBetweenNAndM(m, n) : SumBetweenNAndM(n, m));
else Console.WriteLine("Введены некоректные числа");
// System.Console.WriteLine(SumBetweenNAndM(1, 15));
// System.Console.WriteLine(SumBetweenNAndM(4, 8));
