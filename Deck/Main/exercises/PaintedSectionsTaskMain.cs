namespace Main.Exercises
{
    public class PaintedSectionsTaskMain
    {
        //public static void Main()
        //{
        //    int count;
        //    if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        //        return;
        //    var points = new PointWithType[count * 2];
        //    for (int i = 0; i < count; i++)
        //    {
        //        var xyStrings = Console.ReadLine().Split(' ');
        //        int x1, x2;
        //        if (!int.TryParse(xyStrings[0], out x1) || !int.TryParse(xyStrings[1], out x2))
        //            return;
        //        points[i * 2] = new PointWithType(PointWithType.PointType.Start, x1);
        //        points[i * 2 + 1] = new PointWithType(PointWithType.PointType.End, x2);
        //    }
        //    var sortedPoints = MergeSort(points, count * 2);
        //    Console.WriteLine(CountSections(sortedPoints));
        //    Console.ReadKey();
        //}

        //private static int CountSections(PointWithType[] sorted)
        //{
        //    var length = 0;
        //    var layer = 0;
        //    foreach (var pointWithType in sorted)
        //    {
        //        if (pointWithType.Type == PointWithType.PointType.Start)
        //            pointWithType.Layer = ++layer;
        //        else pointWithType.Layer = --layer;
        //    }
        //    PointWithType start = null;
        //    foreach (var pointWithType in sorted)
        //    {
        //        if (pointWithType.Layer == 1 && start == null)
        //        {
        //            start = pointWithType;
        //            continue;
        //        }
        //        if (pointWithType.Layer != 1 && start != null)
        //        {
        //            length += pointWithType.Point - start.Point;
        //            start = null;
        //        }
        //    }
        //    return length;
        //}

        //private static PointWithType[] MergeSort(PointWithType[] array, int length)
        //{
        //    MergeSortReq(array, 0, length - 1);
        //    return array;
        //}

        //private static void MergeSortReq(PointWithType[] array, int headIndex, int tailIndex)
        //{
        //    if (tailIndex <= headIndex)
        //        return;
        //    var middle = (tailIndex + headIndex) / 2;
        //    MergeSortReq(array, headIndex, middle);
        //    MergeSortReq(array, middle + 1, tailIndex);
        //    Merge(array, headIndex, middle, middle + 1, tailIndex);
        //}

        //private static void Merge(PointWithType[] array, int headLeft, int tailLeft, int headRight, int tailRight)
        //{
        //    var leftLength = tailLeft - headLeft + 1;
        //    var rightLength = tailRight - headRight + 1;
        //    var length = leftLength + rightLength;
        //    var tmpArray = new PointWithType[length];
        //    int rightPtr = headRight, leftPtr = headLeft, ptr = 0;
        //    while (rightPtr <= tailRight && leftPtr <= tailLeft)
        //    {
        //        if (array[rightPtr].CompareTo(array[leftPtr]) == -1)
        //        {
        //            tmpArray[ptr] = array[rightPtr];
        //            ++rightPtr;
        //        }
        //        else
        //        {
        //            tmpArray[ptr] = array[leftPtr];
        //            ++leftPtr;
        //        }
        //        ++ptr;
        //    }
        //    while (rightPtr <= tailRight)
        //    {
        //        tmpArray[ptr] = array[rightPtr];
        //        ++ptr;
        //        ++rightPtr;
        //    }
        //    while (leftPtr <= tailLeft)
        //    {
        //        tmpArray[ptr] = array[leftPtr];
        //        ++ptr;
        //        ++leftPtr;
        //    }
        //    Array.Copy(tmpArray, 0, array, headLeft, length);
        //}

        //public class PointWithType : IComparable
        //{
        //    public PointWithType(PointType type, int point)
        //    {
        //        Type = type;
        //        Point = point;
        //    }

        //    public enum PointType
        //    {
        //        Start, End
        //    }

        //    public int Point { get; }
        //    public PointType Type { get; }
        //    public int Layer { get; set; }

        //    public int CompareTo(object obj)
        //    {
        //        var pwt = obj as PointWithType;
        //        if (pwt == null) throw new ArgumentException(nameof(obj));
        //        if (pwt.Point > Point)
        //            return -1;
        //        if (pwt.Point < Point)
        //            return 1;
        //        if (pwt.Type == PointType.Start && Type == PointType.End)
        //            return -1;
        //        if (pwt.Type == PointType.End && Type == PointType.Start)
        //            return 1;
        //        return 0;
        //    }
        //}
    }
}