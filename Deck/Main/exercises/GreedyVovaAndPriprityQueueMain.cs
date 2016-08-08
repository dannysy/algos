namespace Main.Exercises
{
    public class GreedyVovaAndPriprityQueueMain
    {
        //public static void Main()
        //{
        //    var fruitsCount = Console.ReadLine();
        //    int fCount;
        //    if (!int.TryParse(fruitsCount, out fCount) || fCount < 0)
        //        return;
        //    if (fCount == 0)
        //        Console.WriteLine(0);
        //    var fruitsArray = Console.ReadLine().Split(' ');
        //    var intArray = new List<int>(fCount);
        //    Array.ForEach(fruitsArray, s => intArray.Add(int.Parse(s)));
        //    var maxWeight = Console.ReadLine();
        //    int maxW;
        //    if (!int.TryParse(maxWeight, out maxW) || maxW < 0)
        //        return;
        //    Console.WriteLine(Solve(fCount, intArray.ToArray(), maxW));
        //}

        //public static int Solve(int count, int[] fruits, int maxWeght)
        //{
        //    var steps = 0;
        //    var priorityQueue = new PriorityQueue(count);
        //    priorityQueue.FromArray(fruits);
        //    while (priorityQueue.Length != 0)
        //    {
        //        var next = priorityQueue.GetNext();
        //        int sum = next;
        //        var toInsert = new List<int>();
        //        AddToList(next, toInsert);
        //        while (priorityQueue.Length > 0 && sum + priorityQueue.PeekAtNext() <= maxWeght)
        //        {
        //            next = priorityQueue.GetNext();
        //            AddToList(next, toInsert);
        //            sum += next;
        //        }
        //        foreach (var fruit in toInsert)
        //        {
        //            priorityQueue.InsertWithPriority(fruit);
        //        }
        //        steps++;
        //    }
        //    return steps;
        //}

        //private static void AddToList(int next, List<int> toInsert)
        //{
        //    if (next > 1)
        //        toInsert.Add(next / 2);
        //}

        //private class PriorityQueue
        //{
        //    private int _size;
        //    private int[] _buffer;
        //    private int _length;

        //    public PriorityQueue(int size)
        //    {
        //        _buffer = new int[size];
        //        _size = size;
        //    }

        //    public int Length
        //    {
        //        get { return _length; }
        //        private set { _length = value; }
        //    }

        //    public void InsertWithPriority(int priority)
        //    {
        //        if (_length == _size)
        //            Reallocate();
        //        _buffer[_length] = priority;
        //        _length++;
        //        SiftUp(_length - 1);
        //    }

        //    public int GetNext()
        //    {
        //        var next = _buffer[0];
        //        _buffer[0] = _buffer[_length - 1];
        //        _buffer[_length - 1] = 0;
        //        _length--;
        //        if (_length > 1)
        //            SiftDown(0);
        //        return next;
        //    }

        //    public int PeekAtNext()
        //    {
        //        if (_length == 0)
        //            throw new Exception("empty");
        //        return _buffer[0];
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
        //        return _buffer[first] > _buffer[second] ? first : second;
        //    }

        //    private void Reallocate()
        //    {
        //        var newBuffer = new int[_size * 2];
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
        //            if (_buffer[parentIndex] >= _buffer[index])
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
        //            if (_buffer[index] >= _buffer[largestChildIndex])
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

        //    public void FromArray(int[] fruits)
        //    {
        //        _buffer = fruits;
        //        _size = fruits.Length;
        //        _length = fruits.Length;
        //        BuildHeap();
        //    }
        //}
    }
}