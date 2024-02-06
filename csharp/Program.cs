using System;
using Newtonsoft;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var cust = new Customer()
        {
            FirstName = "Josh",
            LastName = "Lewis",
            Address = "123 main st"    
        };

        //seriializing to json
        string json = JsonConvert.SerializeObject(cust, Formatting.Indented);

        System.Console.WriteLine(json);

        

        //deserializing from json
        var filename = @"C:\Users\T580\Documents\GitHub\01aFileFormatsBonanza\csharp\customerdata.json";

        Customer customer2 = JsonConvert.DeserializeObject<Customer>(File.ReadAllText(filename));

        //csv

        string inputFile = @"C:\Users\T580\Documents\GitHub\01aFileFormatsBonanza\csharp\customerdata.csv";
        string outputFile = @"C:\Users\T580\Documents\GitHub\01aFileFormatsBonanza\csharp\customeroutput.csv";
        
        List<Customer> customerOutput = new();

        //deserializing from csv

        using var reader = new StreamReader(inputFile);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var records = csv.GetRecords<Customer>();
       
        foreach (var customer in records)
        {
            customerOutput.Add(customer);
            //Console.WriteLine(customer.FirstName + "," + customer.LastName + "," + customer.Address);
        }

        //serializing from csv
    
        using var writer = new StreamWriter(outputFile);
        using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

        csvWriter.WriteRecords(customerOutput);

        //Console.ReadLine();

    }
}

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

