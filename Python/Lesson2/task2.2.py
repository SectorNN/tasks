# Задача 2. Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.

# *Пример:*

# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


num = GetInt("Введите число N: ")

prod = 1

if num < 0:
    rng = range(1, num - 1, -1)
else:
    rng = range(1, num + 1)

for i in rng:
    prod *= i
    print(prod, end=" ")
    if prod == 0:
        prod = 1