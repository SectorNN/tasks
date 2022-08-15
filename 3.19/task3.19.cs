int numInt = 0;
string numStr = "";

while (numInt < 10000 || numInt > 99999){
    Console.Write("Введите 5-значное число: ");
    int.TryParse(numStr = Console.ReadLine(), out numInt);
}

bool IsPolin(string numStr){
    for (int f = 0; f < numStr.Length / 2; f++){
        if (numStr[f] == numStr[numStr.Length - f - 1]){
            continue;
        } else return false;
    }
    return true;
}

if (IsPolin(numStr)) Console.Write("Полиндром detected!");