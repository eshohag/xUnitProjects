using CreditCardApp.Enums;
using CreditCardApp.Interface;
using CreditCardApp.Model;

namespace CreditCardApp.Manager
{
    public class EvaluatorManager
    {
        private readonly IFrequentFlyerNumberValidator _validator;
        public EvaluatorManager(IFrequentFlyerNumberValidator validator)
        {
            _validator = validator;
        }

        public DecisionEnum Evaluate(Applicant application)
        {
            if (application.GrossAnnualIncome >= (int)SalariesEnum.HighIncomeThreshhold)
            {
                return DecisionEnum.AutoAccepted;
            }

            var isValidFrequentFlyerNumber = _validator.IsValid(application.FrequentFlyerNumber);

            if (!isValidFrequentFlyerNumber)
            {
                return DecisionEnum.ReferredToHuman;
            }

            if (application.Age <= (int)AgeEnum.AutoReferralMaxAge)
            {
                return DecisionEnum.ReferredToHuman;
            }

            if (application.GrossAnnualIncome < (int)SalariesEnum.LowIncomeThreshhold)
            {
                return DecisionEnum.AutoDeclined;
            }

            return DecisionEnum.ReferredToHuman;
        }
    }
}
