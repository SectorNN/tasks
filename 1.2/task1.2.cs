Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber) Console.WriteLine($"Первое число {firstNumber} больше второго {secondNumber}");
else if (firstNumber < secondNumber) Console.WriteLine($"Второе число {secondNumber} больше первого {firstNumber}");
else Console.WriteLine($"Числа {firstNumber} и {secondNumber} равны");