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
            string licenseKey = "DHAKA-KHA-101";

            bool isValid = _serviceInformationManager.IsValidLicenseKey(licenseKey);

            Assert.True(isValid);
        }

        public IList<string> GetLicense()
        {
            return new List<string>() {
                "DHAKA-KHA-101",
                "DHAKA-KHA-102",
                "DHAKA-KHA-103"
            };
        }
    }
}