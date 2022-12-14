using CsvHelper;
using System.Globalization;
using CSVReader;

void PrintLines()
{
    using (var streamReader = new StreamReader(@"C:\Users\alittlewood\Documents\FileSystem\PG_M_20221211.csv"))
    {
        string line;
        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}

PrintLines();

Console.ReadLine();

