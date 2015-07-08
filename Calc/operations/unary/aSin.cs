using System;

namespace Calc.operations.unary
{
    public class aSin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Asin(argument);
        }
    }
}
