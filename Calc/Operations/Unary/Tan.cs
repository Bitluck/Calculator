using System;

namespace Calc.operations.unary
{
    public class Tan : IOperation
    {
        /// <summary>
        /// Function of finding tangens of number
        /// </summary>
        /// <param name="argument">
        /// Received argument
        /// </param>
        /// <returns>
        /// Tangens of number
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
