// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] InputArray(int len)           // Функция создаёт массив из n элементов, введёных пользователем
{
    string[] arr = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int PosCount (string[] arr)             // Функция считает положительные элементы массива
{
    int count = 0;
    foreach (string i in arr)
    {
        if (int.TryParse(i, out int outInt))
        {
            if (outInt > 0) count++;
        }
    }
    return count;
}

string[] arr = InputArray(10);
Console.Write($"Введённый массив: {string.Join(" ", arr)}\n");
Console.Write($"Число положительных элементов массива: {PosCount(arr)}");