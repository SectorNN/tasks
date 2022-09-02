// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int [,] ArrSortRows(int[,] arr)                         // Функция сортирует строки двумерного массива
{
    int[] tmp = new int[arr.GetLength(1)];
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            tmp[c] = arr[r, c];
        }
        Array.Sort(tmp);
        Array.Reverse(tmp);
        for (int с = 0; с < arr.GetLength(1); с++)
        {
            arr[r, с] = tmp[с];
        }
    }
    
    return arr;
}

int[,] arr = GenerateDualArr();
Console.WriteLine("Исходный масссив:");
PrintArr(arr);
Console.WriteLine("==========================================");
Console.WriteLine("Отсортированный масссив:");
PrintArr(ArrSortRows(arr));