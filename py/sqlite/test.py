import sqlite3
# 1. Connect to a database file (automatically creates it if missing)
# Use ':memory:' instead of a filename to create a temporary database in RAM
connection : sqlite3.Connection  = sqlite3.connect("test.db")

# 2. Create a cursor object to execute SQL commands
cursor = connection.cursor()

cursor.execute("SELECT * FROM emp")
rows = cursor.fetchall()

for row in rows:
    print(row)

connection.close()


