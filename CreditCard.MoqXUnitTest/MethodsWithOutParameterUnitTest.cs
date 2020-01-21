using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Manager;
using CreditCardApp.Model;
using Moq;
using Xunit;
namespace CreditCard.MoqXUnitTest
{
    public class MethodsWithOutParameterUnitTest
    {
        EvaluatorManager manager;
        Mock<IFrequentFlyerNumberValidator> _validator;
        public MethodsWithOutParameterUnitTest()
        {
            _validator = new Mock<IFrequentFlyerNumberValidator>();

            bool isValid = true;
            _validator.Setup(a => a.IsValid(It.IsAny<string>(), out isValid));

            manager = new EvaluatorManager(_validator.Object);
        }

        [Fact]
        public void LowIncomeApplicantAutoDeclined()
        {
            var application = new Applicant
            {
                Id = 1,
                FirstName = "Alan G. ",
                LastName = "Huffman",
                Age = 40,
                FrequentFlyerNumber = "IsAny",
                GrossAnnualIncome = 1000
            };
            DecisionEnum decision = manager.EvaluateUsingOut(application);

            Assert.Equal(DecisionEnum.AutoDeclined, decision);
        }
    }
}
