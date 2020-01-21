using Calculator.XUnitTest.ExternalData;
using Calculator.XUnitTest.Fixtures;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Trait("Calculator", "External Data Source")]
    [Collection("Calculator")]
    public class ExternalDataSourceUnitTest : IDisposable
    {
        private readonly ITestOutputHelper _outputLog;
        private readonly CalculatorFixture _calculator;
        public ExternalDataSourceUnitTest(ITestOutputHelper outputLog,
            CalculatorFixture calculator)
        {
            _outputLog = outputLog;
            _calculator = calculator;
        }

        [Theory]
        //[MemberData("GetExternalData", MemberType = typeof(ExternalDataSource))]
        [MemberData(nameof(ExternalDataSource.GetExternalData), MemberType = typeof(ExternalDataSource))]
        public void Value_Checking_for_Division(double firstValue, double secondValue, double expectedvalue)
        {
            _outputLog.WriteLine($"Inline Data from member Data Collections First Value-{firstValue}, Second Value-{secondValue} & Expected Value-{expectedvalue}");
            double sum = _calculator.CalculatorFixt.Division(firstValue, secondValue);
            Assert.Equal(expectedvalue, sum);
        }

        public void Dispose()
        {
          //Cleanup
        }
    }
}
