Console.Clear();

Console.Write("Введите число: ");
string strNumber = Console.ReadLine();

if (strNumber.Length < 3) Console.Write("Третий символ отсутствует");
else Console.Write($"Третий символ в строке: {strNumber[2]}");