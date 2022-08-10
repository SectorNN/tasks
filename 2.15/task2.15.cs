Console.Clear();

Console.Write("Введите день недели (1-7): ");
int dayNum = int.Parse(Console.ReadLine());

if (dayNum == 6 || dayNum == 7) Console.Write("Это выходной день");
else Console.Write("Это будний день");