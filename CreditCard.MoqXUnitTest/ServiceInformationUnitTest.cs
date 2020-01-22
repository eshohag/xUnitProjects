using CreditCardApp.Interface;
using CreditCardApp.Manager;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace CreditCard.MoqXUnitTest
{
    [Trait("Service", "Service Information")]
    public class ServiceInformationUnitTest
    {
        private readonly ServiceInformationManager _serviceInformationManager;
        Mock<IServiceInformation> _serviceInformation;
        public ServiceInformationUnitTest()
        {
            _serviceInformation = new Mock<IServiceInformation>();
            _serviceInformation.Setup(a => a.License.LicenseKey).Returns(GetLicense());
            _serviceInformationManager = new ServiceInformationManager(_serviceInformation.Object);
        }

        [Fact]
        public void IsValidLicenseForApplicant()
        {
            string licenseKey = "S103";

            bool isValid = _serviceInformationManager.IsValidLicenseKey(licenseKey);

            Assert.True(isValid);
        }

        public List<string> GetLicense()
        {
            return new List<string>() {
                "S101",
                "S102",
                "S103"
            };
        }
    }
}