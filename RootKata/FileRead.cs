using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RootKata
{
    class FileRead
    {
        public static List<string> ReadFile(string fileName)
        {

            //this is hardcoded for now for ease of manual testing
            //TODO replace with flexible input after manual testing completed
            string directory = @"C:\RootKata";
            //string filename = "input.txt";


            string fullPath = Path.Combine(directory, fileName);

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
                            if (line.StartsWith("Driver"))
                            {
                                string driverName = Driver.DriverWork(line);
                                List<double> defaultList = new List<double>
                                {
                                    0,// Miles
                                    0 // Speed
                                };
                                Program.DriverLog.Add(driverName, defaultList);
                            }
                            else if (line.StartsWith("Trip"))
                            {
                                string driverName = Trip.GetName(line);
                                List<double> trip = Trip.TripWork(line);
                                Organize.DoTheOrganization(driverName, trip);
                            }
                            else
                                throw new IOException("Unknown commands in File");
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
