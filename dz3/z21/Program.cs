// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double MathLine(int x1i, int y1i, int z1i, int x2i, int y2i, int z2i)
{
    if ((x1i == 0 && y1i == 0 && z1i == 0) && (x1i == 0 && y1i == 0 && z1i == 0)) return -1;
    double a = Math.Pow((x2i - x1i), 2);
    double b = Math.Pow((y2i - y1i), 2);
    double c = Math.Pow((z2i - z1i), 2);
    return Math.Sqrt(a + b + c);
}
Console.WriteLine("Введит координаты поочерёдно");
Console.WriteLine("Первая точка");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая точка");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(MathLine(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);

Console.WriteLine(result == -1 ? "Введины не верные координаты" : $"Длина между точками равна {result}");

Console.WriteLine($"Длина между точками равна {Math.Round(MathLine(3, 6, 8, 2, 1, -7), 2)}");

Console.WriteLine($"Длина между точками равна {Math.Round(MathLine(7, -5, 0, 1, -1, 9), 2)}");