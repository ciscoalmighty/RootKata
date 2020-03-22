using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace RootKata
{
    class FileWriter
    {
        public static void Writer(IOrderedEnumerable<KeyValuePair<String, List<double>>> DriverLog)
        {
            //recieve a sorted Dictionary from Organize
            //use that Dictionary to send a report
            string outputFile = "Output.txt";


            try
            {
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    foreach (KeyValuePair<string, List<double>> kvp in DriverLog)
                    {
                        if(kvp.Value[0] == 0)
                        {
                            sw.WriteLine(kvp.Key + ": " + kvp.Value[0] + " miles");
                        }
                        else
                            sw.WriteLine(kvp.Key + ": " + Math.Round(kvp.Value[0],0) + " miles @ " + Math.Round(kvp.Value[0] / kvp.Value[1], 0) + " mph");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"{outputFile} has been created.");
        }
    }
}
