using Xunit;

namespace Calculator.XUnitTest.Fixtures
{
    [CollectionDefinition("Calculator")]
    public class CalculatorFixtureCollection : ICollectionFixture<CalculatorFixture>, ICollectionFixture<DatabaseFixture>
    {
    }
}
