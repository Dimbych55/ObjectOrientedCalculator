using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;

namespace UnitTestProject6
{
    [TestClass]
    public class OperationsCalculate
    {
        [TestMethod]
        public void square_4_16returned()
        {
            double a = 4;
            double expected = 16;
            Operationscalculate c = new Operationscalculate();
            double actual = c.square(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
