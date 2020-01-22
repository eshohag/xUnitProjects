using System.Collections.Generic;

namespace CreditCardApp.Interface
{
    public interface ILicenseData
    {
       IList<string> LicenseKey { get; }
    }
}