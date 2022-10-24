// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TablCubs(int n)
{
    if (n < 1) Console.WriteLine("Введено не правильное число");
    int i = 1;
    Console.WriteLine(n > 0 ? $"{n} ->" : "");
    while (i <= n)
    {
        Console.WriteLine($"{i} | {i * i * i}");
        i++;
    }
}

int n = Convert.ToInt32(Console.ReadLine());

TablCubs(n);
