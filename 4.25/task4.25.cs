// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string msg)         // Функция запрашивает и валидирует число у пользователя
{        
    int num;
    do
    {
        Console.Write(msg);
    } while (!int.TryParse(Console.ReadLine(), out num));
    return num;
}

int Expon(int a, int b)         // Функция, возводящая в степень циклом
{        
    int ex = a;
    for (int i = 1; i < b; i++)
    {
        ex *= a;
    }
    return ex;
}

int[] numInt = new int[2];

for (int i = 0; i < 2; i++)
{
    numInt[i] = ReadInt($"Введите {i + 1} число: ");
    if (numInt[1] < 0) i--;     // Принимаем только положительную степень
}

Console.Write($"{numInt[0]}^{numInt[1]} = {Expon(numInt[0], numInt[1])}");
