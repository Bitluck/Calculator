namespace Calc.operations.binary
{
    public class Difference : IBinaryOperation
    {
        /// <summary>
        /// Function of substraction
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The result of substraction
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument - secondArgument);
        }
    }
}
