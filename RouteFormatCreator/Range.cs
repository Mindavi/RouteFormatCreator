using System;

namespace RouteFormatCreator
{
    public class Range
    {
        private int lowerBound;
        private int upperBound;
        private RangeType rangeType;

        public Range(int lowerBound, int upperBound, RangeType type)
        {
            if (lowerBound > upperBound)
            {
                throw new ArgumentException("lowerbound must be bigger than upper bound");
            }
            var isEven = (lowerBound % 2 == 0) && (upperBound % 2 == 0);
            if (type == RangeType.All)
            {
                // no need to check bounds
            }
            else if (isEven && (type != RangeType.Even))
            {
                throw new ArgumentException("Even argument while range is uneven");
            }
            else if (!isEven && (type != RangeType.Uneven))
            {
                throw new ArgumentException("Uneven argument while range is even");
            }
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.rangeType = type;
        }

        public int LowerBound
        {
            get { return lowerBound; }
        }
        public int UpperBound
        {
            get { return upperBound; }
        }

        public RangeType RangeType
        {
            get { return rangeType; }
        }

        public override string ToString()
        {
            return $"{lowerBound},{upperBound},{rangeType}";
        }
    }
}
