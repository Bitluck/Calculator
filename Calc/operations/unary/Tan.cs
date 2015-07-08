using System;

namespace Calc.operations.unary
{
    public class Tan : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
