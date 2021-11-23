using Xunit;

namespace Five_BN_TestTask.Tests
{
    public class EightQueensTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 0)]
        [InlineData(3, 0)]
        [InlineData(4, 2)]
        [InlineData(5, 10)]
        [InlineData(6, 4)]
        [InlineData(7, 40)]
        [InlineData(8, 92)]
        [InlineData(9, 352)]
        [InlineData(10, 724)]
        public void FindAllSolutions_Valid(int numberQueen, int expectedCount)
        {
            var actualCount = new EightQueens().FindAllSolutions(numberQueen).Count;
            
            Assert.Equal(expectedCount, actualCount);
        }
    }
}