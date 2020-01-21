using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace Calculator.XUnitTest.ExternalData
{
    public class ExternalDataSource
    {
        public static IEnumerable<object[]> GetExternalData
        {
            get
            {
                string[] csvLines = File.ReadAllLines(@"E:\Dev_Shohag\Practice\xUnitProjects\Calculator.XUnitTest\ExternalData\TestData.csv");

                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<double> values = csvLine.Split(',').Select(double.Parse);

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }

                return testCases;
            }
        }
    }
}

