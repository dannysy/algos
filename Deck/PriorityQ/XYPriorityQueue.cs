using System;

namespace PriorityQ
{
    public class XYPriorityQueue
    {
        private int _length;
        private XYPoint[] _buffer;
        private int _size;

        public XYPriorityQueue(int size)
        {
            _buffer = new XYPoint[size];
            _size = size;
        }

        public XYPriorityQueue(XYPoint[] buffer) : this(buffer.Length)
        {
            Array.Copy(buffer, _buffer, buffer.Length);
            _length = _size;
            BuildHeap();
        }

        private void BuildHeap()
        {
            if (_length <= 0)
                throw new Exception("empty");
            for (int i = _length / 2 - 1; i >= 0; i--)
            {
                SiftDown(i);
            }
        }

        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private int GetLargestChildIndex(int index)
        {
            var first = index * 2 + 1;
            var second = index * 2 + 2;
            if (first >= _length)
                return -1;
            if (second >= _length)
                return first;
            return _buffer[first].CompareTo(_buffer[second]) == 1 ? first : second;

        }

        private void SiftUp(int index)
        {
            if (_length <= 0)
                throw new Exception("empty");
            while (index > 0)
            {
                var parentIndex = GetParentIndex(index);
                if (_buffer[parentIndex].CompareTo(_buffer[index]) != -1)
                    return;
                var tmpParent = _buffer[parentIndex];
                _buffer[parentIndex] = _buffer[index];
                _buffer[index] = tmpParent;
                index = parentIndex;
            }
        }

        private void SiftDown(int index)
        {
            if (_length <= 0)
                throw new Exception("empty");
            while (index <= _length / 2 - 1)
            {
                var largestChildIndex = GetLargestChildIndex(index);
                if (_buffer[index].CompareTo(_buffer[largestChildIndex]) != -1)
                    return;
                var tmpParent = _buffer[index];
                _buffer[index] = _buffer[largestChildIndex];
                _buffer[largestChildIndex] = tmpParent;
                index = largestChildIndex;
            }
        }


        public void InsertWithPriority(XYPoint value)
        {
            if (_length == _size)
                Reallocate();
            _buffer[_length] = value;
            _length++;
            SiftUp(_length - 1);
        }

        public XYPoint GetNext()
        {
            var next = _buffer[0];
            _buffer[0] = _buffer[_length - 1];
            _buffer[_length - 1] = null;
            _length--;
            if (_length > 1)
                SiftDown(0);
            return next;
        }

        public XYPoint PeekAtNext()
        {
            if (_length == 0)
                throw new Exception("empty");
            return _buffer[0];
        }

        private void Reallocate()
        {
            var newBuffer = new XYPoint[_size * 2];
            Array.Copy(_buffer, 0, newBuffer, 0, _size);
            _size = _size * 2;
            _buffer = newBuffer;
        }

        public XYPoint[] ToArray()
        {
            var newBuffer = new XYPoint[_size];
            Array.Copy(_buffer, 0, newBuffer, 0, _size);
            return newBuffer;
        }
    }
}