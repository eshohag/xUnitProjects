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

        public DecisionEnum EvaluateUsingOut(Applicant application)
        {
            if (application.GrossAnnualIncome >= (int)SalariesEnum.HighIncomeThreshhold)
            {
                return DecisionEnum.AutoAccepted;
            }
            if (_validator.LicenceKey == "EXPIRED")
            {
                return DecisionEnum.ReferredToHuman;
            }
            _validator.IsValid(application.FrequentFlyerNumber, out bool isValidFrequentFlyerNumber);

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
        public DecisionEnum EvaluateProperties(Applicant application)
        {
            if (application.GrossAnnualIncome >= (int)SalariesEnum.HighIncomeThreshhold)
            {
                return DecisionEnum.AutoAccepted;
            }
            if (_validator.LicenceKey == "EXPIRED")
            {
                return DecisionEnum.AutoDeclined;
            }
            _validator.IsValid(application.FrequentFlyerNumber, out bool isValidFrequentFlyerNumber);

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
