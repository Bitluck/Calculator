namespace Calc.operations.binary
{
    public class Divide : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / secondArgument);
        }
    }
}
