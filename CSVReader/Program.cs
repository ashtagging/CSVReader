using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

string inputFilePath = @"C:\Users\alittlewood\Documents\FileSystem\PG_M_20221211.csv";
string outputPath = @"C:\Users\alittlewood\Documents\FileSystem\output.csv";
List<string> lines = new List<string>();
List<string> header = new List<string>();

//Read in header check if the header compare header array with file and use that index position from header array instead of assuming column header position.
//Doesn't take into account double quotes -  look at textfieldParser
//string.Format

try
{
    if (File.Exists(inputFilePath))
    {
        using (StreamReader sr = new StreamReader(inputFilePath))
        {
            if (header.Count() == 0)
            {
                string headerLine = sr.ReadLine();
                header = headerLine.Split(',').ToList();            
            }

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] split = line.Split(",");

                if (string.IsNullOrEmpty(split[6]))
                {
                    split[6] = "0";
                }
                if (string.IsNullOrEmpty(split[7]))
                {
                    split[7] = "0";
                }
                if (string.IsNullOrEmpty(split[8]))
                {
                    split[8] = "0";
                }
                if (split[9] == "0")
                {
                    split[9] = "FALSE";
                }
                if (split[9] == "1")
                {
                    split[9] = "TRUE";
                }
                if (split[10] == "0")
                {
                    split[10] = "FALSE";                  
                }
                if (split[10] == "1")
                {
                    split[10] = "TRUE";                  
                }
                line = String.Join(",", split);
                lines.Add(line);
            }        
        }

        using (StreamWriter sw = new StreamWriter(outputPath, false))
        {
            foreach (String line in lines)
            {
                sw.WriteLine(line);
            }       
        }
    }
    Console.WriteLine("Script Successful");
}
catch (Exception ex)
{
    Console.WriteLine("Error with Request");
    Console.WriteLine(ex.Message);
}

//Console.ReadLine();

//using (var streamReader = new StreamReader(csvPath))
//{
//    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
//    {
//        var records = csvReader.GetRecords<MorrisonsData>().ToList();
//        Console.WriteLine(records.Count);
//    }
//}

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
    //[Name("R_SALES_VOLUME")]
    //public int SalesVolume { get; set; }
    //[Name("R_SALES_VALUE")]
    //public double SalesValue { get; set; }
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
    [Name("R_SALES_VOLUME")]
    public string SalesVolume { get; set; }
    [Name("R_SALES_VALUE")]
    public string SalesValue { get; set; }
    [Name("R_STORE_STOCK_VOLUME")]
    public string StoreStockVolume { get; set; }
    [Name("R_STORE_STOCKED")]
    public string StoreStocked { get; set; }
    [Name("R_STORE_RANGED")]
    public string StoreRanged { get; set; }
}

