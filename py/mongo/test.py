from pymongo import MongoClient
client = MongoClient("mongodb://localhost:27017/")

db = client["NSE"]

emp = db["emp"]

_data = { "firstName" : "Aavya", "lastName" : "Jha", "age" : 10}

emp.insert_one(_data)

_list = emp.find({})




for f in _list:
    print(f)
    print(type(f))




  