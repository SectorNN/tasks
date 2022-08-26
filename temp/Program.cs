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

int[] arr = GenArr(10);
Console.Write($"Arr: {String.Join(" ", arr)}\n");
Console.Write($"RevertArr: {String.Join(" ", ArrRevert(arr))}\n");
Console.Write($"Avv: {ArrAv(arr)}");

// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве.
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33