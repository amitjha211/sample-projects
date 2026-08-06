import psycopg
import symbol

from psycopg.rows import dict_row

connection_string = "dbname=data_bank user=postgres password=sa1983 host=localhost port=5432"

try:
    with psycopg.connect(connection_string) as conn:
        with conn.cursor(row_factory=dict_row) as cur:
            cur.execute("SELECT * FROM mstock;")
            rows = cur.fetchall()
            for row in rows:
                print(f"ID: {row['symbol']}")
                symbol.insert(row['symbol'])

except Exception as error:
    print(f"Database error occurred: {error}")
