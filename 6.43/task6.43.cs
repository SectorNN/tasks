// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadDouble(string msg)         // Функция запрашивает и валидирует число у пользователя
{        
    double num;
    do
    {
        Console.Write(msg);
    } while (!double.TryParse(Console.ReadLine(), out num));
    return num;
}

double b1 = ReadDouble("Введите b1: ");
double b2 = ReadDouble("Введите b2: ");
double k1 = ReadDouble("Введите k1: ");
double k2 = ReadDouble("Введите k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"Координаты пересечения прямых: {x}:{y}");