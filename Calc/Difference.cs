﻿namespace Calc
{
    class Difference : IBinaryOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument - secondArgument);
        }
    }
}
