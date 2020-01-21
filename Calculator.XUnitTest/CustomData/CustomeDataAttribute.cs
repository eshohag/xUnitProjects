using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace Calculator.XUnitTest.CustomData
{
    public class CustomeDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            //var data = new List<object[]>() {
            //new object[] { 16, 2, 8 },
            //new object[] { 18, 2, 9 }
            //};
            //return data;

            //string[] csvLines = File.ReadAllLines(@"E:\Dev_Shohag\Practice\xUnitProjects\Calculator.XUnitTest\ExternalData\TestData.csv");
            string[] csvLines = File.ReadAllLines("CustomData/CustomTestData.csv");

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
