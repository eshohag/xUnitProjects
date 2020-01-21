using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Manager;
using CreditCardApp.Model;
using Moq;
using System.Text.RegularExpressions;
using Xunit;

namespace CreditCard.MoqXUnitTest
{
    [Trait("CreditCard", "Evaluator ManagerUnit Test")]
    public class EvaluatorManagerUnitTest
    {
        EvaluatorManager manager;
        Mock<IFrequentFlyerNumberValidator> _validator;
        public EvaluatorManagerUnitTest()
        {
            _validator = new Mock<IFrequentFlyerNumberValidator>();

            //_validator.Setup(a => a.IsValid("x")).Returns(true);
            //_validator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
            //_validator.Setup(x => x.IsValid(It.Is<string>(number => number.StartsWith('x')))).Returns(true);
            //_validator.Setup(x => x.IsValid(It.IsIn("x", "y", "z"))).Returns(true);
            //_validator.Setup(x => x.IsValid(It.IsInRange("b", "z", Range.Inclusive))).Returns(true);
            _validator.Setup(x => x.IsValid(It.IsRegex("[a-z]",RegexOptions.None))).Returns(true);

            manager = new EvaluatorManager(_validator.Object);
        }

        [Fact]
        public void AcceptHighIncomeApplicant()
        {
            var application = new Applicant
            {
                Id = 1,
                FirstName = "Alan G. ",
                LastName = "Huffman",
                Age = 40,
                FrequentFlyerNumber = "x",
                GrossAnnualIncome = 1000000
            };
            DecisionEnum decision = manager.Evaluate(application);

            Assert.Equal(DecisionEnum.AutoAccepted, decision);
        }

        [Fact]
        public void YoungApplicantReferredToHuman()
        {
            var application = new Applicant
            {
                Id = 1,
                FirstName = "Alan G. ",
                LastName = "Huffman",
                Age = 19,
                FrequentFlyerNumber = "x",
                GrossAnnualIncome = 1000
            };
            DecisionEnum decision = manager.Evaluate(application);

            Assert.Equal(DecisionEnum.ReferredToHuman, decision);
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
                FrequentFlyerNumber = "a",
                GrossAnnualIncome = 1000
            };
            DecisionEnum decision = manager.Evaluate(application);

            Assert.Equal(DecisionEnum.AutoDeclined, decision);
        }
    }
}
