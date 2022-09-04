// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int ReadInt(string msg)             // Функция запрашивает и валидирует число у пользователя
{        
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 1) ReadInt(msg);
    return num;
}

void PrintNaturals(int M, int N)    // Функция выводит ряд натуральных чисел
{
    Console.Write($"{M} ");
    if (M == N) return;
    if (M < N) M++; else M--;
    PrintNaturals(M, N);
}

int M = ReadInt("Введите натуральное число M: ");
int N = ReadInt("Введите натуральное число N: ");

PrintNaturals(M, N);