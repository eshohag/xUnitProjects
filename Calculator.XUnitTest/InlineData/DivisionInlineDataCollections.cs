using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.XUnitTest.InlineData
{
    public class DivisionInlineDataCollections
    {
        public static List<object[]> GetAllInlineData = new List<object[]>()
        {
            new object[]{16,2,8},
            new object[]{18,2,9},
            new object[]{21,2,10.5},
            new object[]{10,2,5},
        };

    }
}
