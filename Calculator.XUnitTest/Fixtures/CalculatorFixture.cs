using CalculatorApp.Model;
using System;

namespace Calculator.XUnitTest.Fixtures
{
    public class CalculatorFixture : IDisposable
    {
        public Calculate CalculatorFixt { get; private set; }
        public CalculatorFixture()
        {
            CalculatorFixt = new Calculate();
        }

        public void Dispose()
        {
            //CleanUp
        }
    }
}
