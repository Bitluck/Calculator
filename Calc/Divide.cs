namespace Calc
{
    class Divide : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / secondArgument);
        }
    }
}
