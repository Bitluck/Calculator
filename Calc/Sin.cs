using System;

namespace Calc
{
    class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Sin(argument));
        }
    }
}
