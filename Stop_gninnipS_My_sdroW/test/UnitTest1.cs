using System;
using src;
using Xunit;
using FluentAssertions;

namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Just gniddik ereht is llits one more", "Just kidding there is still one more")]
        public void Test1(string toFlip, string expected)
        {
            Kata.SpinWords(toFlip).Should().Be(expected);
        }
    }
}
