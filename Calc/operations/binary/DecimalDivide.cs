namespace Calc.operations.binary
{
    public class DecimalDivide : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {  
            return (double)((int)firstArgument/(int)secondArgument);
        }
    }
}
