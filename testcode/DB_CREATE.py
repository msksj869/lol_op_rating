import pymysql
from openpyxl import Workbook
from openpyxl import load_workbook

project=pymysql.connect(
    user='root',
    passwd='!!fnsldkwjsrl11',
    host='127.0.0.1',
    charset='utf8'
)
cursor=project.cursor()
cursor.execute("CREATE DATABASE LOL")