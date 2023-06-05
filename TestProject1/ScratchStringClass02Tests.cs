
namespace TestProject1
{
    [Collection("AnotherString Collection")]
    public class ScratchStringTestClass02
    {
        private readonly string _something;

        public ScratchStringTestClass02(AnotherFixture fixture)
        {
            _something = fixture.somethingElse;
        }

        [Fact]
        public void Test1()
        {
            // arrange
            string expected = "This is a different string";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
       
        [Fact]
        public void Test2()
        {
            // arrange
            string expected = "This is a different string";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
        
        [Fact]
        public void Test3()
        {
            // arrange
            string expected = "This is a different string";

            // act
            string result = _something;

            // assert
            result.Should().Be(expected);
        }
    }
}
