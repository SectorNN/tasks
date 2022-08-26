// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GenerateDualArr(int nx = 3, int ny = 4)          // Функция генерирует двухмерный массив
{
    int[,] dualArr = new int[nx, ny];
    Random rnd = new Random();
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            dualArr[x, y] = rnd.Next(-10, 11);
            Console.Write($"{dualArr[x, y]}\t");
        }
        Console.WriteLine();
    }
    return dualArr;
}

int GetDiagSum(int[,] arr){                             // Функция возвращает сумму главной диагонали
    int sum = 0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        sum += arr[x, x];
    }
    return sum;
}

Console.Write($"Сумма главной диагонали: {GetDiagSum(GenerateDualArr())}");