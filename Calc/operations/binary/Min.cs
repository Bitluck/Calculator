using System;

namespace Calc.operations.binary
{
    public class Min : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}
