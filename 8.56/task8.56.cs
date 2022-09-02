// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] GenerateDualArr(int nx = 5, int ny = 6)          // Функция генерирует двухмерный массив
{
    int[,] dualArr = new int[nx, ny];
    Random rnd = new Random();
    for (int x = 0; x < nx; x++)
    {
        for (int y = 0; y < ny; y++)
        {
            dualArr[x, y] = rnd.Next(0, 10);
        }
    }
    return dualArr;
}

void PrintArr(int[,] arr)                               // Функция выводит двухмерный массив
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

int GetMinSumStr(int[,] arr)                         // Функция возвращает номер строки с наименьшей суммой чисел
{
    int tmp = 0;
    int minSum = 0;
    int minInd = 0;
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            tmp += arr[r, c];
        }
        if (tmp < minSum || r == 0) 
        {
            minSum = tmp;
            minInd = r;
        }
        tmp = 0;
    }
    return minInd;
}

int[,] arr = GenerateDualArr();
Console.WriteLine("Исходный масссив:");
PrintArr(arr);
Console.WriteLine("==========================================");
Console.Write($"Номер строки с минимальной суммой чисел: {GetMinSumStr(arr)}");