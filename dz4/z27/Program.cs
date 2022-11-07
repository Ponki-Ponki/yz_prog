// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void SumNumbers(int a){
    int sumNam = 0;
    a = Math.Abs(a);
    while (a > 0)
    {
        sumNam += a % 10;
        a /= 10;
    };
    Console.WriteLine($"Сумма цифр числа равна: {sumNam}");
}

 Console.Write("Введите число: ");
 SumNumbers(Convert.ToInt32(Console.ReadLine()));