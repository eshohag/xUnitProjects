using CalculatorApp;
using System;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Calculator.XUnitTest
{
    public class CalculatorFixture : IDisposable
    {
        private readonly ITestOutputHelper _outputLog;

        public Calculate Calculator { get; private set; }
        public CalculatorFixture(ITestOutputHelper outputLog)
        {
            _outputLog = outputLog;
            Calculator = new Calculate();
        }

        public void Dispose()
        {
            _outputLog.WriteLine("Methods are dispose!");
        }
    }
}
