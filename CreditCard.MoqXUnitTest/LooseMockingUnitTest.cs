using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Manager;
using CreditCardApp.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CreditCard.MoqXUnitTest
{
    public class LooseMockingUnitTest
    {
        EvaluatorManager manager;
        Mock<IFrequentFlyerNumberValidator> _validator;
        public LooseMockingUnitTest()
        {
            _validator = new Mock<IFrequentFlyerNumberValidator>(MockBehavior.Loose);
           // _validator.Setup(a => a.IsValid(It.IsAny<string>())).Returns(false);
            manager = new EvaluatorManager(_validator.Object);
        }

        [Fact]
        public void ReferInvalidFrequentFlyerNumberApplicant()
        {
            var application = new Applicant();

            DecisionEnum decision = manager.Evaluate(application);

            Assert.Equal(DecisionEnum.ReferredToHuman, decision);
        }
    }
}
