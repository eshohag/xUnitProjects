using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Manager;
using CreditCardApp.Model;
using Moq;
using Xunit;

namespace CreditCard.MoqXUnitTest
{
    public class EvaluateChangeMoqPropertiesUnitTest
    {
        EvaluatorManager manager;
        Mock<IFrequentFlyerNumberValidator> _validator;
        public EvaluateChangeMoqPropertiesUnitTest()
        {
            _validator = new Mock<IFrequentFlyerNumberValidator>();
            _validator.SetupAllProperties();
           // _validator.SetupProperty(a => a.ValidationMode);
         
            manager = new EvaluatorManager(_validator.Object);
        }

        [Fact]
        public void IsDetailedChangeMoqPropertiesUnitTest()
        {
            var application = new Applicant();
            application.Age = 30;
            DecisionEnum decision = manager.EvaluateChangeMoqProperties(application);

            Assert.Equal(ValidationModeEnum.Detailed, _validator.Object.ValidationMode);
        }
    }
}
