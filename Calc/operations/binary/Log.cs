using System;

namespace Calc.operations.binary
{
    public class Log : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
