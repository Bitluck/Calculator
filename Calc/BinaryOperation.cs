using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
    public interface IBinaryOperation
    {
        double Calculate(double dArg1, double dArg2);
    }
}
