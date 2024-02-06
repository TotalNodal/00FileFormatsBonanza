import json

mydict = {"First Name": "John", "Last Name": "Doe", "Address": "123 Elm St"}

json_object = json.dumps(mydict, indent=4)

with open(r"C:\Users\T580\Documents\GitHub\01aFileFormatsBonanza\python\customerdata.json", "w") as customeroutput:
    customeroutput.write(json_object)