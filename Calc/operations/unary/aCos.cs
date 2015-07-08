using System;

namespace Calc.operations.unary
{
    public class aCos : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Acos(argument));
        }
    }
}
