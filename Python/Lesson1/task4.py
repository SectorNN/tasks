# Напишите простой калькулятор, который считывает с пользовательского ввода три строки: первое число, второе число и операцию, после чего применяет операцию к введённым числам ("первое число" "операция" "второе число") и выводит результат на экран.

# Поддерживаемые операции: +, -, /, *, mod, pow, div, где
# mod — это взятие остатка от деления,
# pow — возведение в степень,
# div — целочисленное деление.

# Если выполняется деление и второе число равно 0, необходимо выводить строку "Деление на 0!".

# Обратите внимание, что на вход программе приходят вещественные числа.

# Sample Input 1:
# 5.0
# 0.0
# mod
# Sample Output 1:
# Деление на 0!

# Sample Input 2:
# -12.0
# -8.0
# *
# Sample Output 2:
# 96.0

# Sample Input 3:
# 5.0
# 10.0
# /
# Sample Output 3:
# 0.5

def GetFloat(msg):
    try:
        return float(input(msg))
    except:
        return GetFloat(msg)


def GetOper():
    opers = ['+', '-', '/', '*', 'mod', 'pow', 'div']
    oper = input("Введите операцию: ")
    if oper in opers:
        return oper
    else:
        return GetOper()


a = GetFloat("Введите первое число: ")
b = GetFloat("Введите второе число: ")

oper = GetOper()

if oper in ['/', 'mod', 'div'] and b == 0:
    res = "Нельзя делить на ноль"
else:
    match oper:             # since python 3.10
        case '+':
            res = a + b
        case '-':
            res = a - b
        case '/':
            res = a / b            
        case '*':
            res = a * b
        case 'mod':
            res = a % b
        case 'pow':
            res = a ** b
        case 'div':
            res = a // b

print(f"Результат операции: {res}")
