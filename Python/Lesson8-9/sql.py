import pyodbc
from datetime import datetime, timedelta

server = 'tcp:192.168.10.12'
database = 'gb'
username = 'gb_user'
password = 'gbpass2510'
connstr = 'DRIVER={ODBC Driver 18 for SQL Server};SERVER=' + server + \
    ';DATABASE=' + database + ';ENCRYPT=no;UID=' + username + ';PWD=' + password


def db_init():
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()

        cars = [("Skoda Octavia", "2015", "MT", 150, "Comfort", None),
                ("KIA RIO", "2018", "AT", 105, "Econom", None),
                ("Hyundai Elantra", "2020", "AT", 180, "Comfort", None),
                ("BMW X5M", "2017", "AT", 575, "Premium", None)]

        sql = "insert into rent_cars values (?, ?, ?, ?, ?, ?);"

        cursor.execute("truncate table rent_cars;")
        cursor.executemany(sql, cars)


def db_append(car):
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()

        sql = "insert into rent_cars values (?, ?, ?, ?, ?, ?);"

        cursor.execute(sql, car)


def db_del(id):
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()

        sql = "delete from [rent_cars] where id = ?;"

        cursor.execute(sql, (id,))


def db_get_cars():
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()

        sql = "SELECT * FROM rent_cars;"

        cursor.execute(sql)
        row = cursor.fetchall()
        return row


def db_get_car_info(id):
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()

        sql = "SELECT * FROM rent_cars WHERE id = ?;"

        cursor.execute(sql, (id,))
        row = cursor.fetchone()
        return row


def db_set_rent(id):
    with pyodbc.connect(connstr) as cnxn:
        cursor = cnxn.cursor()


        till = datetime.now() + timedelta(minutes=10)
        sql = "update rent_cars SET leased = ? WHERE id = ?;"

        cursor.execute(sql, (till, id))

print 