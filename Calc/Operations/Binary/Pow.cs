using System;

namespace Calc.operations.binary
{
    public class Pow : IBinaryOperation
    {
        /// <summary>
        /// Fuction raising to a power
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument - Number
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument - Power
        /// </param>
        /// <returns>
        /// The number raised to a power
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
