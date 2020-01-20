using CalculatorApp;
using System;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
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
