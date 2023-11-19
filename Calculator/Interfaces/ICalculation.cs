using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ICalculation
    {
        double Multiple (double x, double y);
        double Divide (double x, double y);
        double Add (double x, double y);
        double Substract (double x, double y);

    }
    class Calculation : ICalculation
    {
        double ICalculation.Add(double x, double y)
        {
            return x+y;
        }

        double ICalculation.Divide(double x, double y)
        {
            return x/y;
        }

        double ICalculation.Multiple(double x, double y)
        {
            return x*y;
        }

        double ICalculation.Substract(double x, double y)
        {
            return x-y;
        }
    }
}
