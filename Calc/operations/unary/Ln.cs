using System;

namespace Calc.operations.unary
{
    public class Ln : IOperation
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
