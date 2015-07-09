namespace Calc.operations.binary
{
    public class DecimalDivide : IBinaryOperation
    {
        /// <summary>
        /// Function of decimal dividing
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The result of decimal dividing
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {  
            return (double)((int)firstArgument/(int)secondArgument);
        }
    }
}
