using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitProjectlibrary;
namespace UnitTestProject4
{
    [TestClass]
    public class OperationsCalculate
    {
        [TestMethod]
        public void del_24and3_8returned()
        {
            double a = 24, b = 3;
            double expected = 8;
            Operationscalculate c = new Operationscalculate();
            double actual = c.del(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
