// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(0, 99999);

void NumDec(int number)
{
    if (number < 100) Console.WriteLine($"У этого числа {number} нет третьего числа");
    else if (99 < number && number < 1000) Console.WriteLine($"Число: {number}. Третье число этого числа: {number % 10}");
    else if (999 < number && number < 10000) Console.WriteLine($"Число: {number}. Третье число этого числа: {number / 10 % 10}");
    else if (9999 < number && number < 100000) Console.WriteLine($"Число: {number}. Третье число этого числа: {number / 100 % 10}");
    else Console.WriteLine("Это число вне диапозона");
}


NumDec(num);
NumDec(645);
NumDec(78);
NumDec(32679);

// Второй метод решение (решение подсказал другой ученик)

int Num(int n)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int digit3 = num % 10;
        return digit3;
    }
    else return -1;
}

int number = Num(num);
Console.WriteLine(number == -1 ? "Нет третьей цифры" : $"третья цифра: {number}");

Num(num);
Num(645);
Num(78);
Num(32679);