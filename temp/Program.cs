// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

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

void ReverseRows(int[,] arr)
{
    int [,] tmpArr = new int [arr.GetLength(0), arr.GetLength(1)];
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            tmpArr[0, y] = arr[0, y];
            arr[0, y] = arr[arr.GetLength(0) - 1, y];
            arr[arr.GetLength(0) - 1, y] = tmpArr[0, y];
        }
}

int[,] arr = GenerateDualArr();
PrintArr(arr);
Console.WriteLine();
ReverseRows(arr);
PrintArr(arr);

int [,] RemoveRowCol (int[,] arr)
{
    int minR = 0;
    int minC = 0;
    int minVal = arr[0, 0];
    int useCOffset = 0;
    int useROffset = 0;
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) -1];
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            if (arr[r, c] < minVal)
            {
                minVal = arr[r, c];
                minR = r;
                minC = c;
            }
        }
    }
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        useCOffset = 0;
        if (r == minR)
        {
            useROffset = 1;
            continue;
        }
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            if (c == minC) 
            {
                useCOffset = 1;
                continue;
            }
            newArr[r - useROffset, c - useCOffset] = arr[r, c];
        }
    }
    return newArr;
}

Console.WriteLine();
PrintArr(RemoveRowCol(arr));

// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, на 
// пересечении которых расположен наименьший элемент.
