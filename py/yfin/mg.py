from pymongo import MongoClient
client = MongoClient("mongodb://localhost:27017/")

db = client["NSE"]

stock_info = db["stock_info"]

def insert(_data):
    stock_info.insert_one(_data)

