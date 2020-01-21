using CalculatorApp;
using CalculatorApp.Manager;
using CalculatorApp.Model;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    public class CalculatorManagerUnitTest : IDisposable
    {
        private readonly ITestOutputHelper _outputLog;
        CalculatorManager manager = null;
        CalculatorInfo info = null;

        public CalculatorManagerUnitTest(ITestOutputHelper helper)
        {
            _outputLog = helper;
            manager = new CalculatorManager();
            info = new CalculatorInfo()
            {
                Model = "",
                Year = "2020",
                ManufacturingBrand = "SISCO"
            };
        }
        [Fact]
        [Trait("Calculator", "Manager")]
        public void Is_Correct_Data_Type_Checking_for_GetCalculatorInfo()
        {
            _outputLog.WriteLine("Is_Correct_Data_Type_Checking_for_GetCalculatorInfo");
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
            Assert.Throws<ArgumentNullException>(() => manager.GetCalculatorInfo(info));
            Assert.Throws<ArgumentNullException>("calculatorInfo", () => manager.GetCalculatorInfo(info));
        }

        [Fact(Skip = "Right now doesn't need to tested!")]
        public void Fact_Skip_for_GetCalculatorInfo()
        {
            Assert.Throws<ArgumentNullException>(() => manager.GetCalculatorInfo(info));
            Assert.Throws<ArgumentNullException>("calculatorInfo", () => manager.GetCalculatorInfo(info));
        }

        public void Dispose()
        {
            _outputLog.WriteLine("Methods are dispose!");
        }
    }
}
