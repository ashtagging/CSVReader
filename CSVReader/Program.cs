using CsvHelper;
using System.Globalization;

using (var streamReader = new StreamReader(@"C:\Users\alittlewood\Documents\FileSystem\PG_M_20221211.csv"))
{
    using(var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
    {
        var records = csvReader.GetRecords<dynamic>().ToList();
        Console.WriteLine(records.Count); 
    }
}

public class MorrisonsData
{
    public string RetailerName { get; set; }
    public int StoreCode { get; set; }
    public string StoreName { get; set; }
    public DateTime Date { get; set; }
    public int SKU { get; set; }
    public string ProductDescription { get; set; }
    public int SalesVolume { get; set; }
    public double SalesValue { get; set; }
    public int StoreStockVolume { get; set; }
    public int StoreStocked { get; set; }
    public int StoreRanged { get; set; }
}

Console.ReadLine();

