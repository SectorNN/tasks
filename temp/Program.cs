// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.).
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenArr(int len, int randMin = -10, int randMax = 11)
{
    Random rand = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++){
        arr[i] = rand.Next(randMin, randMax);
    }
    return arr;
}

int[] ArrRevert(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arr[arr.Length - i - 1] += arr[i];
        arr[i] = arr[arr.Length - i - 1] - arr[i];
        arr[arr.Length - i - 1] -= arr[i];
    }
    return arr;
}

double ArrAv(int[] arr){
    double sum = 0;
    int count = 0;
    foreach (int i in arr)
    {
        if (i > 0){
            sum += i;
            count++;
        }
    }
    return sum / count;
}

// int[] arr = GenArr(10);
// Console.Write($"Arr: {String.Join(" ", arr)}\n");
// Console.Write($"RevertArr: {String.Join(" ", ArrRevert(arr))}\n");
// Console.Write($"Avv: {ArrAv(arr)}");


// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GenerateDualArr(int m = 3, int n = 4)          // Функция генерирует двухмерный массив
{
    int[,] dualArr = new int[m, n];
    Random rnd = new Random();
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            dualArr[x, y] = x + y;
//          if ((x + 1) % 2 == 0 && (y + 1) % 2 ==0) dualArr[x, y] *= dualArr[x, y];
            Console.Write($"{dualArr[x, y]}\t");
        }
        Console.WriteLine();
    }
    return dualArr;
}

int [,] ArrOddReplace(int[,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            if ((x + 1) % 2 == 0 && (y + 1) % 2 ==0) arr[x, y] *= arr[x, y];
            Console.Write($"{arr[x, y]}\t");
        }
        Console.WriteLine();

    }
    return arr;
}

int [,] arr = GenerateDualArr();
Console.WriteLine();
ArrOddReplace(arr);


// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 81 2 9
// 8 4 2 4