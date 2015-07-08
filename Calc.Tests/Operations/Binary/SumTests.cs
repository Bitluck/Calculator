using System;
using Calc.operations.binary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Binary
{
    public class SumTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(5, -2, 3)]
        [TestCase(0, 19, 19)]
        public void SumTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Sum();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
