
namespace TestProject1
{

    [Collection("StringThing Collection")]
    public class ScratchStringTestClass00
    {
        ScratchFixture fixture;

        public ScratchStringTestClass00(ScratchFixture fixture)
        {
            this.fixture = fixture;
        }
        
        [Fact]
        private void Test00()
        {
            var result = fixture.something;
            result.Should().Be("This is a test string to pass to tests");
        }
        [Fact]
        private void Test01()
        {
            var result = fixture.something;
            result.Should().Be("This is a test string to pass to tests");
        }
        [Fact]
        private void Test02()
        {
            var result = fixture.something;
            result.Should().Be("This is a test string to pass to tests");
        }
    }
}
