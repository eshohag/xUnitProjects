using Xunit;

namespace Calculator.XUnitTest
{
    [CollectionDefinition("Calculator")]
    public class CalculatorFixtureCollection : ICollectionFixture<CalculatorFixture>
    {
    }
}
