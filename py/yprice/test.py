import yfinance as yf

# Define the Nifty 50 ticker symbol
#nifty = yf.Ticker("^NSEI")
nifty = yf.Ticker("^NSEI")

# Get live/latest data or fast info
todays_data = nifty.history(period="1d")
print(todays_data[["Open", "High", "Low", "Close"]])

# Or get current price via fast_info / info dictionary
print("Current Price:", nifty.fast_info["lastPrice"])
