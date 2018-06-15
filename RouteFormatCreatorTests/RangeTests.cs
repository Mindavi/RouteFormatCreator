using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RouteFormatCreator.Tests
{
    [TestClass()]
    public class RangeTests
    {
        [TestMethod()]
        public void ValidValueTest()
        {
            var lowerBound = 1;
            var upperBound = 15;
            var rangeType = RangeType.All;
            Range range = new Range(lowerBound, upperBound, rangeType);
            Assert.AreEqual(lowerBound, range.LowerBound);
            Assert.AreEqual(upperBound, range.UpperBound);
            Assert.AreEqual(rangeType, range.RangeType);
        }

        [TestMethod()]
        public void UnevenTest()
        {
            var lowerBound = 1;
            var upperBound = 15;
            var rangeType = RangeType.Uneven;
            Range range = new Range(lowerBound, upperBound, rangeType);
            Assert.AreEqual(lowerBound, range.LowerBound);
            Assert.AreEqual(upperBound, range.UpperBound);
            Assert.AreEqual(rangeType, range.RangeType);
        }

        [TestMethod()]
        public void EvenTest()
        {
            var lowerBound = 2;
            var upperBound = 16;
            var rangeType = RangeType.Even;
            Range range = new Range(lowerBound, upperBound, rangeType);
            Assert.AreEqual(lowerBound, range.LowerBound);
            Assert.AreEqual(upperBound, range.UpperBound);
            Assert.AreEqual(rangeType, range.RangeType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LowerboundTooHighTest()
        {
            var lowerBound = 17;
            var upperBound = 16;
            var rangeType = RangeType.All;
            Range range = new Range(lowerBound, upperBound, rangeType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TypeUnevenBoundsEven()
        {
            var lowerBound = 2;
            var upperBound = 16;
            var rangeType = RangeType.Uneven;
            Range range = new Range(lowerBound, upperBound, rangeType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TypeEvenBoundsUneven()
        {
            var lowerBound = 1;
            var upperBound = 17;
            var rangeType = RangeType.Even;
            Range range = new Range(lowerBound, upperBound, rangeType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void UpperboundWrongeRangeType()
        {
            var lowerBound = 2;
            var upperBound = 17;
            var rangeType = RangeType.Even;
            Range range = new Range(lowerBound, upperBound, rangeType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LowerboundWrongeRangeType()
        {
            var lowerBound = 1;
            var upperBound = 18;
            var rangeType = RangeType.Even;
            Range range = new Range(lowerBound, upperBound, rangeType);
        }
    }
}