using System;
using Calc.operations.binary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Binary
{
    class DecimalDivideTests
    {
        [TestCase(42, 13, 3)]
        [TestCase(5, -2, -2)]
        [TestCase(2, 3, 0)]
        public void DecimalDivideTest(double firstArgument, double secondArgument, Int32 result)
        {
            var calculator = new DecimalDivide();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
