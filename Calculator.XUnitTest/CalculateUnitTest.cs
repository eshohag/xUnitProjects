using CalculatorApp;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    [Trait("Calculator", "Main")]
    public class CalculateUnitTest
    {
        private readonly ITestOutputHelper _helper;
        public CalculateUnitTest(ITestOutputHelper helper)
        {
            _helper = helper;
        }
        [Fact] 
        public void Is_Correct_Data_Type_Checking_for_sum()
        {
            _helper.WriteLine("Is_Correct_Data_Type_Checking_for_sum");

            double sum = Calculate.Sum(3, 5);

            Assert.IsType<double>(sum);
        }
        [Fact]
        public void Value_Checking_for_sum()
        {
            double sum = Calculate.Sum(3, 5);

            Assert.Equal(8,sum);
        }
        [Fact]
        public void Value_Range_Checking_for_sum()
        {
            double sum = Calculate.Sum(3, 5);

            Assert.InRange(sum,1,10);
        }
      
    }
}
