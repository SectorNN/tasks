# Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.

# *Пример:*
# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

from random import randint


def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


def GetMulti4len(k):
    m4len = []
    for k in range(k, 0, -1):
        factor = randint(0, 100)
        if factor:
            odno4len = f"{factor}*x"
            if k > 1:
                odno4len += f"^{k}"
        else:
            continue
        m4len.append(odno4len)
    m4len.append(f"{randint(0, 100)} = 0")
    m4len = " + ".join(m4len)
    print(m4len)
    return m4len


with open("m4len.txt", "w") as fh:
    fh.write(GetMulti4len(GetInt("Натуральная степень k: ")))
