
mongo_connection = "mongodb://localhost:27017/"

def readFile(sFile):
    with open(sFile, "r", encoding="utf-8") as file:
        content = file.read()
        return content
