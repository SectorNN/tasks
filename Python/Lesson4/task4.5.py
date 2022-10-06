from datetime import date
import json


def load():
    global cars
    with open("cars.txt", "r") as f:
        cars = json.load(f)


def save():
    with open("cars.txt", "w") as f:
        f.write(json.dumps(cars))


def GetInt(msg):
    try:
        return int(input(msg))
    except:
        return GetInt(msg)


def SelectCar(cars):
    car = ""
    for i in range(len(cars)):
        print(f"id: {i}")
        for key, val in cars[i].items():
            print(f"{key}: {val}")
        print()
    while car not in range(len(cars)) and car != -1:
        car = GetInt("Введите id автомобиля или -1 для возврата: ")
    return car


availCmds = ["/help: Отобразить список всех команд",
             "/rent: Арендовать автомобиль",
             "/add: Добавить автомобиль в базу",
             "/del: Удалить автомобиль из базы",
             "/bye: Выход"]

try:
    load()
except:
    cars = [{"name": "Skoda Octavia", "year": "2015", "gbox": "MT", "engine": 150, "class": "Comfort"},
            {"name": "KIA RIO", "year": "2018", "gbox": "AT",
                "engine": 105, "class": "Econom"},
            {"name": "Hyundai Elantra", "year": "2020",
            "gbox": "AT", "engine": 180, "class": "Comfort"},
            {"name": "BMW X5M", "year": "2017", "gbox": "AT", "engine": 575, "class": "Premium"}]
    save()

print("Вас приветствует бот по бронированию автомобилей!")
while 1:
    cmd = input("Введите команду. /help для вывода всех команд: ")
    match cmd:             # since python 3.10
        case '/help':
            print("\n".join(availCmds))
        case '/rent':
            car = SelectCar(cars)
            if car == -1:
                continue
            if "!ЗАБРОНИРОВАН!" in cars[car]['name']:
                print("Этот автомобиль уже забронирован, выбирете другой!")
            else:
                print(
                    f"Автомобиль {cars[car]['name']} успешно забронирован на {date.today()}! Спасибо!")
                cars[car]['name'] = cars[car]['name'] + \
                    f" !ЗАБРОНИРОВАН! на {date.today()}"
            # save()
        case '/add':
            print("Выбирете доступный автомобиль:")
            cars.append({"name": input("Марка и модель авто: "), "year": input("Год выпуска: "), "gbox": input(
                "Тип коробки (MT/AT): "), "engine": input("Мощность двигателя: "), "class": input("Класс авто: ")})
            save()
            print("Автомобиль успешно добавлен!")
        case '/del':
            car = SelectCar(cars)
            if car == -1:
                continue
            car = cars.pop(car)
            save()
            print(f"Автомобиль {car['name']} успешно удалён!")
        case '/bye':
            print("До скорых встреч!")
            break
