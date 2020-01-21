using System;
using System.Data.SqlClient;

namespace Calculator.XUnitTest.Fixtures
{
    public class DatabaseFixture : IDisposable
    {
        public string Db { get; private set; }

        public DatabaseFixture()
        {
            Db = "Your Database connection";
        }

        public void Dispose()
        {
            //Cleanup
        }
    }
}
