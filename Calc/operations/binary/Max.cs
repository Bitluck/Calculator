using System;

namespace Calc.operations.binary
{
    public class Max : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
