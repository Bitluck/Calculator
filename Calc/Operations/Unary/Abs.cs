using System;

namespace Calc.operations.unary
{
    public class Abs : IOperation
    {
        /// <summary>
        /// Function of finding absolute value of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Absolute number
        /// </returns>
        public double Calculate(double argument)
        {
            return (Math.Abs(argument));
        }
    }
}
