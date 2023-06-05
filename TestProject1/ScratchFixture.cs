
namespace TestProject1
{
    public class ScratchFixture : IDisposable
    {
        public string something { get; private set; }
        public ScratchFixture()
        {
            something = new string("This is a test string to pass to tests");

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }
    }
    [CollectionDefinition("StringThing Collection")]
    public class StringColletion : ICollectionFixture<ScratchFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

}
