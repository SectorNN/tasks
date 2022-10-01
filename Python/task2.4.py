# Задача 4 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу, которая принимает на вход N, и координаты двух точек и находит расстояние между ними в N-мерном пространстве.

def GetCoords(N):
    try:
        p1 = []
        p2 = []
        for i in range(1, N + 1):
            p1.append(int(input(f"Введите {i} координату точки A: ")))
            p2.append(int(input(f"Введите {i} координату точки B: ")))
        return [p1, p2]
    except:
        return GetCoords(N)


def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


def Evclid(points, N):
    temp = 0
    for i in range(N):
        temp += (points[0][i] - points[1][i]) ** 2
    return temp ** 0.5


N = GetInt("Размерность пространства: ")
points = GetCoords(N)
print(f"Расстояние между точками: {Evclid(points, N)}")
