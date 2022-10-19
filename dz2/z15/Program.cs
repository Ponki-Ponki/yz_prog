// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DayLay(int n){
    if (n > 7 || n < 1) Console.WriteLine("ERROR"); 
    else if (n==6 || n == 7) Console.WriteLine("Этот день выходной");
    else Console.WriteLine("Этот день не выходной");  
}

Console.WriteLine("Введите номер дня недели: ");
DayLay(Convert.ToInt32(Console.ReadLine()));