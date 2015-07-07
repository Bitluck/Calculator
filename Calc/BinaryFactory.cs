using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public static class BinaryFactory
    {
        public static IBinaryOperation CreateBinaryCalculate(string calculator)
        {
            switch (calculator)
            {
                case "Sum": return new Difference();
                case "Difference": return new Difference();
                case "Multiply": return new Multiply();
                case "Divide": return new Divide();
                default: throw new Exception("Unknown Operation!");
            }
        }
    }
}