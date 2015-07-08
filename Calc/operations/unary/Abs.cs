using System;

namespace Calc.operations.unary
{
    public class Abs : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Abs(argument));
        }
    }
}
