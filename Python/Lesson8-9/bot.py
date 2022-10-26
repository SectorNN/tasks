import json
import telebot
import sql
import logger
from tg_token import tg_token
from datetime import date, datetime
from telebot.types import InlineKeyboardMarkup, InlineKeyboardButton


bot = telebot.TeleBot(tg_token, parse_mode='HTML')


def go_start(cb):
    head = "Вас приветствует бот по бронированию автомобилей!\n\nВыберите необходимую операцию:"
    bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=gen_m_menu())


def gen_m_menu():
    markup = InlineKeyboardMarkup()
    markup.row_width = 1
    markup.add(InlineKeyboardButton("Арендовать автомобиль 🚗", callback_data=json.dumps({"act": "rent_1", "id": False})),
               InlineKeyboardButton("Добавить автомобиль в базу ➕", callback_data=json.dumps({"act": "add"})),
               InlineKeyboardButton("Удалить автомобиль из базы ➖", callback_data=json.dumps({"act": "del_1", "id": False})),
               InlineKeyboardButton("Загрузить базу по-умолчанию ♻️", callback_data=json.dumps({"act": "reload"})),
               InlineKeyboardButton("Скачать лог 📋", callback_data=json.dumps({"act": "getlog"})))
    return markup


def gen_cars_menu(action):
    markup = InlineKeyboardMarkup()
    markup.row_width = 1
    cars = sql.db_get_cars()
    for i in cars:
        if i[6] and i[6] > datetime.now():
                car_row = "🔴 "
        else:
            car_row = "🟢 "
        car_row += f"{i[1]} [{i[2]}/{i[3]}] ➡️"
        markup.add(InlineKeyboardButton(car_row, callback_data=json.dumps({"act": action, "id": str(i[0])})))
    markup = gen_back(markup)
    return markup


def confirm_car(id, action):
    markup = InlineKeyboardMarkup()
    markup.row_width = 2
    markup.add(InlineKeyboardButton("Принять ✅", callback_data=json.dumps({"act": action, "id": str(id), "confirm": True})),
               InlineKeyboardButton("Отклонить ❌", callback_data=json.dumps({"act": "start"})))
    return markup


def get_car_info(id):
    car = sql.db_get_car_info(id)
    car = f"Модель: <b>{car[1]}</b>\nГод: <b>{car[2]}</b>\nКПП: <b>{car[3]}</b>\nМощность: <b>{car[4]}</b>\nКласс: <b>{car[5]}</b>\n"
    return car


def gen_back(markup=()):
    if not markup:
        markup = InlineKeyboardMarkup()
        markup.row_width = 1
    markup.add(InlineKeyboardButton("Вернуться в начало ⏪", callback_data=json.dumps({"act": "start"})))
    return markup


@ bot.message_handler(commands=['start', 'help'])
def command_answer(message):
    head = "Вас приветствует бот по бронированию автомобилей! 🤖\n\nВыберите необходимую операцию:"
    logger.write(
        f"Recieved command {message.text} from {message.from_user.username} ({message.from_user.first_name} {message.from_user.last_name})")
    bot.send_message(message.chat.id, head, reply_markup=gen_m_menu())


@ bot.message_handler(func=lambda m: True)
def dump(message):
    logger.write(
        f"Recieved message: {message.text} from {message.from_user.username} ({message.from_user.first_name} {message.from_user.last_name})")
    if "Введите данные" in message.reply_to_message.text and message.reply_to_message.from_user.id == 5467228530:
        car = list(map(lambda x: x.strip(), message.text.split(",")))
        if len(car) != 5:
            head = "Не удалось распознать, повторите ввод согласно шаблону!\n\nВведите данные автомобиля в формате:\n\n<pre>name, year, gbox, engine, class</pre>\n\nПример:\n\nHammer H2, 2007, AT, 315, Premium"
            bot.send_message(message.chat.id, head, reply_markup=telebot.types.ForceReply(selective=False))
        else:
            sql.db_append((car[0], car[1], car[2], car[3], car[4], None))
            bot.send_message(message.chat.id, f"☑️ Автомобиль <b>{car[0]}</b> успешно добавлен в базу!", reply_markup=gen_back())
            logger.write(
                f"Car added: {car[0]} from {message.from_user.username} ({message.from_user.first_name} {message.from_user.last_name})")


@ bot.callback_query_handler(func=lambda cb: True)
def callback_query(cb):
    global cars
    logger.write(f"Recieved callback: {cb.data} from {cb.from_user.username} ({cb.from_user.first_name} {cb.from_user.last_name})")
    cb_data = json.loads(cb.data)
    if 'id' in cb_data:
        id = int(cb_data["id"])

    match cb_data["act"]:

        case "rent_1":
            head = "Выберите необходимый автомобиль:"
            bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=gen_cars_menu("rent_2"))

        case "rent_2":
            car = sql.db_get_car_info(id)
            if car[6] and car[6] > datetime.now():
                head = f"❌ Этот автомобиль забронирован до {car[6].strftime('%d.%m.%y %H:%M')}.\n\nПожалуйста выбирете другой автомобиль!"
                bot.answer_callback_query(cb.id, head, show_alert=True)
            else:
                head = "📋 Информация о выбранном автомобиле:\n\n" + get_car_info(id)
                bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=confirm_car(id, 'rent_3'))

        case "rent_3":
            car = sql.db_get_car_info(id)
            head = f"Автомобиль <b>{car[1]}</b> успешно забронирован на <b>{date.today()}</b> ✅\n\nПриятного вождения! 🚘"
            sql.db_set_rent(id)
            bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=gen_back())
            logger.write(f"Car rent: {car[1]} to {cb.from_user.username} ({cb.from_user.first_name} {cb.from_user.last_name})")

        case 'add':
            head = "Введите данные автомобиля в формате:\n\n<pre>Модель, год, КПП, мощность, класс</pre>\n\nПример:\n\nHammer H2, 2007, AT, 315, Premium"
            bot.send_message(cb.from_user.id, head, reply_markup=telebot.types.ForceReply(selective=False))

        case "del_1":
            head = "Выбирите необходимый автомобиль:"
            bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=gen_cars_menu('del_2'))

        case "del_2":
            head = "Удалить автомобиль?\n\n" + get_car_info(id)
            bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=confirm_car(id, 'del_3'))

        case "del_3":
            car = sql.db_get_car_info(id)
            head = f"☑️ Автомобиль {car[1]} удалён из базы!"
            sql.db_del(int(cb_data['id']))
            bot.answer_callback_query(cb.id, head)
            logger.write(f"Car delete: {car} via {cb.from_user.username} ({cb.from_user.first_name} {cb.from_user.last_name})")
            go_start(cb)

        case "start":
            head = "Вас приветствует бот по бронированию автомобилей!\n\nВыберите необходимую операцию:"
            bot.edit_message_text(head, cb.from_user.id, cb.message.id, reply_markup=gen_m_menu())

        case "reload":
            sql.db_init()
            bot.answer_callback_query(cb.id, 'База данных перезагружена! 🔖')

        case "getlog":
            with open('logdata.txt', 'r', encoding='UTF-8') as fh:
                bot.send_document(cb.from_user.id, fh)


print("Бот запущен!")

bot.infinity_polling()
