// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)         // Функция запрашивает и валидирует число у пользователя
{        
    int num;
    do
    {
        Console.Write(msg);
    } while (!int.TryParse(Console.ReadLine(), out num));
    return num;
}

int SummOfChars(int numInt)     // Функция суммирует цифры в числе
{    
    int sum = 0;
    for (; numInt != 0; numInt /= 10)
    {
        sum += Math.Abs(numInt % 10);
    }
    return sum;
}

int numInt = ReadInt("Введите число: ");
Console.Write($"Сумма цифр в числе {numInt}: {SummOfChars(numInt)}");