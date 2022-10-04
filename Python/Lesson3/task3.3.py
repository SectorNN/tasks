# Задача 3. Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# *Пример:*

# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

from random import uniform


def FloatDiff(inList):
    # откинем целую часть
    inList = list(map(lambda x: round(x - int(x), 3), inList))
    return round(max(inList) - min(inList), 3)


inList = [round(uniform(0, 10), 3) for _ in range(9)]

print(inList)

print(
    f"Разница между максимальным и минимальным значением дробной части элементов: {FloatDiff(inList)}")
