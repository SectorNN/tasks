// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string[] InputArray()           // Функция создаёт массив из 8 элементов, введёных пользователем
{
    string[] arr = new string[8];
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

foreach (string ind in InputArray())
{
    Console.Write($"{ind} ");
}