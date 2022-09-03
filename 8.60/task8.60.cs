// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

Console.Clear();

int[,,] GenerateTripleArr(int nx = 4, int ny = 4, int nz = 4)          // Функция генерирует трёхмерный массив
{
    int[,,] tripleArr = new int[nx, ny, nz];
    int val;
    List<int> vals = new List<int>();
    Random rnd = new Random();
    for (int x = 0; x < nx; x++)
    {
        for (int y = 0; y < ny; y++)
        {
            for (int z = 0; z < nz; z++)
            {
                do val = rnd.Next(10,100);                              // Заполняем уникальными
                while (vals.Contains(val));
                tripleArr[x, y, z] = val;
                vals.Add(val);
            }
        }
    }
    return tripleArr;
}

void PrintTripleArr(int[,,] arr)                                        // Функция выводит трёхмерный массив
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"[{x}, {y}, {z}]: {arr[x, y, z]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

PrintTripleArr(GenerateTripleArr());