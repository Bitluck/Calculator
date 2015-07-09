using System;

namespace Calc.operations.unary
{
    public class aCos : IOperation
    {
        /// <summary>
        /// Function of finding arccosinus of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Arccosinus of number
        /// </returns>
        public double Calculate(double argument)
        {
            return (Math.Acos(argument));
        }
    }
}
