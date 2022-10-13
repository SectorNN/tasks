# Напишите программу вычисления арифметического выражения заданного строкой. Используйте операции +,-,/,*. приоритет операций стандартный.

# *Пример:*
# 2+2 => 4;
# 1+2*3 => 7;
# 1-2*3 => -5;

# - Добавьте возможность использования скобок, меняющих приоритет операций.

#     *Пример:*
#     1+2*3 => 7;
#     (1+2)*3 => 9;

def calc(l, r, op):
    match op:             # since python 3.10
        case '+':
            res = l + r
        case '-':
            res = l - r
        case '/':
            res = l / r
        case '*':
            res = l * r
    return round(res, 2)


def parse(string, opers):
    i = 0
    while i < len(string):
        if string[i] in opers:
            oper = string[i]
            try:
                count = 1
                while string[i + count].isdigit() or string[i + count] == ".":
                    count += 1
            except:
                1
            right = string[i + 1:i + count]

            count = 1
            while (string[i - count - 1].isdigit() or string[i - count - 1] == ".") and i - count > 0:
                count += 1
            left = string[i - count:i]
            print(f"left = {left}, right = {right}, oper = {oper}")
            res = calc(float(left), float(right), oper)
            string = string.replace(f"{left}{oper}{right}", str(res), 1)
            print(f"Res = {string}")
            i = 0
        i += 1
    return string


some_str = "1+2+33*10*15/7*34/10"

some_str = parse(some_str, ["*", "/"])
some_str = parse(some_str, ["+", "-"])
