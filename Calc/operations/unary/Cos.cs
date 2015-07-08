using System;

namespace Calc.operations.unary
{
    public class Cos : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Cos(argument));
        }
    }
}
