# Sample data
data = [
    ["Name", "age", "City"],
    ["Alice", 24, "New York"],
    ["Bob", 19, "Los Angeles"],
    ["Charlie", 32, "Chicago"]
]

# name = "amit jha"
# print(name,end="");

# Print header
print(f"{'Name':<12} {'Age':<6} {'City':<15}")
print("-" * 35)

# Print rows
for row in data:
    print(f"{row[0]:<12} {row[1]:<6} {row[2]:<15}")

