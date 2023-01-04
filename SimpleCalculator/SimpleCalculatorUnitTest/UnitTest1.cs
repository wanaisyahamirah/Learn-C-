using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Summation()
        {

            //Arrange
            double expected = 5;
            double num1 = 3;
            double num2 = 2;

            //Act
            double actual = SimpleCalculator.Form1.Summation(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Difference()
        {

            //Arrange
            double expected = 1;
            double num1 = 3;
            double num2 = 2;

            //Act
            double actual = SimpleCalculator.Form1.Difference(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiplication()
        {

            //Arrange
            double expected = 6;
            double num1 = 3;
            double num2 = 2;

            //Act
            double actual = SimpleCalculator.Form1.Multiplication(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Division()
        {

            //Arrange
            double expected = 2;
            double num1 = 10;
            double num2 = 5;

            //Act
            double actual = SimpleCalculator.Form1.Division(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
