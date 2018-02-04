using System;

namespace Calc.operations.binary
{
    public class Log : IBinaryOperation
    {
        /// <summary>
        /// Function of calculation of logarithm of number
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument - Number
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument - Logarithm base
        /// </param>
        /// <returns>
        /// Logarithm of received number
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
