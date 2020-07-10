using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;

namespace UnitTestProject2
{
    [TestClass]
    public class OperationsCalculate
    {
        [TestMethod]
        public void razn_5and3_2returned()
        {
            double a = 5, b = 3;
            double expected = 2;
            Operationscalculate c = new Operationscalculate();
            double actual = c.razn(a, b);
            Assert.AreEqual(expected, actual);

        }
    }
}
