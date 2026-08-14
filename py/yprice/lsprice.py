import json
import sys
import yfinance as yf

num_col_size:float  = 8.0

def printHeader():
    print(f"{'Symbol':<15}| {'LTP':<8} | {'High':<8} | {'Low':<8}")
    
def printSymbolPrice(info:dict):

    _symbol:str = str(info["symbol"])
    _low  = info["dayLow"]
    _high = info["dayHigh"]
    _current =info["currentPrice"]
    _diff    = round(_high - _low,2)
    _diff_per =  round((_diff * 100) / _low,2)
    
    #printing cols
    print(f"{_symbol.ljust(15)}",end="|")
    print(f"{str(_current).rjust(8)}",end="|")
    print(f"\033[32m{str(_high).rjust(8)}\033[0m",end="|") 
    print(f"\033[31m{str(_low).rjust(8)}\033[0m",end="|")
    print(f"{str(_diff).rjust(8)}",end="|")
    print(f"{str(_diff_per).rjust(8)}",end="|")
    print("")

# symbol = ""

# if len(sys.argv) > 1:
#     symbol = sys.argv[1]
# else:
#     symbol = input("Please the symbol")


_lst = ["ONGC.NS","DABUR.NS","GAIL.NS","IOC.NS","NMDC.NS"]
stocks = yf.Tickers(_lst)




printHeader()

for sKey in _lst:
    stock = stocks.tickers[sKey]
    printSymbolPrice(stock.info)

