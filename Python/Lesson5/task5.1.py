# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет. Все конфеты оппонента достаются сделавшему последний ход. Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?

# a) Добавьте игру против бота

# b) Подумайте как наделить бота ""интеллектом""


from random import randint
import os


def clear(): return os.system('cls')


def Turn(maxTurn):
    try:
        n = int(input(f"Сколько конфет берём? (1 - {maxTurn}): "))
        clear()
        if n < 1 or n > maxTurn:
            return Turn(maxTurn)
    except:
        return Turn(maxTurn)
    return n


def BotTurn(playerTurn):
    if pool == 2021:
        amount = 20
    elif pool < 29:
        amount = pool
    else:
        amount = 29 - playerTurn
    print(f"Бот берёт {amount} конфет")
    return amount


def StateCheck(pool, playerTurn):
    pl = "игрок"
    if not pool:
        if not playerTurn:
            pl = "бот"
        print(f"Игра закончена, {pl} побеждает!\n\n")
        return 0
    if playerTurn:
        pl = "бот"
    print(f"Осталось {pool} конфет, ходит {pl}:\n")
    return pl


pool = 2021
playerTurn = randint(0, 1)
clear()
print(f"Игра начинается! На столе {pool} конфет!\n")
if playerTurn: print("В жеребьёвке побеждает бот, он ходит первым!\n")

while 1:
    maxTurn = 28
    if pool < 28:
        maxTurn = pool
    if not playerTurn:
        playerTurn = Turn(maxTurn)
        pool -= playerTurn
    else:
        pool -= BotTurn(playerTurn)
        playerTurn = 0
    if not StateCheck(pool, playerTurn):
        break
