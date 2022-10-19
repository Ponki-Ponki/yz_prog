//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Mult(int n){
    int result = n / 10;
    result = result % 10;
    return result;
}


int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Второе число этого числа: {Mult(num)}");