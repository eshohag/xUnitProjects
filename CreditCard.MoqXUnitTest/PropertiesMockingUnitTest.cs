using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Manager;
using CreditCardApp.Model;
using Moq;
using Xunit;

namespace CreditCard.MoqXUnitTest
{
    public class PropertiesMockingUnitTest
    {
        EvaluatorManager manager;
        Mock<IFrequentFlyerNumberValidator> _validator;
        public PropertiesMockingUnitTest()
        {
            _validator = new Mock<IFrequentFlyerNumberValidator>();
            _validator.Setup(a => a.IsValid(It.IsAny<string>())).Returns(true);
            _validator.Setup(a => a.LicenceKey).Returns("EXPIRED");
            manager = new EvaluatorManager(_validator.Object);
        }

        [Fact]
        public void LicenceExpiredApplicant()
        {
            var application = new Applicant() { Age=19 };

            DecisionEnum decision = manager.EvaluateProperties(application);

            Assert.Equal(DecisionEnum.AutoDeclined, decision);
        }
    }
}
