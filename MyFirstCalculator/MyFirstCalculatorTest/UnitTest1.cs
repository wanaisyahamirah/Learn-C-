using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        MyFirstCalculator.CalculatorFunction obj = new MyFirstCalculator.CalculatorFunction();

        [TestMethod]
        public void TestSummation()
        {

            //Arrange
            double expected = 10;
            double num1 = 5;
            double num2 = 5;
            double actual_result = 0;

            //Act
            actual_result = obj.FindSummation(num1, num2);

            //Assert
            Assert.IsTrue(expected == actual_result);
        }

        [TestMethod]
        public void TestDifference()
        {

            //Arrange
            double expected = 0;
            double num1 = 5;
            double num2 = 5;
            double actual_result = 0;

            //Act
            actual_result = obj.FindDifference(num1, num2);

            //Assert
            Assert.IsTrue(expected == actual_result);
        }

        [TestMethod]
        public void TestMultiplication()
        {

            //Arrange
            double expected = 25;
            double num1 = 5;
            double num2 = 5;
            double actual_result = 0;

            //Act
            actual_result = obj.FindMultiplication(num1, num2);

            //Assert
            Assert.IsTrue(expected == actual_result);
        }

        [TestMethod]
        public void TestDivision()
        {

            //Arrange
            double expected = 1;
            double num1 = 5;
            double num2 = 5;
            double actual_result = 0;

            //Act
            actual_result = obj.FindDivision(num1, num2);

            //Assert
            Assert.IsTrue(expected == actual_result);
        }


    }
}
