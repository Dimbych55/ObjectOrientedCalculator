using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitProjectlibrary
{
    public class Operationscalculate
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double razn(double a, double b)
        {
            return a - b;
        }

        public double umnog(double a, double b)
        {
            return a * b;
        }

        public double del(double a, double b)
        {
            return a / b;
        }

        public double step(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double square(double a)
        {
            return Math.Pow(a, 2);
        }

    }
}