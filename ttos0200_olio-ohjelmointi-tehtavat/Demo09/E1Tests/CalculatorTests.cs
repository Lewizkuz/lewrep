using Microsoft.VisualStudio.TestTools.UnitTesting;
using E1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int number1 = 5;
            int number2 = 10;
            int expected = 15;

            int actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            int number1 = 5;
            int number2 = 10;
            int expected = 50;

            int actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }
}