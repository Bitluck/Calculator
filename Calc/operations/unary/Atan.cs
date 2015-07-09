using System;

namespace Calc.operations.unary
{
    public class Atan : IOperation
    {
        /// <summary>
        /// Function of finding arctangens of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Arctangens of number
        /// </returns>
        public double Calculate(double argument)
        {
            return (Math.Atan(argument));
        }
    }
}
