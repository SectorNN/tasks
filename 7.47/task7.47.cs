// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateDualArr(int m = 3, int n = 4)          // Функция генерирует двухмерный массив
{
    double[,] dualArr = new double[m, n];
    Random rnd = new Random();
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            dualArr[x, y] = rnd.Next(-10, 10) + rnd.NextDouble();
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
            Console.Write($"{arr[x, y]:F1}\t");
        }
        Console.WriteLine();
    }
}

PrintArr(GenerateDualArr());