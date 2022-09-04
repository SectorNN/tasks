// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg)                         // Функция запрашивает и валидирует число у пользователя
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 1) ReadInt(msg);
    return num;
}

void PrintNaturals(int M, int N, int sum = 0)    // Функция выводит ряд натуральных чисел
{
    sum += M;
    if (M == N) { Console.Write($"Сумма натуральных чисел: {sum}"); return; }
    if (M < N) M++; else M--;
    PrintNaturals(M, N, sum);
}

int M = ReadInt("Введите натуральное число M: ");
int N = ReadInt("Введите натуральное число N: ");

PrintNaturals(M, N);