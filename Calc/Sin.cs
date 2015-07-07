using System;

namespace Calc
{
    class Sin : IOperation
    {
        public double Calculate(double dArg)
        {
            return (Math.Sin(dArg));
        }
    }
}
