# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.


def ParseM4len(m4len):
    print(m4len)
    dict = {}
    for i in (m4len.split(" + ")):
        if '^' in i:
            k = i[i.index("^") + 1]
            dict[k] = i
        elif 'x' in i:
            dict[1] = i
        else:
            dict[0] = i[:i.index(" ")]
    return dict


def SumMulti4len(m1, m2):
    for k, o4len in m1.items():
        if k in m2:
            if not k:
                o4len = str(int(m1[0]) + int(m2[0]))
            else:
                mult1 = int(o4len[:o4len.index("*")])
                mult2 = int(m2[k][:m2[k].index("*")])
                o4len = str(mult1 + mult2) + "*x"
                if int(k) > 1:
                    o4len += f"^{k}"
            m1.update({k: o4len}) 
    return " + ".join(m1.values()) + " = 0"


with open("m4len1.txt", 'r') as f:
    m1 = ParseM4len(f.read())

with open("m4len2.txt", 'r') as f:
    m2 = ParseM4len(f.read())

with open("m4len3.txt", 'w') as f:
    f.write(SumMulti4len(m1, m2))