namespace Calc.operations.binary
{
    public class Difference : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument - secondArgument);
        }
    }
}
