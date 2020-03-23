using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;
namespace DateTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestDate()
        {
            //Arrange
            DateTime date = DateTime.Parse("01-01-2017");
            DateTime date2 = DateTime.Parse("05-01-2017");
            string expected = "01 - 05.01.2017";
            string result;
            //Act
            result = Program.printDate(date, date2);

            //Assert
            Assert.AreEqual(expected, result,"metod printDate working");
        }
        [TestMethod]
        public void TestFormatDate()
        {
            //Arrange
            var date = "01-01-2017";
            var date2 ="05-01-2017";
            bool result;
            //Act
            result = Program.formatValidation(date, date2);

            //Assert
            Assert.IsTrue( result, "metod formatValidation working");
        }

    }
}
