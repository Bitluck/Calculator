using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public static class Factory
    {
        public static IOperation CreateCalculate(string calculator)
        {
            switch (calculator)
            {
                case "Sin": return new Sin();
                default: throw new Exception("Unknown Operation!");
            }
        }
    }
}