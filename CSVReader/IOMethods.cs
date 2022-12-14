using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace CSVReader
{
    public class IOMethods
    {
        string rootPath = @"C:\Users\alittlewood\Documents\FileSystem";

        ////////////* Directory Section */////////////
        public void DirectoryMethods()
        {
            //public static string[] GetDirectories(string path, string searchPattern, System.IO.SearchOption searchOption);

            //Prints to the Console the file path of each folder within the specified folder
            //string[] directories = Directory.GetDirectories(rootPath);

            //Prints to the Console the File paths of all fodlers within the file path, not just top directories
            string[] directories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            foreach(string d in directories)
            {
                Console.WriteLine(d);
            }
        }

        ////////////* File Section */////////////
        public void FileMethods()
        {
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
        }

        ////////////* File Manipulation Section */////////////
        public void ManipulationMethods()
        {
            string newDirectory = @"C:\Users\alittlewood\Documents\FileSystem\SubFolder3";

            // Verify if a Directory Exists
            //bool directoryExists = Directory.Exists(newDirectory);

            // Creates the Specified Directory if one doesn't exist
            // Directory.CreateDirectory(newDirectory);

            ///// Copying Files /////

            // Creates Copies of the files in one Directory and adds them to another Directory 
            string[] fileSelect = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\Users\alittlewood\Documents\FileSystem\SubFolder3";

            //foreach (string file in fileSelect)
            //{
            //    // the true at the end allows for overites if the file name already exists 
            //    File.Copy(file, @$"{destinationFolder}\{Path.GetFileName(file)}", true);
            //}

            //Copying from One Location to another and remanming the file (Be careful using this with file extensions 
            //for(int i = 0; i<files.Length; i++)
            //{
            //    File.Copy(files[i], @$"{destinationFolder}\{i}.txt", true);
            //}

            ///// Moving Files /////

            //foreach (string file in fileSelect)
            //{
            //    File.Move(file, @$"{destinationFolder}\{Path.GetFileName(file)}");
            //}

        }
    }
}

