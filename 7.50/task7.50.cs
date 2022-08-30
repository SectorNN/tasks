// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

double[,] GenerateDualArr(int m = 3, int n = 4)          // Функция генерирует двухмерный массив
{
    double[,] dualArr = new double[m, n];
    Random rnd = new Random();
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            dualArr[x, y] = rnd.Next(-10, 10) + Math.Round(rnd.NextDouble(), 1);
        }

    }
    return dualArr;
}

void PrintArr(double[,] arr)                            // Функция выводит двухмерный массив
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            Console.Write($"{arr[x, y]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindInArr(double[,] arr)
{
    int[] idx = {-1, -1};
    double dbl;
    do
    {
        Console.WriteLine("Введите вещественное число для поиска: ");
    }
    while (!double.TryParse(Console.ReadLine(), out dbl));

    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            if (arr[x, y] == dbl) {
                idx[0] = x; idx[1] = y;
                return idx;
            }
        }
    }
    return idx;
}


double[,] arr = GenerateDualArr();
PrintArr(arr);
Console.Write($"Индекс искомого числа в массиве: [{string.Join(", ", FindInArr(arr))}]");