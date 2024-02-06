import json

with open(r"C:\Users\T580\Documents\GitHub\01aFileFormatsBonanza\python\customerdata.json", "r") as customerinput:
    customerdata = json.load(customerinput)

print(customerdata)