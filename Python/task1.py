# задача 1. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

# *Пример:*

# - 6 -> да
# - 7 -> да
# - 1 -> нет

def IsWeekend(day):
    if day == 6 or day == 7:
        return True
    else:
        return False


def GetDay():
    try:
        day = int(input("Введите день недели (1-7): "))
        if day in range(1, 8):
            return day
        else:
            return GetDay()
    except:
        return GetDay()



if IsWeekend(GetDay()):
    print("Это выходной")
else:
    print("Это будний")
