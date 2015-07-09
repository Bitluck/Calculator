using System;

namespace Calc.operations.unary
{
    public class Ctg : IOperation
    {
        /// <summary>
        /// Function of finding arccotangens of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Arccotangens of number
        /// </returns>
        public double Calculate(double argument)
        {
            return 1.0/Math.Tan(argument);
        }
    }
}
