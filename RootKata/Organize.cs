using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RootKata
{
    public class Organize
    {
        public static void DoTheOrganization(string driverName, List<double> newTrip)
        {
            //add that trip information to the dictionary too, as a value associated with its driver name
            //if trip information already exists as a value, add trip infos together
            List<double> currentTrip = new List<double>();
            List<double> totalTrip = new List<double>();
            if (Program.DriverLog.ContainsKey(driverName))
            {
                Program.DriverLog.TryGetValue(driverName, out currentTrip);
                totalTrip.Add(currentTrip[0] + newTrip[0]);
                totalTrip.Add(currentTrip[1] + newTrip[1]);
                Program.DriverLog.Remove(driverName);
                Program.DriverLog.Add(driverName, totalTrip);

            }
            else
                throw new Exception("You tried to add a log without first defining a driver.");


        }

        public static IOrderedEnumerable<KeyValuePair<string, List<double>>> SortedDictionary(Dictionary<string, List<double>> DriverLog)
        {
            //sorts Dictionary based on total distance driven
            //this version of the Dictionary is what we will pass to FileWriter to make our report
            return from entry in DriverLog orderby entry.Value[0] descending select entry;
        }
    }
}
