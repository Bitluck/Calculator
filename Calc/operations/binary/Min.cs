using System;

namespace Calc.operations.binary
{
    public class Min : IBinaryOperation
    {
        /// <summary>
        /// Function of finding the smallesr number
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The smallest number from received numbers
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}
