
from pymongo import MongoClient
from config import *
import json

def insert():
    sFile_JSON = readFile("sample-data.json")

    jn = json.loads(sFile_JSON)


    #inserting in mongo db 

    client = MongoClient("mongodb://localhost:27017/")
    db = client["sample"]
    emp = db["emp"]
    for r in jn:
        print(r)
        emp.insert_one(r)


if(__name__=="__main__"):
    insert()

