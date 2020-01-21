using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Model
{
    public class CalculatorInfo
    {
        public string Model { get; set; }
        public string ManufacturingBrand { get; set; }
        public string Year { get; set; }

      public string GetCalculatorInfo()
        {
            return Model + " " + Year + " " + ManufacturingBrand;
        }
    }
}
