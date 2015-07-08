using System;
using Calc.operations.binary;

namespace Calc.factories
{
    public static class BinaryFactory
    {
        public static IBinaryOperation CreateBinaryCalculator(string calculator)
        {
            switch (calculator)
            {
                case "Sum": 
                    return new Sum();
                case "Difference":  
                    return new Difference();
                case "Multiply": 
                    return new Multiply();
                case "Divide": 
                    return new Divide();
                case "Pow":
                    return new Pow();
                case "DecimalDivide":
                    return new DecimalDivide();
                case "Mod":
                    return new Mod();
                case "Log":
                    return new Log();
                case "Max":
                    return new Max();
                case "Min":
                    return new Min();
                default: throw new Exception("Unknown Operation!");
            }
        }
    }
}