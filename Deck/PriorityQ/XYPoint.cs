using System;

namespace PriorityQ
{
    public class XYPoint : IComparable
    {
        public int X { get; }
        public int Y { get; }

        public XYPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + " " + Y;
        }

        public int CompareTo(object obj)
        {
            var target = obj as XYPoint;
            if (target == null) throw new ArgumentException(nameof(obj));
            if (X > target.X)
                return 1;
            if (X < target.X)
                return -1;
            if (Y > target.Y)
                return 1;
            if (Y < target.Y)
                return -1;
            return 0;
        }
    }
}