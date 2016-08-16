using System;

namespace Sort.Models
{
    public class PointWithType : IComparable
    {
        public PointWithType(PointType type, int point)
        {
            Type = type;
            Point = point;
        }

        public enum PointType
        {
            Start, End
        }

        public int Point { get; }
        public PointType Type { get; }
        public int Layer { get; set; }

        public int CompareTo(object obj)
        {
            var pwt = obj as PointWithType;
            if(pwt == null) throw new ArgumentException(nameof(obj));
            if (pwt.Point > Point)
                return -1;
            if (pwt.Point < Point)
                return 1;
            if (pwt.Type == PointType.Start && Type == PointType.End)
                return -1;
            if (pwt.Type == PointType.End && Type == PointType.Start)
                return 1;
            return 0;
        }
    }
}