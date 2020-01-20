using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    public class CalculatorManager
    {
        public string GetCalculatorInfo(CalculatorInfo calculatorInfo)
        {
            if (calculatorInfo.Model == null || calculatorInfo.Model == String.Empty)
            {
                throw new ArgumentNullException(nameof(calculatorInfo));
            }
                return calculatorInfo.GetCalculatorInfo();
            }
        }
    }
