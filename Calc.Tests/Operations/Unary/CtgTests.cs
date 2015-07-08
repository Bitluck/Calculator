using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class CtgTests
    {
        [TestCase(Math.PI / 2.0, 0)]
        [TestCase(Math.PI / 4.0, 1)]
        public void CtgTest(double argument, double result)
        {
            var calculator = new Ctg();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult, 0.1);
        }
    }
}
