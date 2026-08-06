
from pymongo import MongoClient
client = MongoClient("mongodb://localhost:27017/")

db = client["NSE"]
stock_list = db["stock_list"]

def insert(symbol):
    _data = {"symbol" : symbol}
    stock_list.insert_one(_data)