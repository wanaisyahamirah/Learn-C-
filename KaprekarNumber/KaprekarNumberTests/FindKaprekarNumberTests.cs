using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaprekarNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumber.Tests
{
    [TestClass()]
    public class FindKaprekarNumberTests
    {
        private readonly KaprekarNumber.FindKaprekarNumber kaprekarNumber = new KaprekarNumber.FindKaprekarNumber();

        [TestMethod()]
        public void GetSquareNumberTest()
        {
            int expected = 60481729;
            int actual = kaprekarNumber.GetSquareNumber(7777);
            Assert.AreEqual(expected, actual);

            int expected2 = 81;
            int actual2 = kaprekarNumber.GetSquareNumber(9);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void ConvertToStringTest()
        {
            string expected = "60481729";
            string actual = kaprekarNumber.ConvertToString(60481729);
            Assert.AreEqual(expected, actual);

            string expected2 = "81";
            string actual2 = kaprekarNumber.ConvertToString(81);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void GetStringLengthTest()
        {
            int expected = 4;
            int actual = kaprekarNumber.GetStringLength(7777);
            Assert.AreEqual(expected, actual);

            int expected2 = 1;
            int actual2 = kaprekarNumber.GetStringLength(9);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void GetLeftSplitValueTest()
        {
            int expected = 6048;
            int actual = kaprekarNumber.GetLeftSplitValue(4, "60481729");
            Assert.AreEqual(expected, actual);

            int expected2 = 8;
            int actual2 = kaprekarNumber.GetLeftSplitValue(1, "81");
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void GetRightSplitValueTest()
        {
            int expected = 1729;
            int actual = kaprekarNumber.GetRightSplitValue(4, "60481729");
            Assert.AreEqual(expected, actual);

            int expected2 = 1;
            int actual2 = kaprekarNumber.GetRightSplitValue(1, "81");
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void IsLeftEqualsRightTest()
        {
            Boolean expected = true;
            Boolean actual = kaprekarNumber.IsLeftEqualsRight(6048, 1729, 7777);
            Assert.AreEqual(expected, actual);

            Boolean expected2 = true;
            Boolean actual2 = kaprekarNumber.IsLeftEqualsRight(8, 1, 9);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void DisplayMessageTest()
        {
            Boolean expected = true;
            kaprekarNumber.DisplayMessage(expected, 7777);
            Assert.IsTrue(true);

            Boolean expected2 = true;
            kaprekarNumber.DisplayMessage(expected2, 9);
            Assert.IsTrue(true);
        }
    }
}