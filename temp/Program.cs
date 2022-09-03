Console.WriteLine("Введите элементы массива через запятую: ");
string [] arr = Console.ReadLine().Split(",");
List<int> vals = new List<int>();

for (int i = 0; i < arr.Length; i++){
    if (int.Parse(arr[i]) % 2 == 0)
    {
        vals.Add(int.Parse(arr[i]));
    }
}

Console.Write(string.Join(" ", vals));