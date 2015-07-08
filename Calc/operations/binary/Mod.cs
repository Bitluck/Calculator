using System;

namespace Calc.operations.binary
{
    public class Mod : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}
