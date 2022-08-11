Console.Clear();

Console.Write("Введите 3-ёх значное число: ");
string number = Console.ReadLine();

Console.WriteLine($"Вторая цифра числа: {number[1]}");

int num = int.Parse(number);
Console.Write($"Арифметическим методом: {num % 100 / 10}");