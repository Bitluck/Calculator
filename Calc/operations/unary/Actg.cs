﻿using System;

namespace Calc.operations.unary
{
    public class Actg : IOperation
    {
        public double Calculate(double argument)
        {
            return 1.0 / Math.Atan(argument);
        }
    }
}