using System.Collections.Generic;
using Xunit;

namespace YellowCounter.Nails.Tests
{
    public class IsPresentTests
    {
        [Fact]
        public void NullObject()
        {
            object value = null;
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void Object()
        {
            object value = new object();
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void EmptyArray()
        {
            var value = new int[0];
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void NonEmptyArray()
        {
            var value = new int[] { 1 };
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void NullList()
        {
            var value = (List<int>)null;
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void EmptyList()
        {
            var value = new List<int>(0);
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void NonEmptyList()
        {
            var value = new List<int> { 1 };
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void EmptyDictionary()
        {
            var value = new Dictionary<int, int>(0);
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void NonEmptyCollection()
        {
            var value = new Dictionary<int, int> { { 1, 2 } };
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void NullString()
        {
            string value = null;
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void EmptyString()
        {
            string value = null;
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void WhiteSpaceString()
        {
            string value = " \t\n\r";
            Assert.False(value.IsPresent());
        }


        [Fact]
        public void VisibleString()
        {
            string value = " a ";
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void False()
        {
            var value = false;
            Assert.False(value.IsPresent());
        }

        [Fact]
        public void True()
        {
            var value = true;
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void Zero()
        {
            var value = 0;
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void PositiveNumber()
        {
            var value = 2;
            Assert.True(value.IsPresent());
        }

        [Fact]
        public void NegativeNumber()
        {
            var value = -2;
            Assert.True(value.IsPresent());
        }
    }
}
