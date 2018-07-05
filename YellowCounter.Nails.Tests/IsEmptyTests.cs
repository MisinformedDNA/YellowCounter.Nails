using System;
using System.Collections.Generic;
using Xunit;

namespace YellowCounter.Nails.Tests
{
    public class IsEmptyTests
    {
        [Fact]
        public void EmptyArray()
        {
            var value = new int[0];
            Assert.True(value.IsEmpty());
        }

        [Fact]
        public void NonEmptyArray()
        {
            var value = new int[] { 1 };
            Assert.False(value.IsEmpty());
        }

        [Fact]
        public void EmptyList()
        {
            var value = new List<int>(0);
            Assert.True(value.IsEmpty());
        }

        [Fact]
        public void NonEmptyList()
        {
            var value = new List<int> { 1 };
            Assert.False(value.IsEmpty());
        }

        [Fact]
        public void EmptyDictionary()
        {
            var value = new Dictionary<int, int>(0);
            Assert.True(value.IsEmpty());
        }

        [Fact]
        public void NonEmptyDictionary()
        {
            var value = new Dictionary<int, int> { { 1, 2 } };
            Assert.False(value.IsEmpty());
        }

        [Fact]
        public void NullString()
        {
            string value = null;
            Assert.Throws<NullReferenceException>(() => value.IsEmpty());
        }

        [Fact]
        public void EmptyString()
        {
            string value = string.Empty;
            Assert.True(value.IsEmpty());
        }

        [Fact]
        public void NonEmptyString()
        {
            string value = " ";
            Assert.False(value.IsEmpty());
        }
    }
}
