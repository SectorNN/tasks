# Дан список чисел. Создайте список, в который попадают числа, описываемые максимальную возрастающую последовательность. Порядок элементов менять нельзя.

# *Пример:*

# [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]

from random import randint


def ChechSeq(lst):
    sequencesDict = {}
    for i in lst:
        minOfSeq = maxOfSeq = i
        seqLen = 1
        while i + seqLen in lst:
            maxOfSeq = i + seqLen
            seqLen += 1
        sequencesDict[seqLen] = [minOfSeq, maxOfSeq]
    return sequencesDict[max(sequencesDict)]


listRng = [randint(0, 10) for _ in range(15)]
print(listRng)
print(ChechSeq(listRng))
listRng.sort()
print(listRng)