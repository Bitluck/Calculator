namespace Calc
{
    class Multiply : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * secondArgument);
        }
    }
}
