using System;
using Xunit;
using FluentAssertions;

namespace Kata.Packer
{
    public class PackerTest
    {
        [Theory]
        [InlineData(25, 18, 6, 5, 12)]
        [InlineData(10, 10, 1, 1, 100)]
        [InlineData(12, 34, 5, 6, 10)]
        [InlineData(12345, 678910, 1112, 1314, 5676)]
        [InlineData(5, 100, 6, 1, 0)]
        public void Test_Fit_Should_Return_Expected(int crateX, int crateY, int boxX, int boxY, int expected)
        {
            Packer.Fit(crateX, crateY, boxX, boxY).Should().Be(expected);
        }
    }
    
}
