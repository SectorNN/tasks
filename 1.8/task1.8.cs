Console.Write("Введите целое число: ");
int firstNumber = int.Parse(Console.ReadLine());

for (int i = 2; i <= firstNumber; i++){
    Console.Write($"{i} ");
    i++;
}