using System;
using Calc.operations.unary;

namespace Calc.factories
{
    public static class Factory
    {
        public static IOperation CreateCalculator(string calculator)
        {
            switch (calculator)
            {
                case "Sin": 
                    return new Sin();
                case "Asin":
                    return new aSin();
                case "Cos":
                    return new Cos();
                case "Acos":
                    return new aCos();
                case "Tan":
                    return new Tan();
                case "Atan":
                    return new Atan();
                case "Ctg":
                    return new Ctg();
                case "Actg":
                    return new Actg();
                case "Abs":
                    return new Abs();
                case "Ln":
                    return new Ln();

                default: 
                    throw new Exception("Unknown Operation.");
            }
        }
    }
}