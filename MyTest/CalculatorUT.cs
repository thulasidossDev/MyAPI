using MyAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    [TestClass]
    public class CalculatorUT
    {
        private ICalculatorService _calculatorService;
        public CalculatorUT()
        {
            _calculatorService = new CalculatorService();
        }

        [TestMethod]
        public void AddWithPass()
        {
            int actual = 5;
            int expected = _calculatorService.Add(3, 2);
            Assert.AreEqual(actual, expected);
        }
        //[TestMethod]
        //public void AddWithFail()
        //{
        //    int actual = 5;
        //    int expected = _calculatorService.Add(3, 3);
        //    Assert.AreEqual(actual, expected);
        //}

        [TestMethod]
        public void MultiplyWithPass()
        {
            int actual = 80;
            int expected = _calculatorService.Multiply(20, 4);
            Assert.AreEqual(actual, expected);
        }
    }
}
