using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
    interface IOperation
    {
        public abstract double Calculate(double dArg);
    }
}
