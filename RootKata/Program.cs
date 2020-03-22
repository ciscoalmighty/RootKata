using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;

namespace RootKata
{
    class Program
    {
        public static Dictionary<String, List<double>> DriverLog = new Dictionary<String, List<double>>();
        public static void Main(string[] args ) 
        {
           
            Console.WriteLine("hi");
            if (args.Length == 1)
            {
                string inputFile = args[0];
                FileRead FileRead = new FileRead();
                List<string> commands = FileRead.ReadFile(inputFile);
                var sortedDict = Organize.SortedDictionary(DriverLog);
                FileWriter.Writer(sortedDict);
            }
            else
            {
                Console.WriteLine("Enter an input file!");
            }


        }
    }
}
