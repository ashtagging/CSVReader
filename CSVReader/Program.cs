using CsvHelper;
using System.Globalization;

string rootPath = @"C:\Users\alittlewood\Documents\FileSystem";

//public static string[] GetDirectories(string path, string searchPattern, System.IO.SearchOption searchOption);

//Prints to the Console the file path of each folder within the specified folder
//string[] directories = Directory.GetDirectories(rootPath);

//foreach (string d in directories)
//{
//    Console.WriteLine(d);
//}

//Prints to the Console the File paths of all fodlers within the file path, not just top directories
string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

foreach (string d in directories)
{
    Console.WriteLine(d);
}



