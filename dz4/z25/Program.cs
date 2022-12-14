// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degree(int a, int b)
{
    int i = 1;
    int sum = a;
    while (i < b)
    {
        sum = sum * a;
        i++;
    }
    return sum;
}


Console.Write("Введите число для возведения в степень: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum == 0 || secondNum == 0)
{
    Console.Write("Некоректно введены значения");
}
else Console.WriteLine($"Степень {secondNum} числа {firstNum}  равен: {Degree(firstNum, secondNum)}");