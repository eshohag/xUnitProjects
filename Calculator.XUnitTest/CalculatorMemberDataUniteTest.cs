using Calculator.XUnitTest.Fixtures;
using Calculator.XUnitTest.InlineData;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Trait("Calculator", "InlineData")]
    [Collection("Calculator")]
    public class CalculatorMemberDataUniteTest
    {
        private readonly ITestOutputHelper _outputLog;
        private readonly CalculatorFixture _calculator;
        public CalculatorMemberDataUniteTest(ITestOutputHelper outputLog,
            CalculatorFixture calculator)
        {
            _outputLog = outputLog;
            _calculator = calculator;
        }

        [Theory]
        //[MemberData("GetAllInlineData", MemberType = typeof(DivisionInlineDataCollections))]
        [MemberData(nameof(DivisionInlineDataCollections.GetAllInlineData), MemberType = typeof(DivisionInlineDataCollections))]
        public void Value_Checking_for_Division(double firstValue, double secondValue, double expectedvalue)
        {
            _outputLog.WriteLine($"Inline Data from member Data Collections First Value-{firstValue}, Second Value-{secondValue} & Expected Value-{expectedvalue}");
            double sum = _calculator.CalculatorFixt.Division(firstValue, secondValue);
            Assert.Equal(expectedvalue, sum);
        }
    }
}
