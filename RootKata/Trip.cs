using System;
using System.Collections.Generic;
using System.Text;

namespace RootKata
{
    class Trip
    {
        private List<string> Split(string lineToSplit)
        {
            //split a line using " " as delimiter
            //TODO consider whether a Helper class should be created for methods like this (DRY)
            return new List<string>();
        }

        private double GetDuration(List<string> splitLine)
        {
            //end time - start time = total time
            return 0;
        }

        private double GetMph(List<string> splitLine)
        {
            //distance/time = mph
            return 0;
        }

        public List<double> TripWork(string line)
        {
            //calls all relevant methods within this class for outside use
            //call Split
            //call GetDuration
            //call GetMph
            //if mph is >100 || <5, disregard that trip
            return new List<double>();
        }
    }
}
