# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.


def Pack(string, pos = 0, outStr = ""):
    seqLen = 1
    try:
        while string[pos + seqLen] == string[pos]:
            seqLen += 1
    except:
        1
    outStr += (str(seqLen) + string[pos])
    pos += seqLen
    while pos < len(string):
        return Pack(string, pos, outStr)
    return outStr


def Unpack(string):
    newStr = ""
    for i in range(len(string)):
        newStr += string[i]
        if not string[i].isdigit() and i != len(string) - 1:
            newStr += '#'
        lst = newStr.split("#")
    return "".join((map(lambda x: x[-1] * int(x[:-1]), lst)))


rle = "aaabcddfffffffffffffffffksskksjkrjhgklsrrrrr"
print (rle)
print (Pack(rle))
print (Unpack(Pack(rle)))