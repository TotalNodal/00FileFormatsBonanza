import csv

with open('C:/Users/T580/Documents/GitHub/01aFileFormatsBonanza/python/customerdata.csv', encoding='utf8') as csv_file:
    customers = csv.DictReader(csv_file)
    for customer in customers:
        print(customer['FirstName'], customer['LastName'], customer['Address'])
        info = [customer['FirstName'], customer['LastName'], customer['Address']]
        with open('C:/Users/T580/Documents/GitHub/01aFileFormatsBonanza/python/customerdata2.csv', mode='a', newline='', encoding='utf8') as csv_file2:
            writer = csv.writer(csv_file2)
            writer.writerow(info)