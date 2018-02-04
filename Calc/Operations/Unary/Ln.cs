using System;

namespace Calc.operations.unary
{
    public class Ln : IOperation
    {
        /// <summary>
        /// Function of finding natural logarithm of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Natural logarithm of number
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
