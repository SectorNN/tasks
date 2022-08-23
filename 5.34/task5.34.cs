// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenArr(int len, int randMin = 100, int randMax = 1000)
{
    Random rand = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++){
        arr[i] = rand.Next(randMin, randMax);
    }
    return arr;
}

int GetArrEvens(int[] arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0) count++;
    }
    return count;
}

int[] arr = GenArr(10);
Console.WriteLine($"Сгенерированный массив:\n{String.Join(" ", arr)}");
Console.WriteLine($"Колличество чётных элементов: {GetArrEvens(arr)}");