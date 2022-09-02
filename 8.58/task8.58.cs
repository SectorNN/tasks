// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] GenerateDualArr(int nx = 5, int ny = 5)              // Функция генерирует двухмерный массив
{
    int[,] dualArr = new int[nx, ny];
    Random rnd = new Random();
    for (int x = 0; x < nx; x++)
    {
        for (int y = 0; y < ny; y++)
        {
            dualArr[x, y] = rnd.Next(0, 10);
        }
    }
    return dualArr;
}

void PrintArr(int[,] arr)                                   // Функция выводит двухмерный массив
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            Console.Write($"{arr[x, y]}\t");
        }
        Console.WriteLine();
    }
}

bool GetMatrixProd(int[,] m1, int[,] m2, out int[,] res)    // Функция возвращает произведение массивов
{
    int [,] q  = new int[m1.GetLength(0), m2.GetLength(1)];
    res = q;
    if (m1.GetLength(1) != m2.GetLength(0)) return false;
    for (int r = 0; r < m1.GetLength(0); r++)
    {
        for (int c = 0; c < m1.GetLength(1); c++)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                res[r, c] += m1[r, i] * m2[i, c];
            }
        }
    }
    return true;
}

int[,] m1 = GenerateDualArr();
int[,] m2 = GenerateDualArr();
int[,] mp;

Console.WriteLine("Матрица m1:");
PrintArr(m1);
Console.WriteLine("==========================================");
Console.WriteLine("Матрица m2:");
PrintArr(m2);
Console.WriteLine("==========================================");

if (GetMatrixProd(m1, m2, out mp))
{
    Console.WriteLine("Произведение матриц:");
    PrintArr(mp);
}
else
{
    Console.WriteLine("Эти матрицы нельзя умножать!");
}