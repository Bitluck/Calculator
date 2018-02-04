namespace Calc.operations.binary
{
    public class Mod : IBinaryOperation
    {
        /// <summary>
        /// Function of finding the remainder of the division
        /// </summary>
        /// <param name="firstArgument">
        /// The first received argument
        /// </param>
        /// <param name="secondArgument">
        /// The second received argument
        /// </param>
        /// <returns>
        /// The remainder of dividing received numbers
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}
