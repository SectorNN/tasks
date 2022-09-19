Console.Clear();
Console.Write("M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
DigitInRange(m);

int DigitInRange(int m)
{
    if (m == n )
    {
        Console.Write(n);
        return n;
    }
    else 
    Console.Write(m + ", ");
    return DigitInRange(m + 1);

}