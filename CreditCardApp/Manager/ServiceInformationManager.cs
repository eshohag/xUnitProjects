using CreditCardApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApp.Manager
{
    public class ServiceInformationManager
    {
        private readonly IServiceInformation _serviceInformation;
        public ServiceInformationManager(IServiceInformation serviceInformation)
        {
            _serviceInformation = serviceInformation;
        }

        public bool IsValidLicenseKey(string licenseKey)
        {
            if (_serviceInformation.License.LicenseKey.Contains(licenseKey))
                return true;
            return false;
        }
    }
}