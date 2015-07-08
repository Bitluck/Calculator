using System;
using NUnit.Framework;
using Calc.operations.binary;
using Calc.operations.unary;

namespace Calc.Tests
{
    [TestFixture]
    public class CalcTess
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

        [TestCase(4, 2, 2)]
        [TestCase(5, -10, 15)]
        [TestCase(0, -2, 2)]
        public void DifferenceTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Difference();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }

        [TestCase(-1, 2, -2)]
        [TestCase(5, -2, -10)]
        [TestCase(0, 29, 0)]
        public void MultiplyTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiply();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }

        [TestCase(1, 2, 0.5)]
        [TestCase(10, -2, -5)]
        [TestCase(18, 0, double.PositiveInfinity)]
        public void DivideTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Divide();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
















        [TestCase(0, 0)]
        [TestCase(Math.PI/2.0, 1)]
        public void SinTest(double argument, double result)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }

    }
}
        
        
       