double[] a = new double[3];
double[] b = new double[3];

Console.Write("Введите координату X точки A: ");
double.TryParse(Console.ReadLine(), out a[0]);
Console.Write("Введите координату Y точки A: ");
double.TryParse(Console.ReadLine(), out a[1]);
Console.Write("Введите координату Z точки A: ");
double.TryParse(Console.ReadLine(), out a[2]);

Console.Write("Введите координату X точки B: ");
double.TryParse(Console.ReadLine(), out b[0]);
Console.Write("Введите координату Y точки B: ");
double.TryParse(Console.ReadLine(), out b[1]);
Console.Write("Введите координату Z точки B: ");
double.TryParse(Console.ReadLine(), out b[2]);

double GetDist(double[] a, double[] b){
    return (Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2)));
}

Console.Write($"Расстояние между точками: {GetDist(a, b)}");