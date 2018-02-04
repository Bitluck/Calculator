namespace Calc.operations.binary
{
    public class Multiply : IBinaryOperation
    {
        /// <summary>
        /// Function of multiplication
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// Composition of received numbers
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument);
        }
    }
}
