// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Решение для 5ти значных положительных чисел

// string PolidNum(int n){
//     if (9999 > n && n < 100000) return null;
//     n =  Math.Abs(n);
//     if (n % 10 != n / 10000) return "не полиндром";
//     if (n % 100 / 10 != n / 1000 % 10) return "не полиндром";
//     return "палиндром";
// }

// int num = Convert.ToInt32(Console.ReadLine());
// string answer = PolidNum(num);
// Console.WriteLine(answer == null? "Число не 5-ти значное" : $"Чило {answer}");



//Другое решение для всех чисел

string PolidNum(int n)
{
    int nNum = Math.Abs(n);
    int polindrom = 0;
    while (nNum > 0)
    {
        int newNum = nNum % 10;
        nNum /= 10;
        polindrom = polindrom * 10 + newNum;
    };
    if (Math.Abs(n) == polindrom) return "палиндром";
    return "не полиндром";
}

int num = Convert.ToInt32(Console.ReadLine());
string answer = PolidNum(num);
Console.WriteLine(answer == null? "Число не 5-ти значное" : $"Чило {answer}");