using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;

namespace UnitTestProject5
{
    [TestClass]
    public class OperationsCalculate
    {
        [TestMethod]
        public void step_3and4_81returned()
        {
            double a = 3, b = 4;
            double expected = 81;
            Operationscalculate c = new Operationscalculate();
            double actual = c.step(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
