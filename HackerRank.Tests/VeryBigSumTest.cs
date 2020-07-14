using Xunit;
using HackerRank.App;

namespace HackerRank.Tests
{
    public class VeryBigSumTest
    {
        [Fact]
        public void ShouldReturnABigSumOfArray()
        {
            // given
            var input = new long[] {
                1000000001,
                1000000002,
                1000000003,
                1000000004,
                1000000005
            };

            // when
            var result = VeryBigSum.run(input);

            //then
            Assert.Equal(5000000015, result);
        }

        [Fact]
        public void ShouldReturnABigSumOfArray2()
        {
            // given
            var input = new long[] {
                1000000001,
                1000000002,
            };

            // when
            var result = VeryBigSum.run(input);

            //then
            Assert.Equal(2000000003, result);
        }
    }
}
