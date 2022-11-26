// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akerman(int m, int n)
{
    int a = int.MinValue;
    if (m == 0) a = n + 1;
    if (m > 0 && n == 0) a = Akerman(m - 1, 1);
    if (m > 0 && n > 0) a = Akerman(m - 1, Akerman(m, n - 1));
    return a;
}


System.Console.WriteLine("Вычисления функции Аккермана: ");
System.Console.Write("Задайте значения m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте значения n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {m}; N = {n} -> ");
System.Console.WriteLine($"A({m},{n}) = {Akerman(m, n)}");
// System.Console.WriteLine(Akerman(3, 2));