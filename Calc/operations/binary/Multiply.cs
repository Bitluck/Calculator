namespace Calc.operations.binary
{
    public class Multiply : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument);
        }
    }
}
