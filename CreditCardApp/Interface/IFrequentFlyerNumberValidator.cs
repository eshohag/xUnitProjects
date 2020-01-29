using System;
using CreditCardApp.Enums;

namespace CreditCardApp.Interface
{
    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
        string LicenceKey { get; }
        ValidationModeEnum ValidationMode { get; set; }
    }
}