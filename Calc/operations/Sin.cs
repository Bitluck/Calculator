using System;

namespace Calc
{
    public class Sin : IOperation
    {
        public double Calculate(double argument)
        {
            return (Math.Sin(argument));
        }
    }
}
