# 29. Задайте два числа. Напишите программу, которая найдёт НОК (наименьшее общее кратное) этих двух чисел.

def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


def NOK(a, b):
    i = 1
    while not (i % a == 0 and i % b == 0):
        i += 1
    return i


a = GetInt("Введите число A: ")
b = GetInt("Введите число B: ")

print (f"Наименьшее общее кратное: {NOK(a, b)}")