using System;

namespace Calc.operations.binary
{
    public class Pow : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
