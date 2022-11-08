// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumNumbers(int a)
{
    int sumNam = 0;
    a = Math.Abs(a);
    while (a > 0)
    {
        sumNam += a % 10;
        a /= 10;
    }
    return sumNam;
}

Console.Write("Введите число: ");
int sum = SumNumbers(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Сумма цифр числа равна: {sum}");