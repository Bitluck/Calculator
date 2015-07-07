using System;

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