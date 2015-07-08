namespace Calc
{
    public class Sum : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument);
        }
    }
}