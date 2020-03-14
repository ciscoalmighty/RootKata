using Microsoft.VisualStudio.TestTools.UnitTesting;
using RootKata;
using System.Collections.Generic;

namespace RootKataTests
{
    [TestClass]
    public class DriverTests
    {
        [TestMethod]
        public void SplitTest()
        {
            //Arrange
            string testLineToSplit = "Driver Dan";
            //Act
            List<string> result = Driver.Split(testLineToSplit);
            //Assert
            Assert.AreEqual("Dan", result[1]);
        }

        [TestMethod]
        public void GetNameTest()
        {
            //Arrange
            List<string> testSplitList = new List<string>()
            {
                "List",
                "of",
                "strings"
            };

            //Act
            //new string result;
            string result = Driver.GetName(testSplitList);

            //Assert
            Assert.AreEqual("of", result);
        }

        [TestMethod]
        public void DriverWorkTest()
        {
            //Arrange
            string testLine = "Driver Dan";
            //Act
            string result = Driver.DriverWork(testLine);
            //Assert
            Assert.AreEqual("Dan", result);
        }
    }
}
