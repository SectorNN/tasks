// Доп. задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int nr = 5, int nc = 5)                    // Функция заполняет массив змейкой
{
    int[,] arr = new int[nr, nc];
    string direction = "r";
    int val = 1;
    int r = 0;
    int c = -1;
    int newC = c;
    int newR = r;

    do
    {
        switch (direction)
        {
            case "r": newC = c + 1; break;
            case "d": newR = r + 1; break;
            case "l": newC = c - 1; break;
            case "u": newR = r - 1; break;
        }
        try
        {
            if (arr[newR, newC] != 0)
            {
                ChangeDirection(ref direction);
                newR = r; newC = c;
                continue;
            }
            arr[newR, newC] = val;
        }
        catch
        {
            ChangeDirection(ref direction);
            newR = r; newC = c;
            val--;
        }
        c = newC; r = newR;
        val++;
    }
    while (val <= nr * nc);
    return arr;
}

void ChangeDirection(ref string direction)                  // Функция меняет направление заполнения массива
{
    switch (direction)
    {
        case "r": direction = "d"; break;
        case "d": direction = "l"; break;
        case "l": direction = "u"; break;
        case "u": direction = "r"; break;
    }
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

PrintArr(FillArray(10, 10));
