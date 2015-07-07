using System;

namespace Calc
{
    public static class BinaryFactory
    {
        public static IBinaryOperation CreateBinaryCalculate(string calculator)
        {
            switch (calculator)
            {
                case "Sum": case "+": return new Sum();
                case "Difference": case "-": return new Difference();
                case "Multiply": case "*": return new Multiply();
                case "Divide": case"/": return new Divide();
                default: throw new Exception("Unknown Operation!");
            }
        }
    }
}