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

int a = ReadInt($"Введите первое число: ");
int b = ReadInt($"Введите второе число: ");

Console.Write($"{a}^{b} = {Expon(a, b)}");