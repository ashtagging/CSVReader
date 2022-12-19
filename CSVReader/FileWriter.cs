namespace CSVReader
{
    public class FileWriter
    {
        // Example taken from Microsoft Documentation to write C#
        public void WriteCDrive()
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            string filePath = @"C:\Users\alittlewood\Documents\FileSystem\CDriveDirs.txt";
            string csvFilePath = @"C:\Users\alittlewood\Documents\FileSystem\CDriveDirs.csv";        

            //If the file already exists, delete the file
            if (File.Exists(csvFilePath))
            {
                File.Delete(csvFilePath);
            }

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the new file in the Console
            string line = "";
            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
