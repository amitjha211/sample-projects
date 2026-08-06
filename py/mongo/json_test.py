import json

def test1():
    _data = { "firstName" : "Aavya", "lastName" : "Jha", "age" : 10}
    _data2 = ["amit","jha"]

def test2():
    json_str = """
    { "firstName" : "Aavya", "lastName" : "Jha", "age" : 10}
"""
    _obj = json.loads(json_str)
    print(type(_obj))
    print(_obj)



test2()





