# Задача 5 VERY HARD SORT необязательная

# Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

# Например, задан массив:
# 1 4 7 2
# 5 9 10 3

# После сортировки
# 1 2 3 4
# 5 7 9 10

from random import randint


def GetInt(msg):
    try:
        var = int(input(msg))
        if var:
            return var
        else:
            return GetInt(msg)
    except:
        return GetInt(msg)


sizeX = GetInt("Введите размер массива X: ")
sizeY = GetInt("Введите размер массива Y: ")

sortList = []

for _ in range(sizeX):
    sortList.append([])
    for _ in range(sizeY):
        sortList[-1].append(randint(0, 10)) 

print(sortList)

for row in sortList:
    row.sort()

sortList.sort()

print(sortList)
