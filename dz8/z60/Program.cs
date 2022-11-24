// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] CreateArrayX3(int rows, int columns, int depth, int min, int max)
{
    int[,,] arrayX3 = new int[rows, columns, depth];
    int[] arr = new int[arrayX3.Length];
    Random rnd = new Random();
    int count = 0;
    for (int i = 0; i < arrayX3.GetLength(1); i++)
    {
        for (int j = 0; j < arrayX3.GetLength(0); j++)
        {
            for (int k = 0; k < arrayX3.GetLength(2); k++)
            {
                // Я не знаю как вынести это в отдельный метод, не смог додумать,
                // по этому сделал так. Но по логике можно упростить и 
                // отдельно сделать вроде как
                bool result = true;
                while (result)
                {
                    int num = rnd.Next(min, max);
                    for (int p = 0; p < arr.Length; p++)
                    {
                        if (arr[p] == num)
                        {
                            p = arr.Length - 1;
                            result = true;
                        }
                        else result = false;
                    }
                    if (result == false)
                    {
                        arrayX3[j, i, k] = num;
                        arr[count] = num;
                        count++;
                    }
                }
            }
        }
    }
    return arrayX3;
}


void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}:({i},{j},{k}) ", 4);
            }
        }
        System.Console.WriteLine("");
    }
}


int[,,] matrix3 = CreateArrayX3(4, 4, 4, 10, 100);
PrintMatrix(matrix3);


