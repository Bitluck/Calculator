using System;

namespace Calc.operations.unary
{
    public class aSin : IOperation
    {
        /// <summary>
        /// Function of finding arcsinus of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Arcsinus of number
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Asin(argument);
        }
    }
}
