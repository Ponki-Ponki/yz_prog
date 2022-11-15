// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointCalck(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Две линии паралельны");
    else {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"({x};{y})");
    }
}


Console.Write("Введите координату 1 линии 1ой точки :");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 1 линии 2ой точки :");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 2 линии 1ой точки :");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 2 линии 2ой точки :");
int k2 = Convert.ToInt32(Console.ReadLine());
PointCalck(b1, k1, b2, k2);
// PointCalck(2, 5, 4, 9);
