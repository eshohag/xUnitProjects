﻿using Calculator.XUnitTest.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Collection("Calculator")]
    public class Class1FixtureCollectionUnitTest
    {
        private readonly ITestOutputHelper _outputLog;
        private readonly CalculatorFixture _calculator;
        public Class1FixtureCollectionUnitTest(ITestOutputHelper outputLog,
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
