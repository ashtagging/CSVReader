using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

string csvPath = @"C:\Users\alittlewood\Documents\FileSystem\PG_M_20221211.csv";

using (var streamReader = new StreamReader(csvPath))
{
    using(var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
    {
        var records = csvReader.GetRecords<MorrisonsData>().ToList();
        Console.WriteLine(records.Count); 
    }
}

Console.ReadLine();


/// <summary>
///  change all to strings and see which ones are a problem (get it working with strings first)
/// </summary>

public class MorrisonsData
{
    [Name("A_RETAILER_NAME")]
    public string RetailerName { get; set; }
    [Name("R_STORE_CODE")]
    public int StoreCode { get; set; }
    [Name("R_STORE_NAME")]
    public string StoreName { get; set; }
    [Name("R_DATE")]
    public DateTime Date { get; set; }
    [Name("R_SKU")]
    public int SKU { get; set; }
    [Name("S_PRODUCT_DESCRIPTION")]
    public string ProductDescription { get; set; }
    [Name("R_SALES_VOLUME")]
    public int SalesVolume { get; set; }
    [Name("R_SALES_VALUE")]
    public double SalesValue { get; set; }
    [Name("R_STORE_STOCK_VOLUME")]
    public int StoreStockVolume { get; set; }
    [Name("R_STORE_STOCKED")]
    public int StoreStocked { get; set; }
    [Name("R_STORE_RANGED")]
    public int StoreRanged { get; set; }
}

