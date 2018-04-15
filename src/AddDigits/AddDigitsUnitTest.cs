using Xunit;

namespace AddDigits
{
    public class AddDigitsUnitTest
    {
        [Fact]
        public void AddDigitsTest()
        {
            int num = 38;

            var solution = new AddDigitsSolution();
            int result = solution.AddDigits(num);

            Assert.Equal(2, result);
        }
    }
}
