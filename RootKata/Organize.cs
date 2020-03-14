using System;
using System.Collections.Generic;
using System.Text;

namespace RootKata
{
    class Organize
    {
        public Dictionary<string, List<double>> DoTheOrganization()
        {
            //for each line in allLines (from FileReader)
            //check the first element:
            //if it's Driver, do DriverWork
            //Add driver's name to be a key in the Dictionary
            //if it's Trip, do TripWork
            //add that trip information to the dictionary too, as a value associated with its driver name
            //if trip information already exists as a value, add trip infos together
            return new Dictionary<string, List<double>>();
        }

        public List<double> AddTripInfos(List<double> existingTripInfo, List<double> newTripInfo)
        {
            //adds to value in dictionary if something is present already
            //add distances together
            //add mphs together and average them
            return new List<double>();
        }

        public Dictionary<string,List<double>> SortedDictionary()
        {
            //sorts Dictionary based on total distance driven
            //this version of the Dictionary is what we will pass to FileWriter to make our report
            return new Dictionary<string, List<double>>();
        }
    }
}
