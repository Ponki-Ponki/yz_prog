// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CalckNum(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res++;
    }
    return res;
}

void PrintResult(int result)
{
    Console.WriteLine($"Чисел больше 0: {result}");
}



Console.Write("Сколько вы введёте чисел?");
int mNum = Convert.ToInt32(Console.ReadLine());
if (mNum <= 0) Console.WriteLine("Введено не верное количесвто элементов");
else
{
    int[] arr = CreateArray(mNum);
    int result = CalckNum(arr);
    PrintResult(result);
}
