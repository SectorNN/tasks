# <p align="center"><a href="https://t.me/GeekB_study_bot">RentCar_bot Telegram Bot</a>

<p align="center">Этот скрипт на Python создан в учебных целях и демонстрирует работу библиотеки <a href="https://pypi.org/project/pyTelegramBotAPI/">telebot</a>.</p>
<p align="center">Для хранения данных используется БД MS SQL. Для доступа к данным используется ODBC Driver 18 for SQL Server, pyodbc</p>

<p align="center">Используется Bot API version: <a href="https://core.telegram.org/bots/api#august-12-2022">6.2</a>!

<a href='https://pytba.readthedocs.io/en/latest/index.html'>Документация по Bot API</a>

## Краткое описание

Этот бот протестирован на Python 3.10. Бот использует базу данных SQL, в которой хранит некую базу автомобилей:
  
![DB](https://online.habarskoe.ru/github_img/6.PNG "DB")
  
Структура базы данных:

![DB](https://online.habarskoe.ru/github_img/5.PNG "DB")

Используя механизм <a href='https://core.telegram.org/bots/api#inlinekeyboardmarkup'>InlineKeyboardMarkup</a> задействованы Callback-кнопки, посредством которых выбираются нужные операции:

* Арендовать автомобиль:

![DB](https://online.habarskoe.ru/github_img/1.PNG "DB")

* Удалить автомобиль из базы:

![DB](https://online.habarskoe.ru/github_img/2.PNG "DB")

* Добавить автомобиль в базу:

![DB](https://online.habarskoe.ru/github_img/3.PNG "DB")

Также имеется возможность в любой момент восстановить исходную (эталонную) базу данных. Все операции пишутся в лог, который в свою очередь можно запросить у бота соответствующей кнопкой
