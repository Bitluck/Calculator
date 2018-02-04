using System;

namespace Calc.operations.binary
{
    public class Max : IBinaryOperation
    {
        /// <summary>
        /// Function of finding the largest number
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The largest number from received numbers
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
