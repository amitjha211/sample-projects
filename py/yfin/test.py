import json
import yfinance as yf

def save_symbol(symbol):
    stock = yf.Ticker(symbol)
    info = stock.info
    with open(f"{symbol}.json", "w") as json_file:
        json.dump(info, json_file, indent=4)



def print_ohlc(symbol):
    stock = yf.Ticker(symbol)
    info = stock.info
 



if __name__ == "__main__":
    print("i'm inside main")
else:
    print("i'm out side main")
    