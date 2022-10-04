# Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

# *Пример:*

# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

def DecToBin(dec, bin=[]):
    bin.append(str(dec % 2))
    dec //= 2
    if dec == 0 and dec % 2 == 0:
        bin.reverse()
        return "".join(bin)
    else:
        return DecToBin(dec, bin)


def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


dec = GetInt(f"Введите десятичное число: ")
print(f"{dec} => {DecToBin(dec)}")
