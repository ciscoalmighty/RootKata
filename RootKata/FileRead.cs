using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RootKata
{
    class FileRead
    {
        public static List<string> ReadFile()
        {
            //this is hardcoded for now for ease of manual testing
            //TODO replace with flexible input after manual testing completed
            string directory = "c:\\RootKata";
            string filename = "input.txt";

            string fullPath = Path.Combine(directory, filename);

            List<string> allLines = new List<string>();
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();

                        if (line != "")
                        {
                            allLines.Add(line);
                        }
                    }
                }
            }
            
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            return allLines;
        }
    }
}
