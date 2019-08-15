﻿using Xunit;
using Platform.Numbers;

namespace Platform.Numbers.Tests
{
    public class MathExtensionsTests
    {
        [Fact]
        public void AbsTest()
        {
            var number = -1L;
            var returnValue = number.Abs();
            Assert.Equal(1L, returnValue);
            Assert.Equal(1L, number);
        }

        [Fact]
        public void NegateTest()
        {
            var number = 2L;
            var returnValue = number.Negate();
            Assert.Equal(-2L, returnValue);
            Assert.Equal(-2L, number);
        }
    }
}
