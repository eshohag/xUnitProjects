using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Collection("Calculator")]
    public class Class2UnitTest
    {
        private readonly ITestOutputHelper _outputLog;
        private readonly CalculatorFixture _calculator;
        public Class2UnitTest(ITestOutputHelper outputLog,
            CalculatorFixture calculator)
        {
            _outputLog = outputLog;
            _calculator = calculator;
        }

        [Fact]
        public void Is_Correct_Data_Type_Checking_for_Division()
        {
            _outputLog.WriteLine("Is_Correct_Data_Type_Checking_for_Division");

            double division = _calculator.CalculatorFixt.Division(9, 3);

            Assert.IsType<double>(division);
        }
    }
}
