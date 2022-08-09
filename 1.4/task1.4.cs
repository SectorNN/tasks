List<int> nums = new List<int>();

for (int i = 1; i < 4; i++){
    Console.Write($"Введите {i} целое число: ");
    nums.Add(int.Parse(Console.ReadLine()));
}
Console.Write($"Максимальное число: {nums.Max()}");

commit!