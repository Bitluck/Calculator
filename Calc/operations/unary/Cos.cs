using System;

namespace Calc.operations.unary
{
    public class Cos : IOperation
    {
        /// <summary>
        /// Function of finding cosinus of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Cosinus of number
        /// </returns>
        public double Calculate(double argument)
        {
            return (Math.Cos(argument));
        }
    }
}
