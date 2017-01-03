namespace BinaryGap.Test
{
    using BinaryGap.Core;

    using Xunit;
        
    public class SolutionTests
    {
        [Theory()]
        [InlineData(1041, 5)]
        [InlineData(9, 2)]
        [InlineData(15, 0)]
        [InlineData(2147483647, 0)]
        [InlineData(6, 0)]
        [InlineData(5, 1)]
        [InlineData(16, 0)]
        [InlineData(1024, 0)]
        [InlineData(328, 2)]
        [InlineData(51712, 2)]
        [InlineData(20, 1)]
        public void BinaryGap_ShouldReturnCorrectValueForGivenInput(int value, int result)
        {
            //Arange
            var sut = new Solution();

            //Act
            var actual = sut.BinaryGap(value);

            //Assert
            Assert.Equal(result, actual);
        }
    }
}
