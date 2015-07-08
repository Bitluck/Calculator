using System;

namespace Calc.operations.unary
{
    public class Ctg : IOperation
    {
        public double Calculate(double argument)
        {
            return 1.0/Math.Tan(argument);
        }
    }
}
