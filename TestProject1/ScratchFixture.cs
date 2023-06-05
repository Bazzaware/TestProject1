
namespace TestProject1
{
    public class ScratchFixture
    {
        public string something { get; private set; }
        public ScratchFixture()
        {
            something = new string("This is a test string to pass to tests");
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
