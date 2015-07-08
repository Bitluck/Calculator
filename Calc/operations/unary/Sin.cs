using System;

namespace Calc.operations.unary
{
    public class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
