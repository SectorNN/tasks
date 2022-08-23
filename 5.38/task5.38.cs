// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GenArr(int len, int randMin = 100, int randMax = 1000)
{
    Random rand = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++){
        arr[i] = rand.Next(randMin, randMax);
    }
    return arr;
}

int GetSumOdds(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] arr = GenArr(10);
Console.WriteLine($"Сгенерированный массив:\n{String.Join(" ", arr)}");
Console.WriteLine($"Разница между максимальным и минимальным значениями: {arr.Max() - arr.Min()}");

// Или решение циклом:

int GetMinMaxDiff(int[] arr)
{
    int min = arr[0]; int max = arr[0];
    foreach (int i in arr)
    {
        if (i < min) min = i;
        else if (i > max) max = i;
    }
    return max - min;
}

Console.WriteLine($"Или: {GetMinMaxDiff(arr)}");