# Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.

# *Пример:*

# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}


def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)

n = GetInt("Введите N: ")

arr = {}

for i in range(n):
    arr[i] = 3 * i + 1

print(arr)


# 13. Напишите программу, в которой пользователь будет задавать две строки, а программа - определять количество вхождений одной строки в другой.

str1 = input("Введите строку 1: ")
str2 = input("Введите строку 2: ")

arr = str1.split(str2)

count = len(arr) - 1

print(f"Колличество вхождений: {count}") 