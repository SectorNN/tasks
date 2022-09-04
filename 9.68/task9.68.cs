// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int ReadInt(string msg)                         // Функция запрашивает и валидирует число у пользователя
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 1) ReadInt(msg);
    return num;
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = ReadInt("Введите натуральное число M: ");
int n = ReadInt("Введите натуральное число N: ");

Console.Write($"Результат: {Ackermann(m, n)}");