int numInt = 0;

do {
    Console.Write("Введите исходное число: ");
} while (!int.TryParse(Console.ReadLine(), out numInt));

void Pow3 (int num){
    for (int i = 1;; i++){
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
        if (i == numInt) break;
        if (numInt <= 0) i -= 2;
    }
}

Pow3(numInt);