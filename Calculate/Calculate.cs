using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public interface Calculate
    {
        double Sum(double a, double b);
        double razn(double a, double b);
        double umnog(double a, double b);
        double del(double a, double b);
        double step(double a, double b);
        double square(double a);
    }
}
