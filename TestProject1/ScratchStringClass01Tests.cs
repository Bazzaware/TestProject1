
namespace TestProject1
{
    [Collection("StringThing Collection")]
    public class ScratchStringTestClass01
    {
        private readonly ScratchFixture fixture;
        private readonly string _something;

        public ScratchStringTestClass01(ScratchFixture fixture)
        {
            this.fixture = fixture;
            _something = fixture.something;
        }

        [Fact]
        public void Test00()
        {
            // arrange
            string expected = "This is a test string to pass to tests";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
        [Fact]
        public void Test01()
        {
            // arrange
            string expected = "This is a test string to pass to tests";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
        [Fact]
        public void Test02()
        {
            // arrange
            string expected = "This is a test string to pass to tests";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
        [Fact]
        public void Test03()
        {
            // arrange
            string expected = "This is a test string to pass to tests";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
    }
}
