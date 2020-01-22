using CreditCardApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApp.Validator
{
    public class ServiceInformationValidator : IServiceInformation
    {
        public ILicenseData License {
            get => throw new NotImplementedException();
        }
    }
}
