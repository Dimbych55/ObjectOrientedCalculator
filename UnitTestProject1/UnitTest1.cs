using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class OperationscalculateTests
    {
        [TestMethod]
        public void Sum_1and2_3returned()
        {
            double a = 1, b = 2;
            double expected = 3;
            Operationscalculate c = new Operationscalculate();
            double actual = c.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
