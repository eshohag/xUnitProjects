using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Collection("Calculator")]
    public class DataDrivenTest
    {
        private readonly ITestOutputHelper _outputLog;
        private readonly CalculatorFixture _calculator;
        public DataDrivenTest(ITestOutputHelper outputLog,
            CalculatorFixture calculator)
        {
            _outputLog = outputLog;
            _calculator = calculator;
        }

        [Fact]
        public void LessThan10Value_Checking_for_Division()
        {
            double sum = _calculator.CalculatorFixt.Division(16, 2);
            Assert.Equal(8, sum);
        }
        [Fact]
        public void LessThan20Value_Checking_for_Division()
        {
            double sum = _calculator.CalculatorFixt.Division(18, 2);
            Assert.Equal(9, sum);
        }

        [Theory]
        [InlineData(16,2,8)]
        [InlineData(18,2,9)]
        [InlineData(21,2,10.5)]
        public void Value_Checking_for_Division(double firstValue, double secondValue, double expectedvalue)
        {
            double sum = _calculator.CalculatorFixt.Division(firstValue, secondValue);
            Assert.Equal(expectedvalue, sum);
        }
    }
}
