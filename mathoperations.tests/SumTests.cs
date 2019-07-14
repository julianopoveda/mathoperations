using System;
using Xunit;
using mathoperations;

namespace mathoperations.tests
{
    public class SumTests
    {
        private readonly IOperations _operations = new Operations();

        [Fact]
        public void ShouldSumTwoPositiveNumbers()
        {
            Assert.Equal(15 + 27, _operations.Addition(15, 27));
        }

        [Fact]
        public void AdditionOfTwoOpositeNumbersShouldBeZero()
        {
            Assert.Equal(0, _operations.Addition(-47, 47));
            Assert.Equal(0, _operations.Addition(50, -50));

            //This is -1, because int.Minvalue is -2147483648 whereas int.MaxValue is 2147483647.
            //That is the anser of why they are oposite but non zero
            Assert.Equal(-1, _operations.Addition(int.MinValue, int.MaxValue));
        }

        [Fact]
        public void IfNegativeNumberGreaterThanPositiveResultMustBeNegative()
        {
            Assert.Equal(-13, _operations.Addition(-21, 8));
            Assert.Equal(-15, _operations.Addition(30, -45));
        }

        [Fact]
        public void IfNegativeNumberLessThanPositiveResultMustBePositive()
        {
            Assert.Equal(13, _operations.Addition(21, -8));
            Assert.Equal(15, _operations.Addition(-30, 45));
        }
    }
}
