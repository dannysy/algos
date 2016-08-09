namespace Main.Exercises
{
    public class DeepMergeTaskMain
    {
        //public static void Main()
        //{
        //    int length;
        //    if (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        //        return;
        //    var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    int k;
        //    if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
        //        return;
        //    var intses = new List<int[]>();
        //    var step = k;
        //    while (step <= length)
        //    {
        //        var intArray = new int[k];
        //        Array.Copy(array, step - k, intArray, 0, k);
        //        intses.Add(MergeSort(intArray, k));
        //        step += k;
        //    }
        //    Console.WriteLine(string.Join(" ", DeepMerge(intses, length / k, k)));
        //    Console.ReadKey();
        //}

        ///// <summary>
        ///// В целом, условия задачи такие, 
        ///// что иможно было слить отсортированные массивы размера k просто последовательно,
        ///// но урок все-таки был на слияние k отсортированных массивов
        ///// </summary>
        ///// <param name="sortedArrays"></param>
        ///// <param name="count"></param>
        ///// <param name="length"></param>
        ///// <returns></returns>
        //private static int[] DeepMerge(List<int[]> sortedArrays, int count, int length)
        //{
        //    var minHeap = new MinHeap<ValueInfo>(count);
        //    var sorted = new int[length * count];
        //    var ind = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        var value = sortedArrays[i][0];
        //        minHeap.InsertWithPriority(value, new ValueInfo(0, i, value));
        //    }
        //    while (minHeap.Length > 0)
        //    {
        //        var min = minHeap.GetNext();
        //        sorted[ind++] = min.Value;
        //        if (min.ValueIndex >= sortedArrays[min.ArrayIndex].Length - 1) continue;
        //        var nextValue = new ValueInfo(min.ValueIndex + 1, min.ArrayIndex, sortedArrays[min.ArrayIndex][min.ValueIndex + 1]);
        //        minHeap.InsertWithPriority(nextValue.Value, nextValue);
        //    }
        //    return sorted;
        //}

        //private static int[] MergeSort(int[] array, int length)
        //{
        //    MergeSortReq(array, 0, length - 1);
        //    return array;
        //}

        //private static void MergeSortReq(int[] array, int headIndex, int tailIndex)
        //{
        //    if (tailIndex <= headIndex)
        //        return;
        //    var middle = (tailIndex + headIndex) / 2;
        //    MergeSortReq(array, headIndex, middle);
        //    MergeSortReq(array, middle + 1, tailIndex);
        //    Merge(array, headIndex, middle, middle + 1, tailIndex);
        //}

        //private static void Merge(int[] array, int headLeft, int tailLeft, int headRight, int tailRight)
        //{
        //    var leftLength = tailLeft - headLeft + 1;
        //    var rightLength = tailRight - headRight + 1;
        //    var length = leftLength + rightLength;
        //    var tmpArray = new int[length];
        //    int rightPtr = headRight, leftPtr = headLeft, ptr = 0;
        //    while (rightPtr <= tailRight && leftPtr <= tailLeft)
        //    {
        //        if (array[rightPtr] < array[leftPtr])
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

        //private class ValueInfo
        //{
        //    public ValueInfo(int valueIndex, int arrayIndex, int value)
        //    {
        //        ValueIndex = valueIndex;
        //        ArrayIndex = arrayIndex;
        //        Value = value;
        //    }

        //    public int Value { get; }
        //    public int ArrayIndex { get; }
        //    public int ValueIndex { get; }
        //}

        //private class MinHeap<T>
        //{
        //    private int _size;
        //    private MinHeapNode<T>[] _buffer;
        //    private int _length;

        //    public MinHeap(int size)
        //    {
        //        _buffer = new MinHeapNode<T>[size];
        //        _size = size;
        //    }

        //    public MinHeap(int[] buffer)
        //    {
        //        _buffer = new MinHeapNode<T>[buffer.Length];
        //        Array.Copy(buffer, _buffer, buffer.Length);
        //        _size = _buffer.Length;
        //        _length = _buffer.Length;
        //        BuildHeap();
        //    }

        //    public MinHeap(int[] buffer, int length)
        //    {
        //        if (buffer.Length < length) throw new ArgumentOutOfRangeException(nameof(length));
        //        _buffer = new MinHeapNode<T>[buffer.Length];
        //        Array.Copy(buffer, _buffer, buffer.Length);
        //        _size = length;
        //        _length = length;
        //        BuildHeap();
        //    }

        //    public int Length
        //    {
        //        get { return _length; }
        //        private set { _length = value; }
        //    }

        //    public void InsertWithPriority(int priority, T value)
        //    {
        //        if (_length == _size)
        //            Reallocate();
        //        _buffer[_length] = new MinHeapNode<T>(priority, value);
        //        _length++;
        //        SiftUp(_length - 1);
        //    }

        //    public T GetNext()
        //    {
        //        var next = _buffer[0];
        //        _buffer[0] = _buffer[_length - 1];
        //        _buffer[_length - 1] = null;
        //        _length--;
        //        if (_length > 1)
        //            SiftDown(0);
        //        return next.Value;
        //    }

        //    public T PeekAtNext()
        //    {
        //        if (_length == 0)
        //            throw new Exception("empty");
        //        return _buffer[0].Value;
        //    }

        //    private int GetParentIndex(int index)
        //    {
        //        return (index - 1) / 2;
        //    }

        //    private int GetMinChildIndex(int index)
        //    {
        //        var first = index * 2 + 1;
        //        var second = index * 2 + 2;
        //        if (first >= _length)
        //            return -1;
        //        if (second >= _length)
        //            return first;
        //        return _buffer[first].Priority < _buffer[second].Priority ? first : second;
        //    }

        //    private void Reallocate()
        //    {
        //        var newBuffer = new MinHeapNode<T>[_size * 2];
        //        Array.Copy(_buffer, 0, newBuffer, 0, _size);
        //        _size = _size * 2;
        //        _buffer = newBuffer;
        //    }

        //    private void SiftUp(int index)
        //    {
        //        if (_length <= 0)
        //            throw new Exception("empty");
        //        while (index > 0)
        //        {
        //            var parentIndex = GetParentIndex(index);
        //            if (_buffer[parentIndex].Priority <= _buffer[index].Priority)
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
        //            var largestChildIndex = GetMinChildIndex(index);
        //            if (_buffer[index].Priority <= _buffer[largestChildIndex].Priority)
        //                return;
        //            var tmpParent = _buffer[index];
        //            _buffer[index] = _buffer[largestChildIndex];
        //            _buffer[largestChildIndex] = tmpParent;
        //            index = largestChildIndex;
        //        }
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
        //}

        //private class MinHeapNode<T>
        //{
        //    public MinHeapNode(int priority, T value)
        //    {
        //        Priority = priority;
        //        Value = value;
        //    }

        //    public T Value { get; set; }
        //    public int Priority { get; }
        //}
    }
}