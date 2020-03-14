using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RootKata
{
    public class Driver
    {
        public static List<string> Split(string lineToSplit)
        {
            //split a line using " " as delimiter
            List<string> finishedLine = lineToSplit.Split(" ").ToList();
            return finishedLine;
        }

        public static string GetName(List<string> splitLine)
        {
            //an element of the split line will be the Driver's name: this method returns that element
            string name = splitLine[1];
            return name;
        }

        public static string DriverWork(string line)
        {
            //calls all relevant methods within this class for outside use
            string name = GetName(Split(line));
            return name;
        }
    }
}
