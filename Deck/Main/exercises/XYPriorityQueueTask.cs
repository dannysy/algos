namespace Main.exercises
{
    public class XYPriorityQueueTask
    {
        //public static void Main()
        //{
        //    int count;
        //    if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        //        return;
        //    var xyPoints = new XYPoint[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        var xyStrings = Console.ReadLine().Split(' ');
        //        int x, y;
        //        if (!int.TryParse(xyStrings[0], out x) || !int.TryParse(xyStrings[1], out y))
        //            return;
        //        xyPoints[i] = new XYPoint(x, y);
        //    }
        //    Console.WriteLine(SolveCurve(xyPoints, count));
        //    Console.ReadKey();
        //}

        //private static string SolveCurve(XYPoint[] points, int count)
        //{
        //    var sorted = XYPyramidSort(points);
        //    var result = new StringBuilder();
        //    for (int i = 0; i < count; i++)
        //    {
        //        result.AppendLine(sorted[i].ToString());
        //    }
        //    return result.ToString();
        //}

        //private static XYPoint[] XYPyramidSort(XYPoint[] array)
        //{
        //    var xyPriorityQueue = new XYPriorityQueue(array);
        //    for (int i = array.Length - 1; i >= 0; i--)
        //    {
        //        array[i] = xyPriorityQueue.GetNext();
        //    }
        //    return array;
        //}

        //public class XYPriorityQueue
        //{
        //    private int _length;
        //    private XYPoint[] _buffer;
        //    private int _size;

        //    public XYPriorityQueue(int size)
        //    {
        //        _buffer = new XYPoint[size];
        //        _size = size;
        //    }

        //    public XYPriorityQueue(XYPoint[] buffer) : this(buffer.Length)
        //    {
        //        Array.Copy(buffer, _buffer, buffer.Length);
        //        _length = _size;
        //        BuildHeap();
        //    }

        //    private void BuildHeap()
        //    {
        //        if (_length <= 0)
        //            throw new Exception("empty");
        //        for (int i = _length / 2 - 1; i >= 0; i--)
        //        {
        //            SiftDown(i);
        //        }
        //    }

        //    private int GetParentIndex(int index)
        //    {
        //        return (index - 1) / 2;
        //    }

        //    private int GetLargestChildIndex(int index)
        //    {
        //        var first = index * 2 + 1;
        //        var second = index * 2 + 2;
        //        if (first >= _length)
        //            return -1;
        //        if (second >= _length)
        //            return first;
        //        return _buffer[first].CompareTo(_buffer[second]) == 1 ? first : second;

        //    }

        //    private void SiftUp(int index)
        //    {
        //        if (_length <= 0)
        //            throw new Exception("empty");
        //        while (index > 0)
        //        {
        //            var parentIndex = GetParentIndex(index);
        //            if (_buffer[parentIndex].CompareTo(_buffer[index]) != -1)
        //                return;
        //            var tmpParent = _buffer[parentIndex];
        //            _buffer[parentIndex] = _buffer[index];
        //            _buffer[index] = tmpParent;
        //            index = parentIndex;
        //        }
        //    }

        //    private void SiftDown(int index)
        //    {
        //        if (_length <= 0)
        //            throw new Exception("empty");
        //        while (index <= _length / 2 - 1)
        //        {
        //            var largestChildIndex = GetLargestChildIndex(index);
        //            if (_buffer[index].CompareTo(_buffer[largestChildIndex]) != -1)
        //                return;
        //            var tmpParent = _buffer[index];
        //            _buffer[index] = _buffer[largestChildIndex];
        //            _buffer[largestChildIndex] = tmpParent;
        //            index = largestChildIndex;
        //        }
        //    }


        //    public void InsertWithPriority(XYPoint value)
        //    {
        //        if (_length == _size)
        //            Reallocate();
        //        _buffer[_length] = value;
        //        _length++;
        //        SiftUp(_length - 1);
        //    }

        //    public XYPoint GetNext()
        //    {
        //        var next = _buffer[0];
        //        _buffer[0] = _buffer[_length - 1];
        //        _buffer[_length - 1] = null;
        //        _length--;
        //        if (_length > 1)
        //            SiftDown(0);
        //        return next;
        //    }

        //    public XYPoint PeekAtNext()
        //    {
        //        if (_length == 0)
        //            throw new Exception("empty");
        //        return _buffer[0];
        //    }

        //    private void Reallocate()
        //    {
        //        var newBuffer = new XYPoint[_size * 2];
        //        Array.Copy(_buffer, 0, newBuffer, 0, _size);
        //        _size = _size * 2;
        //        _buffer = newBuffer;
        //    }

        //    public XYPoint[] ToArray()
        //    {
        //        var newBuffer = new XYPoint[_size];
        //        Array.Copy(_buffer, 0, newBuffer, 0, _size);
        //        return newBuffer;
        //    }
        //}

        //public class XYPoint : IComparable
        //{
        //    public int X { get; }
        //    public int Y { get; }

        //    public XYPoint(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    public override string ToString()
        //    {
        //        return X + " " + Y;
        //    }

        //    public int CompareTo(object obj)
        //    {
        //        var target = obj as XYPoint;
        //        if (target == null) throw new ArgumentException(nameof(obj));
        //        if (X > target.X)
        //            return 1;
        //        if (X < target.X)
        //            return -1;
        //        if (Y > target.Y)
        //            return 1;
        //        if (Y < target.Y)
        //            return -1;
        //        return 0;
        //    }
        //}
    }
}