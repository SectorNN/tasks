# Задача 5 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z
# для всех значений предикат. # Количество предикатов генерируется случайным образом от 5 до 11, проверяем это
# утверждение 10 раз, с помощью модуля time выводим на экран сколько времени отработала программа.

from itertools import product
from random import randint
from datetime import datetime

start = datetime.now()
predicats = list(product(range(2), repeat=randint(5, 11)))

for k in range(10):
    left = predicats[0][0]
    right = not predicats[0][0]
    for i in predicats:
        print(i, end=": ")
        for j in i:
            left = left or j
            right = right and not j
        left = not left
        print(f"{left} = {right} => {left == right}")

print(f"Выполнено за {(datetime.now() - start).total_seconds()} секунд")
