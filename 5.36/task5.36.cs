// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {GetSumOdds(arr)}");