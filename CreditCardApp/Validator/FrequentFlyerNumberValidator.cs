using CreditCardApp.Interface;

namespace CreditCardApp.Validator
{
    public class FrequentFlyerNumberValidatorService : IFrequentFlyerNumberValidator
    {
        public bool IsValid(string frequentFlyerNumber)
        {
            if (frequentFlyerNumber == null)
                return false; ;
            return true;
        }

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            if (frequentFlyerNumber == null)
            {
                isValid = false;
            }
            else
                isValid = true;
        }

        public string LicenceKey
        {
            get
            {
                return "EXPIRED";
            }
        }
    }
}
