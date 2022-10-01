# Напишите программу, которая принимает на вход вещественное или целое число и показывает сумму его цифр. Через строку нельзя решать.

# *Пример:*

# - 6782 -> 23
# - 0,56 -> 11

def GetFloat(msg):
    try:
        return float(input(msg))
    except:
        return GetFloat(msg)

def SumDigits(num):
    sum = 0
    num = abs(num)
    while (num) >= 1:
        sum += num % 10
        num //= 10
    return(sum)

def FloatToInt(number):                # eliminate float's troubles: https://docs.python.org/3/tutorial/floatingpoint.html
    while number % 1:               
        number = round(number * 10, len(str(number)))
    return (number)

number = GetFloat("Введите число: ")
print(f"Сумма цифр в числе: {SumDigits(FloatToInt(number))}")