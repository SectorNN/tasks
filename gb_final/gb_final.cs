void PopArrElement(ref string[] Array, int ind)                 // Функция удаляет из массива элемент по индексу
{
    string[] tmpArray = new string[Array.Length - 1];
    int offset = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i != ind) tmpArray[i - offset] = Array[i];
        else offset++;
    }
    Array = tmpArray;
}

string[] FilterArr(string[] arr)                                // Функция фильтрует из массива строки длиннее 3 символов
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 3)
        {
            PopArrElement(ref arr, i);
            i--;
        }
    }
    return arr;
}

string[] Array = { "One", "Two", "Thre", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

Console.WriteLine(string.Join("; ", Array));
Console.WriteLine(string.Join("; ", FilterArr(Array)));