using CsvHelper;
using System.Globalization;

string rootPath = @"C:\Users\alittlewood\Documents\FileSystem";

///////////* Directory & Fodler Section */////////////

//public static string[] GetDirectories(string path, string searchPattern, System.IO.SearchOption searchOption);

//Prints to the Console the file path of each folder within the specified folder
//string[] directories = Directory.GetDirectories(rootPath);

//Prints to the Console the File paths of all fodlers within the file path, not just top directories
string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

foreach (string d in directories)
{
    //Console.WriteLine(d);
}

////////////* File Section */////////////

// ...All Files within the top Directory Only: Use SearchOption.AllDirectories for all Directories
var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

foreach (string file in files)
{
    // All Files within Specified Directory
    //Console.WriteLine(file);

    // File Names Only
    //Console.WriteLine(Path.GetFileName(file));

    // File Names Only without Extensions
    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));

    // Full File Path 
    //Console.WriteLine(Path.GetFullPath(file));

    // Get Directory Names
    //Console.WriteLine(Path.GetDirectoryName(file));

    // Size of the each file in bytes (info.Length)
    //var info = new FileInfo(file);
    //Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} btyes");
}

////////////* File Manipulation Section */////////////

string newDirectory = @"C:\Users\alittlewood\Documents\FileSystem\SubFolder3";

// Verify if a Directory Exists
//bool directoryExists = Directory.Exists(newDirectory);

// Creates the Specified Directory if one doesn't exist
// Directory.CreateDirectory(newDirectory);

//Creates Copies of teh files in one Directory and adds them to another Directory 
string[] fileSelect = Directory.GetFiles(rootPath);
string destinationFolder = @"C:\Users\alittlewood\Documents\FileSystem\SubFolder3";

foreach (string file in fileSelect)
{
    File.Copy(file,@$"{destinationFolder}\{Path.GetFileName(file)}");
}

Console.ReadLine();
