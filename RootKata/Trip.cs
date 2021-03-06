﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RootKata
{
    public class Trip
    {
        public static List<string> Split(string lineToSplit)
        {
            //split a line using " " as delimiter
            //TODO consider whether a Helper class should be created for methods like this (DRY)
            List<string> finishedLine = lineToSplit.Split(" ").ToList();
            return finishedLine;
        }

        public static TimeSpan GetDuration(List<string> splitLine)
        {
            //end time - start time = total time
            DateTime startTime = Convert.ToDateTime(splitLine[2]);
            DateTime endTime = Convert.ToDateTime(splitLine[3]);
            TimeSpan totalTime = endTime - startTime;
            return totalTime;
        }

        public static double GetMiles(List<string> splitLine)
        {
            //distance/time = mph
            double miles = Convert.ToDouble(splitLine[4]);
            return miles;
        }

        public static double GetMph(List<string> splitLine)
        {
            //distance/time = mph
            TimeSpan duration = GetDuration(splitLine);
            double miles = GetMiles(splitLine);
            double milesPerHour = miles / duration.TotalHours;
            return milesPerHour;
        }
        public static string GetName(List<string> splitLine)
        {
            //an element of the split line will be the Driver's name: this method returns that element
            string name = splitLine[1];
            return name;
        }
        public static string GetName(string line)
        {
            return GetName(Split(line));
        }
        public static double Time(TimeSpan time)
        {
            return time.TotalMinutes/60;
        }
        public static List<double> TripWork(string line)
        {
            List<double> distanceAndSpeed = new List<double>();
            List<String> result = new List<string>(Split(line));
            //GetDuration(result);
            double speed = GetMph(result);
            
            if (speed <100 && speed >5)
            {
                distanceAndSpeed.Add(GetMiles(result));
                distanceAndSpeed.Add(Time(GetDuration(result)));
            }
            return distanceAndSpeed;
        }
    }
}
