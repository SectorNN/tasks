# Задача 2. Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# *Пример:*

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

from random import randint


def PairsProduct(inList):
    prod = []
    for i in range(round((len(inList) + 0.1) / 2)):
        prod.append(inList[i] * inList[-i - 1])
    return prod


inList = [randint(1, 10) for _ in range(9)]
print(f"Произведения пар чисел из списка {inList}: {PairsProduct(inList)}")
