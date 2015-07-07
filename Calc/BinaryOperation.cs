using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
    interface IBinaryOperation
    {
        public abstract double Calculate(double dArg1, double dArg2);
    }
}
