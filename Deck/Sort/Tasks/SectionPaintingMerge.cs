using System.Collections.Generic;
using Sort.Models;

namespace Sort.Tasks
{
    public static class SectionPaintingMerge
    {
        public static int CountSections(PointWithType[] sorted)
        {
            var length = 0;
            var layer = 0;
            foreach (var pointWithType in sorted)
            {
                if(pointWithType.Type == PointWithType.PointType.Start)
                    pointWithType.Layer = ++layer;
                else pointWithType.Layer = --layer;
            }
            PointWithType start = null;
            foreach (var pointWithType in sorted)
            {
                if (pointWithType.Layer == 1 && start == null)
                {
                    start = pointWithType;
                    continue;
                }
                if(pointWithType.Layer != 1 && start != null)
                {
                    length += pointWithType.Point - start.Point;
                    start = null;
                }
            }
            return length;
        }
    }
}