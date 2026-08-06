import psycopg
import yfinance as yf
import mg
from psycopg.rows import dict_row

connection_string = "dbname=data_bank user=postgres password=sa1983 host=localhost port=5432"


def insert(symbol):
    stock = yf.Ticker(f"{symbol}.NS")
    info = stock.info
    mg.insert(info)
    print(f"{symbol} ----- [Done]")

def symbol_loop():
    try:
        with psycopg.connect(connection_string) as conn:
            with conn.cursor(row_factory=dict_row) as cur:
                cur.execute("SELECT * FROM mstock;")
                rows = cur.fetchall()
                for row in rows:
                    _symbol = row['symbol']
                    insert(_symbol)
                    print(f"ID: {_symbol}")

                    
    except Exception as error:
        print(f"Database error occurred: {error}")


if __name__== "__main__":
    symbol_loop()