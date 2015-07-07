using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Multiply : BinaryOperation
    {
        public override double Calculate(double dArg1, double dArg2)
        {
            return (dArg1 * dArg2);
        }
    }
}
