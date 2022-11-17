// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string PointCalck(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) return "Две линии паралельны";
    else {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return $"({x};{y})";
    }
}

void PrintResult(string result)
{
    Console.WriteLine(result.Length < 12 ? $"Точка пересечения: {result}" : result);
}


Console.Write("Введите 1ый коофициент 1 линии :");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ой коофициент 1 линии  :");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1ый коофициент 2 линии  :");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ой коофициент 2 линии  :");
int k2 = Convert.ToInt32(Console.ReadLine());
PrintResult(PointCalck(b1, k1, b2, k2));

// PrintResult(PointCalck(2, 5, 4, 9));
