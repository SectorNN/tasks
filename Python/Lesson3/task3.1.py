# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

# *Пример:*

# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

from random import randint


def SummOdd(inList):
    sum = 0
    for i in range(1, len(inList), 2):
        sum += inList[i]
    return sum


inList = [randint(1, 10) for _ in range(10)]
print(f"Сумма чётных индексов в списке {inList}: {SummOdd(inList)}")
