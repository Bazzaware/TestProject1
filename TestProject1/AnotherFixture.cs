
namespace TestProject1
{
    public class AnotherFixture : IDisposable
    {
        public string somethingElse { get; private set; }
        public AnotherFixture()
        {
            somethingElse = new string("This is a different string");

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }
    }
    [CollectionDefinition("AnotherString Collection")]
    public class AnotherString : ICollectionFixture<AnotherFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

}
