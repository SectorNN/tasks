# Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

from itertools import product
from random import randint
from secrets import choice


def GetEvenInt(msg):
    try:
        evInt = int(input(msg))
        if not (evInt % 2) and evInt:
            return evInt
        else:
            return GetEvenInt(msg)
    except:
        return GetEvenInt(msg)


def PrintArr(arr):
    m = len(arr[0])
    n = len(arr)
    print("╔══" + ("══╤══" * (m - 1)) + "══╗")
    for i in range(n):
        print("║ " + " │ ".join(arr[i]) + " ║")
        if i != n - 1:
            print("╟──" + ("──┼──" * (m - 1)) + "──╢")
    print("╚══" + ("══╧══" * (m - 1)) + "══╝")


def ArrShuffle(arr):
    setForChoice = list(product(range(len(arr)), range(len(arr[0]))))
    counter = 0
    for _ in range(len(setForChoice) // 2):
        indFrom = choice(setForChoice)
        setForChoice.remove(indFrom)
        indTo = choice(setForChoice)
        setForChoice.remove(indTo)
        tmp = arr[indFrom[0]][indFrom[1]]       
        arr[indFrom[0]][indFrom[1]] = arr[indTo[0]][indTo[1]]
        arr[indTo[0]][indTo[1]] = tmp
        counter += 1
    print(f"Число проходов: {counter}")
    return arr


m = GetEvenInt("M: ")
n = GetEvenInt("N: ")
arr = [[str(randint(10, 99)) for _ in range(m)] for _ in range(n)]
PrintArr(arr)
PrintArr(ArrShuffle(arr))
