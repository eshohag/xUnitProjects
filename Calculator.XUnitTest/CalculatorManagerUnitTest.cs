using CalculatorApp;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    public class CalculatorManagerUnitTest
    {
        private readonly ITestOutputHelper _helper;
        CalculatorManager manager = null;

        public CalculatorManagerUnitTest(ITestOutputHelper helper)
        {
            _helper = helper;
            manager = new CalculatorManager();
        }
        [Fact]
        [Trait("Calculator", "Manager")]
        public void Is_Correct_Data_Type_Checking_for_GetCalculatorInfo()
        {
            _helper.WriteLine("Is_Correct_Data_Type_Checking_for_GetCalculatorInfo");
            var info = new CalculatorInfo()
            {
                Model = "C101",
                Year = "2020",
                ManufacturingBrand = "SISCO"
            };
            Assert.IsType<string>(manager.GetCalculatorInfo(info));
        }

        [Fact]
        public void Null_Field_Checking_for_GetCalculatorInfo()
        {
            var info = new CalculatorInfo()
            {
                Model = "",
                Year = "2020",
                ManufacturingBrand = "SISCO"
            };
            var manager = new CalculatorManager();
            Assert.Throws<ArgumentNullException>(() => manager.GetCalculatorInfo(info));
            Assert.Throws<ArgumentNullException>("calculatorInfo", () => manager.GetCalculatorInfo(info));
        }

        [Fact(Skip = "Right now doesn't need to tested!")]
        public void Fact_Skip_for_GetCalculatorInfo()
        {
            var info = new CalculatorInfo()
            {
                Model = "",
                Year = "2020",
                ManufacturingBrand = "SISCO"
            };
            Assert.Throws<ArgumentNullException>(() => manager.GetCalculatorInfo(info));
            Assert.Throws<ArgumentNullException>("calculatorInfo", () => manager.GetCalculatorInfo(info));
        }
    }
}
