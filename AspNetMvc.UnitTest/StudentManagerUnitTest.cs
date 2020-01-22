using AspNetMvc.Manager;
using System;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AspNetMvc.UnitTest
{
    public class StudentManagerUnitTest
    {
        [Fact]
        public void ValidStudent()
        {
            StudentManager studentManager = new StudentManager();
            bool isValid = studentManager.IsValid("Test");

            Assert.IsTrue(isValid);
        }
    }
}
