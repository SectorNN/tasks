# задача 3. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).

# *Пример:*

# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3

def GetFloat(msg):
    try:
        var = float(input(msg))
        if var:
            return var
        else:
            return GetFloat(msg)
    except:
        return GetFloat(msg)


x = GetFloat("Введите координату X: ")
y = GetFloat("Введите координату Y: ")

a = b = c = d = " "

if x > 0 and y > 0: b = "X"
if x > 0 and y < 0: d = "X"
if x < 0 and y > 0: a = "X"
if x < 0 and y < 0: c = "X"

print(f"""
 {a} | {b}
-------
 {c} | {d} 
""")