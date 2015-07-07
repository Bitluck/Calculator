namespace Calc
{
    class Sum : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument);
        }
    }
}