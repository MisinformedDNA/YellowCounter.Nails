using System;
using Xunit;

namespace YellowCounter.Nails.Tests
{
    public class IsNullTests
    {
        [Fact]
        public void NullObjectTest()
        {
            object value = null;
            Assert.True(value.IsNull());
        }

        [Fact]
        public void NullStringTest()
        {
            string value = null;
            Assert.True(value.IsNull());
        }

        [Fact]
        public void NullNullableTest()
        {
            int? value = null;
            Assert.True(value.IsNull());
        }
    }
}
