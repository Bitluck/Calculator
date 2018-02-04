using System;

namespace Calc.operations.unary
{
    public class Sin : IOperation
    {
        /// <summary>
        /// Function of finding sinus of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Sinus of number
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
