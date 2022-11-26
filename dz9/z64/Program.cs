// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int[] NatureNumbersArray(int n)
// {

// }
void PrintChar(int n)
{
    if (n != 0)
        if (n > 1) Console.Write(n + ", ");
        else Console.Write(n);
}

int NatureNumbers(int n)
{
    PrintChar(n);
    if (n > 1)
        return NatureNumbers(n - 1);
    else return 1;
}

void PrintResutNatureNumbers(int n)
{
    Console.Write($"N = {n} -> ");
    Console.Write('"');
    NatureNumbers(n);
    Console.WriteLine('"');
}


System.Console.WriteLine("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Все натуральные числа в промежутке от {n} до 1");
// int n = 5;
PrintResutNatureNumbers(n);
// n = 8;
// PrintResutNatureNumbers(n);