using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RootKata;

namespace RootKataTests
{
    [TestClass]
    public class TripTests
    {
        [TestMethod]
        public void SplitTest()
        {
            //Arrange
            string testLineToSplit = "Trip Dan 07:15 07:45 17.3";
            //Act
            List<string> result = Trip.Split(testLineToSplit);
            //Assert
            Assert.AreEqual("Trip", result[0]);
            Assert.AreEqual("Dan", result[1]);
        }
        [TestMethod]
        public void GetDurationTest()
        {
            //Arrange
            List<string> testLineToSplit = new List<string>()
            {
                "Trip",
                "Dan",
                "07:15",
                "07:45",
                "17.3"
            };
            //Act
            TimeSpan result = Trip.GetDuration(testLineToSplit);
            //Assert
            Assert.AreEqual(30, result.TotalMinutes);
        }
        [TestMethod]
        public void GetMilesTest()
        {
            //Arrange
            List<string> testLineToSplit = new List<string>()
            {
                "Trip",
                "Dan",
                "07:15",
                "07:45",
                "17.3"
            };
            //Act
            double result = Trip.GetMiles(testLineToSplit);
            //Assert    
            Assert.AreEqual(17.3, result);
        }
        [TestMethod]
        public void GetMphTest()
        {
            //Arrange
            List<string> testLineToSplit = new List<string>()
            {
                "Trip",
                "Dan",
                "07:15",
                "07:45",
                "17.3"
            };
            //Act
            double result = Trip.GetMph(testLineToSplit);
            //Assert
            Assert.AreEqual(34.6, result);
        }
        [TestMethod]
        public void TripWorkTest()
        {
            //Arrange
            string testLineToSplit = "Trip Dan 07:15 07:45 17.3";
            //Act
            List<string> result = Driver.Split(testLineToSplit);
            //Assert
            Assert.AreEqual("Dan", result[1]);
        }

    }
}
