using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;

namespace UnitTestProject3
{
    [TestClass]
    public class OperationsCalculate
    {
        [TestMethod]
        public void umnog_9and7_63returned()
        {
            double a = 9, b = 7;
            double expected = 63;
            Operationscalculate c = new Operationscalculate();
            double actual = c.umnog(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
