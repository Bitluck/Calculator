namespace Calc.operations.binary
{
    public class Sum : IBinaryOperation
    {
        /// <summary>
        /// Function of addition
        /// </summary>
        /// <param name="firstArgument">
        /// The second received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The result of addition
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument);
        }
    }
}