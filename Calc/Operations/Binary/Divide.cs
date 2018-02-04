namespace Calc.operations.binary
{
    public class Divide : IBinaryOperation
    {
        /// <summary>
        /// Function of division
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The result of division
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / secondArgument);
        }
    }
}
