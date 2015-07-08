using System;

namespace Calc.operations.unary
{
    public class Atan : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Atan(argument));
        }
    }
}
