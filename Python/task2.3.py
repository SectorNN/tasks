# Задача 3. Реализуйте алгоритм перемешивания списка. Список размерностью 10 задается случайными целыми числами, выводится на экран, затем перемешивается, опять выводится на экран. SHUFFLE нельзя юзать!

from random import randint


slist =  [randint(1, 10) for i in range(10)]

print(slist)

for i in range(50):
    slist.insert(randint(0, 9), slist.pop(randint(0, 9)))

print (slist)
