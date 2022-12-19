namespace CSVReader
{
    public class StreamReaderCSV
    {
        public static void OriginalDataScript()
        {
            string csvPath = @"C:\Users\alittlewood\Documents\FileSystem\PG_M_20221211.csv";
            List<string> lines = new List<string>();

            try
            {
                if (File.Exists(csvPath))
                {
                    using (StreamReader sr = new StreamReader(csvPath))
                    {
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

                    using (StreamWriter sw = new StreamWriter(csvPath, false))
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
        }
    }
}
