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

// Need to add line to change blanks to 0 so that it can be added to the correct data type,
// or make string and then add fucntionality for if string "" => change to string "0" then ToINT

/// <summary>
///  change all to strings and see which ones are a problem (get it working with strings first) (dynamic vs MorrisonsData class)
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
    //[Name("R_STORE_STOCK_VOLUME")]
    //public int StoreStockVolume { get; set; }
    //[Name("R_STORE_STOCKED")]
    //public int StoreStocked { get; set; }
    //[Name("R_STORE_RANGED")]
    //public int StoreRanged { get; set; }

    //[Name("A_RETAILER_NAME")]
    //public string RetailerName { get; set; }
    //[Name("R_STORE_CODE")]
    //public string StoreCode { get; set; }
    //[Name("R_STORE_NAME")]
    //public string StoreName { get; set; }
    //[Name("R_DATE")]
    //public string Date { get; set; }
    //[Name("R_SKU")]
    //public string SKU { get; set; }
    //[Name("S_PRODUCT_DESCRIPTION")]
    //public string ProductDescription { get; set; }
    //[Name("R_SALES_VOLUME")]
    //public string SalesVolume { get; set; }
    //[Name("R_SALES_VALUE")]
    //public string SalesValue { get; set; }
    [Name("R_STORE_STOCK_VOLUME")]
    public string StoreStockVolume { get; set; }
    [Name("R_STORE_STOCKED")]
    public string StoreStocked { get; set; }
    [Name("R_STORE_RANGED")]
    public string StoreRanged { get; set; }
}

